namespace SerializableCards
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
            this.writeCards = new System.Windows.Forms.Button();
            this.readCards = new System.Windows.Forms.Button();
            this.writeManyTimes = new System.Windows.Forms.Button();
            this.readManyTimes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // writeCards
            // 
            this.writeCards.Location = new System.Drawing.Point(42, 56);
            this.writeCards.Name = "writeCards";
            this.writeCards.Size = new System.Drawing.Size(112, 23);
            this.writeCards.TabIndex = 0;
            this.writeCards.Text = "Write Cards";
            this.writeCards.UseVisualStyleBackColor = true;
            this.writeCards.Click += new System.EventHandler(this.writeCards_Click);
            // 
            // readCards
            // 
            this.readCards.Location = new System.Drawing.Point(42, 120);
            this.readCards.Name = "readCards";
            this.readCards.Size = new System.Drawing.Size(112, 23);
            this.readCards.TabIndex = 1;
            this.readCards.Text = "Read Cards";
            this.readCards.UseVisualStyleBackColor = true;
            this.readCards.Click += new System.EventHandler(this.readCards_Click);
            // 
            // writeManyTimes
            // 
            this.writeManyTimes.Location = new System.Drawing.Point(42, 167);
            this.writeManyTimes.Name = "writeManyTimes";
            this.writeManyTimes.Size = new System.Drawing.Size(112, 23);
            this.writeManyTimes.TabIndex = 2;
            this.writeManyTimes.Text = "Write Many Times";
            this.writeManyTimes.UseVisualStyleBackColor = true;
            this.writeManyTimes.Click += new System.EventHandler(this.writeManyTimes_Click);
            // 
            // readManyTimes
            // 
            this.readManyTimes.Location = new System.Drawing.Point(42, 210);
            this.readManyTimes.Name = "readManyTimes";
            this.readManyTimes.Size = new System.Drawing.Size(112, 23);
            this.readManyTimes.TabIndex = 3;
            this.readManyTimes.Text = "Read Many Times";
            this.readManyTimes.UseVisualStyleBackColor = true;
            this.readManyTimes.Click += new System.EventHandler(this.readManyTimes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.readManyTimes);
            this.Controls.Add(this.writeManyTimes);
            this.Controls.Add(this.readCards);
            this.Controls.Add(this.writeCards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button writeCards;
        private System.Windows.Forms.Button readCards;
        private System.Windows.Forms.Button writeManyTimes;
        private System.Windows.Forms.Button readManyTimes;
    }
}

