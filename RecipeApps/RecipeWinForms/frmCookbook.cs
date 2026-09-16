namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        DataTable dtcookbook;

        DataTable dtrecipecookbook = new();

        BindingSource bindsource = new();
        int cookbookid = 0;

        string deletecolname = "deletecol";

        bool isautocreated = false;

        public frmCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnRecipeSave.Click += BtnRecipeSave_Click;
            gData.CellContentClick += GData_CellContentClick;
            this.FormClosing += FrmCookbook_FormClosing;
            this.Shown += FrmCookbook_Shown;
        }



        private void FrmCookbook_Shown(object? sender, EventArgs e)
        {
            LoadRecipeCookbook();
            ShowRecipeCookbookColumns();
        }

        public void LoadForm(int cookbookidval, bool isautocreatedval = false)
        {
            cookbookid = cookbookidval;
            isautocreated = isautocreatedval;
            this.Tag = cookbookid;

            dtcookbook = Cookbook.Load(cookbookid);
            bindsource.DataSource = dtcookbook;

            if (cookbookid == 0)
            {

                DataRow r = dtcookbook.Rows.Add();
                r["DateCookbookCreated"] = DateTime.Today;
                r["Active"] = false;
            }
            DataTable dtusers = Cookbook.GetWebUserList();
            WindowsFormsUtility.SetListBinding(lstWebUserName, dtusers, dtcookbook, "WebUser");
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCookbookPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateCookbookCreated, bindsource);
            cbActive.DataBindings.Add("Checked", bindsource, "Active", true, DataSourceUpdateMode.OnPropertyChanged);
            this.Text = GetCookbookDesc();
            SetButtonState();
        }
        


        private string GetCookbookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = "Cookbook - " + SQLUtility.GetValueFromFirstRowAsString(dtcookbook, "CookbookName");
            }
            return value;
        }

        private void SetButtonState()
        {
            btnDelete.Enabled = cookbookid > 0;
            btnRecipeSave.Enabled = cookbookid > 0;
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Save(dtcookbook);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtcookbook, "CookbookId");
                this.Tag = cookbookid;


                dtcookbook = Cookbook.Load(cookbookid);
                bindsource.DataSource = dtcookbook;
                bindsource.ResetBindings(false);
                SetButtonState();

                b = true;
                this.Text = GetCookbookDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cookbook");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void Delete()
        {
        
            var response = MessageBox.Show("Are you sure you want to delete this Cookbook?", "Cookbook", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Delete(dtcookbook);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cookbook");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void LoadRecipeCookbook()
        {
            dtrecipecookbook = RecipeCookbook.LoadByCookbookId(cookbookid);
            gData.Columns.Clear();
            gData.AutoGenerateColumns = true;
            gData.DataSource = dtrecipecookbook;

            WindowsFormsUtility.AddComboBoxToGrid(gData, DataMaintenance.GetDataList("Recipe", true), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gData, "RecipeCookbook");
            gData.AutoGenerateColumns = false;

        }

        private void RefreshPrice()
        {
            if (isautocreated)
            {
                dtcookbook.Rows[0]["CookbookPrice"] = dtrecipecookbook.Rows.Count * 1.33m;
                Cookbook.Save(dtcookbook);
                bindsource.ResetBindings(false);
            }
        }

        private void ShowRecipeCookbookColumns()
        {
            gData.Columns["RecipeName"].Visible = false;
            gData.Columns["RecipeSequence"].HeaderText = "Sequence";
        }

        private void SaveRecipeCookbook()
        {
        
            Application.UseWaitCursor = true;

            try
            {
                RecipeCookbook.SaveTable(dtrecipecookbook, cookbookid);
                RefreshPrice();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        

        private void DeleteRecipeCookbook(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, "RecipeCookbookId");
            if (id > 0)
            {
                try
                {
                    RecipeCookbook.Delete(id);
                    LoadRecipeCookbook();
                    ShowRecipeCookbookColumns();
                    RefreshPrice();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gData.Rows.Count)
            {
                gData.Rows.RemoveAt(rowindex);
            }
        }


        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && gData.Columns[e.ColumnIndex].Name == deletecolname)
            {
                DeleteRecipeCookbook(e.RowIndex);
            }
        }

        private void FrmCookbook_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtcookbook))
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

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnRecipeSave_Click(object? sender, EventArgs e)
        {
            SaveRecipeCookbook();
        }

    }
}
