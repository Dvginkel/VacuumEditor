namespace VacuumEditor.Forms
{
    partial class Base64DecodeForm
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
            this.base64StringGroupBox = new System.Windows.Forms.GroupBox();
            this.base64StringRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ConvertedStringGroupBox = new System.Windows.Forms.GroupBox();
            this.ConvertedStringRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ConvertBase64ToStringBtn = new System.Windows.Forms.Button();
            this.SaveConvertedStringBtn = new System.Windows.Forms.Button();
            this.SaveConvertedStringFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.convertedStringToEditorBtn = new System.Windows.Forms.Button();
            this.base64StringGroupBox.SuspendLayout();
            this.ConvertedStringGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // base64StringGroupBox
            // 
            this.base64StringGroupBox.Controls.Add(this.base64StringRichTextBox);
            this.base64StringGroupBox.Location = new System.Drawing.Point(13, 13);
            this.base64StringGroupBox.Name = "base64StringGroupBox";
            this.base64StringGroupBox.Size = new System.Drawing.Size(775, 164);
            this.base64StringGroupBox.TabIndex = 0;
            this.base64StringGroupBox.TabStop = false;
            this.base64StringGroupBox.Text = "Base 64 String";
            // 
            // base64StringRichTextBox
            // 
            this.base64StringRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.base64StringRichTextBox.Location = new System.Drawing.Point(3, 16);
            this.base64StringRichTextBox.Name = "base64StringRichTextBox";
            this.base64StringRichTextBox.Size = new System.Drawing.Size(769, 145);
            this.base64StringRichTextBox.TabIndex = 0;
            this.base64StringRichTextBox.Text = "";
            // 
            // ConvertedStringGroupBox
            // 
            this.ConvertedStringGroupBox.Controls.Add(this.ConvertedStringRichTextBox);
            this.ConvertedStringGroupBox.Location = new System.Drawing.Point(13, 212);
            this.ConvertedStringGroupBox.Name = "ConvertedStringGroupBox";
            this.ConvertedStringGroupBox.Size = new System.Drawing.Size(775, 187);
            this.ConvertedStringGroupBox.TabIndex = 1;
            this.ConvertedStringGroupBox.TabStop = false;
            this.ConvertedStringGroupBox.Text = "Converted String";
            // 
            // ConvertedStringRichTextBox
            // 
            this.ConvertedStringRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConvertedStringRichTextBox.Location = new System.Drawing.Point(3, 16);
            this.ConvertedStringRichTextBox.Name = "ConvertedStringRichTextBox";
            this.ConvertedStringRichTextBox.Size = new System.Drawing.Size(769, 168);
            this.ConvertedStringRichTextBox.TabIndex = 0;
            this.ConvertedStringRichTextBox.Text = "";
            // 
            // ConvertBase64ToStringBtn
            // 
            this.ConvertBase64ToStringBtn.BackColor = System.Drawing.Color.SlateGray;
            this.ConvertBase64ToStringBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ConvertBase64ToStringBtn.Location = new System.Drawing.Point(13, 183);
            this.ConvertBase64ToStringBtn.Name = "ConvertBase64ToStringBtn";
            this.ConvertBase64ToStringBtn.Size = new System.Drawing.Size(775, 23);
            this.ConvertBase64ToStringBtn.TabIndex = 2;
            this.ConvertBase64ToStringBtn.Text = "Convert";
            this.ConvertBase64ToStringBtn.UseVisualStyleBackColor = false;
            this.ConvertBase64ToStringBtn.Click += new System.EventHandler(this.ConvertBase64ToStringBtn_Click);
            // 
            // SaveConvertedStringBtn
            // 
            this.SaveConvertedStringBtn.Location = new System.Drawing.Point(673, 406);
            this.SaveConvertedStringBtn.Name = "SaveConvertedStringBtn";
            this.SaveConvertedStringBtn.Size = new System.Drawing.Size(111, 23);
            this.SaveConvertedStringBtn.TabIndex = 3;
            this.SaveConvertedStringBtn.Text = "Save to file...";
            this.SaveConvertedStringBtn.UseVisualStyleBackColor = true;
            // 
            // convertedStringToEditorBtn
            // 
            this.convertedStringToEditorBtn.Location = new System.Drawing.Point(505, 406);
            this.convertedStringToEditorBtn.Name = "convertedStringToEditorBtn";
            this.convertedStringToEditorBtn.Size = new System.Drawing.Size(162, 23);
            this.convertedStringToEditorBtn.TabIndex = 4;
            this.convertedStringToEditorBtn.Text = "Load In Editor";
            this.convertedStringToEditorBtn.UseVisualStyleBackColor = true;
            this.convertedStringToEditorBtn.Visible = false;
            this.convertedStringToEditorBtn.Click += new System.EventHandler(this.convertedStringToEditorBtn_Click);
            // 
            // Base64DecodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.convertedStringToEditorBtn);
            this.Controls.Add(this.SaveConvertedStringBtn);
            this.Controls.Add(this.ConvertBase64ToStringBtn);
            this.Controls.Add(this.ConvertedStringGroupBox);
            this.Controls.Add(this.base64StringGroupBox);
            this.Name = "Base64DecodeForm";
            this.Text = "Base64 Decode Form";
            this.base64StringGroupBox.ResumeLayout(false);
            this.ConvertedStringGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox base64StringGroupBox;
        private System.Windows.Forms.GroupBox ConvertedStringGroupBox;
        private System.Windows.Forms.Button ConvertBase64ToStringBtn;
        private System.Windows.Forms.RichTextBox base64StringRichTextBox;
        private System.Windows.Forms.RichTextBox ConvertedStringRichTextBox;
        private System.Windows.Forms.Button SaveConvertedStringBtn;
        private System.Windows.Forms.SaveFileDialog SaveConvertedStringFileDialog;
        private System.Windows.Forms.Button convertedStringToEditorBtn;
    }
}