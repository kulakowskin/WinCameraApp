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
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.buttonAddPart = new System.Windows.Forms.Button();
            this.buttonSaveInspection = new System.Windows.Forms.Button();
            this.comboBoxParts = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelForm
            // 
            this.tableLayoutPanelForm.ColumnCount = 2;
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanelForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelForm.Controls.Add(this.buttonNewInspection, 0, 25);
            this.tableLayoutPanelForm.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelForm.Name = "tableLayoutPanelForm";
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
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelForm.Size = new System.Drawing.Size(196, 534);
            this.tableLayoutPanelForm.TabIndex = 0;
            this.tableLayoutPanelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelForm_Paint);
            // 
            // buttonNewInspection
            // 
            this.buttonNewInspection.Location = new System.Drawing.Point(3, 503);
            this.buttonNewInspection.Name = "buttonNewInspection";
            this.buttonNewInspection.Size = new System.Drawing.Size(194, 26);
            this.buttonNewInspection.TabIndex = 1;
            this.buttonNewInspection.Text = "New Inspection";
            this.buttonNewInspection.UseVisualStyleBackColor = true;
            this.buttonNewInspection.Click += new System.EventHandler(this.buttonNewInspection_Click);
            // 
            // textTitle
            // 
            this.textTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTitle.Location = new System.Drawing.Point(363, 65);
            this.textTitle.Name = "textTitle";
            this.textTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textTitle.Size = new System.Drawing.Size(338, 20);
            this.textTitle.TabIndex = 2;
            this.textTitle.Text = "Title";
            // 
            // textDate
            // 
            this.textDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDate.Location = new System.Drawing.Point(252, 65);
            this.textDate.MaxLength = 10;
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(89, 20);
            this.textDate.TabIndex = 3;
            this.textDate.Text = "MM/DD/YYYY";
            this.textDate.WordWrap = false;
            // 
            // textDescription
            // 
            this.textDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textDescription.Location = new System.Drawing.Point(252, 157);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDescription.Size = new System.Drawing.Size(467, 105);
            this.textDescription.TabIndex = 4;
            this.textDescription.Text = "Description";
            // 
            // buttonAddPart
            // 
            this.buttonAddPart.Location = new System.Drawing.Point(606, 341);
            this.buttonAddPart.Name = "buttonAddPart";
            this.buttonAddPart.Size = new System.Drawing.Size(95, 23);
            this.buttonAddPart.TabIndex = 5;
            this.buttonAddPart.Text = "Add New Part";
            this.buttonAddPart.UseVisualStyleBackColor = true;
            // 
            // buttonSaveInspection
            // 
            this.buttonSaveInspection.Location = new System.Drawing.Point(606, 462);
            this.buttonSaveInspection.Name = "buttonSaveInspection";
            this.buttonSaveInspection.Size = new System.Drawing.Size(95, 23);
            this.buttonSaveInspection.TabIndex = 6;
            this.buttonSaveInspection.Text = "Save Inspection";
            this.buttonSaveInspection.UseVisualStyleBackColor = true;
            // 
            // comboBoxParts
            // 
            this.comboBoxParts.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxParts.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboBoxParts.FormattingEnabled = true;
            this.comboBoxParts.Location = new System.Drawing.Point(252, 341);
            this.comboBoxParts.Name = "comboBoxParts";
            this.comboBoxParts.Size = new System.Drawing.Size(281, 21);
            this.comboBoxParts.TabIndex = 7;
            // 
            // FormDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 537);
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
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private Button buttonAddPart;
        private Button buttonSaveInspection;
        private ComboBox comboBoxParts;
    }
}