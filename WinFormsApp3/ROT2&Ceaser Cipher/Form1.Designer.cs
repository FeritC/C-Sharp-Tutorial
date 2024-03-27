namespace Exp3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.rot2RadioButton = new System.Windows.Forms.RadioButton();
            this.chipperRadio = new System.Windows.Forms.RadioButton();
            this.encryptButton = new System.Windows.Forms.Button();
            this.successLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(58, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(161, 35);
            this.textBox1.TabIndex = 0;
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pwdLabel.Location = new System.Drawing.Point(51, 61);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(183, 42);
            this.pwdLabel.TabIndex = 1;
            this.pwdLabel.Text = "Password";
            // 
            // rot2RadioButton
            // 
            this.rot2RadioButton.AutoSize = true;
            this.rot2RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rot2RadioButton.Location = new System.Drawing.Point(468, 83);
            this.rot2RadioButton.Name = "rot2RadioButton";
            this.rot2RadioButton.Size = new System.Drawing.Size(78, 28);
            this.rot2RadioButton.TabIndex = 2;
            this.rot2RadioButton.TabStop = true;
            this.rot2RadioButton.Text = "ROT2";
            this.rot2RadioButton.UseVisualStyleBackColor = true;
            this.rot2RadioButton.CheckedChanged += new System.EventHandler(this.rot2RadioButton_CheckedChanged);
            // 
            // chipperRadio
            // 
            this.chipperRadio.AutoSize = true;
            this.chipperRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chipperRadio.Location = new System.Drawing.Point(468, 128);
            this.chipperRadio.Name = "chipperRadio";
            this.chipperRadio.Size = new System.Drawing.Size(160, 28);
            this.chipperRadio.TabIndex = 3;
            this.chipperRadio.TabStop = true;
            this.chipperRadio.Text = "Ceaser Chipper";
            this.chipperRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chipperRadio.UseVisualStyleBackColor = true;
            this.chipperRadio.CheckedChanged += new System.EventHandler(this.chipperRadio_CheckedChanged);
            // 
            // encryptButton
            // 
            this.encryptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.encryptButton.Location = new System.Drawing.Point(58, 332);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(161, 59);
            this.encryptButton.TabIndex = 4;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.successLabel.Location = new System.Drawing.Point(516, 342);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(0, 33);
            this.successLabel.TabIndex = 5;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resultLabel.Location = new System.Drawing.Point(500, 396);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 25);
            this.resultLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.chipperRadio);
            this.Controls.Add(this.rot2RadioButton);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pwdLabel;
        private System.Windows.Forms.RadioButton rot2RadioButton;
        private System.Windows.Forms.RadioButton chipperRadio;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label successLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

