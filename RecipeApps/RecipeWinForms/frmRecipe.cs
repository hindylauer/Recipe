namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe = new();

        DataTable dtrecipeingredient = new();

        DataTable dtdirection = new();
        BindingSource bindsource = new();

        int recipeid = 0;

        string deletecolname = "deletecol";
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            btnIngredientsSave.Click += BtnIngredientsSave_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            btnStepsSave.Click += BtnStepsSave_Click;
            gSteps.CellContentClick += GSteps_CellContentClick;
            this.FormClosing += FrmRecipe_FormClosing;
            this.Shown += FrmRecipe_Shown;
            
        }



        private void FrmRecipe_Shown(object? sender, EventArgs e)
        {
            LoadRecipeIngredients();
            LoadRecipeDirections();

            ShowRecipeIngredientColumns();
            ShowRecipeDirectionColumns();
        }

        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;

            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;

            if (recipeid == 0)
            {

                DataRow r = dtrecipe.Rows.Add();
                r["DateDrafted"] = DateTime.Today;
            }
            DataTable dtusers = Recipe.GetWebUserList();
            DataTable dtcuisines = Recipe.GetCuisineList();
            WindowsFormsUtility.SetListBinding(lstWebUserName, dtusers, dtrecipe, "WebUser");
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisines, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtAmountCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bindsource);
            this.Text = GetRecipeDesc();
            SetButtonState();
        }

        private void LoadRecipeIngredients()
        {
            dtrecipeingredient = RecipeIngredient.LoadByRecipeId(recipeid);
            gIngredients.Columns.Clear();
            gIngredients.AutoGenerateColumns = true;
            gIngredients.DataSource = dtrecipeingredient;

            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Measurement"), "Measurement", "MeasurementDesc");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");
            gIngredients.AutoGenerateColumns = false;
        }
        private void ShowRecipeIngredientColumns()
        {
            gIngredients.Columns["RecipeIngredientId"].Visible = false;
            gIngredients.Columns["RecipeId"].Visible = false;
            gIngredients.Columns["IngredientId"].Visible = false;
            gIngredients.Columns["MeasurementId"].Visible = false;
            gIngredients.Columns["IngredientName"].Visible = false;
            gIngredients.Columns["MeasurementDesc"].Visible = false;


            gIngredients.Columns["Ingredient"].DisplayIndex = 0;
            gIngredients.Columns["Measurement"].DisplayIndex = 1;
            gIngredients.Columns["MeasurementAmount"].DisplayIndex = 2;
            gIngredients.Columns["IngredientSequence"].DisplayIndex = 3;
            gIngredients.Columns[deletecolname].DisplayIndex = 4;

            gIngredients.Columns["MeasurementAmount"].HeaderText = "Quantity";
            gIngredients.Columns["IngredientSequence"].HeaderText = "Sequence";

            gIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadRecipeDirections()
        {
            dtdirection = RecipeStep.LoadByRecipeId(recipeid);
            gSteps.Columns.Clear();
            gSteps.AutoGenerateColumns = true;
            gSteps.DataSource = dtdirection;

            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gSteps, "Direction");
            gSteps.AutoGenerateColumns = false;

        }


        private void ShowRecipeDirectionColumns()
        {
            gSteps.Columns["DirectionId"].Visible = false;
            gSteps.Columns["RecipeId"].Visible = false;


            gSteps.Columns["RecipeDirection"].DisplayIndex = 0;
            gSteps.Columns["RecipeSequence"].DisplayIndex = 1;
            gSteps.Columns[deletecolname].DisplayIndex = 2;

            gSteps.Columns["RecipeDirection"].HeaderText = "Step";
            gSteps.Columns["RecipeSequence"].HeaderText = "Sequence";


            gSteps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void SetButtonState()
        {
            btnDelete.Enabled = recipeid > 0;
            btnChangeStatus.Enabled = recipeid > 0;
            btnIngredientsSave.Enabled = recipeid > 0;
            btnStepsSave.Enabled = recipeid > 0;
        }

        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = "Recipe - " + SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }

        public void ReloadRecipe()
        {
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;
            bindsource.ResetBindings(false);
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                if(WindowsFormsUtility.IsValidNumber(txtAmountCalories, "AmountCalories") == false)
                {
                    return false;
                }
                Recipe.Save(dtrecipe);
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Tag = recipeid;


                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;
                bindsource.ResetBindings(false);
                SetButtonState();

                b = true;
                this.Text = GetRecipeDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }


        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this Recipe?", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void SaveRecipeIngredient()
        {
            Application.UseWaitCursor = true;

            try
            {
                RecipeIngredient.SaveTable(dtrecipeingredient, recipeid);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void DeleteRecipeIngredient(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gIngredients, rowindex, "RecipeIngredientId");
            if(id > 0)
            {
                try
                {
                    RecipeIngredient.Delete(id);
                    LoadRecipeIngredients();
                    ShowRecipeIngredientColumns();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if(id < gIngredients.Rows.Count)
            {
                gIngredients.Rows.RemoveAt(rowindex);
            }
        }

        private void SaveRecipeDirection()
        {
            Application.UseWaitCursor = true;

            try
            {
                RecipeStep.SaveTable(dtdirection, recipeid);
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

        private void DeleteRecipeDirection(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gSteps, rowindex, "DirectionId");
            if (id > 0)
            {
                try
                {
                    RecipeStep.Delete(id);
                    LoadRecipeDirections();
                    ShowRecipeDirectionColumns();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gSteps.Rows.Count)
            {
                gSteps.Rows.RemoveAt(rowindex);
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            frmMain main = (frmMain)this.MdiParent;
            main.OpenForm(typeof(frmChangeStatus), recipeid);
        }

        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            gIngredients.CommitEdit(DataGridViewDataErrorContexts.Commit);
            gIngredients.EndEdit();
            gSteps.EndEdit();
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtrecipe) || SQLUtility.TableHasChanges(dtrecipeingredient) || SQLUtility.TableHasChanges(dtdirection))
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

        private void BtnIngredientsSave_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredient();
        }

        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && gIngredients.Columns[e.ColumnIndex].Name == deletecolname)
            {
                if (gIngredients.Rows[e.RowIndex].Cells[deletecolname].Value?.ToString() == "X")
                {
                    DeleteRecipeIngredient(e.RowIndex);
                }
            }
        }

        private void BtnStepsSave_Click(object? sender, EventArgs e)
        {
            SaveRecipeDirection();
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && gSteps.Columns[e.ColumnIndex].Name == deletecolname)
            {
                if (gSteps.Rows[e.RowIndex].Cells[deletecolname].Value?.ToString() == "X")
                {
                    DeleteRecipeDirection(e.RowIndex);
                }   
            }

        }
    }
}
