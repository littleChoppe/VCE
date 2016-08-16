namespace JerseyNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // number
            // 
            this.number.FormattingEnabled = true;
            this.number.Location = new System.Drawing.Point(59, 23);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(48, 20);
            this.number.TabIndex = 1;
            this.number.Text = "l";
            this.number.SelectedIndexChanged += new System.EventHandler(this.number_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "was worn by";
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(190, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.ReadOnly = true;
            this.nameLabel.Size = new System.Drawing.Size(114, 21);
            this.nameLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "and retired in";
            // 
            // yearNumber
            // 
            this.yearNumber.Location = new System.Drawing.Point(405, 23);
            this.yearNumber.Name = "yearNumber";
            this.yearNumber.ReadOnly = true;
            this.yearNumber.Size = new System.Drawing.Size(63, 21);
            this.yearNumber.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 63);
            this.Controls.Add(this.yearNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Retired Jersey Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yearNumber;
    }
}

