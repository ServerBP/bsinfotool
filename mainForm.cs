using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BSInfoTool
{
    public partial class mainScreen : Form
    {
        // we define all of the needed variables
        public static string envFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string localFolder = Path.Combine(envFolder, "BSInfo");
        public static string jsonFolder = Path.Combine(localFolder, "json");
        public static bool saveLocally = false;
        public static bool songInfoPanelExists = false;
        
        public mainScreen()
        {
            InitializeComponent();
            // setting the form size to static
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //setting the form to be able to be minimized, but not fullscreened
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            // check if the appdata folder exists
            if (!Directory.Exists(envFolder))
            {
                Directory.CreateDirectory(envFolder);
            }
            // check if the localFolder exists
            if (!Directory.Exists(localFolder))
            {
                Directory.CreateDirectory(localFolder);
            }
            // check if the jsonFolder exists
            if (!Directory.Exists(jsonFolder))
            {
                Directory.CreateDirectory(jsonFolder);
            }
            progressBarMain.Hide();
            progressBarText.Hide();
            saveInfoToggle.Checked = true;
        }

        private void mainScreen_Load(object sender, EventArgs e)
        {

        }

        private void saveInfoToggle_CheckedChanged(object sender, EventArgs e)
        {
            saveLocally = saveInfoToggle.Checked;
        }

        // when the user clicks the get map information button
        private void getMapInfoButton_Click(object sender, EventArgs e)
        {
            if(songInfoPanelExists == false)
            {
                mapInfoForm mapInfop = new mapInfoForm();
                mapInfop.Show();
                mapInfop.FormClosed += mapInfop_FormClosed;
                songInfoPanelExists = true;
                progressBarText.Hide();
            } 
            else
            {
                progressBarText.Text = "You already have a song information panel open!";
                progressBarText.Show();
            }
        }
        // when the user clicks the get player information button
        private void getPlayerInfoButton_Click(object sender, EventArgs e)
        {

        }

        // useless but required...
        public void progressBarMain_Click(object sender, EventArgs e)
        {

        }
        // what to do when the songInfoPanel closes
        private void mapInfop_FormClosed(object sender, EventArgs e)
        {
            songInfoPanelExists = false;
            progressBarText.Hide();
        }
    }
}
