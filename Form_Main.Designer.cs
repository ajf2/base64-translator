namespace Base64Translator
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_ClearText = new System.Windows.Forms.TextBox();
            this.textBox_CipherText = new System.Windows.Forms.TextBox();
            this.label_ClearText = new System.Windows.Forms.Label();
            this.label_CipherText = new System.Windows.Forms.Label();
            this.label_TextEncoding = new System.Windows.Forms.Label();
            this.comboBox_TextEncoding = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_ClearText
            // 
            this.textBox_ClearText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ClearText.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ClearText.Location = new System.Drawing.Point(12, 33);
            this.textBox_ClearText.Multiline = true;
            this.textBox_ClearText.Name = "textBox_ClearText";
            this.textBox_ClearText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_ClearText.Size = new System.Drawing.Size(400, 100);
            this.textBox_ClearText.TabIndex = 0;
            this.textBox_ClearText.TextChanged += new System.EventHandler(this.textBox_ClearText_TextChanged);
            // 
            // textBox_CipherText
            // 
            this.textBox_CipherText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_CipherText.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CipherText.Location = new System.Drawing.Point(12, 152);
            this.textBox_CipherText.Multiline = true;
            this.textBox_CipherText.Name = "textBox_CipherText";
            this.textBox_CipherText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_CipherText.Size = new System.Drawing.Size(400, 100);
            this.textBox_CipherText.TabIndex = 1;
            this.textBox_CipherText.TextChanged += new System.EventHandler(this.textBox_CipherText_TextChanged);
            // 
            // label_ClearText
            // 
            this.label_ClearText.AutoSize = true;
            this.label_ClearText.Location = new System.Drawing.Point(12, 17);
            this.label_ClearText.Name = "label_ClearText";
            this.label_ClearText.Size = new System.Drawing.Size(55, 13);
            this.label_ClearText.TabIndex = 2;
            this.label_ClearText.Text = "Clear Text";
            // 
            // label_CipherText
            // 
            this.label_CipherText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_CipherText.AutoSize = true;
            this.label_CipherText.Location = new System.Drawing.Point(12, 136);
            this.label_CipherText.Name = "label_CipherText";
            this.label_CipherText.Size = new System.Drawing.Size(61, 13);
            this.label_CipherText.TabIndex = 3;
            this.label_CipherText.Text = "Cipher Text";
            // 
            // label_TextEncoding
            // 
            this.label_TextEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TextEncoding.AutoSize = true;
            this.label_TextEncoding.Location = new System.Drawing.Point(269, 9);
            this.label_TextEncoding.Name = "label_TextEncoding";
            this.label_TextEncoding.Size = new System.Drawing.Size(76, 13);
            this.label_TextEncoding.TabIndex = 4;
            this.label_TextEncoding.Text = "Text Encoding";
            // 
            // comboBox_TextEncoding
            // 
            this.comboBox_TextEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_TextEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TextEncoding.FormattingEnabled = true;
            this.comboBox_TextEncoding.Items.AddRange(new object[] {
            "ASCII",
            "UTF-8",
            "UTF-16",
            "UTF-32"});
            this.comboBox_TextEncoding.Location = new System.Drawing.Point(351, 6);
            this.comboBox_TextEncoding.Name = "comboBox_TextEncoding";
            this.comboBox_TextEncoding.Size = new System.Drawing.Size(61, 21);
            this.comboBox_TextEncoding.TabIndex = 5;
            this.comboBox_TextEncoding.SelectedIndexChanged += new System.EventHandler(this.comboBox_TextEncoding_SelectedIndexChanged);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 264);
            this.Controls.Add(this.comboBox_TextEncoding);
            this.Controls.Add(this.label_TextEncoding);
            this.Controls.Add(this.label_CipherText);
            this.Controls.Add(this.label_ClearText);
            this.Controls.Add(this.textBox_CipherText);
            this.Controls.Add(this.textBox_ClearText);
            this.MinimumSize = new System.Drawing.Size(440, 302);
            this.Name = "Form_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Base 64 Translator";
            this.SizeChanged += new System.EventHandler(this.Form_Main_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ClearText;
        private System.Windows.Forms.TextBox textBox_CipherText;
        private System.Windows.Forms.Label label_ClearText;
        private System.Windows.Forms.Label label_CipherText;
        private System.Windows.Forms.Label label_TextEncoding;
        private System.Windows.Forms.ComboBox comboBox_TextEncoding;
    }
}

