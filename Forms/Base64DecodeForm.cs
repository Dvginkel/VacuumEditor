using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VacuumEditor.Forms
{
    public partial class Base64DecodeForm : Form
    {
        public Base64DecodeForm()
        {
            InitializeComponent();
        }

        private void ConvertBase64ToStringBtn_Click(object sender, EventArgs e)
        {
            // Get the base64 string from the text box and convert it to bytes
            byte[] data = Convert.FromBase64String(base64StringRichTextBox.Text);

            // Convert from bytes to string
            string decodedString = Encoding.UTF8.GetString(data);

            // Set the converted string to the text box
            ConvertedStringRichTextBox.Text = decodedString;

            // create code to check encoding of decodedString

        }

        private void convertedStringToEditorBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
