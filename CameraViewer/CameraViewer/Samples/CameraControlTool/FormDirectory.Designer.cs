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
            this.tableLayoutPanelForm = new System.Windows.Forms.TableLayoutPanel();
            this.buttonNewInspection = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.buttonAddPart = new System.Windows.Forms.Button();
            this.buttonSaveInspection = new System.Windows.Forms.Button();
            this.comboBoxParts = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelForm
            // 
            this.tableLayoutPanelForm.ColumnCount = 2;
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelForm.Controls.Add(this.buttonNewInspection, 0, 23);
            this.tableLayoutPanelForm.Controls.Add(this.treeView1, 0, 2);
            this.tableLayoutPanelForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelForm.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanelForm.Name = "tableLayoutPanelForm";
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelForm.Size = new System.Drawing.Size(261, 657);
            this.tableLayoutPanelForm.TabIndex = 0;
            // 
            // buttonNewInspection
            // 
            this.buttonNewInspection.Location = new System.Drawing.Point(4, 577);
            this.buttonNewInspection.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNewInspection.Name = "buttonNewInspection";
            this.buttonNewInspection.Size = new System.Drawing.Size(259, 32);
            this.buttonNewInspection.TabIndex = 1;
            this.buttonNewInspection.Text = "New Inspection";
            this.buttonNewInspection.UseVisualStyleBackColor = true;
            this.buttonNewInspection.Click += new System.EventHandler(this.buttonNewInspection_Click);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(4, 54);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.MaximumSize = new System.Drawing.Size(256, 1230);
            this.treeView1.Name = "treeView1";
            this.tableLayoutPanelForm.SetRowSpan(this.treeView1, 20);
            this.treeView1.Size = new System.Drawing.Size(256, 490);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeNode_Select);
            // 
            // textTitle
            // 
            this.textTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTitle.Location = new System.Drawing.Point(484, 80);
            this.textTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textTitle.Name = "textTitle";
            this.textTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textTitle.Size = new System.Drawing.Size(450, 22);
            this.textTitle.TabIndex = 2;
            this.textTitle.Text = "Title";
            // 
            // textDate
            // 
            this.textDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDate.Location = new System.Drawing.Point(336, 80);
            this.textDate.Margin = new System.Windows.Forms.Padding(4);
            this.textDate.MaxLength = 10;
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(118, 22);
            this.textDate.TabIndex = 3;
            this.textDate.Text = "MM/DD/YYYY";
            this.textDate.WordWrap = false;
            // 
            // textDescription
            // 
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textDescription.Location = new System.Drawing.Point(336, 193);
            this.textDescription.Margin = new System.Windows.Forms.Padding(4);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDescription.Size = new System.Drawing.Size(622, 129);
            this.textDescription.TabIndex = 4;
            this.textDescription.Text = "Description";
            // 
            // buttonAddPart
            // 
            this.buttonAddPart.Location = new System.Drawing.Point(808, 420);
            this.buttonAddPart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddPart.Name = "buttonAddPart";
            this.buttonAddPart.Size = new System.Drawing.Size(127, 28);
            this.buttonAddPart.TabIndex = 5;
            this.buttonAddPart.Text = "Add New Part";
            this.buttonAddPart.UseVisualStyleBackColor = true;
            // 
            // buttonSaveInspection
            // 
            this.buttonSaveInspection.Location = new System.Drawing.Point(808, 569);
            this.buttonSaveInspection.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveInspection.Name = "buttonSaveInspection";
            this.buttonSaveInspection.Size = new System.Drawing.Size(127, 28);
            this.buttonSaveInspection.TabIndex = 6;
            this.buttonSaveInspection.Text = "Save Inspection";
            this.buttonSaveInspection.UseVisualStyleBackColor = true;
            this.buttonSaveInspection.Click += new System.EventHandler(this.buttonSaveInspection_Click);
            // 
            // comboBoxParts
            // 
            this.comboBoxParts.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxParts.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboBoxParts.FormattingEnabled = true;
            this.comboBoxParts.Location = new System.Drawing.Point(336, 420);
            this.comboBoxParts.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxParts.Name = "comboBoxParts";
            this.comboBoxParts.Size = new System.Drawing.Size(373, 24);
            this.comboBoxParts.TabIndex = 7;
            // 
            // FormDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 661);
            this.Controls.Add(this.comboBoxParts);
            this.Controls.Add(this.buttonSaveInspection);
            this.Controls.Add(this.buttonAddPart);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.tableLayoutPanelForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(787, 656);
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
    }
}