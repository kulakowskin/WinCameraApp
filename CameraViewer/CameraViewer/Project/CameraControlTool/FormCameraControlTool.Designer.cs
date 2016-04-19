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
            this.sectionLabel = new System.Windows.Forms.TextBox();
            this.engineLabel = new System.Windows.Forms.TextBox();
            this.comboBoxEngine = new System.Windows.Forms.ComboBox();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.comboBoxPart = new System.Windows.Forms.ComboBox();
            this.buttonSavePicture = new System.Windows.Forms.Button();
            this.buttonNewInspection = new System.Windows.Forms.Button();
            this.buttonSaveInspection = new System.Windows.Forms.Button();
            this.panelCamera = new System.Windows.Forms.Panel();
            this.cameraControl = new Camera_NET.CameraControl();
            this.buttonUnZoom = new System.Windows.Forms.Button();
            this.tableLayoutPanelForm = new System.Windows.Forms.TableLayoutPanel();
            this.partLabel = new System.Windows.Forms.TextBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.notesLabel = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panelCamera.SuspendLayout();
            this.tableLayoutPanelForm.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
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
            // sectionLabel
            // 
            this.sectionLabel.BackColor = System.Drawing.SystemColors.Window;
            this.sectionLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sectionLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.sectionLabel.Enabled = false;
            this.sectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionLabel.Location = new System.Drawing.Point(11, 63);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(100, 16);
            this.sectionLabel.TabIndex = 13;
            this.sectionLabel.Text = "Section:";
            // 
            // engineLabel
            // 
            this.engineLabel.BackColor = System.Drawing.SystemColors.Window;
            this.engineLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.engineLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.engineLabel.Enabled = false;
            this.engineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineLabel.Location = new System.Drawing.Point(11, 11);
            this.engineLabel.Name = "engineLabel";
            this.engineLabel.Size = new System.Drawing.Size(100, 16);
            this.engineLabel.TabIndex = 12;
            this.engineLabel.Text = "Engine:";
            // 
            // comboBoxEngine
            // 
            this.comboBoxEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEngine.FormattingEnabled = true;
            this.comboBoxEngine.Location = new System.Drawing.Point(11, 33);
            this.comboBoxEngine.MaxDropDownItems = 50;
            this.comboBoxEngine.Name = "comboBoxEngine";
            this.comboBoxEngine.Size = new System.Drawing.Size(161, 24);
            this.comboBoxEngine.TabIndex = 9;
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(11, 85);
            this.comboBoxSection.MaxDropDownItems = 80;
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSection.TabIndex = 10;
            // 
            // comboBoxPart
            // 
            this.comboBoxPart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPart.FormattingEnabled = true;
            this.comboBoxPart.ItemHeight = 16;
            this.comboBoxPart.Location = new System.Drawing.Point(11, 134);
            this.comboBoxPart.MaxDropDownItems = 100;
            this.comboBoxPart.Name = "comboBoxPart";
            this.comboBoxPart.Size = new System.Drawing.Size(161, 24);
            this.comboBoxPart.TabIndex = 11;
            // 
            // buttonSavePicture
            // 
            this.buttonSavePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSavePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSavePicture.Location = new System.Drawing.Point(18, 398);
            this.buttonSavePicture.Name = "buttonSavePicture";
            this.buttonSavePicture.Size = new System.Drawing.Size(146, 36);
            this.buttonSavePicture.TabIndex = 1;
            this.buttonSavePicture.Text = "Capture Picture";
            this.buttonSavePicture.UseVisualStyleBackColor = true;
            this.buttonSavePicture.Click += new System.EventHandler(this.buttonSavePicture_Click);
            // 
            // buttonNewInspection
            // 
            this.buttonNewInspection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNewInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewInspection.Location = new System.Drawing.Point(19, 300);
            this.buttonNewInspection.Name = "buttonNewInspection";
            this.buttonNewInspection.Size = new System.Drawing.Size(145, 35);
            this.buttonNewInspection.TabIndex = 7;
            this.buttonNewInspection.Text = "New Inspection";
            this.buttonNewInspection.UseVisualStyleBackColor = true;
            this.buttonNewInspection.Click += new System.EventHandler(this.buttonNewInspection_Click);
            // 
            // buttonSaveInspection
            // 
            this.buttonSaveInspection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSaveInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveInspection.Location = new System.Drawing.Point(19, 263);
            this.buttonSaveInspection.Name = "buttonSaveInspection";
            this.buttonSaveInspection.Size = new System.Drawing.Size(145, 31);
            this.buttonSaveInspection.TabIndex = 8;
            this.buttonSaveInspection.Text = "Save Inspection";
            this.buttonSaveInspection.UseVisualStyleBackColor = true;
            this.buttonSaveInspection.Click += new System.EventHandler(this.buttonSaveInspection_Click);
            // 
            // panelCamera
            // 
            this.panelCamera.Controls.Add(this.cameraControl);
            this.panelCamera.Controls.Add(this.buttonUnZoom);
            this.panelCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCamera.Location = new System.Drawing.Point(178, 11);
            this.panelCamera.Name = "panelCamera";
            this.tableLayoutPanelForm.SetRowSpan(this.panelCamera, 16);
            this.panelCamera.Size = new System.Drawing.Size(662, 594);
            this.panelCamera.TabIndex = 1;
            // 
            // cameraControl
            // 
            this.cameraControl.DirectShowLogFilepath = "";
            this.cameraControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraControl.Location = new System.Drawing.Point(0, 0);
            this.cameraControl.Margin = new System.Windows.Forms.Padding(4);
            this.cameraControl.Name = "cameraControl";
            this.cameraControl.Size = new System.Drawing.Size(662, 594);
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
            // tableLayoutPanelForm
            // 
            this.tableLayoutPanelForm.ColumnCount = 2;
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelForm.Controls.Add(this.notesLabel, 0, 6);
            this.tableLayoutPanelForm.Controls.Add(this.panelCamera, 1, 0);
            this.tableLayoutPanelForm.Controls.Add(this.comboBoxPart, 0, 5);
            this.tableLayoutPanelForm.Controls.Add(this.comboBoxSection, 0, 3);
            this.tableLayoutPanelForm.Controls.Add(this.comboBoxEngine, 0, 1);
            this.tableLayoutPanelForm.Controls.Add(this.engineLabel, 0, 0);
            this.tableLayoutPanelForm.Controls.Add(this.sectionLabel, 0, 2);
            this.tableLayoutPanelForm.Controls.Add(this.partLabel, 0, 4);
            this.tableLayoutPanelForm.Controls.Add(this.textBoxNotes, 0, 7);
            this.tableLayoutPanelForm.Controls.Add(this.buttonSaveInspection, 0, 9);
            this.tableLayoutPanelForm.Controls.Add(this.buttonSavePicture, 0, 12);
            this.tableLayoutPanelForm.Controls.Add(this.buttonNewInspection, 0, 10);
            this.tableLayoutPanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelForm.Location = new System.Drawing.Point(0, 24);
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
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.Size = new System.Drawing.Size(851, 468);
            this.tableLayoutPanelForm.TabIndex = 0;
            this.tableLayoutPanelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelForm_Paint);
            // 
            // partLabel
            // 
            this.partLabel.BackColor = System.Drawing.SystemColors.Window;
            this.partLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.partLabel.Enabled = false;
            this.partLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partLabel.Location = new System.Drawing.Point(11, 112);
            this.partLabel.Name = "partLabel";
            this.partLabel.Size = new System.Drawing.Size(100, 16);
            this.partLabel.TabIndex = 14;
            this.partLabel.Text = "Part:";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotes.Location = new System.Drawing.Point(11, 183);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.tableLayoutPanelForm.SetRowSpan(this.textBoxNotes, 2);
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(160, 74);
            this.textBoxNotes.TabIndex = 15;
            // 
            // notesLabel
            // 
            this.notesLabel.BackColor = System.Drawing.SystemColors.Window;
            this.notesLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.notesLabel.Enabled = false;
            this.notesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesLabel.Location = new System.Drawing.Point(11, 161);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(100, 16);
            this.notesLabel.TabIndex = 16;
            this.notesLabel.Text = "Notes:";
            // 
            // FormCameraControlTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 492);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelCamera.ResumeLayout(false);
            this.tableLayoutPanelForm.ResumeLayout(false);
            this.tableLayoutPanelForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxDefaultPictureResolution;
        private System.Windows.Forms.Label labelDefaultPictureResolutionTitle;
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
        private System.Windows.Forms.ToolStripMenuItem addNewEnginePartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem viewEnginePartsToolStripMenuItem;
        private Camera_NET.CameraControl cameraControl1;
        private System.Windows.Forms.ToolStripMenuItem manageEnginesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.TextBox sectionLabel;
        private System.Windows.Forms.TextBox engineLabel;
        private System.Windows.Forms.ComboBox comboBoxEngine;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.ComboBox comboBoxPart;
        private System.Windows.Forms.Button buttonSavePicture;
        private System.Windows.Forms.Button buttonNewInspection;
        private System.Windows.Forms.Button buttonSaveInspection;
        private System.Windows.Forms.Panel panelCamera;
        private Camera_NET.CameraControl cameraControl;
        private System.Windows.Forms.Button buttonUnZoom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelForm;
        private System.Windows.Forms.TextBox partLabel;
        private System.Windows.Forms.TextBox notesLabel;
        private System.Windows.Forms.TextBox textBoxNotes;
    }
}

