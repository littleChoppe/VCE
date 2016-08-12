namespace _7Hide_and_Seek
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
            this.exits = new System.Windows.Forms.ComboBox();
            this.goThroughTheDoor = new System.Windows.Forms.Button();
            this.goHere = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exits
            // 
            this.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(95, 258);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(251, 20);
            this.exits.TabIndex = 7;
            // 
            // goThroughTheDoor
            // 
            this.goThroughTheDoor.Location = new System.Drawing.Point(13, 297);
            this.goThroughTheDoor.Name = "goThroughTheDoor";
            this.goThroughTheDoor.Size = new System.Drawing.Size(333, 23);
            this.goThroughTheDoor.TabIndex = 6;
            this.goThroughTheDoor.Text = "Go through the door";
            this.goThroughTheDoor.UseVisualStyleBackColor = true;
            this.goThroughTheDoor.Visible = false;
            this.goThroughTheDoor.Click += new System.EventHandler(this.goThroughTheDoor_Click);
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(13, 256);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(75, 23);
            this.goHere.TabIndex = 5;
            this.goHere.Text = "Go here:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(13, 15);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Size = new System.Drawing.Size(333, 225);
            this.description.TabIndex = 4;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(12, 338);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(333, 23);
            this.check.TabIndex = 8;
            this.check.Text = "Check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Visible = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(12, 379);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(333, 23);
            this.hide.TabIndex = 9;
            this.hide.Text = "Hide!";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Visible = false;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 414);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.check);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.goThroughTheDoor);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.description);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Hide and Seek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button goThroughTheDoor;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button hide;
    }
}

