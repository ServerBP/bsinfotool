using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BSInfoTool
{
    public partial class mapInfoForm : Form
    {
        public dynamic map;
        public mapInfoForm()
        {
            InitializeComponent();
            // setting the form size to static
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //setting the form to be able to be minimized, but not fullscreened
            this.MaximizeBox = false;
            this.MinimizeBox = true;
        }

        private void mapInfoForm_Load(object sender, EventArgs e)
        {
            mapImagePicturebox.ImageLocation = "https://th.bing.com/th/id/OIP.xUikNgM3Yi87bETw7ru-egAAAA?rs=1&pid=ImgDetMain";
            mapImagePicturebox.SizeMode = PictureBoxSizeMode.Zoom;
            mapInfoDisplayList.AllowDrop = true;
        }

        private void mapIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startMapInfo_Click(object sender, EventArgs e)
        {
            string mapIDProvided = mapIDTextbox.Text;
            if(mapIDProvided == "")
            {
                mapInfoLabel.Text = "Please provide a map ID";
                return;
            }
            
            try
            {
                using (WebClient client = new WebClient())
                {
                    // we check if the map is found by the api
                    if (client.DownloadString($"https://api.beatsaver.com/maps/id/{mapIDProvided}") == null)
                    {
                        mapInfoLabel.Text = $"The map ID {mapIDProvided} is incorrect. Please retry.";
                        mapInfoDisplayList.Items.Clear();
                        mapImagePicturebox.ImageLocation = "https://th.bing.com/th/id/OIP.xUikNgM3Yi87bETw7ru-egAAAA?rs=1&pid=ImgDetMain";
                        return;
                    }
                    // we check user preference for saving files locally
                    if (mainScreen.saveLocally == true)
                    {
                        client.DownloadFile($"https://api.beatsaver.com/maps/id/{mapIDProvided}", $"{mainScreen.jsonFolder}/{mapIDProvided}.json");
                        string mapJson = File.ReadAllText($"{mainScreen.jsonFolder}/{mapIDProvided}.json");
                        map = JsonConvert.DeserializeObject(mapJson);
                    }
                    else
                    {
                        string mapJson = client.DownloadString($"https://api.beatsaver.com/maps/id/{mapIDProvided}");
                        map = JsonConvert.DeserializeObject(mapJson);
                    }
                    mapImagePicturebox.ImageLocation = map.versions[0].coverURL;
                    mapInfoLabel.Text = $"{mapIDProvided} - {map.name}";
                    setInformation_Map(map, mapInfoDisplayList);
                }
            }
            catch (WebException)
            {
                mapInfoLabel.Text = $"The map ID {mapIDProvided} is incorrect. Please retry.";
                mapInfoDisplayList.Items.Clear();
                mapImagePicturebox.ImageLocation = "https://th.bing.com/th/id/OIP.xUikNgM3Yi87bETw7ru-egAAAA?rs=1&pid=ImgDetMain";
                return;
            }
        }

        private void mapInfoDisplayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapInfoDisplayList.SelectedItem.ToString().Contains("Uploader"))
            {
                mapImagePicturebox.ImageLocation = map.uploader.avatar;
                mapInfoLabel.Text = $"{map.uploader.name} - Mapper";
                setInformation_SideUser(map, sideInfoList);
            }
            else
            {
                mapImagePicturebox.ImageLocation = map.versions[0].coverURL;
                mapInfoLabel.Text = $"{map.id} - {map.name}";
            }
        }
        // useless but required...
        private void mapInagePicturebox_Click(object sender, EventArgs e)
        {
            
        }

        public static void setInformation_Map(dynamic map, ListBox mapInfoDisplayList)
        {
            mapInfoDisplayList.Items.Clear();
            mapInfoDisplayList.Items.Add($"Map Name: {map.name}");
            mapInfoDisplayList.Items.Add($"Uploader: {map.uploader.name}");
            mapInfoDisplayList.Items.Add($"Uploader ID: {map.uploader.id}");
            mapInfoDisplayList.Items.Add($"Map Description: {map.description}");
            mapInfoDisplayList.Items.Add($"Created at: {map.createdAt}");
            mapInfoDisplayList.Items.Add($"Declared AI: {map.declaredAi}");
            mapInfoDisplayList.Items.Add($"Deleted at: {map.deletedAt}");
            mapInfoDisplayList.Items.Add($"Last published at: {map.lastPublishedAt}");
            mapInfoDisplayList.Items.Add($"Map is qualified(SS): {map.qualified}");
            mapInfoDisplayList.Items.Add($"Map is ranked(SS): {map.ranked}");
            mapInfoDisplayList.Items.Add($"Map is qualified(BL): {map.blQualified}");
            mapInfoDisplayList.Items.Add($"Map is ranked(BL): {map.blRanked}");
            mapInfoDisplayList.Items.Add($"Map tags: {map.tags}");
            mapInfoDisplayList.Items.Add($"Map uploaded at: {map.uploadedAt}");
            mapInfoDisplayList.Items.Add($"");
            mapInfoDisplayList.Items.Add($"");
            mapInfoDisplayList.Items.Add($"");
            mapInfoDisplayList.Items.Add($"");
            mapInfoDisplayList.Items.Add($"");
        }
        public static void setInformation_SideUser(dynamic map, ListBox mapInfoDisplayList)
        {
            dynamic user;
            using (WebClient client = new WebClient())
            {
                string userJson = client.DownloadString($"https://api.beatsaver.com/users/id/{map.uploader.id}");
                user = JsonConvert.DeserializeObject(userJson);
            }
            mapInfoDisplayList.Items.Clear();
            mapInfoDisplayList.Items.Add($"Username: {map.uploader.name}");
            mapInfoDisplayList.Items.Add($"Uploader ID: {map.uploader.name}");
            mapInfoDisplayList.Items.Add($"User is admin: {map.uploader.admin}");
            mapInfoDisplayList.Items.Add($"User is curator: {map.uploader.curator}");
            mapInfoDisplayList.Items.Add($"User is senior curator: {map.uploader.seniorCurator}");
            mapInfoDisplayList.Items.Add($"User playlist URL: {map.uploader.playlistURL}");
            mapInfoDisplayList.Items.Add($"User registration platform: {map.uploader.type}");
            mapInfoDisplayList.Items.Add($"User is a verified mapper: {user.verifiedMapper}");
            mapInfoDisplayList.Items.Add($"Average BPM: {user.stats.avgBpm}");
            mapInfoDisplayList.Items.Add($"Average Duration: {user.stats.avgDuration}");
            mapInfoDisplayList.Items.Add($"Average Score: {user.stats.avgScore}");
            mapInfoDisplayList.Items.Add($"First upload: {user.stats.firstUpload}");
            mapInfoDisplayList.Items.Add($"Last upload: {user.stats.lastUpload}");
            mapInfoDisplayList.Items.Add($"Ranked maps: {user.stats.rankedMaps}");
            mapInfoDisplayList.Items.Add($"Total downvotes: {user.stats.totalDownvotes}");
            mapInfoDisplayList.Items.Add($"Total upvotes: {user.stats.totalUpvotes}");
            mapInfoDisplayList.Items.Add($"Total easy(diff) maps: {user.stats.diffStats.easy}");
            mapInfoDisplayList.Items.Add($"Total normal(diff) maps: {user.stats.diffStats.normal}");
            mapInfoDisplayList.Items.Add($"Total hard(diff) maps: {user.stats.diffStats.hard}");
            mapInfoDisplayList.Items.Add($"Total expert(diff) maps: {user.stats.diffStats.expert}");
            mapInfoDisplayList.Items.Add($"Total expert+(diff) maps: {user.stats.diffStats.expertPlus}");
            mapInfoDisplayList.Items.Add($"Total difficulties in maps: {user.stats.diffStats.total}");
            mapInfoDisplayList.Items.Add($"Upload limit: {map.uploader.uploadLimit}");
        }
    }
}
