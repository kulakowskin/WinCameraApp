using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CameraControlTool
{
	/// <summary>
	/// Summary description for frmSampleGrid1.
	/// </summary>
	public class EnginePartForm : System.Windows.Forms.Form
	{
        private static InspectionList inspecList;
        private System.Windows.Forms.Button brAddRow;
        private System.Windows.Forms.Button btRemoveRow;
		private SourceGrid.Grid grid1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btExportHTML;
		private System.Windows.Forms.CheckBox chkReadOnly;
        private System.Windows.Forms.CheckBox chkEditOnDoubleClick;
        private Button btExportCsv;
        private Button btExportImage;
        private static EnginePartList enginePartList;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EnginePartForm()
		{
            enginePartList = EnginePartList.getInstance();
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.brAddRow = new System.Windows.Forms.Button();
            this.btRemoveRow = new System.Windows.Forms.Button();
            this.grid1 = new SourceGrid.Grid();
            this.label1 = new System.Windows.Forms.Label();
            this.btExportHTML = new System.Windows.Forms.Button();
            this.chkReadOnly = new System.Windows.Forms.CheckBox();
            this.chkEditOnDoubleClick = new System.Windows.Forms.CheckBox();
            this.btExportCsv = new System.Windows.Forms.Button();
            this.btExportImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // brAddRow
            // 
            this.brAddRow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.brAddRow.Location = new System.Drawing.Point(10, 9);
            this.brAddRow.Name = "brAddRow";
            this.brAddRow.Size = new System.Drawing.Size(100, 27);
            this.brAddRow.TabIndex = 1;
            this.brAddRow.Text = "Add Part";
            this.brAddRow.Click += new System.EventHandler(this.brAddRow_Click);
            // 
            // btRemoveRow
            // 
            this.btRemoveRow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btRemoveRow.Location = new System.Drawing.Point(115, 9);
            this.btRemoveRow.Name = "btRemoveRow";
            this.btRemoveRow.Size = new System.Drawing.Size(101, 27);
            this.btRemoveRow.TabIndex = 2;
            this.btRemoveRow.Text = "Delete Part";
            this.btRemoveRow.Click += new System.EventHandler(this.btRemoveRow_Click);
            // 
            // grid1
            // 
            this.grid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid1.BackColor = System.Drawing.Color.White;
            this.grid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid1.EnableSort = true;
            this.grid1.Location = new System.Drawing.Point(10, 43);
            this.grid1.Name = "grid1";
            this.grid1.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid1.SelectionMode = SourceGrid.GridSelectionMode.Cell;
            this.grid1.Size = new System.Drawing.Size(748, 299);
            this.grid1.TabIndex = 1;
            this.grid1.TabStop = true;
            this.grid1.ToolTipText = "";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(10, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Click column header to sort the grid";
            // 
            // btExportHTML
            // 
            this.btExportHTML.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btExportHTML.Location = new System.Drawing.Point(445, 10);
            this.btExportHTML.Name = "btExportHTML";
            this.btExportHTML.Size = new System.Drawing.Size(101, 27);
            this.btExportHTML.TabIndex = 7;
            this.btExportHTML.Text = "&Export HTML";
            this.btExportHTML.Click += new System.EventHandler(this.btExportHTML_Click);
            // 
            // chkReadOnly
            // 
            this.chkReadOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkReadOnly.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkReadOnly.Location = new System.Drawing.Point(596, 349);
            this.chkReadOnly.Name = "chkReadOnly";
            this.chkReadOnly.Size = new System.Drawing.Size(153, 23);
            this.chkReadOnly.TabIndex = 8;
            this.chkReadOnly.Text = "Read Only Cells";
            this.chkReadOnly.CheckedChanged += new System.EventHandler(this.chkReadOnly_CheckedChanged);
            // 
            // chkEditOnDoubleClick
            // 
            this.chkEditOnDoubleClick.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkEditOnDoubleClick.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkEditOnDoubleClick.Location = new System.Drawing.Point(596, 367);
            this.chkEditOnDoubleClick.Name = "chkEditOnDoubleClick";
            this.chkEditOnDoubleClick.Size = new System.Drawing.Size(153, 23);
            this.chkEditOnDoubleClick.TabIndex = 9;
            this.chkEditOnDoubleClick.Text = "Edit On Double Click";
            this.chkEditOnDoubleClick.CheckedChanged += new System.EventHandler(this.chkEditOnDoubleClick_CheckedChanged);
            // 
            // btExportCsv
            // 
            this.btExportCsv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btExportCsv.Location = new System.Drawing.Point(552, 9);
            this.btExportCsv.Name = "btExportCsv";
            this.btExportCsv.Size = new System.Drawing.Size(101, 27);
            this.btExportCsv.TabIndex = 13;
            this.btExportCsv.Text = "Export CSV";
            this.btExportCsv.Click += new System.EventHandler(this.btExportCsv_Click);
            // 
            // btExportImage
            // 
            this.btExportImage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btExportImage.Location = new System.Drawing.Point(659, 9);
            this.btExportImage.Name = "btExportImage";
            this.btExportImage.Size = new System.Drawing.Size(101, 27);
            this.btExportImage.TabIndex = 14;
            this.btExportImage.Text = "Export Image";
            this.btExportImage.Click += new System.EventHandler(this.btExportImage_Click);
            // 
            // EnginePartForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(764, 395);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.btExportImage);
            this.Controls.Add(this.chkEditOnDoubleClick);
            this.Controls.Add(this.chkReadOnly);
            this.Controls.Add(this.btExportCsv);
            this.Controls.Add(this.btExportHTML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btRemoveRow);
            this.Controls.Add(this.brAddRow);
            this.Name = "EnginePartForm";
            this.Text = "Sample Grid 1";
            this.Load += new System.EventHandler(this.frmSampleGrid1_Load);
            this.ResumeLayout(false);

		}
		#endregion

		//Editors
		private SourceGrid.Cells.Editors.EditorBase mEditor_Id;
		private SourceGrid.Cells.Editors.EditorBase mEditor_Name;
        private SourceGrid.Cells.Editors.EditorBase mEditor_Description;

        
		//Views
        private SourceGrid.Cells.Views.Cell mView_Price;

		//Controllers
		private SourceGrid.Cells.Controllers.Button mController_Link;

		private void frmSampleGrid1_Load(object sender, System.EventArgs e)
		{
			//string[] l_CountryList = new string[]{"Italy","France","Spain","UK","Argentina","Mexico", "Switzerland", "Brazil", "Germany","Portugal","Sweden","Austria"};

			grid1.RowsCount = 1;
			grid1.ColumnsCount = 4;
			grid1.FixedRows = 1;
			grid1.FixedColumns = 1;
			grid1.SelectionMode = SourceGrid.GridSelectionMode.Row;
			grid1.AutoStretchColumnsToFitWidth = true;
			grid1.Columns[0].AutoSizeMode = SourceGrid.AutoSizeMode.None;
			grid1.Columns[0].Width = 25;

            grid1.Controller.AddController(new KeyDeleteController());
		
            //TODO
            ////Enable Drag and Drop
            //grid1.GridController.AddController(SourceGrid.Controllers.SelectionDrag.Cut);
            //grid1.GridController.AddController(SourceGrid.Controllers.SelectionDrop.Default);


			#region Create Grid Style, Views and Controllers
			//Views
			mView_Price = new SourceGrid.Cells.Views.Cell();
			mView_Price.TextAlignment = DevAge.Drawing.ContentAlignment.MiddleRight;


			mController_Link = new SourceGrid.Cells.Controllers.Button();
			mController_Link.Executed += new EventHandler(mController_Link_Click);
			#endregion

			#region Create Header Row and Editor
			SourceGrid.Cells.Header l_00Header = new SourceGrid.Cells.Header(null);
			grid1[0,0] = l_00Header;

            mEditor_Id = SourceGrid.Cells.Editors.Factory.Create(typeof(int));
			mEditor_Id.EditableMode = SourceGrid.EditableMode.Focus|SourceGrid.EditableMode.AnyKey|SourceGrid.EditableMode.SingleClick;
			grid1[0,1] = new SourceGrid.Cells.ColumnHeader("ID (int)");

            mEditor_Name = SourceGrid.Cells.Editors.Factory.Create(typeof(string));
			mEditor_Name.EditableMode = SourceGrid.EditableMode.Focus|SourceGrid.EditableMode.AnyKey|SourceGrid.EditableMode.SingleClick;
			grid1[0,2] = new SourceGrid.Cells.ColumnHeader("Part Name (string)");

            mEditor_Description = SourceGrid.Cells.Editors.Factory.Create(typeof(string));
            mEditor_Description.EditableMode = SourceGrid.EditableMode.Focus | SourceGrid.EditableMode.AnyKey | SourceGrid.EditableMode.SingleClick;
            grid1[0, 3] = new SourceGrid.Cells.ColumnHeader("Description (string)");

            mEditor_Id.EditableMode = SourceGrid.EditableMode.AnyKey | SourceGrid.EditableMode.DoubleClick | SourceGrid.EditableMode.F2Key;
            mEditor_Name.EditableMode = SourceGrid.EditableMode.AnyKey | SourceGrid.EditableMode.DoubleClick | SourceGrid.EditableMode.F2Key;
            mEditor_Description.EditableMode = SourceGrid.EditableMode.AnyKey | SourceGrid.EditableMode.DoubleClick | SourceGrid.EditableMode.F2Key;

            #endregion

            //Read Data From EnginePartList
            int rows = enginePartList.getSize() + 1;
            grid1.RowsCount = rows + 1;
            int rowsCount = 1;
            foreach (EnginePart part in enginePartList.getEngineParts()){
                Console.WriteLine("part: " + part.getDescription());
                grid1[rowsCount, 0] = new SourceGrid.Cells.RowHeader(null);
                grid1[rowsCount, 1] = new SourceGrid.Cells.Cell(rowsCount, mEditor_Name);
                grid1[rowsCount, 2] = new SourceGrid.Cells.Cell(part.getPartName(), mEditor_Name);
                grid1[rowsCount, 3] = new SourceGrid.Cells.Cell(part.getDescription(), mEditor_Description);
                rowsCount++;
            }
           

            grid1.AutoSizeCells();
		}

		private void brAddRow_Click(object sender, System.EventArgs e)
		{
            int row = grid1.RowsCount;
			grid1.Rows.Insert(row);

            grid1[row, 0] = new SourceGrid.Cells.RowHeader(null);
            grid1[row, 1] = new SourceGrid.Cells.Cell(grid1.RowsCount, mEditor_Id);
			grid1[row, 2] = new SourceGrid.Cells.Cell(mEditor_Name.DefaultValue, mEditor_Name);
            grid1[row, 3] = new SourceGrid.Cells.Cell(mEditor_Description.DefaultValue, mEditor_Description);

            String name = (String)mEditor_Name.GetEditedValue();
            Console.WriteLine("Edited value: " + name);
            // Add new engine part
            Console.WriteLine("Description: " + mEditor_Description);
            Console.WriteLine("Name: + " + mEditor_Name);
            EnginePart part = new EnginePart(mEditor_Name.ToString(), mEditor_Name.ToString(), "", "");
            enginePartList.addNewPart(part);

            grid1.Selection.FocusRow(row);
		}

		private void btRemoveRow_Click(object sender, System.EventArgs e)
		{
			int[] rowsIndex = grid1.Selection.GetSelectionRegion().GetRowsIndex();
			SourceGrid.RowInfo[] rows = new SourceGrid.RowInfo[rowsIndex.Length];
			for (int i = 0; i < rows.Length; i++)
				rows[i] = grid1.Rows[rowsIndex[i]];

			foreach (SourceGrid.RowInfo r in rows)
				grid1.Rows.Remove(r.Index);

			if (grid1.RowsCount > 1)
				grid1.Selection.FocusRow(1);
		}

		private void btMoveRow_Click(object sender, System.EventArgs e)
		{
			if (grid1.RowsCount>1)
				grid1.Rows.Move(grid1.RowsCount-1,1);
		}

		private void btMoveColumn_Click(object sender, System.EventArgs e)
		{
			brAddRow.Enabled = false; //disable the add button to prevent adding new row when column are out of position
			if (grid1.ColumnsCount>1)
				grid1.Columns.Move(grid1.ColumnsCount-1,1);
		}

		private void btExportHTML_Click(object sender, System.EventArgs e)
		{
			try
			{
				string l_Path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "tmpSourceGridExport.htm");

				using (System.IO.FileStream l_Stream = new System.IO.FileStream(l_Path,System.IO.FileMode.Create,System.IO.FileAccess.Write))
				{
					SourceGrid.Exporter.HTML html = new SourceGrid.Exporter.HTML(SourceGrid.Exporter.ExportHTMLMode.Default, System.IO.Path.GetTempPath(), "", l_Stream);
					html.Export(grid1);
					l_Stream.Close();
				}

				DevAge.Shell.Utilities.OpenFile(l_Path);
			}
			catch(Exception err)
			{
				DevAge.Windows.Forms.ErrorDialog.Show(this,err,"HTML Export Error");
			}
		}

		private void chkReadOnly_CheckedChanged(object sender, System.EventArgs e)
		{
			for (int r = 0; r < grid1.RowsCount; r++)
				for (int c = 0; c < grid1.ColumnsCount; c++)
				{
					if (grid1[r,c].Editor != null)
						grid1[r,c].Editor.EnableEdit = !chkReadOnly.Checked;
				}
		}

		private void mController_Link_Click(object sender, EventArgs e)
		{
			try
			{
				SourceGrid.CellContext context = (SourceGrid.CellContext)sender;
				DevAge.Shell.Utilities.OpenFile( ((SourceGrid.Cells.Link)context.Cell).Value.ToString());
			}
			catch(Exception)
			{
			}
		}

		private void chkEditOnDoubleClick_CheckedChanged(object sender, System.EventArgs e)
		{
			//if (chkEditOnDoubleClick.Checked)
			//{
				mEditor_Id.EditableMode = SourceGrid.EditableMode.AnyKey | SourceGrid.EditableMode.DoubleClick | SourceGrid.EditableMode.F2Key;
				mEditor_Name.EditableMode = SourceGrid.EditableMode.AnyKey | SourceGrid.EditableMode.DoubleClick | SourceGrid.EditableMode.F2Key;
			//}
			//else
			//{
				//mEditor_Id.EditableMode = SourceGrid.EditableMode.Focus|SourceGrid.EditableMode.AnyKey|SourceGrid.EditableMode.SingleClick;
				//mEditor_Name.EditableMode = SourceGrid.EditableMode.Focus|SourceGrid.EditableMode.AnyKey|SourceGrid.EditableMode.SingleClick;
			//}
		}

        private void btExportCsv_Click(object sender, EventArgs e)
        {
            try
            {
                string l_Path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "CsvFile.csv");

                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(l_Path, false, System.Text.Encoding.Default))
                {
                    SourceGrid.Exporter.CSV csv = new SourceGrid.Exporter.CSV();
                    csv.Export(grid1, writer);
                    writer.Close();
                }

                DevAge.Shell.Utilities.OpenFile(l_Path);
            }
            catch (Exception err)
            {
                DevAge.Windows.Forms.ErrorDialog.Show(this, err, "CSV Export Error");
            }
        }

        private void btExportImage_Click(object sender, EventArgs e)
        {
            try
            {
                string l_Path = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "ImageFile.bmp");

                SourceGrid.Exporter.Image image = new SourceGrid.Exporter.Image();

                using (System.Drawing.Bitmap bitmap = image.Export(grid1, grid1.CompleteRange))
                {
                    bitmap.Save(l_Path);
                }

                DevAge.Shell.Utilities.OpenFile(l_Path);
            }
            catch (Exception err)
            {
                DevAge.Windows.Forms.ErrorDialog.Show(this, err, "BITMAP Export Error");
            }
        }

        public class KeyDeleteController : SourceGrid.Cells.Controllers.ControllerBase
        {
            public override void OnKeyDown(SourceGrid.CellContext sender, KeyEventArgs e)
            {
                base.OnKeyDown(sender, e);

                if (e.KeyCode == Keys.Delete)
                {
                    SourceGrid.Grid grid = (SourceGrid.Grid)sender.Grid;
                    grid.Rows.Remove(sender.Position.Row);
                }
            }
        }
	}
}
