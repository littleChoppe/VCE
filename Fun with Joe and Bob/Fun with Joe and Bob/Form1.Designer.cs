namespace Chapter3Program2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joesCashlabel = new System.Windows.Forms.Label();
            this.bobsCashlabel = new System.Windows.Forms.Label();
            this.bankCashlabel = new System.Windows.Forms.Label();
            this.joeGiveToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(153, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joesCashlabel
            // 
            this.joesCashlabel.AutoSize = true;
            this.joesCashlabel.Location = new System.Drawing.Point(31, 34);
            this.joesCashlabel.Name = "joesCashlabel";
            this.joesCashlabel.Size = new System.Drawing.Size(41, 12);
            this.joesCashlabel.TabIndex = 2;
            this.joesCashlabel.Text = "label1";
            // 
            // bobsCashlabel
            // 
            this.bobsCashlabel.AutoSize = true;
            this.bobsCashlabel.Location = new System.Drawing.Point(31, 63);
            this.bobsCashlabel.Name = "bobsCashlabel";
            this.bobsCashlabel.Size = new System.Drawing.Size(41, 12);
            this.bobsCashlabel.TabIndex = 3;
            this.bobsCashlabel.Text = "label2";
            // 
            // bankCashlabel
            // 
            this.bankCashlabel.AutoSize = true;
            this.bankCashlabel.Location = new System.Drawing.Point(31, 94);
            this.bankCashlabel.Name = "bankCashlabel";
            this.bankCashlabel.Size = new System.Drawing.Size(41, 12);
            this.bankCashlabel.TabIndex = 4;
            this.bankCashlabel.Text = "label3";
            // 
            // joeGiveToBob
            // 
            this.joeGiveToBob.Location = new System.Drawing.Point(33, 194);
            this.joeGiveToBob.Name = "joeGiveToBob";
            this.joeGiveToBob.Size = new System.Drawing.Size(75, 43);
            this.joeGiveToBob.TabIndex = 5;
            this.joeGiveToBob.Text = "Joe gives $10 to Bob";
            this.joeGiveToBob.UseVisualStyleBackColor = true;
            this.joeGiveToBob.Click += new System.EventHandler(this.joeGiveToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(153, 194);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(75, 43);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob gives $5 to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGiveToBob);
            this.Controls.Add(this.bankCashlabel);
            this.Controls.Add(this.bobsCashlabel);
            this.Controls.Add(this.joesCashlabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label joesCashlabel;
        private System.Windows.Forms.Label bobsCashlabel;
        private System.Windows.Forms.Label bankCashlabel;
        private System.Windows.Forms.Button joeGiveToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
    }
}

