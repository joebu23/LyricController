namespace LyricController
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
            this.button1 = new System.Windows.Forms.Button();
            this.clockStartStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clockDown = new System.Windows.Forms.Button();
            this.clockUp = new System.Windows.Forms.Button();
            this.clockTiming = new System.Windows.Forms.Label();
            this.clockAdjustBar = new System.Windows.Forms.HScrollBar();
            this.adjustClockShow = new System.Windows.Forms.Button();
            this.clockSeconds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clockMinutes = new System.Windows.Forms.TextBox();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clockStartStop
            // 
            this.clockStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockStartStop.Location = new System.Drawing.Point(6, 7);
            this.clockStartStop.Name = "clockStartStop";
            this.clockStartStop.Size = new System.Drawing.Size(80, 51);
            this.clockStartStop.TabIndex = 1;
            this.clockStartStop.Text = "Start";
            this.clockStartStop.UseVisualStyleBackColor = true;
            this.clockStartStop.Click += new System.EventHandler(this.clockStartStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clockDown);
            this.groupBox1.Controls.Add(this.clockUp);
            this.groupBox1.Controls.Add(this.clockTiming);
            this.groupBox1.Controls.Add(this.clockAdjustBar);
            this.groupBox1.Controls.Add(this.adjustClockShow);
            this.groupBox1.Controls.Add(this.clockSeconds);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.clockMinutes);
            this.groupBox1.Controls.Add(this.clockStartStop);
            this.groupBox1.Location = new System.Drawing.Point(504, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // clockDown
            // 
            this.clockDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockDown.Location = new System.Drawing.Point(203, 31);
            this.clockDown.Name = "clockDown";
            this.clockDown.Size = new System.Drawing.Size(18, 15);
            this.clockDown.TabIndex = 9;
            this.clockDown.Text = "-";
            this.clockDown.UseVisualStyleBackColor = true;
            this.clockDown.Click += new System.EventHandler(this.clockDown_Click);
            // 
            // clockUp
            // 
            this.clockUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockUp.Location = new System.Drawing.Point(203, 10);
            this.clockUp.Name = "clockUp";
            this.clockUp.Size = new System.Drawing.Size(18, 15);
            this.clockUp.TabIndex = 8;
            this.clockUp.Text = "+";
            this.clockUp.UseVisualStyleBackColor = true;
            this.clockUp.Click += new System.EventHandler(this.clockUp_Click);
            // 
            // clockTiming
            // 
            this.clockTiming.AutoSize = true;
            this.clockTiming.Location = new System.Drawing.Point(6, 61);
            this.clockTiming.Name = "clockTiming";
            this.clockTiming.Size = new System.Drawing.Size(91, 13);
            this.clockTiming.TabIndex = 7;
            this.clockTiming.Text = "1000 Milliseconds";
            this.clockTiming.Visible = false;
            // 
            // clockAdjustBar
            // 
            this.clockAdjustBar.Location = new System.Drawing.Point(9, 88);
            this.clockAdjustBar.Maximum = 2000;
            this.clockAdjustBar.Minimum = 100;
            this.clockAdjustBar.Name = "clockAdjustBar";
            this.clockAdjustBar.Size = new System.Drawing.Size(212, 23);
            this.clockAdjustBar.TabIndex = 6;
            this.clockAdjustBar.Value = 1000;
            this.clockAdjustBar.Visible = false;
            this.clockAdjustBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.clockAdjustBar_Scroll);
            // 
            // adjustClockShow
            // 
            this.adjustClockShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adjustClockShow.Location = new System.Drawing.Point(145, 56);
            this.adjustClockShow.Name = "adjustClockShow";
            this.adjustClockShow.Size = new System.Drawing.Size(76, 18);
            this.adjustClockShow.TabIndex = 5;
            this.adjustClockShow.Text = "Adjust Clock";
            this.adjustClockShow.UseVisualStyleBackColor = true;
            this.adjustClockShow.Click += new System.EventHandler(this.adjustClockShow_Click);
            // 
            // clockSeconds
            // 
            this.clockSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockSeconds.Location = new System.Drawing.Point(157, 15);
            this.clockSeconds.Name = "clockSeconds";
            this.clockSeconds.Size = new System.Drawing.Size(40, 31);
            this.clockSeconds.TabIndex = 4;
            this.clockSeconds.Text = "99";
            this.clockSeconds.TextChanged += new System.EventHandler(this.clockSeconds_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // clockMinutes
            // 
            this.clockMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockMinutes.Location = new System.Drawing.Point(104, 15);
            this.clockMinutes.Name = "clockMinutes";
            this.clockMinutes.Size = new System.Drawing.Size(40, 31);
            this.clockMinutes.TabIndex = 2;
            this.clockMinutes.Text = "99";
            this.clockMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clockMinutes.TextChanged += new System.EventHandler(this.clockMinutes_TextChanged);
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 229);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clockStartStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox clockSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clockMinutes;
        private System.Windows.Forms.Button adjustClockShow;
        private System.Windows.Forms.Label clockTiming;
        private System.Windows.Forms.HScrollBar clockAdjustBar;
        private System.Windows.Forms.Button clockDown;
        private System.Windows.Forms.Button clockUp;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Timer timer1;
    }
}

