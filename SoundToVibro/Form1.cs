using NAudio.CoreAudioApi;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using SharpDX.XInput;
using System.Threading;

namespace SoundToVibro
{
    public partial class Form1 : Form
    {
        decimal preSplitBoosted=0;
        private static int Map(int value, int fromLow, int fromHigh, int toLow, int toHigh)
        {
            return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
        }
        private static int CropAndScaleValue(int value, int cropMin, int cropMax, int min, int max) 
        {
            if (value < cropMin) value = cropMin;
            if (value > cropMax) value = cropMax;
            return Map(value,min,max,cropMin,cropMax);
        }
        public Form1()
        {
            InitializeComponent();
            MMDeviceEnumerator en = new MMDeviceEnumerator();
            var devices = en.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());
            timer1.Start();
            backgroundWorker1.RunWorkerAsync();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                var device = (MMDevice)comboBox1.SelectedItem;
                preSplitBoosted = (decimal)(device.AudioMeterInformation.MasterPeakValue * double.Parse(tbGlobalBoost.Text));
                    pbLeft.Value = CropAndScaleValue((int)(preSplitBoosted * tbLeftBoost.Value),tbLeftMin.Value*10, tbLeftMax.Value*10,0,100);
                    pbRight.Value = CropAndScaleValue((int)(preSplitBoosted * tbRightBoost.Value), tbRightMin.Value * 10, tbRightMax.Value * 10, 0, 100);
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var controllers = new[] { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) };
            Controller controller = null;
            foreach (var selectControler in controllers)
            {
                if (selectControler.IsConnected)
                {
                    controller = selectControler;
                    break;
                }
            }
            if (controller == null)
            { 
                MessageBox.Show("No controller detected. Please plug the controller in and relaunch the app.", "Error: No controller", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {
                var previousState = controller.GetState();
                Vibration v = new Vibration();

                while (controller.IsConnected)
                {
                    var state = controller.GetState();
                    if (cbEnableLeft.Checked) v.LeftMotorSpeed = (ushort)(pbLeft.Value * 1000);
                    else v.LeftMotorSpeed = (ushort)0;
                    if (cbEnableRight.Checked) v.RightMotorSpeed = (ushort)(pbRight.Value * 1000);
                    else v.RightMotorSpeed = (ushort)0;
                    lblRightSoundLevel.Text = v.RightMotorSpeed.ToString();
                    lblLeftSoundLevel.Text = v.LeftMotorSpeed.ToString();
                    controller.SetVibration(v);
                    Thread.Sleep(10);
                    previousState = state;
                }
            }
        }
    }
}