namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { WebUser, Cuisine, Ingredient, Measurement, Course}

        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.WebUser;

        string deletecolname = "deletecol";
        public frmDataMaintenance()
        {
            InitializeComponent();
            SetUpRadioButtons();
            this.FormClosing += FrmDataMaintenance_FormClosing;
            BindData(currenttabletype);
            btnSave.Click += BtnSave_Click;
            gData.CellContentClick += GData_CellContentClick;
        }


        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;

            WindowsFormsUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gData, currenttabletype.ToString());
            
        }

        
        private void SetUpRadioButtons()
        {
            foreach(Control c in pnlOptionButtons.Controls)
            {
                if(c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            optWebUser.Tag = TableTypeEnum.WebUser;
            optCuisine.Tag = TableTypeEnum.Cuisine;
            optIngredient.Tag = TableTypeEnum.Ingredient;
            optMeasurement.Tag = TableTypeEnum.Measurement;
            optCourse.Tag = TableTypeEnum.Course;
        }

        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.UpdateDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }

        private void Delete(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
            if (id != 0)
            {
                try
                {
                    if(currenttabletype == TableTypeEnum.WebUser)
                    {
                        if(ConfirmDeleteUser() == false)
                        {
                            return;
                        }
                    }
                    else
                    {
                        if(ConfirmDeleteRelatedRecords(currenttabletype.ToString()) == false)
                        {
                            return;
                        }
                    }
                    
                    DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }

            }
            else if (id == 0 && rowindex < gData.Rows.Count)
            {
                gData.Rows.Remove(gData.Rows[rowindex]);
            }
        }

        private bool ConfirmDeleteRelatedRecords(string tablename)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this " + tablename + " and all related records?", Application.ProductName, MessageBoxButtons.YesNo);
            return result == DialogResult.Yes;
        }

        private bool ConfirmDeleteUser()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user and all related recipes, meals, and cookbooks?", Application.ProductName, MessageBoxButtons.YesNo);
            return result == DialogResult.Yes;
        }
            

        private void C_Click(object? sender, EventArgs e)
        {
            if(sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }


        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHasChanges(dtlist))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }


        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].Name == deletecolname)
            {
                Delete(e.RowIndex);
            }
        }
    }
}
