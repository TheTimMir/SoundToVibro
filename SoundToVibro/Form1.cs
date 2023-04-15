using NAudio.CoreAudioApi;
using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace SoundToVibro
{
    public partial class Form1 : Form
    {
        Vibration currVibr = new Vibration();
        Vibration clearVibr = new Vibration();
        Controller controller = null;
        decimal preSplitBoosted = 0;
        List<Controller> controllers = new List<Controller>();
        private static int Map(int value, int fromLow, int fromHigh, int toLow, int toHigh)
        {
            return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
        }
        private static int CropAndScaleValue(int value, int cropMin, int cropMax, int min, int max)
        {
            if (value < cropMin) value = cropMin;
            if (value > cropMax) value = cropMax;
            return Map(value, min, max, cropMin, cropMax);
        }
        public Form1()
        {
            InitializeComponent();
            clearVibr.LeftMotorSpeed = 0; 
            clearVibr.RightMotorSpeed = 0;
            MMDeviceEnumerator en = new MMDeviceEnumerator();
            var devices = en.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            cbAudioSelection.Items.AddRange(devices.ToArray());
            timer1.Start();

            backgroundWorker1.RunWorkerAsync();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cbAudioSelection.SelectedItem != null)
            {
                var device = (MMDevice)cbAudioSelection.SelectedItem;
                preSplitBoosted = (decimal)(device.AudioMeterInformation.MasterPeakValue * double.Parse(tbGlobalBoost.Text));
                pbLeft.Value = CropAndScaleValue((int)(preSplitBoosted * tbLeftBoost.Value), tbLeftMin.Value * 10, tbLeftMax.Value * 10, 0, 100);
                pbRight.Value = CropAndScaleValue((int)(preSplitBoosted * tbRightBoost.Value), tbRightMin.Value * 10, tbRightMax.Value * 10, 0, 100);
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            var possibleControllers = new[] { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };
            for (int i = 0; i < possibleControllers.Length; i++)
            {
                Controller controllerTmp = possibleControllers[i];
                if (controllerTmp.IsConnected)
                {
                    controllers.Add(controllerTmp);
                }
            }
            if (controllers.ToArray().Length == 0)
            {
                MessageBox.Show("No controller detected. Please plug the controller in and relaunch the app.", "Error: No controller", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                foreach (Controller controllerTmp in controllers)
                {
                    cbGamepadSelection.Items.Add($"Controller {controllerTmp.UserIndex}");
                }
                cbGamepadSelection.SelectedIndex = 0;
                controller = controllers[0];
                var previousState = controller.GetState();
                while (true)
                {
                    if (controller != controllers[cbGamepadSelection.SelectedIndex])
                    {
                        controller.SetVibration(clearVibr);
                        controller = controllers[cbGamepadSelection.SelectedIndex];
                    }
                    var state = controller.GetState();
                    if (cbEnableLeft.Checked) currVibr.LeftMotorSpeed = (ushort)(pbLeft.Value * 1000);
                    else currVibr.LeftMotorSpeed = (ushort)0;
                    if (cbEnableRight.Checked) currVibr.RightMotorSpeed = (ushort)(pbRight.Value * 1000);
                    else currVibr.RightMotorSpeed = (ushort)0;
                    lblRightSoundLevel.Text = currVibr.RightMotorSpeed.ToString();
                    lblLeftSoundLevel.Text = currVibr.LeftMotorSpeed.ToString();
                    controller.SetVibration(currVibr);
                    Thread.Sleep(10);
                    previousState = state;
                }
            }
        }
    }
}