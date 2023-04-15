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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pbLeft = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbEnableLeft = new System.Windows.Forms.CheckBox();
            this.cbEnableRight = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbRight = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLeftMin = new System.Windows.Forms.TrackBar();
            this.tbLeftMax = new System.Windows.Forms.TrackBar();
            this.tbRightMax = new System.Windows.Forms.TrackBar();
            this.tbRightMin = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbRightBoost = new System.Windows.Forms.NumericUpDown();
            this.tbLeftBoost = new System.Windows.Forms.NumericUpDown();
            this.tbGlobalBoost = new System.Windows.Forms.NumericUpDown();
            this.lblRightSoundLevel = new System.Windows.Forms.Label();
            this.lblLeftSoundLevel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRightBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLeftBoost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGlobalBoost)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // pbLeft
            // 
            this.pbLeft.Location = new System.Drawing.Point(12, 145);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(248, 23);
            this.pbLeft.Step = 100;
            this.pbLeft.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
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
            this.cbEnableLeft.Location = new System.Drawing.Point(141, 122);
            this.cbEnableLeft.Name = "cbEnableLeft";
            this.cbEnableLeft.Size = new System.Drawing.Size(119, 17);
            this.cbEnableLeft.TabIndex = 5;
            this.cbEnableLeft.Text = "Enable Left Vibrator";
            this.cbEnableLeft.UseVisualStyleBackColor = true;
            // 
            // cbEnableRight
            // 
            this.cbEnableRight.AutoSize = true;
            this.cbEnableRight.Location = new System.Drawing.Point(389, 122);
            this.cbEnableRight.Name = "cbEnableRight";
            this.cbEnableRight.Size = new System.Drawing.Size(126, 17);
            this.cbEnableRight.TabIndex = 6;
            this.cbEnableRight.Text = "Enable Right Vibrator";
            this.cbEnableRight.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Global multiplier:";
            // 
            // pbRight
            // 
            this.pbRight.Location = new System.Drawing.Point(267, 145);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(248, 23);
            this.pbRight.Step = 100;
            this.pbRight.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(100, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "L";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(375, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 42);
            this.label4.TabIndex = 10;
            this.label4.Text = "R";
            // 
            // tbLeftMin
            // 
            this.tbLeftMin.Location = new System.Drawing.Point(12, 175);
            this.tbLeftMin.Name = "tbLeftMin";
            this.tbLeftMin.Size = new System.Drawing.Size(248, 45);
            this.tbLeftMin.TabIndex = 11;
            this.tbLeftMin.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbLeftMax
            // 
            this.tbLeftMax.Location = new System.Drawing.Point(12, 224);
            this.tbLeftMax.Name = "tbLeftMax";
            this.tbLeftMax.Size = new System.Drawing.Size(248, 45);
            this.tbLeftMax.TabIndex = 12;
            this.tbLeftMax.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbLeftMax.Value = 10;
            // 
            // tbRightMax
            // 
            this.tbRightMax.Location = new System.Drawing.Point(266, 224);
            this.tbRightMax.Name = "tbRightMax";
            this.tbRightMax.Size = new System.Drawing.Size(248, 45);
            this.tbRightMax.TabIndex = 14;
            this.tbRightMax.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbRightMax.Value = 10;
            // 
            // tbRightMin
            // 
            this.tbRightMin.Location = new System.Drawing.Point(266, 175);
            this.tbRightMin.Name = "tbRightMin";
            this.tbRightMin.Size = new System.Drawing.Size(248, 45);
            this.tbRightMin.TabIndex = 13;
            this.tbRightMin.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "L multiplier:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "R multiplier:";
            // 
            // tbRightBoost
            // 
            this.tbRightBoost.Location = new System.Drawing.Point(333, 121);
            this.tbRightBoost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbRightBoost.Name = "tbRightBoost";
            this.tbRightBoost.Size = new System.Drawing.Size(37, 20);
            this.tbRightBoost.TabIndex = 19;
            this.tbRightBoost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbLeftBoost
            // 
            this.tbLeftBoost.Location = new System.Drawing.Point(77, 121);
            this.tbLeftBoost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbLeftBoost.Name = "tbLeftBoost";
            this.tbLeftBoost.Size = new System.Drawing.Size(37, 20);
            this.tbLeftBoost.TabIndex = 20;
            this.tbLeftBoost.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbGlobalBoost
            // 
            this.tbGlobalBoost.Location = new System.Drawing.Point(381, 46);
            this.tbGlobalBoost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tbGlobalBoost.Name = "tbGlobalBoost";
            this.tbGlobalBoost.Size = new System.Drawing.Size(37, 20);
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
            this.lblRightSoundLevel.Location = new System.Drawing.Point(380, 150);
            this.lblRightSoundLevel.Name = "lblRightSoundLevel";
            this.lblRightSoundLevel.Size = new System.Drawing.Size(13, 13);
            this.lblRightSoundLevel.TabIndex = 22;
            this.lblRightSoundLevel.Text = "0";
            // 
            // lblLeftSoundLevel
            // 
            this.lblLeftSoundLevel.AutoSize = true;
            this.lblLeftSoundLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLeftSoundLevel.Location = new System.Drawing.Point(125, 150);
            this.lblLeftSoundLevel.Name = "lblLeftSoundLevel";
            this.lblLeftSoundLevel.Size = new System.Drawing.Size(13, 13);
            this.lblLeftSoundLevel.TabIndex = 23;
            this.lblLeftSoundLevel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Audio source:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLeftSoundLevel);
            this.Controls.Add(this.lblRightSoundLevel);
            this.Controls.Add(this.tbGlobalBoost);
            this.Controls.Add(this.tbLeftBoost);
            this.Controls.Add(this.tbRightBoost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRightMax);
            this.Controls.Add(this.tbRightMin);
            this.Controls.Add(this.tbLeftMax);
            this.Controls.Add(this.tbLeftMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEnableRight);
            this.Controls.Add(this.cbEnableLeft);
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Sound To Vibro V0.1";
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

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ProgressBar pbLeft;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox cbEnableLeft;
        private System.Windows.Forms.CheckBox cbEnableRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbLeftMin;
        private System.Windows.Forms.TrackBar tbLeftMax;
        private System.Windows.Forms.TrackBar tbRightMax;
        private System.Windows.Forms.TrackBar tbRightMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown tbRightBoost;
        private System.Windows.Forms.NumericUpDown tbLeftBoost;
        private System.Windows.Forms.NumericUpDown tbGlobalBoost;
        private System.Windows.Forms.Label lblRightSoundLevel;
        private System.Windows.Forms.Label lblLeftSoundLevel;
        private System.Windows.Forms.Label label1;
    }
}

