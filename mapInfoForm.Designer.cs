namespace BSInfoTool
{
    partial class mapInfoForm
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
            this.startMapInfo = new System.Windows.Forms.Button();
            this.mapIDTextbox = new System.Windows.Forms.TextBox();
            this.mapInfoDisplayList = new System.Windows.Forms.ListBox();
            this.mapImagePicturebox = new System.Windows.Forms.PictureBox();
            this.mapInfoLabel = new System.Windows.Forms.Label();
            this.sideInfoList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapImagePicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // startMapInfo
            // 
            this.startMapInfo.Location = new System.Drawing.Point(277, 12);
            this.startMapInfo.Name = "startMapInfo";
            this.startMapInfo.Size = new System.Drawing.Size(115, 21);
            this.startMapInfo.TabIndex = 0;
            this.startMapInfo.Text = "Get Map Information";
            this.startMapInfo.UseVisualStyleBackColor = true;
            this.startMapInfo.Click += new System.EventHandler(this.startMapInfo_Click);
            // 
            // mapIDTextbox
            // 
            this.mapIDTextbox.AcceptsReturn = true;
            this.mapIDTextbox.Location = new System.Drawing.Point(13, 13);
            this.mapIDTextbox.Name = "mapIDTextbox";
            this.mapIDTextbox.Size = new System.Drawing.Size(258, 20);
            this.mapIDTextbox.TabIndex = 1;
            this.mapIDTextbox.TextChanged += new System.EventHandler(this.mapIDTextbox_TextChanged);
            // 
            // mapInfoDisplayList
            // 
            this.mapInfoDisplayList.AllowDrop = true;
            this.mapInfoDisplayList.FormattingEnabled = true;
            this.mapInfoDisplayList.Location = new System.Drawing.Point(13, 39);
            this.mapInfoDisplayList.Name = "mapInfoDisplayList";
            this.mapInfoDisplayList.Size = new System.Drawing.Size(258, 394);
            this.mapInfoDisplayList.TabIndex = 2;
            this.mapInfoDisplayList.SelectedIndexChanged += new System.EventHandler(this.mapInfoDisplayList_SelectedIndexChanged);
            // 
            // mapImagePicturebox
            // 
            this.mapImagePicturebox.Location = new System.Drawing.Point(340, 56);
            this.mapImagePicturebox.Name = "mapImagePicturebox";
            this.mapImagePicturebox.Size = new System.Drawing.Size(162, 150);
            this.mapImagePicturebox.TabIndex = 3;
            this.mapImagePicturebox.TabStop = false;
            this.mapImagePicturebox.Click += new System.EventHandler(this.mapInagePicturebox_Click);
            // 
            // mapInfoLabel
            // 
            this.mapInfoLabel.AutoSize = true;
            this.mapInfoLabel.Location = new System.Drawing.Point(278, 40);
            this.mapInfoLabel.Name = "mapInfoLabel";
            this.mapInfoLabel.Size = new System.Drawing.Size(112, 13);
            this.mapInfoLabel.TabIndex = 4;
            this.mapInfoLabel.Text = "Map Information Label";
            // 
            // sideInfoList
            // 
            this.sideInfoList.FormattingEnabled = true;
            this.sideInfoList.Location = new System.Drawing.Point(281, 221);
            this.sideInfoList.Name = "sideInfoList";
            this.sideInfoList.Size = new System.Drawing.Size(286, 212);
            this.sideInfoList.TabIndex = 5;
            // 
            // mapInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 440);
            this.Controls.Add(this.sideInfoList);
            this.Controls.Add(this.mapInfoLabel);
            this.Controls.Add(this.mapImagePicturebox);
            this.Controls.Add(this.mapInfoDisplayList);
            this.Controls.Add(this.mapIDTextbox);
            this.Controls.Add(this.startMapInfo);
            this.Name = "mapInfoForm";
            this.Text = "Get Map Information";
            this.Load += new System.EventHandler(this.mapInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapImagePicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startMapInfo;
        private System.Windows.Forms.TextBox mapIDTextbox;
        private System.Windows.Forms.ListBox mapInfoDisplayList;
        private System.Windows.Forms.PictureBox mapImagePicturebox;
        private System.Windows.Forms.Label mapInfoLabel;
        private System.Windows.Forms.ListBox sideInfoList;
    }
}