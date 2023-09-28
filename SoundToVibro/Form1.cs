using NAudio.CoreAudioApi;
using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace SoundToVibro
{
    public partial class Form1 : Form
    {

        Vibration currVibr = new Vibration(); //Defining var to store current vibration on both motors
        Vibration clearVibr = new Vibration(); //Defining var to store zero vibration on both motors
        Controller controller = null; //Definig var for selected gamepad 
        decimal preSplitMultiplied = 0; //Definig var for storing boosted by "Global multiplier", pre-splitted between motores sound
        List<Controller> controllers = new List<Controller>(); //Defining var for all controllers
        int CroppedLeft = 0; //Int post-cropped sound value for left motor
        int CroppedRight = 0;//Int post-cropped sound value for right motor
        private static int CropValue(decimal value, decimal cropMin, decimal cropMax, ProgressBar pb = null)
        {
            if (value < cropMin)                    // if current sound is lower than selected minimum
            {
                if (!(pb is null)) pb.SetState(3);  // Painting sound proggres bar in yellow
                return 0;                           // Returning no sound (0)
            }
            else if (value < cropMax)               // if current sound is lower than selected maximum
            {
                if (!(pb is null)) pb.SetState(1);  // Painting sound proggres bar in green
                return (int)value;                  // Returning current sound value
            }
            else                                    // And everything that remains is higher than maximum, so
            {
                if (!(pb is null)) pb.SetState(2);  // Painting sound proggres bar in red
                return (int)cropMax;                // Returning selected maximum value
            }
        }
        public Form1()
        {
            InitializeComponent(); // Default WF func
            clearVibr.LeftMotorSpeed = 0;  // Setting clear vibration as 0 for left... 
            clearVibr.RightMotorSpeed = 0; // ...and right motors
            MMDeviceEnumerator en = new MMDeviceEnumerator(); // Defining sound device enumerator 
            var devices = en.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active); // Getting sound devices that output sound, and that are active
            cbAudioSelection.Items.AddRange(devices.ToArray()); // Adding those audio devices to Combobox 
            cbAudioSelection.SelectedIndex = cbAudioSelection.FindString(en.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console).ToString()); //Selectuing currently chosen audio device in Windows
            timer1.Start(); //Starting timer
            backgroundWorker1.RunWorkerAsync(); //Running bgworker
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            decimal preCropLeft = 0; // Clearing/Defining pre-cropped sound level for left... 
            decimal preCropRight = 0;// ...and right motors
            if (cbAudioSelection.SelectedItem != null) //If audiodevice is selected:
            {
                var device = (MMDevice)cbAudioSelection.SelectedItem; //Defining selected audio device
                preSplitMultiplied = (decimal)(device.AudioMeterInformation.MasterPeakValue * double.Parse(tbGlobalBoost.Text) * 10); // Defining/Calculating pre-splited multiplied sound level
                preCropLeft = (preSplitMultiplied * tbLeftBoost.Value);  // Calculating pre-cropped sound level for left... 
                preCropRight = (preSplitMultiplied * tbRightBoost.Value);// ...and right motors
                pbLeft.Value = CropValue(preCropLeft, 0, 100);  // Setting progressbar level for both left motor...
                pbRight.Value = CropValue(preCropRight, 0, 100);// ...and right motor
                CroppedLeft = CropValue(preCropLeft, tbLeftMin.Value * 2, tbLeftMax.Value * 2, pbLeft);     // Setting post-cropped sound value for left motor...
                CroppedRight = CropValue(preCropRight, tbRightMin.Value * 2, tbRightMax.Value * 2, pbRight);// ...and the right one
            }
            lblLeftSoundLevel.Text = $"Current: {(int)preCropLeft}";  // Changing "Current" sound level label for left...
            lblRightSoundLevel.Text = $"Current: {(int)preCropRight}";// ...and right motors
        }

        private void onAnyCropTrackBarScroll(object sender, EventArgs e) //Setting lables here
        {
            lblLeftMin.Text = $"Minimal:{tbLeftMin.Value * 2}";
            lblRightMin.Text = $"Minimal:{tbRightMin.Value * 2}";
            lblLeftMax.Text = $"Maximal:{tbLeftMax.Value * 2}";
            lblRightMax.Text = $"Maximal:{tbRightMax.Value * 2}";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Controller[] possibleControllers = new[] { new Controller(UserIndex.One), new Controller(UserIndex.Two), new Controller(UserIndex.Three), new Controller(UserIndex.Four) }; // Defining possible controllers
            foreach (Controller tmpController in possibleControllers) if (tmpController.IsConnected) controllers.Add(tmpController); // Filter out disconnected controllers and pass connected ones to controller list
            if (controllers.ToArray().Length == 0)// If there are no controllers on the list
            {
                MessageBox.Show("No controller detected. Please plug the controller in and relaunch the app.", "Error: No controller", MessageBoxButtons.OK, MessageBoxIcon.Error); //Shows the error message
                Application.Exit();//Exits
            }
            else // If there are controllers on the list
            {
                foreach (Controller controllerTmp in controllers) cbGamepadSelection.Items.Add($"Controller {controllerTmp.UserIndex}"); // Placing controllers into combobox
                cbGamepadSelection.SelectedIndex = 0; // Selecting first controller visually
                controller = controllers[0]; // Selecting first controller tecnicaly
                while (true) // Infinite loop
                {
                    if (controller != controllers[cbGamepadSelection.SelectedIndex]) // If another controller chosen
                    {
                        controller.SetVibration(clearVibr); // Set no vibration to past selected contoller
                        controller = controllers[cbGamepadSelection.SelectedIndex]; // and change controller to selected
                    }
                    if (cbEnableLeft.Checked) currVibr.LeftMotorSpeed = (ushort)(CroppedLeft * 655.35); // If right motor enabled - set motor speed
                    else currVibr.LeftMotorSpeed = clearVibr.LeftMotorSpeed; // If not - set no vibration
                    if (cbEnableRight.Checked) currVibr.RightMotorSpeed = (ushort)(CroppedRight * 655.35);// If left motor enabled - set motor speed
                    else currVibr.RightMotorSpeed = clearVibr.RightMotorSpeed;// If not - set no vibration
                    controller.SetVibration(currVibr); // Assing vibrations to controller
                    Thread.Sleep(10); // Neccesary delay
                }
            }
        }
    }

    //Progressbar coloring from stackoverflow 
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}