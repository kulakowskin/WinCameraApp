namespace CameraControlTool
{
    partial class FormCameraControlTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCameraControlTool));
            this.buttonSavePicture = new System.Windows.Forms.Button();
            this.buttonRefreshCameras = new System.Windows.Forms.Button();
            this.buttonSnapshotOutputFrame = new System.Windows.Forms.Button();
            this.buttonUnZoom = new System.Windows.Forms.Button();
            this.pictureBoxScreenshot = new System.Windows.Forms.PictureBox();
            this.labelCameraTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanelForm = new System.Windows.Forms.TableLayoutPanel();
            this.panelCamera = new System.Windows.Forms.Panel();
            this.cameraControl = new Camera_NET.CameraControl();
            this.buttonNewInspection = new System.Windows.Forms.Button();
            this.buttonClearSnapshotFrame = new System.Windows.Forms.Button();
            this.buttonSaveSnapshot = new System.Windows.Forms.Button();
            this.labelSnapshotTitle = new System.Windows.Forms.Label();
            this.buttonPinOutputSettings = new System.Windows.Forms.Button();
            this.buttonCameraSettings = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxResolutionList = new System.Windows.Forms.ComboBox();
            this.labelResolutionTitle = new System.Windows.Forms.Label();
            this.comboBoxCameraList = new System.Windows.Forms.ComboBox();
            this.comboBoxDefaultPictureResolution = new System.Windows.Forms.ComboBox();
            this.labelDefaultPictureResolutionTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenshot)).BeginInit();
            this.tableLayoutPanelForm.SuspendLayout();
            this.panelCamera.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSavePicture
            // 
            this.buttonSavePicture.Location = new System.Drawing.Point(11, 256);
            this.buttonSavePicture.Name = "buttonSavePicture";
            this.buttonSavePicture.Size = new System.Drawing.Size(194, 26);
            this.buttonSavePicture.TabIndex = 1;
            this.buttonSavePicture.Text = "Capture Picture";
            this.buttonSavePicture.UseVisualStyleBackColor = true;
            this.buttonSavePicture.Click += new System.EventHandler(this.buttonSavePicture_Click);
            // 
            // buttonRefreshCameras
            // 
            this.buttonRefreshCameras.Location = new System.Drawing.Point(11, 11);
            this.buttonRefreshCameras.Name = "buttonRefreshCameras";
            this.buttonRefreshCameras.Size = new System.Drawing.Size(194, 28);
            this.buttonRefreshCameras.TabIndex = 1;
            this.buttonRefreshCameras.Text = "Refresh Cameras";
            this.buttonRefreshCameras.UseVisualStyleBackColor = true;
            this.buttonRefreshCameras.Click += new System.EventHandler(this.buttonRefreshCameras_Click);
            // 
            // buttonSnapshotOutputFrame
            // 
            this.buttonSnapshotOutputFrame.Location = new System.Drawing.Point(11, 309);
            this.buttonSnapshotOutputFrame.Name = "buttonSnapshotOutputFrame";
            this.buttonSnapshotOutputFrame.Size = new System.Drawing.Size(194, 26);
            this.buttonSnapshotOutputFrame.TabIndex = 1;
            this.buttonSnapshotOutputFrame.Text = "Preview";
            this.buttonSnapshotOutputFrame.UseVisualStyleBackColor = true;
            this.buttonSnapshotOutputFrame.Click += new System.EventHandler(this.buttonSnapshotOutputFrame_Click);
            // 
            // buttonUnZoom
            // 
            this.buttonUnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnZoom.Image = ((System.Drawing.Image)(resources.GetObject("buttonUnZoom.Image")));
            this.buttonUnZoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUnZoom.Location = new System.Drawing.Point(13, 10);
            this.buttonUnZoom.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUnZoom.Name = "buttonUnZoom";
            this.buttonUnZoom.Size = new System.Drawing.Size(113, 26);
            this.buttonUnZoom.TabIndex = 1;
            this.buttonUnZoom.Text = "Reset zoom";
            this.buttonUnZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUnZoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUnZoom.UseVisualStyleBackColor = true;
            this.buttonUnZoom.Visible = false;
            this.buttonUnZoom.Click += new System.EventHandler(this.buttonUnZoom_Click);
            // 
            // pictureBoxScreenshot
            // 
            this.pictureBoxScreenshot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxScreenshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxScreenshot.Location = new System.Drawing.Point(18, 373);
            this.pictureBoxScreenshot.Name = "pictureBoxScreenshot";
            this.pictureBoxScreenshot.Size = new System.Drawing.Size(180, 120);
            this.pictureBoxScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScreenshot.TabIndex = 2;
            this.pictureBoxScreenshot.TabStop = false;
            // 
            // labelCameraTitle
            // 
            this.labelCameraTitle.AutoSize = true;
            this.labelCameraTitle.Location = new System.Drawing.Point(11, 50);
            this.labelCameraTitle.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelCameraTitle.Name = "labelCameraTitle";
            this.labelCameraTitle.Size = new System.Drawing.Size(91, 13);
            this.labelCameraTitle.TabIndex = 4;
            this.labelCameraTitle.Text = "Camera selection:";
            // 
            // tableLayoutPanelForm
            // 
            this.tableLayoutPanelForm.ColumnCount = 2;
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelForm.Controls.Add(this.buttonRefreshCameras, 0, 0);
            this.tableLayoutPanelForm.Controls.Add(this.panelCamera, 1, 0);
            this.tableLayoutPanelForm.Controls.Add(this.buttonNewInspection, 0, 5);
            this.tableLayoutPanelForm.Controls.Add(this.buttonClearSnapshotFrame, 0, 15);
            this.tableLayoutPanelForm.Controls.Add(this.pictureBoxScreenshot, 0, 13);
            this.tableLayoutPanelForm.Controls.Add(this.buttonSaveSnapshot, 0, 12);
            this.tableLayoutPanelForm.Controls.Add(this.buttonSnapshotOutputFrame, 0, 11);
            this.tableLayoutPanelForm.Controls.Add(this.labelSnapshotTitle, 0, 10);
            this.tableLayoutPanelForm.Controls.Add(this.buttonSavePicture, 0, 9);
            this.tableLayoutPanelForm.Controls.Add(this.buttonPinOutputSettings, 0, 8);
            this.tableLayoutPanelForm.Controls.Add(this.buttonCameraSettings, 0, 7);
            this.tableLayoutPanelForm.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanelForm.Controls.Add(this.comboBoxResolutionList, 0, 4);
            this.tableLayoutPanelForm.Controls.Add(this.labelResolutionTitle, 0, 3);
            this.tableLayoutPanelForm.Controls.Add(this.comboBoxCameraList, 0, 2);
            this.tableLayoutPanelForm.Controls.Add(this.labelCameraTitle, 0, 1);
            this.tableLayoutPanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            this.tableLayoutPanelForm.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanelForm.RowCount = 16;
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.Size = new System.Drawing.Size(842, 537);
            this.tableLayoutPanelForm.TabIndex = 0;
            this.tableLayoutPanelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelForm_Paint);
            // 
            // panelCamera
            // 
            this.panelCamera.Controls.Add(this.buttonUnZoom);
            this.panelCamera.Controls.Add(this.cameraControl);
            this.panelCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamera.Location = new System.Drawing.Point(211, 11);
            this.panelCamera.Name = "panelCamera";
            this.tableLayoutPanelForm.SetRowSpan(this.panelCamera, 16);
            this.panelCamera.Size = new System.Drawing.Size(620, 515);
            this.panelCamera.TabIndex = 1;
            // 
            // cameraControl
            // 
            this.cameraControl.DirectShowLogFilepath = "";
            this.cameraControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraControl.Location = new System.Drawing.Point(0, 0);
            this.cameraControl.Margin = new System.Windows.Forms.Padding(6);
            this.cameraControl.Name = "cameraControl";
            this.cameraControl.Size = new System.Drawing.Size(620, 515);
            this.cameraControl.TabIndex = 2;
            this.cameraControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseDoubleClick);
            this.cameraControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseDown);
            this.cameraControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseMove);
            this.cameraControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseUp);
            // 
            // buttonNewInspection
            // 
            this.buttonNewInspection.Location = new System.Drawing.Point(11, 141);
            this.buttonNewInspection.Name = "buttonNewInspection";
            this.buttonNewInspection.Size = new System.Drawing.Size(194, 24);
            this.buttonNewInspection.TabIndex = 1;
            this.buttonNewInspection.Text = "New Inspection";
            this.buttonNewInspection.UseVisualStyleBackColor = true;
            this.buttonNewInspection.Click += new System.EventHandler(this.buttonNewInspection_Click);
            // 
            // buttonClearSnapshotFrame
            // 
            this.buttonClearSnapshotFrame.Location = new System.Drawing.Point(11, 499);
            this.buttonClearSnapshotFrame.Name = "buttonClearSnapshotFrame";
            this.buttonClearSnapshotFrame.Size = new System.Drawing.Size(194, 24);
            this.buttonClearSnapshotFrame.TabIndex = 1;
            this.buttonClearSnapshotFrame.Text = "Clear preview";
            this.buttonClearSnapshotFrame.UseVisualStyleBackColor = true;
            this.buttonClearSnapshotFrame.Click += new System.EventHandler(this.buttonClearSnapshotFrame_Click);
            // 
            // buttonSaveSnapshot
            // 
            this.buttonSaveSnapshot.Location = new System.Drawing.Point(11, 341);
            this.buttonSaveSnapshot.Name = "buttonSaveSnapshot";
            this.buttonSaveSnapshot.Size = new System.Drawing.Size(194, 26);
            this.buttonSaveSnapshot.TabIndex = 1;
            this.buttonSaveSnapshot.Text = "Save Snapshot";
            this.buttonSaveSnapshot.UseVisualStyleBackColor = true;
            this.buttonSaveSnapshot.Click += new System.EventHandler(this.buttonSaveSnapShot_Click);
            // 
            // labelSnapshotTitle
            // 
            this.labelSnapshotTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSnapshotTitle.AutoSize = true;
            this.labelSnapshotTitle.Location = new System.Drawing.Point(11, 293);
            this.labelSnapshotTitle.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelSnapshotTitle.Name = "labelSnapshotTitle";
            this.labelSnapshotTitle.Size = new System.Drawing.Size(60, 13);
            this.labelSnapshotTitle.TabIndex = 5;
            this.labelSnapshotTitle.Text = "Snapshots:";
            // 
            // buttonPinOutputSettings
            // 
            this.buttonPinOutputSettings.Location = new System.Drawing.Point(11, 224);
            this.buttonPinOutputSettings.Name = "buttonPinOutputSettings";
            this.buttonPinOutputSettings.Size = new System.Drawing.Size(194, 26);
            this.buttonPinOutputSettings.TabIndex = 9;
            this.buttonPinOutputSettings.Text = "Camera Output settings";
            this.buttonPinOutputSettings.UseVisualStyleBackColor = true;
            this.buttonPinOutputSettings.Click += new System.EventHandler(this.buttonPinOutputSettings_Click);
            // 
            // buttonCameraSettings
            // 
            this.buttonCameraSettings.Location = new System.Drawing.Point(11, 192);
            this.buttonCameraSettings.Name = "buttonCameraSettings";
            this.buttonCameraSettings.Size = new System.Drawing.Size(194, 26);
            this.buttonCameraSettings.TabIndex = 1;
            this.buttonCameraSettings.Text = "Camera settings";
            this.buttonCameraSettings.UseVisualStyleBackColor = true;
            this.buttonCameraSettings.Click += new System.EventHandler(this.buttonCameraSettings_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 176);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Controls:";
            // 
            // comboBoxResolutionList
            // 
            this.comboBoxResolutionList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResolutionList.FormattingEnabled = true;
            this.comboBoxResolutionList.Location = new System.Drawing.Point(11, 114);
            this.comboBoxResolutionList.Name = "comboBoxResolutionList";
            this.comboBoxResolutionList.Size = new System.Drawing.Size(194, 21);
            this.comboBoxResolutionList.TabIndex = 6;
            this.comboBoxResolutionList.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolutionList_SelectedIndexChanged);
            // 
            // labelResolutionTitle
            // 
            this.labelResolutionTitle.AutoSize = true;
            this.labelResolutionTitle.Location = new System.Drawing.Point(11, 98);
            this.labelResolutionTitle.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelResolutionTitle.Name = "labelResolutionTitle";
            this.labelResolutionTitle.Size = new System.Drawing.Size(105, 13);
            this.labelResolutionTitle.TabIndex = 7;
            this.labelResolutionTitle.Text = "Resolution selection:";
            // 
            // comboBoxCameraList
            // 
            this.comboBoxCameraList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCameraList.FormattingEnabled = true;
            this.comboBoxCameraList.Location = new System.Drawing.Point(11, 66);
            this.comboBoxCameraList.Name = "comboBoxCameraList";
            this.comboBoxCameraList.Size = new System.Drawing.Size(194, 21);
            this.comboBoxCameraList.TabIndex = 3;
            this.comboBoxCameraList.SelectedIndexChanged += new System.EventHandler(this.comboBoxCameraList_SelectedIndexChanged);
            // 
            // comboBoxDefaultPictureResolution
            // 
            this.comboBoxDefaultPictureResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDefaultPictureResolution.FormattingEnabled = true;
            this.comboBoxDefaultPictureResolution.Location = new System.Drawing.Point(11, 125);
            this.comboBoxDefaultPictureResolution.Name = "comboBoxDefaultPictureResolution";
            this.comboBoxDefaultPictureResolution.Size = new System.Drawing.Size(194, 21);
            this.comboBoxDefaultPictureResolution.TabIndex = 0;
            this.comboBoxDefaultPictureResolution.SelectedIndexChanged += new System.EventHandler(this.comboBoxDefaultPictureResolution_SelectedIndexChanged);
            // 
            // labelDefaultPictureResolutionTitle
            // 
            this.labelDefaultPictureResolutionTitle.AutoSize = true;
            this.labelDefaultPictureResolutionTitle.Location = new System.Drawing.Point(11, 112);
            this.labelDefaultPictureResolutionTitle.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelDefaultPictureResolutionTitle.Name = "labelDefaultPictureResolutionTitle";
            this.labelDefaultPictureResolutionTitle.Size = new System.Drawing.Size(105, 13);
            this.labelDefaultPictureResolutionTitle.TabIndex = 10;
            this.labelDefaultPictureResolutionTitle.Text = "Default Capture Resolution";
            // 
            // FormCameraControlTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 537);
            this.Controls.Add(this.tableLayoutPanelForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(595, 542);
            this.Name = "FormCameraControlTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormCameraControlTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenshot)).EndInit();
            this.tableLayoutPanelForm.ResumeLayout(false);
            this.tableLayoutPanelForm.PerformLayout();
            this.panelCamera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Button buttonMixerOnOff;
        private System.Windows.Forms.Button buttonRefreshCameras;
        private System.Windows.Forms.Button buttonNewInspection;
        private System.Windows.Forms.Button buttonSavePicture;
        private System.Windows.Forms.Button buttonSnapshotOutputFrame;
        private System.Windows.Forms.PictureBox pictureBoxScreenshot;
        private System.Windows.Forms.Button buttonSaveSnapshot;
        //private System.Windows.Forms.Button buttonSnapshotNextSourceFrame;
        private System.Windows.Forms.Button buttonUnZoom;
        //private System.Windows.Forms.Button buttonCrossbarSettings;
        //private System.Windows.Forms.Button buttonTVMode;
        private System.Windows.Forms.Label labelCameraTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelForm;
        private System.Windows.Forms.Panel panelCamera;
        private System.Windows.Forms.ComboBox comboBoxCameraList;
        private System.Windows.Forms.Label labelSnapshotTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxResolutionList;
        private System.Windows.Forms.ComboBox comboBoxDefaultPictureResolution;
        private System.Windows.Forms.Label labelResolutionTitle;
        private System.Windows.Forms.Label labelDefaultPictureResolutionTitle;
        private System.Windows.Forms.Button buttonClearSnapshotFrame;
        private System.Windows.Forms.Button buttonCameraSettings;
        private Camera_NET.CameraControl cameraControl;
        private System.Windows.Forms.Button buttonPinOutputSettings;
    }
}

