using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace VacuumEditor.Forms
{
    public partial class VacuumWarrior : Form
    {
        private string fileName;

        public VacuumWarrior()
        {
            InitializeComponent();
        }

        private void VacuumWarrior_Load(object sender, EventArgs e)
        {

        }

        private void LoadSaveToolStripMenuItem_Click(object sender, EventArgs e)
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

            //Debug.WriteLine(decodedString);

            var result = JsonConvert.DeserializeObject<Instances>(decodedString);

            Debug.WriteLine(result.Currencies.CurrencyData.VacuumTokens);



        }

        private void VacuumWarriorLoadSaveBtn_Click(object sender, EventArgs e)
        {
            // create a open file dialog in the location of vacuum warrior idle game save path
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
    }
}
