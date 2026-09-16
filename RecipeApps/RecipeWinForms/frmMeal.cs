namespace RecipeWinForms
{
    public partial class frmMeal : Form
    {
        DataTable dtmeal;
        int mealid = 0;

        BindingSource bindsource = new();
        public frmMeal()
        {
            InitializeComponent();
            optActive.CheckedChanged += OptActive_CheckedChanged;
            optInactive.CheckedChanged += OptInactive_CheckedChanged;
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }



        public void LoadForm(int mealidval)
        {
            mealid = mealidval;
            this.Tag = mealid;

            dtmeal = Meal.Load(mealid);
            bindsource.DataSource = dtmeal;

            DataTable dtusers = Meal.GetWebUserList();
            WindowsFormsUtility.SetListBinding(lstWebUserName, dtusers, dtmeal, "WebUser");
            WindowsFormsUtility.SetControlBinding(txtMealName, bindsource);
            WindowsFormsUtility.SetControlBinding(lstWebUserName, bindsource);
            WindowsFormsUtility.SetControlBinding(dtpDateMealCreated, bindsource);
            optActive.Checked = Convert.ToBoolean(dtmeal.Rows[0]["Active"]);
            optInactive.Checked = !optActive.Checked;
            this.Text = GetMealDesc();
            //SetButtonState();
        }

        private string GetMealDesc()
        {
            string value = "";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtmeal, "MealId");
            if (pkvalue > 0)
            {
                value = "Meal - " + SQLUtility.GetValueFromFirstRowAsString(dtmeal, "MealName");
            }
            return value;
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Meal.Save(dtmeal);
                mealid = SQLUtility.GetValueFromFirstRowAsInt(dtmeal, "MealId");
                this.Tag = mealid;


                dtmeal = Meal.Load(mealid);
                bindsource.DataSource = dtmeal;
                bindsource.ResetBindings(false);
                //SetButtonState();

                b = true;
                this.Text = GetMealDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Meal");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void OptInactive_CheckedChanged(object? sender, EventArgs e)
        {
            if(optInactive.Checked && dtmeal.Rows.Count > 0)
            {
                dtmeal.Rows[0]["Active"] = false;
            }
        }

        private void OptActive_CheckedChanged(object? sender, EventArgs e)
        {
            if(optActive.Checked && dtmeal.Rows.Count > 0)
            {
                dtmeal.Rows[0]["Active"] = true;
            }
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this Meal?", "Meal", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Meal.Delete(dtmeal);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Meal");
            }
            finally
            {
                Application.UseWaitCursor = false;
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
    }
}
