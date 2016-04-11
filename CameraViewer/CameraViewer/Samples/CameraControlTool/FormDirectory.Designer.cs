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
            this.buttonShowNotes = new System.Windows.Forms.Button();
            this.buttonSaveInspection = new System.Windows.Forms.Button();
            this.comboBoxParts = new System.Windows.Forms.ComboBox();
            this.textPartDescription = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.titleDate = new System.Windows.Forms.TextBox();
            this.titleTitle = new System.Windows.Forms.TextBox();
            this.titleNotes = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelForm.SuspendLayout();
            this.SuspendLayout();
            //
            // tableLayoutPanelForm
            //
            this.tableLayoutPanelForm.ColumnCount = 2;
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelForm.Controls.Add(this.buttonNewInspection, 0, 21);
            this.tableLayoutPanelForm.Controls.Add(this.treeView1, 0, 1);
            this.tableLayoutPanelForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelForm.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
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
            this.treeView1.HotTracking = true;
            this.treeView1.Location = new System.Drawing.Point(20, 23);
            this.treeView1.Margin = new System.Windows.Forms.Padding(20, 3, 6, 20);
            this.treeView1.MaximumSize = new System.Drawing.Size(193, 900);
            this.treeView1.Name = "treeView1";
            this.tableLayoutPanelForm.SetRowSpan(this.treeView1, 20);
            this.treeView1.Size = new System.Drawing.Size(174, 377);
            this.treeView1.TabIndex = 3;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            //
            // textTitle
            //
            this.textTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTitle.Location = new System.Drawing.Point(354, 41);
            this.textTitle.Name = "textTitle";
            this.textTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textTitle.Size = new System.Drawing.Size(450, 22);
            this.textTitle.TabIndex = 2;
            this.textTitle.Text = "Title";
            //
            // textDate
            //
            this.textDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDate.Location = new System.Drawing.Point(231, 41);
            this.textDate.MaxLength = 10;
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(118, 22);
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
            // buttonShowNotes
            //
            this.buttonShowNotes.Location = new System.Drawing.Point(587, 275);
            this.buttonShowNotes.Name = "buttonShowNotes";
            this.buttonShowNotes.Size = new System.Drawing.Size(95, 23);
            this.buttonShowNotes.TabIndex = 5;
            this.buttonShowNotes.Text = "Show Part Notes";
            this.buttonShowNotes.UseVisualStyleBackColor = true;
            this.buttonShowNotes.Click += new System.EventHandler(this.buttonShowNotes_Click);
            //
            // buttonSaveInspection
            //
            this.buttonSaveInspection.Location = new System.Drawing.Point(417, 426);
            this.buttonSaveInspection.Name = "buttonSaveInspection";
            this.buttonSaveInspection.Size = new System.Drawing.Size(127, 28);
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
            this.comboBoxParts.Location = new System.Drawing.Point(231, 277);
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
            this.textPartDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPartDescription.Location = new System.Drawing.Point(231, 320);
            this.textPartDescription.Multiline = true;
            this.textPartDescription.Name = "textPartDescription";
            this.textPartDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textPartDescription.Size = new System.Drawing.Size(467, 70);
            this.textPartDescription.TabIndex = 8;
            this.textPartDescription.Text = "Part Description";
            //
            // imageList1
            //
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            //
            // titleDate
            //
            this.titleDate.BackColor = System.Drawing.SystemColors.Window;
            this.titleDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleDate.Enabled = false;
            this.titleDate.ForeColor = System.Drawing.SystemColors.InfoText;
            this.titleDate.Location = new System.Drawing.Point(231, 15);
            this.titleDate.Name = "titleDate";
            this.titleDate.ReadOnly = true;
            this.titleDate.Size = new System.Drawing.Size(41, 13);
            this.titleDate.TabIndex = 10;
            this.titleDate.Text = "Date";
            //
            // titleTitle
            //
            this.titleTitle.BackColor = System.Drawing.SystemColors.Window;
            this.titleTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleTitle.Enabled = false;
            this.titleTitle.ForeColor = System.Drawing.SystemColors.InfoText;
            this.titleTitle.Location = new System.Drawing.Point(354, 15);
            this.titleTitle.Name = "titleTitle";
            this.titleTitle.ReadOnly = true;
            this.titleTitle.Size = new System.Drawing.Size(41, 13);
            this.titleTitle.TabIndex = 11;
            this.titleTitle.Text = "Title";
            //
            // titleNotes
            //
            this.titleNotes.BackColor = System.Drawing.SystemColors.Window;
            this.titleNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleNotes.Cursor = System.Windows.Forms.Cursors.Default;
            this.titleNotes.Enabled = false;
            this.titleNotes.ForeColor = System.Drawing.SystemColors.InfoText;
            this.titleNotes.Location = new System.Drawing.Point(231, 78);
            this.titleNotes.Name = "titleNotes";
            this.titleNotes.ReadOnly = true;
            this.titleNotes.Size = new System.Drawing.Size(41, 13);
            this.titleNotes.TabIndex = 12;
            this.titleNotes.Text = "Notes";
            //
            // textBox1
            //
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(231, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(137, 13);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "(e.g. Engine, Section, Part)";
            //
            // FormDirectory
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 461);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.titleNotes);
            this.Controls.Add(this.titleTitle);
            this.Controls.Add(this.titleDate);
            this.Controls.Add(this.textPartDescription);
            this.Controls.Add(this.comboBoxParts);
            this.Controls.Add(this.buttonSaveInspection);
            this.Controls.Add(this.buttonShowNotes);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.tableLayoutPanelForm);
            this.MinimumSize = new System.Drawing.Size(595, 350);
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
        private Button buttonShowNotes;
        private Button buttonSaveInspection;
        private ComboBox comboBoxParts;
        private TreeView treeView1;
        private TextBox textPartDescription;
        private ImageList imageList1;
        private ColorDialog colorDialog1;
        private TextBox titleDate;
        private TextBox titleTitle;
        private TextBox titleNotes;
        private TextBox textBox1;
    }
}
