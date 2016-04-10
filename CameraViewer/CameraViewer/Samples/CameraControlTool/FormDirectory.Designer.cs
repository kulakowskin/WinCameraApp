using System.Windows.Forms;

namespace CameraControlTool
{
    partial class FormDirectory
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanelForm = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNewInspection = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.buttonAddPart = new System.Windows.Forms.Button();
            this.buttonSaveInspection = new System.Windows.Forms.Button();
            this.comboBoxParts = new System.Windows.Forms.ComboBox();
            this.textPartDescription = new System.Windows.Forms.TextBox();
            this.buttonSavePart = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelForm
            // 
            this.tableLayoutPanelForm.ColumnCount = 2;
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelForm.Controls.Add(this.buttonNewInspection, 0, 21);
            this.tableLayoutPanelForm.Controls.Add(this.treeView1, 0, 1);
            this.tableLayoutPanelForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.Size = new System.Drawing.Size(196, 492);
            this.tableLayoutPanelForm.TabIndex = 0;
            // 
            // buttonNewInspection
            // 
            this.buttonNewInspection.Location = new System.Drawing.Point(25, 423);
            this.buttonNewInspection.Margin = new System.Windows.Forms.Padding(25, 3, 3, 3);
            this.buttonNewInspection.Name = "buttonNewInspection";
            this.buttonNewInspection.Size = new System.Drawing.Size(160, 26);
            this.buttonNewInspection.TabIndex = 1;
            this.buttonNewInspection.Text = "New Inspection";
            this.buttonNewInspection.UseVisualStyleBackColor = true;
            this.buttonNewInspection.Click += new System.EventHandler(this.buttonNewInspection_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(20, 23);
            this.treeView1.Margin = new System.Windows.Forms.Padding(20, 3, 6, 20);
            this.treeView1.MaximumSize = new System.Drawing.Size(193, 900);
            this.treeView1.Name = "treeView1";
            this.tableLayoutPanelForm.SetRowSpan(this.treeView1, 20);
            this.treeView1.Size = new System.Drawing.Size(174, 377);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeNode_Select);
            // 
            // textTitle
            // 
            this.textTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTitle.Location = new System.Drawing.Point(354, 41);
            this.textTitle.Name = "textTitle";
            this.textTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textTitle.Size = new System.Drawing.Size(338, 20);
            this.textTitle.TabIndex = 2;
            this.textTitle.Text = "Title";
            // 
            // textDate
            // 
            this.textDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDate.Location = new System.Drawing.Point(231, 41);
            this.textDate.MaxLength = 10;
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(89, 20);
            this.textDate.TabIndex = 3;
            this.textDate.Text = "MM/DD/YYYY";
            this.textDate.WordWrap = false;
            // 
            // textDescription
            // 
            this.textDescription.AcceptsReturn = true;
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textDescription.Location = new System.Drawing.Point(231, 97);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDescription.Size = new System.Drawing.Size(467, 139);
            this.textDescription.TabIndex = 4;
            this.textDescription.Text = "Description";
            // 
            // buttonAddPart
            // 
            this.buttonAddPart.Location = new System.Drawing.Point(587, 263);
            this.buttonAddPart.Name = "buttonAddPart";
            this.buttonAddPart.Size = new System.Drawing.Size(95, 23);
            this.buttonAddPart.TabIndex = 5;
            this.buttonAddPart.Text = "New Part";
            this.buttonAddPart.UseVisualStyleBackColor = true;
            // 
            // buttonSaveInspection
            // 
            this.buttonSaveInspection.Location = new System.Drawing.Point(417, 458);
            this.buttonSaveInspection.Name = "buttonSaveInspection";
            this.buttonSaveInspection.Size = new System.Drawing.Size(95, 23);
            this.buttonSaveInspection.TabIndex = 6;
            this.buttonSaveInspection.Text = "Save Inspection";
            this.buttonSaveInspection.UseVisualStyleBackColor = true;
            this.buttonSaveInspection.Click += new System.EventHandler(this.buttonSaveInspection_Click);
            // 
            // comboBoxParts
            // 
            this.comboBoxParts.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBoxParts.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxParts.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxParts.FormattingEnabled = true;
            this.comboBoxParts.Location = new System.Drawing.Point(231, 263);
            this.comboBoxParts.MaxDropDownItems = 50;
            this.comboBoxParts.Name = "comboBoxParts";
            this.comboBoxParts.Size = new System.Drawing.Size(281, 21);
            this.comboBoxParts.Sorted = true;
            this.comboBoxParts.TabIndex = 7;
            this.comboBoxParts.Text = "Parts List";
            // 
            // textPartDescription
            // 
            this.textPartDescription.AcceptsReturn = true;
            this.textPartDescription.Location = new System.Drawing.Point(231, 320);
            this.textPartDescription.Multiline = true;
            this.textPartDescription.Name = "textPartDescription";
            this.textPartDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textPartDescription.Size = new System.Drawing.Size(467, 70);
            this.textPartDescription.TabIndex = 8;
            this.textPartDescription.Text = "Part Description";
            // 
            // buttonSavePart
            // 
            this.buttonSavePart.Location = new System.Drawing.Point(587, 406);
            this.buttonSavePart.Name = "buttonSavePart";
            this.buttonSavePart.Size = new System.Drawing.Size(95, 23);
            this.buttonSavePart.TabIndex = 9;
            this.buttonSavePart.Text = "Save Part";
            this.buttonSavePart.UseVisualStyleBackColor = true;
            this.buttonSavePart.Click += new System.EventHandler(this.buttonSavePart_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 504);
            this.Controls.Add(this.buttonSavePart);
            this.Controls.Add(this.textPartDescription);
            this.Controls.Add(this.comboBoxParts);
            this.Controls.Add(this.buttonSaveInspection);
            this.Controls.Add(this.buttonAddPart);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.tableLayoutPanelForm);
            this.MinimumSize = new System.Drawing.Size(595, 542);
            this.Name = "FormDirectory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera Viewer";
            this.tableLayoutPanelForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void show()
        {
            FormDirectory formDirectory = new FormDirectory();
            formDirectory.Show();
        }
        #endregion

        private System.Windows.Forms.Button buttonNewInspection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelForm;
        private TextBox textTitle;
        private TextBox textDate;
        private TextBox textDescription;
        private Button buttonAddPart;
        private Button buttonSaveInspection;
        private ComboBox comboBoxParts;
        private TreeView treeView1;
        private TextBox textPartDescription;
        private Button buttonSavePart;
        private ImageList imageList1;
        private ColorDialog colorDialog1;
    }
}