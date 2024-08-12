namespace BSInfoTool
{
    partial class mainScreen
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
            this.saveInfoToggle = new System.Windows.Forms.CheckBox();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.progressBarText = new System.Windows.Forms.Label();
            this.getMapInfoButton = new System.Windows.Forms.Button();
            this.getPlayerInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saveInfoToggle
            // 
            this.saveInfoToggle.AutoSize = true;
            this.saveInfoToggle.Location = new System.Drawing.Point(15, 66);
            this.saveInfoToggle.Name = "saveInfoToggle";
            this.saveInfoToggle.Size = new System.Drawing.Size(160, 17);
            this.saveInfoToggle.TabIndex = 0;
            this.saveInfoToggle.Text = "Save map information locally";
            this.saveInfoToggle.UseVisualStyleBackColor = true;
            this.saveInfoToggle.CheckedChanged += new System.EventHandler(this.saveInfoToggle_CheckedChanged);
            // 
            // progressBarMain
            // 
            this.progressBarMain.Location = new System.Drawing.Point(12, 109);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(262, 24);
            this.progressBarMain.TabIndex = 1;
            this.progressBarMain.Click += new System.EventHandler(this.progressBarMain_Click);
            // 
            // progressBarText
            // 
            this.progressBarText.AutoSize = true;
            this.progressBarText.Location = new System.Drawing.Point(9, 93);
            this.progressBarText.Name = "progressBarText";
            this.progressBarText.Size = new System.Drawing.Size(84, 13);
            this.progressBarText.TabIndex = 2;
            this.progressBarText.Text = "progressBarText";
            // 
            // getMapInfoButton
            // 
            this.getMapInfoButton.Location = new System.Drawing.Point(12, 12);
            this.getMapInfoButton.Name = "getMapInfoButton";
            this.getMapInfoButton.Size = new System.Drawing.Size(128, 48);
            this.getMapInfoButton.TabIndex = 3;
            this.getMapInfoButton.Text = "Get Map Information";
            this.getMapInfoButton.UseVisualStyleBackColor = true;
            this.getMapInfoButton.Click += new System.EventHandler(this.getMapInfoButton_Click);
            // 
            // getPlayerInfoButton
            // 
            this.getPlayerInfoButton.Location = new System.Drawing.Point(146, 12);
            this.getPlayerInfoButton.Name = "getPlayerInfoButton";
            this.getPlayerInfoButton.Size = new System.Drawing.Size(128, 48);
            this.getPlayerInfoButton.TabIndex = 4;
            this.getPlayerInfoButton.Text = "Get Player Information";
            this.getPlayerInfoButton.UseVisualStyleBackColor = true;
            this.getPlayerInfoButton.Click += new System.EventHandler(this.getPlayerInfoButton_Click);
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 154);
            this.Controls.Add(this.getPlayerInfoButton);
            this.Controls.Add(this.getMapInfoButton);
            this.Controls.Add(this.progressBarText);
            this.Controls.Add(this.progressBarMain);
            this.Controls.Add(this.saveInfoToggle);
            this.Name = "mainScreen";
            this.Text = "Beat Saber Info Tool";
            this.Load += new System.EventHandler(this.mainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox saveInfoToggle;
        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.Windows.Forms.Label progressBarText;
        private System.Windows.Forms.Button getMapInfoButton;
        private System.Windows.Forms.Button getPlayerInfoButton;
    }
}

