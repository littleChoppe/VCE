namespace SecretIngredients
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
            this.useIngredient = new System.Windows.Forms.Button();
            this.getSuzanne = new System.Windows.Forms.Button();
            this.getAmy = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            this.SuspendLayout();
            // 
            // useIngredient
            // 
            this.useIngredient.Location = new System.Drawing.Point(12, 12);
            this.useIngredient.Name = "useIngredient";
            this.useIngredient.Size = new System.Drawing.Size(150, 23);
            this.useIngredient.TabIndex = 0;
            this.useIngredient.Text = "Get the ingredient";
            this.useIngredient.UseVisualStyleBackColor = true;
            this.useIngredient.Click += new System.EventHandler(this.useIngredient_Click);
            // 
            // getSuzanne
            // 
            this.getSuzanne.Location = new System.Drawing.Point(12, 41);
            this.getSuzanne.Name = "getSuzanne";
            this.getSuzanne.Size = new System.Drawing.Size(195, 23);
            this.getSuzanne.TabIndex = 1;
            this.getSuzanne.Text = "Get Suzanne\'s delegate";
            this.getSuzanne.UseVisualStyleBackColor = true;
            this.getSuzanne.Click += new System.EventHandler(this.getSuzanne_Click);
            // 
            // getAmy
            // 
            this.getAmy.Location = new System.Drawing.Point(12, 70);
            this.getAmy.Name = "getAmy";
            this.getAmy.Size = new System.Drawing.Size(195, 23);
            this.getAmy.TabIndex = 2;
            this.getAmy.Text = "Get Amy\'s delegate";
            this.getAmy.UseVisualStyleBackColor = true;
            this.getAmy.Click += new System.EventHandler(this.getAmy_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(168, 12);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(39, 21);
            this.amount.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 112);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.getAmy);
            this.Controls.Add(this.getSuzanne);
            this.Controls.Add(this.useIngredient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Secret Ingredients";
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button useIngredient;
        private System.Windows.Forms.Button getSuzanne;
        private System.Windows.Forms.Button getAmy;
        private System.Windows.Forms.NumericUpDown amount;
    }
}

