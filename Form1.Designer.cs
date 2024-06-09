namespace WF_lab3_zad1_v2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxAlgorithm = new System.Windows.Forms.ComboBox();
            this.textBoxPlainText = new System.Windows.Forms.TextBox();
            this.textBoxPlainTextHex = new System.Windows.Forms.TextBox();
            this.textBoxEncryptedTextAscii = new System.Windows.Forms.TextBox();
            this.textBoxEncryptedTextHex = new System.Windows.Forms.TextBox();
            this.textBoxDecryptedTextAscii = new System.Windows.Forms.TextBox();
            this.textBoxDecryptedTextHex = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.buttonGenerateKeys = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEncryptTime = new System.Windows.Forms.TextBox();
            this.textBoxDecryptTime = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonmanualKeys = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxAlgorithm
            // 
            this.comboBoxAlgorithm.FormattingEnabled = true;
            this.comboBoxAlgorithm.Location = new System.Drawing.Point(102, 11);
            this.comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            this.comboBoxAlgorithm.Size = new System.Drawing.Size(300, 21);
            this.comboBoxAlgorithm.TabIndex = 0;
            // 
            // textBoxPlainText
            // 
            this.textBoxPlainText.Location = new System.Drawing.Point(102, 38);
            this.textBoxPlainText.Multiline = true;
            this.textBoxPlainText.Name = "textBoxPlainText";
            this.textBoxPlainText.Size = new System.Drawing.Size(300, 45);
            this.textBoxPlainText.TabIndex = 1;
            this.textBoxPlainText.Text = "Wprowadź tekst jawny";
            // 
            // textBoxPlainTextHex
            // 
            this.textBoxPlainTextHex.Location = new System.Drawing.Point(102, 89);
            this.textBoxPlainTextHex.Multiline = true;
            this.textBoxPlainTextHex.Name = "textBoxPlainTextHex";
            this.textBoxPlainTextHex.Size = new System.Drawing.Size(300, 45);
            this.textBoxPlainTextHex.TabIndex = 2;
            // 
            // textBoxEncryptedTextAscii
            // 
            this.textBoxEncryptedTextAscii.Location = new System.Drawing.Point(102, 170);
            this.textBoxEncryptedTextAscii.Multiline = true;
            this.textBoxEncryptedTextAscii.Name = "textBoxEncryptedTextAscii";
            this.textBoxEncryptedTextAscii.Size = new System.Drawing.Size(300, 45);
            this.textBoxEncryptedTextAscii.TabIndex = 3;
            // 
            // textBoxEncryptedTextHex
            // 
            this.textBoxEncryptedTextHex.Location = new System.Drawing.Point(102, 221);
            this.textBoxEncryptedTextHex.Multiline = true;
            this.textBoxEncryptedTextHex.Name = "textBoxEncryptedTextHex";
            this.textBoxEncryptedTextHex.Size = new System.Drawing.Size(300, 45);
            this.textBoxEncryptedTextHex.TabIndex = 4;
            // 
            // textBoxDecryptedTextAscii
            // 
            this.textBoxDecryptedTextAscii.Location = new System.Drawing.Point(102, 272);
            this.textBoxDecryptedTextAscii.Multiline = true;
            this.textBoxDecryptedTextAscii.Name = "textBoxDecryptedTextAscii";
            this.textBoxDecryptedTextAscii.ReadOnly = true;
            this.textBoxDecryptedTextAscii.Size = new System.Drawing.Size(300, 45);
            this.textBoxDecryptedTextAscii.TabIndex = 5;
            // 
            // textBoxDecryptedTextHex
            // 
            this.textBoxDecryptedTextHex.Location = new System.Drawing.Point(102, 323);
            this.textBoxDecryptedTextHex.Multiline = true;
            this.textBoxDecryptedTextHex.Name = "textBoxDecryptedTextHex";
            this.textBoxDecryptedTextHex.ReadOnly = true;
            this.textBoxDecryptedTextHex.Size = new System.Drawing.Size(300, 45);
            this.textBoxDecryptedTextHex.TabIndex = 6;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(102, 406);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(300, 20);
            this.textBoxKey.TabIndex = 7;
            // 
            // textBoxIV
            // 
            this.textBoxIV.Location = new System.Drawing.Point(102, 432);
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.Size = new System.Drawing.Size(300, 20);
            this.textBoxIV.TabIndex = 8;
            // 
            // buttonGenerateKeys
            // 
            this.buttonGenerateKeys.Location = new System.Drawing.Point(102, 469);
            this.buttonGenerateKeys.Name = "buttonGenerateKeys";
            this.buttonGenerateKeys.Size = new System.Drawing.Size(300, 23);
            this.buttonGenerateKeys.TabIndex = 9;
            this.buttonGenerateKeys.Text = "Generate Keys";
            this.buttonGenerateKeys.UseVisualStyleBackColor = true;
            this.buttonGenerateKeys.Click += new System.EventHandler(this.buttonGenerateKeys_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(102, 539);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(300, 23);
            this.buttonEncrypt.TabIndex = 10;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(102, 568);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(300, 23);
            this.buttonDecrypt.TabIndex = 11;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Decrypted HEX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Decrypted ASCII";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Encrypted HEX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Encrypted ASCII";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Text in HEX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "IV";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Algoritm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 620);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Encrypt Time";
            // 
            // textBoxEncryptTime
            // 
            this.textBoxEncryptTime.Location = new System.Drawing.Point(102, 615);
            this.textBoxEncryptTime.Name = "textBoxEncryptTime";
            this.textBoxEncryptTime.ReadOnly = true;
            this.textBoxEncryptTime.Size = new System.Drawing.Size(300, 20);
            this.textBoxEncryptTime.TabIndex = 22;
            // 
            // textBoxDecryptTime
            // 
            this.textBoxDecryptTime.Location = new System.Drawing.Point(102, 642);
            this.textBoxDecryptTime.Name = "textBoxDecryptTime";
            this.textBoxDecryptTime.ReadOnly = true;
            this.textBoxDecryptTime.Size = new System.Drawing.Size(300, 20);
            this.textBoxDecryptTime.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 646);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Decrypt Time";
            // 
            // buttonmanualKeys
            // 
            this.buttonmanualKeys.Location = new System.Drawing.Point(102, 498);
            this.buttonmanualKeys.Name = "buttonmanualKeys";
            this.buttonmanualKeys.Size = new System.Drawing.Size(300, 23);
            this.buttonmanualKeys.TabIndex = 25;
            this.buttonmanualKeys.Text = "Confirm Manually Entered Keys";
            this.buttonmanualKeys.UseVisualStyleBackColor = true;
            this.buttonmanualKeys.Click += new System.EventHandler(this.buttonmanualKeys_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Generate Keys or Enter Them Manualy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 713);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonmanualKeys);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxDecryptTime);
            this.Controls.Add(this.textBoxEncryptTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.buttonGenerateKeys);
            this.Controls.Add(this.textBoxIV);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBoxDecryptedTextHex);
            this.Controls.Add(this.textBoxDecryptedTextAscii);
            this.Controls.Add(this.textBoxEncryptedTextHex);
            this.Controls.Add(this.textBoxEncryptedTextAscii);
            this.Controls.Add(this.textBoxPlainTextHex);
            this.Controls.Add(this.textBoxPlainText);
            this.Controls.Add(this.comboBoxAlgorithm);
            this.Name = "Form1";
            this.Text = "Encryption Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ComboBox comboBoxAlgorithm;
        private System.Windows.Forms.TextBox textBoxPlainText;
        private System.Windows.Forms.TextBox textBoxPlainTextHex;
        private System.Windows.Forms.TextBox textBoxEncryptedTextAscii;
        private System.Windows.Forms.TextBox textBoxEncryptedTextHex;
        private System.Windows.Forms.TextBox textBoxDecryptedTextHex;
        private System.Windows.Forms.TextBox textBoxDecryptedTextAscii;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxIV;
        private System.Windows.Forms.Button buttonGenerateKeys;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEncryptTime;
        private System.Windows.Forms.TextBox textBoxDecryptTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonmanualKeys;
        private System.Windows.Forms.Label label12;
    }
}

