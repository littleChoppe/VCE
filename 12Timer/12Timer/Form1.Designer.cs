namespace _12Timer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toggleEnabled = new System.Windows.Forms.Button();
            this.startTimer = new System.Windows.Forms.Button();
            this.stopTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toggleEnabled
            // 
            this.toggleEnabled.Location = new System.Drawing.Point(90, 55);
            this.toggleEnabled.Name = "toggleEnabled";
            this.toggleEnabled.Size = new System.Drawing.Size(75, 23);
            this.toggleEnabled.TabIndex = 0;
            this.toggleEnabled.Text = "Toggle";
            this.toggleEnabled.UseVisualStyleBackColor = true;
            this.toggleEnabled.Click += new System.EventHandler(this.toggleEnabled_Click);
            // 
            // startTimer
            // 
            this.startTimer.Location = new System.Drawing.Point(90, 105);
            this.startTimer.Name = "startTimer";
            this.startTimer.Size = new System.Drawing.Size(75, 23);
            this.startTimer.TabIndex = 1;
            this.startTimer.Text = "Start";
            this.startTimer.UseVisualStyleBackColor = true;
            this.startTimer.Click += new System.EventHandler(this.startTimer_Click);
            // 
            // stopTimer
            // 
            this.stopTimer.Location = new System.Drawing.Point(90, 151);
            this.stopTimer.Name = "stopTimer";
            this.stopTimer.Size = new System.Drawing.Size(75, 23);
            this.stopTimer.TabIndex = 2;
            this.stopTimer.Text = "Stop";
            this.stopTimer.UseVisualStyleBackColor = true;
            this.stopTimer.Click += new System.EventHandler(this.stopTimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.stopTimer);
            this.Controls.Add(this.startTimer);
            this.Controls.Add(this.toggleEnabled);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button toggleEnabled;
        private System.Windows.Forms.Button startTimer;
        private System.Windows.Forms.Button stopTimer;
    }
}

