using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using VacuumEditor.Forms;

namespace VacuumEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        String fileName = "";
        private void SaveGameSelectBtn_Click(object sender, EventArgs e)
        {
            // Show a dialog box to select a save file
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Vacuum Warrior Save Files (*.dat)|*.dat",
                Title = "Select a Vacuum Warrior Save File",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\VacuumWarrior\VacuumWarrior"
            };
            openFileDialog1.ShowDialog();
            // Debug.WriteLine(openFileDialog1.FileName);
            // Debug.WriteLine(openFileDialog1.InitialDirectory);
            fileName = openFileDialog1.FileName;
            ReadSaveFile();
        }

        private void Main_Load(object sender, EventArgs e)
        {


        }

        private void ReadSaveFile()
        {
            // Read the save file
            string saveFile = System.IO.File.ReadAllText(fileName);
            // Decode the save file from base64 to bytes
            byte[] data = Convert.FromBase64String(saveFile);

            // Convert from bytes to string
            string decodedString = Encoding.UTF8.GetString(data);

            Debug.WriteLine(decodedString);





        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        private void LoadSaveButton_Click(object sender, EventArgs e)
        {
            // Show a dialog box to select a save file to load
            OpenFileDialog loadSaveFileDialog = new OpenFileDialog
            {
                Filter = "Vacuum Warrior Save Files (*.dat)|*.dat",
                Title = "Select a Vacuum Warrior Save File",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\VacuumWarrior\VacuumWarrior"
            };
            loadSaveFileDialog.ShowDialog();
        }

        private void DecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Base64DecodeForm base64DecodeForm = new Base64DecodeForm();
            base64DecodeForm.MdiParent = this;
            base64DecodeForm.Show();
        }

        private void VacuumWarriorIdleGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VacuumWarrior VacuumWarrior = new VacuumWarrior();
            VacuumWarrior.MdiParent = this;
            VacuumWarrior.Show();
        }
    }
}
