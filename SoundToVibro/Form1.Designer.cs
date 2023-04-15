namespace SoundToVibro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbAudioSelection = new System.Windows.Forms.ComboBox();
            this.pbLeft = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbEnableLeft = new System.Windows.Forms.CheckBox();
            this.cbEnableRight = new System.Windows.Forms.CheckBox();
            this.lblGlobMultDesc = new System.Windows.Forms.Label();
            this.pbRight = new System.Windows.Forms.ProgressBar();
            this.lblLeftMotorTitle = new System.Windows.Forms.Label();
            this.lblRightMotorTitle = new System.Windows.Forms.Label();
            this.tbLeftMin = new System.Windows.Forms.TrackBar();
            this.tbLeftMax = new System.Windows.Forms.TrackBar();
            this.tbRightMax = new System.Windows.Forms.TrackBar();
            this.tbRightMin = new System.Windows.Forms.TrackBar();
            this.lblLeftMultDesc = new System.Windows.Forms.Label();
            this.lblRightMultDesc = new System.Windows.Forms.Label();
            this.tbRightBoost = new System.Windows.Forms.NumericUpDown();
            this.tbLeftBoost = new System.Windows.Forms.NumericUpDown();
            this.tbGlobalBoost = new System.Windows.Forms.NumericUpDown();
            this.lblRightSoundLevel = new System.Windows.Forms.Label();
            this.lblLeftSoundLevel = new System.Windows.Forms.Label();
            this.lblAudioSelTitle = new System.Windows.Forms.Label();
            this.cbGamepadSelection = new System.Windows.Forms.ComboBox();
            this.lblGamepadSelTitle = new System.Windows.Forms.Label();
            this.lblLeftMin = new System.Windows.Forms.Label();
            this.lblLeftMax = new System.Windows.Forms.Label();
            this.lblRightMax = new System.Windows.Forms.Label();
            this.lblRightMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGlobalBoost)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAudioSelection
            // 
            this.cbAudioSelection.FormattingEnabled = true;
            this.cbAudioSelection.Location = new System.Drawing.Point(12, 26);
            this.cbAudioSelection.Name = "cbAudioSelection";
            this.cbAudioSelection.Size = new System.Drawing.Size(248, 21);
            this.cbAudioSelection.TabIndex = 0;
            // 
            // pbLeft
            // 
            this.pbLeft.Location = new System.Drawing.Point(12, 153);
            this.pbLeft.MarqueeAnimationSpeed = 0;
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(248, 23);
            this.pbLeft.Step = 100;
            this.pbLeft.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // cbEnableLeft
            // 
            this.cbEnableLeft.AutoSize = true;
            this.cbEnableLeft.Location = new System.Drawing.Point(141, 111);
            this.cbEnableLeft.Name = "cbEnableLeft";
            this.cbEnableLeft.Size = new System.Drawing.Size(119, 17);
            this.cbEnableLeft.TabIndex = 5;
            this.cbEnableLeft.Text = "Enable Left Vibrator";
            this.cbEnableLeft.UseVisualStyleBackColor = true;
            // 
            // cbEnableRight
            // 
            this.cbEnableRight.AutoSize = true;
            this.cbEnableRight.Location = new System.Drawing.Point(389, 111);
            this.cbEnableRight.Name = "cbEnableRight";
            this.cbEnableRight.Size = new System.Drawing.Size(126, 17);
            this.cbEnableRight.TabIndex = 6;
            this.cbEnableRight.Text = "Enable Right Vibrator";
            this.cbEnableRight.UseVisualStyleBackColor = true;
            // 
            // lblGlobMultDesc
            // 
            this.lblGlobMultDesc.AutoSize = true;
            this.lblGlobMultDesc.Location = new System.Drawing.Point(65, 50);
            this.lblGlobMultDesc.Name = "lblGlobMultDesc";
            this.lblGlobMultDesc.Size = new System.Drawing.Size(83, 13);
            this.lblGlobMultDesc.TabIndex = 7;
            this.lblGlobMultDesc.Text = "Global multiplier:";
            // 
            // pbRight
            // 
            this.pbRight.Location = new System.Drawing.Point(267, 153);
            this.pbRight.MarqueeAnimationSpeed = 0;
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(248, 23);
            this.pbRight.Step = 100;
            this.pbRight.TabIndex = 8;
            // 
            // lblLeftMotorTitle
            // 
            this.lblLeftMotorTitle.AutoSize = true;
            this.lblLeftMotorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLeftMotorTitle.Location = new System.Drawing.Point(100, 64);
            this.lblLeftMotorTitle.Name = "lblLeftMotorTitle";
            this.lblLeftMotorTitle.Size = new System.Drawing.Size(39, 42);
            this.lblLeftMotorTitle.TabIndex = 9;
            this.lblLeftMotorTitle.Text = "L";
            // 
            // lblRightMotorTitle
            // 
            this.lblRightMotorTitle.AutoSize = true;
            this.lblRightMotorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRightMotorTitle.Location = new System.Drawing.Point(375, 64);
            this.lblRightMotorTitle.Name = "lblRightMotorTitle";
            this.lblRightMotorTitle.Size = new System.Drawing.Size(45, 42);
            this.lblRightMotorTitle.TabIndex = 10;
            this.lblRightMotorTitle.Text = "R";
            // 
            // tbLeftMin
            // 
            this.tbLeftMin.Location = new System.Drawing.Point(12, 183);
            this.tbLeftMin.Maximum = 50;
            this.tbLeftMin.Name = "tbLeftMin";
            this.tbLeftMin.Size = new System.Drawing.Size(248, 45);
            this.tbLeftMin.TabIndex = 11;
            this.tbLeftMin.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbLeftMax
            // 
            this.tbLeftMax.Location = new System.Drawing.Point(12, 232);
            this.tbLeftMax.Maximum = 50;
            this.tbLeftMax.Name = "tbLeftMax";
            this.tbLeftMax.Size = new System.Drawing.Size(248, 45);
            this.tbLeftMax.TabIndex = 12;
            this.tbLeftMax.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbLeftMax.Value = 50;
            // 
            // tbRightMax
            // 
            this.tbRightMax.Location = new System.Drawing.Point(266, 232);
            this.tbRightMax.Maximum = 50;
            this.tbRightMax.Name = "tbRightMax";
            this.tbRightMax.Size = new System.Drawing.Size(248, 45);
            this.tbRightMax.TabIndex = 14;
            this.tbRightMax.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbRightMax.Value = 50;
            // 
            // tbRightMin
            // 
            this.tbRightMin.Location = new System.Drawing.Point(266, 183);
            this.tbRightMin.Maximum = 50;
            this.tbRightMin.Name = "tbRightMin";
            this.tbRightMin.Size = new System.Drawing.Size(248, 45);
            this.tbRightMin.TabIndex = 13;
            this.tbRightMin.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // lblLeftMultDesc
            // 
            this.lblLeftMultDesc.AutoSize = true;
            this.lblLeftMultDesc.Location = new System.Drawing.Point(12, 112);
            this.lblLeftMultDesc.Name = "lblLeftMultDesc";
            this.lblLeftMultDesc.Size = new System.Drawing.Size(59, 13);
            this.lblLeftMultDesc.TabIndex = 16;
            this.lblLeftMultDesc.Text = "L multiplier:";
            // 
            // lblRightMultDesc
            // 
            this.lblRightMultDesc.AutoSize = true;
            this.lblRightMultDesc.Location = new System.Drawing.Point(266, 112);
            this.lblRightMultDesc.Name = "lblRightMultDesc";
            this.lblRightMultDesc.Size = new System.Drawing.Size(61, 13);
            this.lblRightMultDesc.TabIndex = 18;
            this.lblRightMultDesc.Text = "R multiplier:";
            // 
            // tbRightBoost
            // 
            this.tbRightBoost.Location = new System.Drawing.Point(333, 110);
            this.tbRightBoost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbRightBoost.Name = "tbRightBoost";
            this.tbRightBoost.Size = new System.Drawing.Size(40, 20);
            this.tbRightBoost.TabIndex = 19;
            this.tbRightBoost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbLeftBoost
            // 
            this.tbLeftBoost.Location = new System.Drawing.Point(77, 110);
            this.tbLeftBoost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbLeftBoost.Name = "tbLeftBoost";
            this.tbLeftBoost.Size = new System.Drawing.Size(40, 20);
            this.tbLeftBoost.TabIndex = 20;
            this.tbLeftBoost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbGlobalBoost
            // 
            this.tbGlobalBoost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbGlobalBoost.Location = new System.Drawing.Point(150, 48);
            this.tbGlobalBoost.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbGlobalBoost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbGlobalBoost.Name = "tbGlobalBoost";
            this.tbGlobalBoost.Size = new System.Drawing.Size(40, 20);
            this.tbGlobalBoost.TabIndex = 21;
            this.tbGlobalBoost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRightSoundLevel
            // 
            this.lblRightSoundLevel.AutoSize = true;
            this.lblRightSoundLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblRightSoundLevel.Location = new System.Drawing.Point(367, 137);
            this.lblRightSoundLevel.Name = "lblRightSoundLevel";
            this.lblRightSoundLevel.Size = new System.Drawing.Size(53, 13);
            this.lblRightSoundLevel.TabIndex = 22;
            this.lblRightSoundLevel.Text = "Current: 0";
            // 
            // lblLeftSoundLevel
            // 
            this.lblLeftSoundLevel.AutoSize = true;
            this.lblLeftSoundLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLeftSoundLevel.Location = new System.Drawing.Point(104, 137);
            this.lblLeftSoundLevel.Name = "lblLeftSoundLevel";
            this.lblLeftSoundLevel.Size = new System.Drawing.Size(53, 13);
            this.lblLeftSoundLevel.TabIndex = 23;
            this.lblLeftSoundLevel.Text = "Current: 0";
            // 
            // lblAudioSelTitle
            // 
            this.lblAudioSelTitle.AutoSize = true;
            this.lblAudioSelTitle.Location = new System.Drawing.Point(74, 9);
            this.lblAudioSelTitle.Name = "lblAudioSelTitle";
            this.lblAudioSelTitle.Size = new System.Drawing.Size(89, 13);
            this.lblAudioSelTitle.TabIndex = 24;
            this.lblAudioSelTitle.Text = "Audio source (in):";
            // 
            // cbGamepadSelection
            // 
            this.cbGamepadSelection.FormattingEnabled = true;
            this.cbGamepadSelection.Location = new System.Drawing.Point(269, 26);
            this.cbGamepadSelection.Name = "cbGamepadSelection";
            this.cbGamepadSelection.Size = new System.Drawing.Size(248, 21);
            this.cbGamepadSelection.TabIndex = 25;
            // 
            // lblGamepadSelTitle
            // 
            this.lblGamepadSelTitle.AutoSize = true;
            this.lblGamepadSelTitle.Location = new System.Drawing.Point(353, 9);
            this.lblGamepadSelTitle.Name = "lblGamepadSelTitle";
            this.lblGamepadSelTitle.Size = new System.Drawing.Size(80, 13);
            this.lblGamepadSelTitle.TabIndex = 26;
            this.lblGamepadSelTitle.Text = "Gamepad (out):";
            // 
            // lblLeftMin
            // 
            this.lblLeftMin.AutoSize = true;
            this.lblLeftMin.Location = new System.Drawing.Point(12, 137);
            this.lblLeftMin.Name = "lblLeftMin";
            this.lblLeftMin.Size = new System.Drawing.Size(54, 13);
            this.lblLeftMin.TabIndex = 27;
            this.lblLeftMin.Text = "Minimal: 0";
            // 
            // lblLeftMax
            // 
            this.lblLeftMax.AutoSize = true;
            this.lblLeftMax.Location = new System.Drawing.Point(191, 137);
            this.lblLeftMax.Name = "lblLeftMax";
            this.lblLeftMax.Size = new System.Drawing.Size(69, 13);
            this.lblLeftMax.TabIndex = 28;
            this.lblLeftMax.Text = "Maximal: 100";
            // 
            // lblRightMax
            // 
            this.lblRightMax.AutoSize = true;
            this.lblRightMax.Location = new System.Drawing.Point(446, 137);
            this.lblRightMax.Name = "lblRightMax";
            this.lblRightMax.Size = new System.Drawing.Size(69, 13);
            this.lblRightMax.TabIndex = 30;
            this.lblRightMax.Text = "Maximal: 100";
            // 
            // lblRightMin
            // 
            this.lblRightMin.AutoSize = true;
            this.lblRightMin.Location = new System.Drawing.Point(267, 137);
            this.lblRightMin.Name = "lblRightMin";
            this.lblRightMin.Size = new System.Drawing.Size(54, 13);
            this.lblRightMin.TabIndex = 29;
            this.lblRightMin.Text = "Minimal: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 281);
            this.Controls.Add(this.lblRightMax);
            this.Controls.Add(this.lblRightMin);
            this.Controls.Add(this.lblLeftMax);
            this.Controls.Add(this.lblLeftMin);
            this.Controls.Add(this.lblGamepadSelTitle);
            this.Controls.Add(this.cbGamepadSelection);
            this.Controls.Add(this.lblAudioSelTitle);
            this.Controls.Add(this.lblLeftSoundLevel);
            this.Controls.Add(this.lblRightSoundLevel);
            this.Controls.Add(this.tbGlobalBoost);
            this.Controls.Add(this.tbLeftBoost);
            this.Controls.Add(this.tbRightBoost);
            this.Controls.Add(this.lblRightMultDesc);
            this.Controls.Add(this.lblLeftMultDesc);
            this.Controls.Add(this.tbRightMax);
            this.Controls.Add(this.tbRightMin);
            this.Controls.Add(this.tbLeftMax);
            this.Controls.Add(this.tbLeftMin);
            this.Controls.Add(this.lblRightMotorTitle);
            this.Controls.Add(this.lblLeftMotorTitle);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.lblGlobMultDesc);
            this.Controls.Add(this.cbEnableRight);
            this.Controls.Add(this.cbEnableLeft);
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.cbAudioSelection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sound To Vibro V0.2";
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightBoost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftBoost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGlobalBoost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAudioSelection;
        private System.Windows.Forms.ProgressBar pbLeft;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbEnableLeft;
        private System.Windows.Forms.CheckBox cbEnableRight;
        private System.Windows.Forms.Label lblGlobMultDesc;
        private System.Windows.Forms.ProgressBar pbRight;
        private System.Windows.Forms.Label lblLeftMotorTitle;
        private System.Windows.Forms.Label lblRightMotorTitle;
        private System.Windows.Forms.TrackBar tbLeftMin;
        private System.Windows.Forms.TrackBar tbLeftMax;
        private System.Windows.Forms.TrackBar tbRightMax;
        private System.Windows.Forms.TrackBar tbRightMin;
        private System.Windows.Forms.Label lblLeftMultDesc;
        private System.Windows.Forms.Label lblRightMultDesc;
        private System.Windows.Forms.NumericUpDown tbRightBoost;
        private System.Windows.Forms.NumericUpDown tbLeftBoost;
        private System.Windows.Forms.NumericUpDown tbGlobalBoost;
        private System.Windows.Forms.Label lblRightSoundLevel;
        private System.Windows.Forms.Label lblLeftSoundLevel;
        private System.Windows.Forms.Label lblAudioSelTitle;
        private System.Windows.Forms.ComboBox cbGamepadSelection;
        private System.Windows.Forms.Label lblGamepadSelTitle;
        private System.Windows.Forms.Label lblLeftMin;
        private System.Windows.Forms.Label lblLeftMax;
        private System.Windows.Forms.Label lblRightMax;
        private System.Windows.Forms.Label lblRightMin;
    }
}

