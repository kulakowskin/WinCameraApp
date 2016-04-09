﻿namespace CameraControlTool
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
            this.buttonSnapshotOutputFrame = new System.Windows.Forms.Button();
            this.pictureBoxScreenshot = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelForm = new System.Windows.Forms.TableLayoutPanel();
            this.panelCamera = new System.Windows.Forms.Panel();
            this.buttonUnZoom = new System.Windows.Forms.Button();
            this.cameraControl = new Camera_NET.CameraControl();
            this.buttonClearSnapshotFrame = new System.Windows.Forms.Button();
            this.buttonSaveSnapshot = new System.Windows.Forms.Button();
            this.labelSnapshotTitle = new System.Windows.Forms.Label();
            this.buttonPinOutputSettings = new System.Windows.Forms.Button();
            this.comboBoxDefaultPictureResolution = new System.Windows.Forms.ComboBox();
            this.labelDefaultPictureResolutionTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.viewMetaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraOutputSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenshot)).BeginInit();
            this.tableLayoutPanelForm.SuspendLayout();
            this.panelCamera.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSavePicture
            // 
            this.buttonSavePicture.Location = new System.Drawing.Point(15, 286);
            this.buttonSavePicture.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSavePicture.Name = "buttonSavePicture";
            this.buttonSavePicture.Size = new System.Drawing.Size(259, 32);
            this.buttonSavePicture.TabIndex = 1;
            this.buttonSavePicture.Text = "Capture Picture";
            this.buttonSavePicture.UseVisualStyleBackColor = true;
            this.buttonSavePicture.Click += new System.EventHandler(this.buttonSavePicture_Click);
            // 
            // buttonSnapshotOutputFrame
            // 
            this.buttonSnapshotOutputFrame.Location = new System.Drawing.Point(15, 353);
            this.buttonSnapshotOutputFrame.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSnapshotOutputFrame.Name = "buttonSnapshotOutputFrame";
            this.buttonSnapshotOutputFrame.Size = new System.Drawing.Size(259, 32);
            this.buttonSnapshotOutputFrame.TabIndex = 1;
            this.buttonSnapshotOutputFrame.Text = "Preview";
            this.buttonSnapshotOutputFrame.UseVisualStyleBackColor = true;
            this.buttonSnapshotOutputFrame.Click += new System.EventHandler(this.buttonSnapshotOutputFrame_Click);
            // 
            // pictureBoxScreenshot
            // 
            this.pictureBoxScreenshot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxScreenshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxScreenshot.Location = new System.Drawing.Point(25, 433);
            this.pictureBoxScreenshot.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxScreenshot.Name = "pictureBoxScreenshot";
            this.pictureBoxScreenshot.Size = new System.Drawing.Size(239, 147);
            this.pictureBoxScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScreenshot.TabIndex = 2;
            this.pictureBoxScreenshot.TabStop = false;
            // 
            // tableLayoutPanelForm
            // 
            this.tableLayoutPanelForm.ColumnCount = 2;
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelForm.Controls.Add(this.panelCamera, 1, 0);
            this.tableLayoutPanelForm.Controls.Add(this.buttonClearSnapshotFrame, 0, 15);
            this.tableLayoutPanelForm.Controls.Add(this.pictureBoxScreenshot, 0, 13);
            this.tableLayoutPanelForm.Controls.Add(this.buttonSaveSnapshot, 0, 12);
            this.tableLayoutPanelForm.Controls.Add(this.buttonSnapshotOutputFrame, 0, 11);
            this.tableLayoutPanelForm.Controls.Add(this.labelSnapshotTitle, 0, 10);
            this.tableLayoutPanelForm.Controls.Add(this.buttonSavePicture, 0, 9);
            this.tableLayoutPanelForm.Controls.Add(this.buttonPinOutputSettings, 0, 8);
            this.tableLayoutPanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelForm.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanelForm.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            this.tableLayoutPanelForm.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
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
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.Size = new System.Drawing.Size(1123, 633);
            this.tableLayoutPanelForm.TabIndex = 0;
            this.tableLayoutPanelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelForm_Paint);
            // 
            // panelCamera
            // 
            this.panelCamera.Controls.Add(this.buttonUnZoom);
            this.panelCamera.Controls.Add(this.cameraControl);
            this.panelCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamera.Location = new System.Drawing.Point(282, 14);
            this.panelCamera.Margin = new System.Windows.Forms.Padding(4);
            this.panelCamera.Name = "panelCamera";
            this.tableLayoutPanelForm.SetRowSpan(this.panelCamera, 16);
            this.panelCamera.Size = new System.Drawing.Size(826, 605);
            this.panelCamera.TabIndex = 1;
            // 
            // buttonUnZoom
            // 
            this.buttonUnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUnZoom.Image = ((System.Drawing.Image)(resources.GetObject("buttonUnZoom.Image")));
            this.buttonUnZoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUnZoom.Location = new System.Drawing.Point(17, 12);
            this.buttonUnZoom.Margin = new System.Windows.Forms.Padding(0);
            this.buttonUnZoom.Name = "buttonUnZoom";
            this.buttonUnZoom.Size = new System.Drawing.Size(151, 32);
            this.buttonUnZoom.TabIndex = 1;
            this.buttonUnZoom.Text = "Reset zoom";
            this.buttonUnZoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUnZoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUnZoom.UseVisualStyleBackColor = true;
            this.buttonUnZoom.Visible = false;
            this.buttonUnZoom.Click += new System.EventHandler(this.buttonUnZoom_Click);
            // 
            // cameraControl
            // 
            this.cameraControl.DirectShowLogFilepath = "";
            this.cameraControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraControl.Location = new System.Drawing.Point(0, 0);
            this.cameraControl.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cameraControl.Name = "cameraControl";
            this.cameraControl.Size = new System.Drawing.Size(826, 605);
            this.cameraControl.TabIndex = 2;
            this.cameraControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseDoubleClick);
            this.cameraControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseDown);
            this.cameraControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseMove);
            this.cameraControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseUp);
            // 
            // buttonClearSnapshotFrame
            // 
            this.buttonClearSnapshotFrame.Location = new System.Drawing.Point(15, 618);
            this.buttonClearSnapshotFrame.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearSnapshotFrame.Name = "buttonClearSnapshotFrame";
            this.buttonClearSnapshotFrame.Size = new System.Drawing.Size(259, 1);
            this.buttonClearSnapshotFrame.TabIndex = 1;
            this.buttonClearSnapshotFrame.Text = "Clear preview";
            this.buttonClearSnapshotFrame.UseVisualStyleBackColor = true;
            this.buttonClearSnapshotFrame.Click += new System.EventHandler(this.buttonClearSnapshotFrame_Click);
            // 
            // buttonSaveSnapshot
            // 
            this.buttonSaveSnapshot.Location = new System.Drawing.Point(15, 393);
            this.buttonSaveSnapshot.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveSnapshot.Name = "buttonSaveSnapshot";
            this.buttonSaveSnapshot.Size = new System.Drawing.Size(259, 32);
            this.buttonSaveSnapshot.TabIndex = 1;
            this.buttonSaveSnapshot.Text = "Save Snapshot";
            this.buttonSaveSnapshot.UseVisualStyleBackColor = true;
            this.buttonSaveSnapshot.Click += new System.EventHandler(this.buttonSaveSnapShot_Click);
            // 
            // labelSnapshotTitle
            // 
            this.labelSnapshotTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSnapshotTitle.AutoSize = true;
            this.labelSnapshotTitle.Location = new System.Drawing.Point(15, 332);
            this.labelSnapshotTitle.Margin = new System.Windows.Forms.Padding(4, 10, 4, 0);
            this.labelSnapshotTitle.Name = "labelSnapshotTitle";
            this.labelSnapshotTitle.Size = new System.Drawing.Size(79, 17);
            this.labelSnapshotTitle.TabIndex = 5;
            this.labelSnapshotTitle.Text = "Snapshots:";
            // 
            // buttonPinOutputSettings
            // 
            this.buttonPinOutputSettings.Location = new System.Drawing.Point(15, 246);
            this.buttonPinOutputSettings.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPinOutputSettings.Name = "buttonPinOutputSettings";
            this.buttonPinOutputSettings.Size = new System.Drawing.Size(259, 32);
            this.buttonPinOutputSettings.TabIndex = 9;
            this.buttonPinOutputSettings.Text = "Camera Output settings";
            this.buttonPinOutputSettings.UseVisualStyleBackColor = true;
            this.buttonPinOutputSettings.Click += new System.EventHandler(this.buttonPinOutputSettings_Click);
            // 
            // comboBoxDefaultPictureResolution
            // 
            this.comboBoxDefaultPictureResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDefaultPictureResolution.FormattingEnabled = true;
            this.comboBoxDefaultPictureResolution.Location = new System.Drawing.Point(11, 125);
            this.comboBoxDefaultPictureResolution.Name = "comboBoxDefaultPictureResolution";
            this.comboBoxDefaultPictureResolution.Size = new System.Drawing.Size(194, 24);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1123, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newInspectionToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.toolStripSeparator2,
            this.viewMetaDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newInspectionToolStripMenuItem
            // 
            this.newInspectionToolStripMenuItem.Name = "newInspectionToolStripMenuItem";
            this.newInspectionToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.newInspectionToolStripMenuItem.Text = "New Inspection";
            this.newInspectionToolStripMenuItem.Click += new System.EventHandler(this.newInspectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.saveToolStripMenuItem.Text = "Save Inspections";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(215, 26);
            this.saveToolStripMenuItem1.Text = "Save All Inspections";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(212, 6);
            // 
            // viewMetaDataToolStripMenuItem
            // 
            this.viewMetaDataToolStripMenuItem.Name = "viewMetaDataToolStripMenuItem";
            this.viewMetaDataToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.viewMetaDataToolStripMenuItem.Text = "View MetaData";
            this.viewMetaDataToolStripMenuItem.Click += new System.EventHandler(this.viewMetaDataToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cameraToolStripMenuItem,
            this.resolutionToolStripMenuItem,
            this.toolStripSeparator3,
            this.cameraSettingsToolStripMenuItem,
            this.cameraOutputSettingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.cameraToolStripMenuItem.Text = "Camera";
            this.cameraToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // resolutionToolStripMenuItem
            // 
            this.resolutionToolStripMenuItem.Name = "resolutionToolStripMenuItem";
            this.resolutionToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.resolutionToolStripMenuItem.Text = "Resolution";
            this.resolutionToolStripMenuItem.Click += new System.EventHandler(this.resolutionToolStripMenuItem_Click);
            // 
            // cameraSettingsToolStripMenuItem
            // 
            this.cameraSettingsToolStripMenuItem.Name = "cameraSettingsToolStripMenuItem";
            this.cameraSettingsToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.cameraSettingsToolStripMenuItem.Text = "Camera Settings";
            this.cameraSettingsToolStripMenuItem.Click += new System.EventHandler(this.cameraSettingsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // cameraOutputSettingsToolStripMenuItem
            // 
            this.cameraOutputSettingsToolStripMenuItem.Name = "cameraOutputSettingsToolStripMenuItem";
            this.cameraOutputSettingsToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.cameraOutputSettingsToolStripMenuItem.Text = "Camera Output Settings";
            this.cameraOutputSettingsToolStripMenuItem.Click += new System.EventHandler(this.cameraOutputSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(239, 6);
            // 
            // FormCameraControlTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 661);
            this.Controls.Add(this.tableLayoutPanelForm);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(787, 656);
            this.Name = "FormCameraControlTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormCameraControlTool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenshot)).EndInit();
            this.tableLayoutPanelForm.ResumeLayout(false);
            this.tableLayoutPanelForm.PerformLayout();
            this.panelCamera.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSavePicture;
        private System.Windows.Forms.Button buttonSnapshotOutputFrame;
        private System.Windows.Forms.PictureBox pictureBoxScreenshot;
        private System.Windows.Forms.Button buttonSaveSnapshot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelForm;
        private System.Windows.Forms.Panel panelCamera;
        private System.Windows.Forms.Label labelSnapshotTitle;
        private System.Windows.Forms.ComboBox comboBoxDefaultPictureResolution;
        private System.Windows.Forms.Label labelDefaultPictureResolutionTitle;
        private System.Windows.Forms.Button buttonClearSnapshotFrame;
        private Camera_NET.CameraControl cameraControl;
        private System.Windows.Forms.Button buttonPinOutputSettings;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newInspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem resolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem viewMetaDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.Button buttonUnZoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cameraOutputSettingsToolStripMenuItem;
    }
}

