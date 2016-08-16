namespace _7MoveTheCard
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
            this.listDeck1 = new System.Windows.Forms.ListBox();
            this.labelDeck1 = new System.Windows.Forms.Label();
            this.listDeck2 = new System.Windows.Forms.ListBox();
            this.moveToDeck2 = new System.Windows.Forms.Button();
            this.moveToDeck1 = new System.Windows.Forms.Button();
            this.labelDeck2 = new System.Windows.Forms.Label();
            this.reset1 = new System.Windows.Forms.Button();
            this.shuffle1 = new System.Windows.Forms.Button();
            this.reset2 = new System.Windows.Forms.Button();
            this.shuffle2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDeck1
            // 
            this.listDeck1.FormattingEnabled = true;
            this.listDeck1.ItemHeight = 12;
            this.listDeck1.Location = new System.Drawing.Point(12, 39);
            this.listDeck1.Name = "listDeck1";
            this.listDeck1.Size = new System.Drawing.Size(159, 292);
            this.listDeck1.TabIndex = 0;
            // 
            // labelDeck1
            // 
            this.labelDeck1.AutoSize = true;
            this.labelDeck1.Location = new System.Drawing.Point(10, 24);
            this.labelDeck1.Name = "labelDeck1";
            this.labelDeck1.Size = new System.Drawing.Size(65, 12);
            this.labelDeck1.TabIndex = 1;
            this.labelDeck1.Text = "labelDeck1";
            // 
            // listDeck2
            // 
            this.listDeck2.FormattingEnabled = true;
            this.listDeck2.ItemHeight = 12;
            this.listDeck2.Location = new System.Drawing.Point(229, 39);
            this.listDeck2.Name = "listDeck2";
            this.listDeck2.Size = new System.Drawing.Size(159, 292);
            this.listDeck2.TabIndex = 2;
            // 
            // moveToDeck2
            // 
            this.moveToDeck2.Location = new System.Drawing.Point(177, 122);
            this.moveToDeck2.Name = "moveToDeck2";
            this.moveToDeck2.Size = new System.Drawing.Size(46, 23);
            this.moveToDeck2.TabIndex = 3;
            this.moveToDeck2.Text = ">>";
            this.moveToDeck2.UseVisualStyleBackColor = true;
            this.moveToDeck2.Click += new System.EventHandler(this.moveToDeck2_Click);
            // 
            // moveToDeck1
            // 
            this.moveToDeck1.Location = new System.Drawing.Point(177, 187);
            this.moveToDeck1.Name = "moveToDeck1";
            this.moveToDeck1.Size = new System.Drawing.Size(46, 23);
            this.moveToDeck1.TabIndex = 4;
            this.moveToDeck1.Text = "<<";
            this.moveToDeck1.UseVisualStyleBackColor = true;
            this.moveToDeck1.Click += new System.EventHandler(this.moveToDeck1_Click);
            // 
            // labelDeck2
            // 
            this.labelDeck2.AutoSize = true;
            this.labelDeck2.Location = new System.Drawing.Point(227, 24);
            this.labelDeck2.Name = "labelDeck2";
            this.labelDeck2.Size = new System.Drawing.Size(65, 12);
            this.labelDeck2.TabIndex = 5;
            this.labelDeck2.Text = "labelDeck2";
            // 
            // reset1
            // 
            this.reset1.Location = new System.Drawing.Point(12, 350);
            this.reset1.Name = "reset1";
            this.reset1.Size = new System.Drawing.Size(159, 23);
            this.reset1.TabIndex = 6;
            this.reset1.Text = "Reset Deck #1";
            this.reset1.UseVisualStyleBackColor = true;
            this.reset1.Click += new System.EventHandler(this.reset1_Click);
            // 
            // shuffle1
            // 
            this.shuffle1.Location = new System.Drawing.Point(12, 379);
            this.shuffle1.Name = "shuffle1";
            this.shuffle1.Size = new System.Drawing.Size(159, 23);
            this.shuffle1.TabIndex = 7;
            this.shuffle1.Text = "Shuffle Deck #1";
            this.shuffle1.UseVisualStyleBackColor = true;
            this.shuffle1.Click += new System.EventHandler(this.shuffle1_Click);
            // 
            // reset2
            // 
            this.reset2.Location = new System.Drawing.Point(229, 350);
            this.reset2.Name = "reset2";
            this.reset2.Size = new System.Drawing.Size(159, 23);
            this.reset2.TabIndex = 8;
            this.reset2.Text = "Reset Deck #2";
            this.reset2.UseVisualStyleBackColor = true;
            this.reset2.Click += new System.EventHandler(this.reset2_Click);
            // 
            // shuffle2
            // 
            this.shuffle2.Location = new System.Drawing.Point(229, 379);
            this.shuffle2.Name = "shuffle2";
            this.shuffle2.Size = new System.Drawing.Size(159, 23);
            this.shuffle2.TabIndex = 9;
            this.shuffle2.Text = "Shuffle Deck #2";
            this.shuffle2.UseVisualStyleBackColor = true;
            this.shuffle2.Click += new System.EventHandler(this.shuffle2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 422);
            this.Controls.Add(this.shuffle2);
            this.Controls.Add(this.reset2);
            this.Controls.Add(this.shuffle1);
            this.Controls.Add(this.reset1);
            this.Controls.Add(this.labelDeck2);
            this.Controls.Add(this.moveToDeck1);
            this.Controls.Add(this.moveToDeck2);
            this.Controls.Add(this.listDeck2);
            this.Controls.Add(this.labelDeck1);
            this.Controls.Add(this.listDeck1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Two Decks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listDeck1;
        private System.Windows.Forms.Label labelDeck1;
        private System.Windows.Forms.ListBox listDeck2;
        private System.Windows.Forms.Button moveToDeck2;
        private System.Windows.Forms.Button moveToDeck1;
        private System.Windows.Forms.Label labelDeck2;
        private System.Windows.Forms.Button reset1;
        private System.Windows.Forms.Button shuffle1;
        private System.Windows.Forms.Button reset2;
        private System.Windows.Forms.Button shuffle2;
    }
}

