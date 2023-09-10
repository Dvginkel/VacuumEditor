namespace VacuumEditor.Forms
{
    partial class VacuumWarrior
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.VacuumWarriorLoadSaveBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // VacuumWarriorLoadSaveBtn
            // 
            this.VacuumWarriorLoadSaveBtn.Location = new System.Drawing.Point(13, 13);
            this.VacuumWarriorLoadSaveBtn.Name = "VacuumWarriorLoadSaveBtn";
            this.VacuumWarriorLoadSaveBtn.Size = new System.Drawing.Size(218, 23);
            this.VacuumWarriorLoadSaveBtn.TabIndex = 0;
            this.VacuumWarriorLoadSaveBtn.Text = "Load Save";
            this.VacuumWarriorLoadSaveBtn.UseVisualStyleBackColor = true;
            this.VacuumWarriorLoadSaveBtn.Click += new System.EventHandler(this.VacuumWarriorLoadSaveBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(775, 395);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // VacuumWarrior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.VacuumWarriorLoadSaveBtn);
            this.Name = "VacuumWarrior";
            this.Text = "Vacuum Warrior";
            this.Load += new System.EventHandler(this.VacuumWarrior_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button VacuumWarriorLoadSaveBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}