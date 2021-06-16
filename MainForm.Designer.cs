namespace osu_keypad_server {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboBoxIpAddress = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKeyA = new System.Windows.Forms.TextBox();
            this.textBoxKeyB = new System.Windows.Forms.TextBox();
            this.buttonStartServer = new System.Windows.Forms.Button();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.buttonLoadConfig = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // comboBoxIpAddress
            // 
            this.comboBoxIpAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxIpAddress.FormattingEnabled = true;
            this.comboBoxIpAddress.Location = new System.Drawing.Point(12, 38);
            this.comboBoxIpAddress.Name = "comboBoxIpAddress";
            this.comboBoxIpAddress.Size = new System.Drawing.Size(241, 21);
            this.comboBoxIpAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select ip address of your pc to host the server on,\r\notherwise type it manually.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select and click the keys you are using in osu.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxKeyA
            // 
            this.textBoxKeyA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKeyA.Location = new System.Drawing.Point(15, 78);
            this.textBoxKeyA.Name = "textBoxKeyA";
            this.textBoxKeyA.Size = new System.Drawing.Size(108, 20);
            this.textBoxKeyA.TabIndex = 3;
            this.textBoxKeyA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyA_KeyDown);
            // 
            // textBoxKeyB
            // 
            this.textBoxKeyB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxKeyB.Location = new System.Drawing.Point(145, 78);
            this.textBoxKeyB.Name = "textBoxKeyB";
            this.textBoxKeyB.Size = new System.Drawing.Size(108, 20);
            this.textBoxKeyB.TabIndex = 4;
            this.textBoxKeyB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxKeyB_KeyDown);
            // 
            // buttonStartServer
            // 
            this.buttonStartServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(59)))));
            this.buttonStartServer.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonStartServer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartServer.ForeColor = System.Drawing.Color.White;
            this.buttonStartServer.Location = new System.Drawing.Point(12, 104);
            this.buttonStartServer.Name = "buttonStartServer";
            this.buttonStartServer.Size = new System.Drawing.Size(241, 49);
            this.buttonStartServer.TabIndex = 5;
            this.buttonStartServer.Text = "Start server";
            this.buttonStartServer.UseVisualStyleBackColor = false;
            this.buttonStartServer.Click += new System.EventHandler(this.buttonStartServer_Click);
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(72)))), ((int)(((byte)(91)))));
            this.buttonSaveConfig.CausesValidation = false;
            this.buttonSaveConfig.FlatAppearance.BorderSize = 0;
            this.buttonSaveConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveConfig.ForeColor = System.Drawing.Color.White;
            this.buttonSaveConfig.Location = new System.Drawing.Point(12, 159);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(241, 23);
            this.buttonSaveConfig.TabIndex = 7;
            this.buttonSaveConfig.Text = "Save configuration";
            this.buttonSaveConfig.UseVisualStyleBackColor = false;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // buttonLoadConfig
            // 
            this.buttonLoadConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(71)))), ((int)(((byte)(91)))));
            this.buttonLoadConfig.CausesValidation = false;
            this.buttonLoadConfig.FlatAppearance.BorderSize = 0;
            this.buttonLoadConfig.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLoadConfig.ForeColor = System.Drawing.Color.White;
            this.buttonLoadConfig.Location = new System.Drawing.Point(12, 188);
            this.buttonLoadConfig.Name = "buttonLoadConfig";
            this.buttonLoadConfig.Size = new System.Drawing.Size(241, 23);
            this.buttonLoadConfig.TabIndex = 8;
            this.buttonLoadConfig.Text = "Load configuration";
            this.buttonLoadConfig.UseVisualStyleBackColor = false;
            this.buttonLoadConfig.Click += new System.EventHandler(this.buttonLoadConfig_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(97)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(7)))), ((int)(((byte)(40)))));
            this.linkLabel1.Location = new System.Drawing.Point(9, 227);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(143, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "This app was made by procq";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(7)))), ((int)(((byte)(40)))));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(65)))), ((int)(((byte)(97)))));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(7)))), ((int)(((byte)(40)))));
            this.linkLabel2.Location = new System.Drawing.Point(191, 227);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(55, 13);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "osu!profile";
            this.linkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(7)))), ((int)(((byte)(40)))));
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(119)))), ((int)(((byte)(147)))));
            this.ClientSize = new System.Drawing.Size(265, 249);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonLoadConfig);
            this.Controls.Add(this.buttonSaveConfig);
            this.Controls.Add(this.buttonStartServer);
            this.Controls.Add(this.textBoxKeyB);
            this.Controls.Add(this.textBoxKeyA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxIpAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "osu!keypad-server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIpAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKeyA;
        private System.Windows.Forms.TextBox textBoxKeyB;
        private System.Windows.Forms.Button buttonStartServer;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.Button buttonLoadConfig;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

