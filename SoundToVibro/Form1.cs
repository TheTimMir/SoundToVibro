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
        private static int CropValue(decimal value, decimal cropMin, decimal cropMax)
        {
            if (value < cropMin) return 0;
            if (value < cropMax) return (int)value;
            else return 0;
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
            decimal preCropLeft = 0;
            decimal preCropRight = 0;
            if (cbAudioSelection.SelectedItem != null)
            {
                var device = (MMDevice)cbAudioSelection.SelectedItem;
                preSplitBoosted = (decimal)(device.AudioMeterInformation.MasterPeakValue * double.Parse(tbGlobalBoost.Text) * 10);
                preCropLeft = (preSplitBoosted * tbLeftBoost.Value);
                preCropRight = (preSplitBoosted * tbRightBoost.Value);
            }
            pbLeft.Value = CropValue(preCropLeft, tbLeftMin.Value * 2, tbLeftMax.Value * 2);
            pbRight.Value = CropValue(preCropRight, tbRightMin.Value * 2, tbRightMax.Value * 2);
            lblLeftSoundLevel.Text = $"Current: {(int)preCropLeft}";
            lblRightSoundLevel.Text = $"Current: {(int)preCropRight}";
            lblLeftMin.Text = $"Minimal:{tbLeftMin.Value * 2}";
            lblRightMin.Text = $"Minimal:{tbRightMin.Value * 2}";
            lblLeftMax.Text = $"Maximal:{tbLeftMax.Value * 2}";
            lblRightMax.Text = $"Maximal:{tbRightMax.Value * 2}";
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
                    if (cbEnableLeft.Checked) currVibr.LeftMotorSpeed = (ushort)(pbLeft.Value * 655.35);
                    else currVibr.LeftMotorSpeed = (ushort)0;
                    if (cbEnableRight.Checked) currVibr.RightMotorSpeed = (ushort)(pbRight.Value * 655.35);
                    else currVibr.RightMotorSpeed = (ushort)0;
                    controller.SetVibration(currVibr);
                    Thread.Sleep(10);
                    previousState = state;
                }
            }
        }
    }
}