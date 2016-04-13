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
            this.buttonSnapshotOutputFrame = new System.Windows.Forms.Button();
            this.tableLayoutPanelForm = new System.Windows.Forms.TableLayoutPanel();
            this.panelCamera = new System.Windows.Forms.Panel();
            this.cameraControl = new Camera_NET.CameraControl();
            this.buttonUnZoom = new System.Windows.Forms.Button();
            this.buttonSaveSnapshot = new System.Windows.Forms.Button();
            this.sdf = new System.Windows.Forms.Label();
            this.pictureBoxScreenshot = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.comboBoxDefaultPictureResolution = new System.Windows.Forms.ComboBox();
            this.labelDefaultPictureResolutionTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEnginePartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.manageEnginesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEnginePartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.newInspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editInspectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cameraSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraOutputSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraControl1 = new Camera_NET.CameraControl();
            this.buttonNewInspection = new System.Windows.Forms.Button();
            this.buttonSaveInspection = new System.Windows.Forms.Button();
            this.tableLayoutPanelForm.SuspendLayout();
            this.panelCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenshot)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSavePicture
            // 
            this.buttonSavePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePicture.Location = new System.Drawing.Point(11, 229);
            this.buttonSavePicture.Name = "buttonSavePicture";
            this.buttonSavePicture.Size = new System.Drawing.Size(146, 26);
            this.buttonSavePicture.TabIndex = 1;
            this.buttonSavePicture.Text = "Capture Picture";
            this.buttonSavePicture.UseVisualStyleBackColor = true;
            this.buttonSavePicture.Click += new System.EventHandler(this.buttonSavePicture_Click);
            // 
            // buttonSnapshotOutputFrame
            // 
            this.buttonSnapshotOutputFrame.Location = new System.Drawing.Point(11, 282);
            this.buttonSnapshotOutputFrame.Name = "buttonSnapshotOutputFrame";
            this.buttonSnapshotOutputFrame.Size = new System.Drawing.Size(146, 26);
            this.buttonSnapshotOutputFrame.TabIndex = 1;
            this.buttonSnapshotOutputFrame.Text = "Preview";
            this.buttonSnapshotOutputFrame.UseVisualStyleBackColor = true;
            this.buttonSnapshotOutputFrame.Click += new System.EventHandler(this.buttonSnapshotOutputFrame_Click);
            // 
            // tableLayoutPanelForm
            // 
            this.tableLayoutPanelForm.ColumnCount = 2;
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelForm.Controls.Add(this.buttonSaveInspection, 0, 10);
            this.tableLayoutPanelForm.Controls.Add(this.panelCamera, 1, 0);
            this.tableLayoutPanelForm.Controls.Add(this.buttonSaveSnapshot, 0, 4);
            this.tableLayoutPanelForm.Controls.Add(this.buttonSnapshotOutputFrame, 0, 3);
            this.tableLayoutPanelForm.Controls.Add(this.sdf, 0, 2);
            this.tableLayoutPanelForm.Controls.Add(this.buttonSavePicture, 0, 1);
            this.tableLayoutPanelForm.Controls.Add(this.pictureBoxScreenshot, 0, 5);
            this.tableLayoutPanelForm.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanelForm.Controls.Add(this.buttonNewInspection, 0, 6);
            this.tableLayoutPanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelForm.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            this.tableLayoutPanelForm.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.tableLayoutPanelForm.RowCount = 7;
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelForm.Size = new System.Drawing.Size(895, 592);
            this.tableLayoutPanelForm.TabIndex = 0;
            this.tableLayoutPanelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelForm_Paint);
            // 
            // panelCamera
            // 
            this.panelCamera.Controls.Add(this.cameraControl);
            this.panelCamera.Controls.Add(this.buttonUnZoom);
            this.panelCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamera.Location = new System.Drawing.Point(163, 11);
            this.panelCamera.Name = "panelCamera";
            this.tableLayoutPanelForm.SetRowSpan(this.panelCamera, 16);
            this.panelCamera.Size = new System.Drawing.Size(721, 594);
            this.panelCamera.TabIndex = 1;
            // 
            // cameraControl
            // 
            this.cameraControl.DirectShowLogFilepath = "";
            this.cameraControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraControl.Location = new System.Drawing.Point(0, 0);
            this.cameraControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cameraControl.Name = "cameraControl";
            this.cameraControl.Size = new System.Drawing.Size(721, 594);
            this.cameraControl.TabIndex = 2;
            this.cameraControl.Load += new System.EventHandler(this.cameraControl_Load);
            this.cameraControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseDoubleClick);
            this.cameraControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseDown);
            this.cameraControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseMove);
            this.cameraControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cameraControl_MouseUp);
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
            // buttonSaveSnapshot
            // 
            this.buttonSaveSnapshot.Location = new System.Drawing.Point(11, 314);
            this.buttonSaveSnapshot.Name = "buttonSaveSnapshot";
            this.buttonSaveSnapshot.Size = new System.Drawing.Size(146, 26);
            this.buttonSaveSnapshot.TabIndex = 1;
            this.buttonSaveSnapshot.Text = "Save Snapshot";
            this.buttonSaveSnapshot.UseVisualStyleBackColor = true;
            this.buttonSaveSnapshot.Click += new System.EventHandler(this.buttonSaveSnapShot_Click);
            // 
            // sdf
            // 
            this.sdf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sdf.AutoSize = true;
            this.sdf.Location = new System.Drawing.Point(11, 266);
            this.sdf.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.sdf.Name = "sdf";
            this.sdf.Size = new System.Drawing.Size(52, 13);
            this.sdf.TabIndex = 5;
            this.sdf.Text = "Snapshot";
            this.sdf.Click += new System.EventHandler(this.sdf_Click);
            // 
            // pictureBoxScreenshot
            // 
            this.pictureBoxScreenshot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxScreenshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxScreenshot.Location = new System.Drawing.Point(12, 397);
            this.pictureBoxScreenshot.Name = "pictureBoxScreenshot";
            this.pictureBoxScreenshot.Size = new System.Drawing.Size(144, 58);
            this.pictureBoxScreenshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxScreenshot.TabIndex = 2;
            this.pictureBoxScreenshot.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(10, 11);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(148, 212);
            this.treeView1.TabIndex = 6;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(895, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewEnginePartToolStripMenuItem,
            this.toolStripSeparator4,
            this.manageEnginesToolStripMenuItem,
            this.viewEnginePartsToolStripMenuItem,
            this.manageSectionsToolStripMenuItem,
            this.toolStripSeparator5,
            this.newInspectionToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.toolStripSeparator2,
            this.editInspectionsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addNewEnginePartToolStripMenuItem
            // 
            this.addNewEnginePartToolStripMenuItem.Name = "addNewEnginePartToolStripMenuItem";
            this.addNewEnginePartToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.addNewEnginePartToolStripMenuItem.Text = "Add New Engine Part";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(199, 6);
            // 
            // manageEnginesToolStripMenuItem
            // 
            this.manageEnginesToolStripMenuItem.Name = "manageEnginesToolStripMenuItem";
            this.manageEnginesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.manageEnginesToolStripMenuItem.Text = "Manage Engines List";
            this.manageEnginesToolStripMenuItem.Click += new System.EventHandler(this.manageEnginesToolStripMenuItem_Click);
            // 
            // viewEnginePartsToolStripMenuItem
            // 
            this.viewEnginePartsToolStripMenuItem.Name = "viewEnginePartsToolStripMenuItem";
            this.viewEnginePartsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.viewEnginePartsToolStripMenuItem.Text = "Manage Parts List";
            this.viewEnginePartsToolStripMenuItem.Click += new System.EventHandler(this.viewEnginePartsToolStripMenuItem_Click);
            // 
            // manageSectionsToolStripMenuItem
            // 
            this.manageSectionsToolStripMenuItem.Name = "manageSectionsToolStripMenuItem";
            this.manageSectionsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.manageSectionsToolStripMenuItem.Text = "Manage Sections List";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(199, 6);
            // 
            // newInspectionToolStripMenuItem
            // 
            this.newInspectionToolStripMenuItem.Name = "newInspectionToolStripMenuItem";
            this.newInspectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newInspectionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.newInspectionToolStripMenuItem.Text = "New Inspection";
            this.newInspectionToolStripMenuItem.Click += new System.EventHandler(this.newInspectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveToolStripMenuItem.Text = "Save Inspections";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.saveToolStripMenuItem1.Text = "Save All Inspections";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
            // 
            // editInspectionsToolStripMenuItem
            // 
            this.editInspectionsToolStripMenuItem.Name = "editInspectionsToolStripMenuItem";
            this.editInspectionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.editInspectionsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.editInspectionsToolStripMenuItem.Text = "Edit Inspections";
            this.editInspectionsToolStripMenuItem.Click += new System.EventHandler(this.editInspectionsToolStripMenuItem_Click);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // cameraToolStripMenuItem
            // 
            this.cameraToolStripMenuItem.Name = "cameraToolStripMenuItem";
            this.cameraToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.cameraToolStripMenuItem.Text = "Camera";
            this.cameraToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // resolutionToolStripMenuItem
            // 
            this.resolutionToolStripMenuItem.Name = "resolutionToolStripMenuItem";
            this.resolutionToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.resolutionToolStripMenuItem.Text = "Resolution";
            this.resolutionToolStripMenuItem.Click += new System.EventHandler(this.resolutionToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(241, 6);
            // 
            // cameraSettingsToolStripMenuItem
            // 
            this.cameraSettingsToolStripMenuItem.Name = "cameraSettingsToolStripMenuItem";
            this.cameraSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.cameraSettingsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.cameraSettingsToolStripMenuItem.Text = "Camera Settings";
            this.cameraSettingsToolStripMenuItem.Click += new System.EventHandler(this.cameraSettingsToolStripMenuItem_Click);
            // 
            // cameraOutputSettingsToolStripMenuItem
            // 
            this.cameraOutputSettingsToolStripMenuItem.Name = "cameraOutputSettingsToolStripMenuItem";
            this.cameraOutputSettingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.cameraOutputSettingsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.cameraOutputSettingsToolStripMenuItem.Text = "Camera Output Settings";
            this.cameraOutputSettingsToolStripMenuItem.Click += new System.EventHandler(this.cameraOutputSettingsToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // cameraControl1
            // 
            this.cameraControl1.DirectShowLogFilepath = "";
            this.cameraControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraControl1.Location = new System.Drawing.Point(0, 0);
            this.cameraControl1.Margin = new System.Windows.Forms.Padding(12);
            this.cameraControl1.Name = "cameraControl1";
            this.cameraControl1.Size = new System.Drawing.Size(1337, 962);
            this.cameraControl1.TabIndex = 3;
            // 
            // buttonNewInspection
            // 
            this.buttonNewInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewInspection.Location = new System.Drawing.Point(11, 512);
            this.buttonNewInspection.Name = "buttonNewInspection";
            this.tableLayoutPanelForm.SetRowSpan(this.buttonNewInspection, 4);
            this.buttonNewInspection.Size = new System.Drawing.Size(145, 31);
            this.buttonNewInspection.TabIndex = 7;
            this.buttonNewInspection.Text = "New Inspection";
            this.buttonNewInspection.UseVisualStyleBackColor = true;
            this.buttonNewInspection.Click += new System.EventHandler(this.buttonNewInspection_Click);
            // 
            // buttonSaveInspection
            // 
            this.buttonSaveInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveInspection.Location = new System.Drawing.Point(11, 551);
            this.buttonSaveInspection.Name = "buttonSaveInspection";
            this.tableLayoutPanelForm.SetRowSpan(this.buttonSaveInspection, 4);
            this.buttonSaveInspection.Size = new System.Drawing.Size(145, 31);
            this.buttonSaveInspection.TabIndex = 8;
            this.buttonSaveInspection.Text = "Save Inspection";
            this.buttonSaveInspection.UseVisualStyleBackColor = true;
            this.buttonSaveInspection.Click += new System.EventHandler(this.buttonSaveInspection_Click);
            // 
            // FormCameraControlTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 616);
            this.Controls.Add(this.tableLayoutPanelForm);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(592, 530);
            this.Name = "FormCameraControlTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormCameraControlTool_Load);
            this.tableLayoutPanelForm.ResumeLayout(false);
            this.tableLayoutPanelForm.PerformLayout();
            this.panelCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScreenshot)).EndInit();
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
        private System.Windows.Forms.Label sdf;
        private System.Windows.Forms.ComboBox comboBoxDefaultPictureResolution;
        private System.Windows.Forms.Label labelDefaultPictureResolutionTitle;
        private Camera_NET.CameraControl cameraControl;
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
        private System.Windows.Forms.ToolStripMenuItem editInspectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cameraOutputSettingsToolStripMenuItem;
        private System.Windows.Forms.Button buttonUnZoom;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem addNewEnginePartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem viewEnginePartsToolStripMenuItem;
        private Camera_NET.CameraControl cameraControl1;
        private System.Windows.Forms.ToolStripMenuItem manageEnginesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Button buttonSaveInspection;
        private System.Windows.Forms.Button buttonNewInspection;
    }
}

