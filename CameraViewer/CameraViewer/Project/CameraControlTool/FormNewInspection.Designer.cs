using System.Windows.Forms;


namespace CameraControlTool
{
    partial class FormNewInspection
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
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textDate = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.buttonAddPart = new System.Windows.Forms.Button();
            this.buttonSaveInspection = new System.Windows.Forms.Button();
            this.comboBoxParts = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textTitle
            // 
            this.textTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTitle.Location = new System.Drawing.Point(164, 40);
            this.textTitle.Name = "textTitle";
            this.textTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textTitle.Size = new System.Drawing.Size(338, 20);
            this.textTitle.TabIndex = 2;
            this.textTitle.Text = "Title";
            // 
            // textDate
            // 
            this.textDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDate.Location = new System.Drawing.Point(35, 40);
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
            this.textDescription.Location = new System.Drawing.Point(35, 98);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textDescription.Size = new System.Drawing.Size(467, 123);
            this.textDescription.TabIndex = 4;
            this.textDescription.Text = "Description";
            // 
            // buttonAddPart
            // 
            this.buttonAddPart.Location = new System.Drawing.Point(389, 265);
            this.buttonAddPart.Name = "buttonAddPart";
            this.buttonAddPart.Size = new System.Drawing.Size(95, 23);
            this.buttonAddPart.TabIndex = 5;
            this.buttonAddPart.Text = "Add New Part";
            this.buttonAddPart.UseVisualStyleBackColor = true;
            // 
            // buttonSaveInspection
            // 
            this.buttonSaveInspection.Location = new System.Drawing.Point(221, 336);
            this.buttonSaveInspection.Name = "buttonSaveInspection";
            this.buttonSaveInspection.Size = new System.Drawing.Size(95, 23);
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
            this.comboBoxParts.Location = new System.Drawing.Point(35, 265);
            this.comboBoxParts.Name = "comboBoxParts";
            this.comboBoxParts.Size = new System.Drawing.Size(281, 21);
            this.comboBoxParts.TabIndex = 7;
            // 
            // FormNewInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 377);
            this.Controls.Add(this.comboBoxParts);
            this.Controls.Add(this.buttonSaveInspection);
            this.Controls.Add(this.buttonAddPart);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textTitle);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "FormNewInspection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera Viewer";
            this.Load += new System.EventHandler(this.FormNewInspection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void show()
        {
            FormNewInspection formNewInspec = new FormNewInspection();
            formNewInspec.Show();
        }
        #endregion
        private TextBox textTitle;
        private TextBox textDate;
        private TextBox textDescription;
        private Button buttonAddPart;
        private Button buttonSaveInspection;
        private ComboBox comboBoxParts;
    }
}