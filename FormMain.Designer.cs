
namespace CameraViewer
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tbCameraInfo = new System.Windows.Forms.TextBox();
            this.tbMessages = new System.Windows.Forms.TextBox();
            this.tbSuccessfulGrabs = new System.Windows.Forms.TextBox();
            this.tbFailedGrabs = new System.Windows.Forms.TextBox();
            this.lbCameraInfo = new System.Windows.Forms.Label();
            this.lbSuccessfulImages = new System.Windows.Forms.Label();
            this.lbFailedImages = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lbMessages = new System.Windows.Forms.Label();
            this.cbUseTestImage = new System.Windows.Forms.CheckBox();
            this.btnOpenCamera = new System.Windows.Forms.Button();
            this.btnStartGrabbing = new System.Windows.Forms.Button();
            this.btnStopGrabbing = new System.Windows.Forms.Button();
            this.pbSnapShot = new System.Windows.Forms.PictureBox();
            this.btnSnapShot = new System.Windows.Forms.Button();
            this.btnSaveSnapshot = new System.Windows.Forms.Button();
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.lbSerialNumber = new System.Windows.Forms.Label();
            this.btnReleaseCamera = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnapShot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCameraInfo
            // 
            this.tbCameraInfo.Location = new System.Drawing.Point(7, 30);
            this.tbCameraInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbCameraInfo.Multiline = true;
            this.tbCameraInfo.Name = "tbCameraInfo";
            this.tbCameraInfo.ReadOnly = true;
            this.tbCameraInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCameraInfo.Size = new System.Drawing.Size(388, 155);
            this.tbCameraInfo.TabIndex = 13;
            // 
            // tbMessages
            // 
            this.tbMessages.Location = new System.Drawing.Point(399, 30);
            this.tbMessages.Margin = new System.Windows.Forms.Padding(2);
            this.tbMessages.Multiline = true;
            this.tbMessages.Name = "tbMessages";
            this.tbMessages.ReadOnly = true;
            this.tbMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMessages.Size = new System.Drawing.Size(762, 155);
            this.tbMessages.TabIndex = 1;
            // 
            // tbSuccessfulGrabs
            // 
            this.tbSuccessfulGrabs.Location = new System.Drawing.Point(7, 457);
            this.tbSuccessfulGrabs.Margin = new System.Windows.Forms.Padding(2);
            this.tbSuccessfulGrabs.Name = "tbSuccessfulGrabs";
            this.tbSuccessfulGrabs.ReadOnly = true;
            this.tbSuccessfulGrabs.Size = new System.Drawing.Size(136, 27);
            this.tbSuccessfulGrabs.TabIndex = 2;
            this.tbSuccessfulGrabs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbFailedGrabs
            // 
            this.tbFailedGrabs.Location = new System.Drawing.Point(7, 508);
            this.tbFailedGrabs.Margin = new System.Windows.Forms.Padding(2);
            this.tbFailedGrabs.Name = "tbFailedGrabs";
            this.tbFailedGrabs.ReadOnly = true;
            this.tbFailedGrabs.Size = new System.Drawing.Size(136, 27);
            this.tbFailedGrabs.TabIndex = 3;
            this.tbFailedGrabs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbCameraInfo
            // 
            this.lbCameraInfo.AutoSize = true;
            this.lbCameraInfo.Location = new System.Drawing.Point(7, 7);
            this.lbCameraInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCameraInfo.Name = "lbCameraInfo";
            this.lbCameraInfo.Size = new System.Drawing.Size(142, 20);
            this.lbCameraInfo.TabIndex = 5;
            this.lbCameraInfo.Text = "Camera Information";
            // 
            // lbSuccessfulImages
            // 
            this.lbSuccessfulImages.AutoSize = true;
            this.lbSuccessfulImages.Location = new System.Drawing.Point(7, 435);
            this.lbSuccessfulImages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSuccessfulImages.Name = "lbSuccessfulImages";
            this.lbSuccessfulImages.Size = new System.Drawing.Size(128, 20);
            this.lbSuccessfulImages.TabIndex = 6;
            this.lbSuccessfulImages.Text = "Successful Images";
            // 
            // lbFailedImages
            // 
            this.lbFailedImages.AutoSize = true;
            this.lbFailedImages.Location = new System.Drawing.Point(7, 486);
            this.lbFailedImages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFailedImages.Name = "lbFailedImages";
            this.lbFailedImages.Size = new System.Drawing.Size(100, 20);
            this.lbFailedImages.TabIndex = 7;
            this.lbFailedImages.Text = "Failed Images";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(171, 208);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(640, 480);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 10;
            this.pbImage.TabStop = false;
            // 
            // lbMessages
            // 
            this.lbMessages.AutoSize = true;
            this.lbMessages.Location = new System.Drawing.Point(399, 7);
            this.lbMessages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(97, 20);
            this.lbMessages.TabIndex = 23;
            this.lbMessages.Text = "Last Message";
            // 
            // cbUseTestImage
            // 
            this.cbUseTestImage.AutoSize = true;
            this.cbUseTestImage.Checked = true;
            this.cbUseTestImage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbUseTestImage.Location = new System.Drawing.Point(7, 539);
            this.cbUseTestImage.Margin = new System.Windows.Forms.Padding(2);
            this.cbUseTestImage.Name = "cbUseTestImage";
            this.cbUseTestImage.Size = new System.Drawing.Size(131, 24);
            this.cbUseTestImage.TabIndex = 24;
            this.cbUseTestImage.Text = "Use Test Image";
            this.cbUseTestImage.UseVisualStyleBackColor = true;
            this.cbUseTestImage.CheckedChanged += new System.EventHandler(this.CbUseTestImage_CheckedChanged);
            // 
            // btnOpenCamera
            // 
            this.btnOpenCamera.Location = new System.Drawing.Point(7, 276);
            this.btnOpenCamera.Name = "btnOpenCamera";
            this.btnOpenCamera.Size = new System.Drawing.Size(136, 29);
            this.btnOpenCamera.TabIndex = 27;
            this.btnOpenCamera.Text = "Open Camera";
            this.btnOpenCamera.UseVisualStyleBackColor = true;
            this.btnOpenCamera.Click += new System.EventHandler(this.BtnOpenCamera_Click);
            // 
            // btnStartGrabbing
            // 
            this.btnStartGrabbing.Enabled = false;
            this.btnStartGrabbing.Location = new System.Drawing.Point(7, 312);
            this.btnStartGrabbing.Name = "btnStartGrabbing";
            this.btnStartGrabbing.Size = new System.Drawing.Size(136, 29);
            this.btnStartGrabbing.TabIndex = 28;
            this.btnStartGrabbing.Text = "Start Grabbing";
            this.btnStartGrabbing.UseVisualStyleBackColor = true;
            this.btnStartGrabbing.Click += new System.EventHandler(this.BtnStartGrabbing_Click);
            // 
            // btnStopGrabbing
            // 
            this.btnStopGrabbing.Enabled = false;
            this.btnStopGrabbing.Location = new System.Drawing.Point(7, 347);
            this.btnStopGrabbing.Name = "btnStopGrabbing";
            this.btnStopGrabbing.Size = new System.Drawing.Size(136, 29);
            this.btnStopGrabbing.TabIndex = 29;
            this.btnStopGrabbing.Text = "Stop Grabbing";
            this.btnStopGrabbing.UseVisualStyleBackColor = true;
            this.btnStopGrabbing.Click += new System.EventHandler(this.BtnStopGrabbing_Click);
            // 
            // pbSnapShot
            // 
            this.pbSnapShot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbSnapShot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSnapShot.Location = new System.Drawing.Point(825, 208);
            this.pbSnapShot.Name = "pbSnapShot";
            this.pbSnapShot.Size = new System.Drawing.Size(320, 240);
            this.pbSnapShot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSnapShot.TabIndex = 30;
            this.pbSnapShot.TabStop = false;
            // 
            // btnSnapShot
            // 
            this.btnSnapShot.Enabled = false;
            this.btnSnapShot.Location = new System.Drawing.Point(825, 454);
            this.btnSnapShot.Name = "btnSnapShot";
            this.btnSnapShot.Size = new System.Drawing.Size(135, 29);
            this.btnSnapShot.TabIndex = 31;
            this.btnSnapShot.Text = "Take Snapshot";
            this.btnSnapShot.UseVisualStyleBackColor = true;
            this.btnSnapShot.Click += new System.EventHandler(this.BtnSnapShot_Click);
            // 
            // btnSaveSnapshot
            // 
            this.btnSaveSnapshot.Enabled = false;
            this.btnSaveSnapshot.Location = new System.Drawing.Point(1010, 454);
            this.btnSaveSnapshot.Name = "btnSaveSnapshot";
            this.btnSaveSnapshot.Size = new System.Drawing.Size(135, 29);
            this.btnSaveSnapshot.TabIndex = 32;
            this.btnSaveSnapshot.Text = "Save Snapshot";
            this.btnSaveSnapshot.UseVisualStyleBackColor = true;
            this.btnSaveSnapshot.Click += new System.EventHandler(this.BtnSaveSnapshot_Click);
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.Location = new System.Drawing.Point(7, 236);
            this.tbSerialNumber.MaxLength = 8;
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.Size = new System.Drawing.Size(136, 27);
            this.tbSerialNumber.TabIndex = 33;
            this.tbSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSerialNumber
            // 
            this.lbSerialNumber.AutoSize = true;
            this.lbSerialNumber.Location = new System.Drawing.Point(7, 208);
            this.lbSerialNumber.Name = "lbSerialNumber";
            this.lbSerialNumber.Size = new System.Drawing.Size(145, 20);
            this.lbSerialNumber.TabIndex = 34;
            this.lbSerialNumber.Text = "Enter Serial Number:";
            // 
            // btnReleaseCamera
            // 
            this.btnReleaseCamera.Enabled = false;
            this.btnReleaseCamera.Location = new System.Drawing.Point(7, 383);
            this.btnReleaseCamera.Name = "btnReleaseCamera";
            this.btnReleaseCamera.Size = new System.Drawing.Size(136, 29);
            this.btnReleaseCamera.TabIndex = 35;
            this.btnReleaseCamera.Text = "Release Camera";
            this.btnReleaseCamera.UseVisualStyleBackColor = true;
            this.btnReleaseCamera.Click += new System.EventHandler(this.BtnReleaseCamera_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo.BackgroundImage")));
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(825, 501);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(320, 187);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 36;
            this.pbLogo.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 705);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnReleaseCamera);
            this.Controls.Add(this.lbSerialNumber);
            this.Controls.Add(this.tbSerialNumber);
            this.Controls.Add(this.btnSaveSnapshot);
            this.Controls.Add(this.btnSnapShot);
            this.Controls.Add(this.pbSnapShot);
            this.Controls.Add(this.btnStopGrabbing);
            this.Controls.Add(this.btnStartGrabbing);
            this.Controls.Add(this.btnOpenCamera);
            this.Controls.Add(this.cbUseTestImage);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.lbFailedImages);
            this.Controls.Add(this.lbSuccessfulImages);
            this.Controls.Add(this.lbCameraInfo);
            this.Controls.Add(this.tbFailedGrabs);
            this.Controls.Add(this.tbSuccessfulGrabs);
            this.Controls.Add(this.tbMessages);
            this.Controls.Add(this.tbCameraInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Camera Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnapShot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCameraInfo;
        private System.Windows.Forms.TextBox tbMessages;
        private System.Windows.Forms.TextBox tbSuccessfulGrabs;
        private System.Windows.Forms.TextBox tbFailedGrabs;
        private System.Windows.Forms.Label lbCameraInfo;
        private System.Windows.Forms.Label lbSuccessfulImages;
        private System.Windows.Forms.Label lbFailedImages;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbMessages;
        private System.Windows.Forms.CheckBox cbUseTestImage;
        private System.Windows.Forms.Button btnOpenCamera;
        private System.Windows.Forms.Button btnStartGrabbing;
        private System.Windows.Forms.Button btnStopGrabbing;
        private System.Windows.Forms.PictureBox pbSnapShot;
        private System.Windows.Forms.Button btnSnapShot;
        private System.Windows.Forms.Button btnSaveSnapshot;
        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.Label lbSerialNumber;
        private System.Windows.Forms.Button btnReleaseCamera;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

