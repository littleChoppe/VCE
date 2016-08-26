namespace PlayBall
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
            this.trajectory = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.NumericUpDown();
            this.playBall = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trajectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).BeginInit();
            this.SuspendLayout();
            // 
            // trajectory
            // 
            this.trajectory.Location = new System.Drawing.Point(119, 36);
            this.trajectory.Name = "trajectory";
            this.trajectory.Size = new System.Drawing.Size(120, 21);
            this.trajectory.TabIndex = 0;
            this.trajectory.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trajectory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distance";
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(119, 77);
            this.distance.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(120, 21);
            this.distance.TabIndex = 3;
            this.distance.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // playBall
            // 
            this.playBall.Location = new System.Drawing.Point(119, 119);
            this.playBall.Name = "playBall";
            this.playBall.Size = new System.Drawing.Size(75, 23);
            this.playBall.TabIndex = 4;
            this.playBall.Text = "Play ball!";
            this.playBall.UseVisualStyleBackColor = true;
            this.playBall.Click += new System.EventHandler(this.playBall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.playBall);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trajectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Baseball";
            ((System.ComponentModel.ISupportInitialize)(this.trajectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown trajectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown distance;
        private System.Windows.Forms.Button playBall;
    }
}

