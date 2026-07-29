using System.Data;
using CPUWindowsFormsFramework;
using Microsoft.VisualBasic;
using RecipeSystem;


namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            
        }


        public void ShowForm(int recipeid)
        {
            dtrecipe = Recipe.Load(recipeid);
            if(recipeid == 0)
            {
                DataRow r = dtrecipe.Rows.Add();
                r["RecipeId"] = 0;
                r["DateDrafted"] = DateTime.Today;
            }
            DataTable dtusers = Recipe.GetWebUserList();
            DataTable dtcuisines = Recipe.GetCuisineList();

            WindowsFormsUtility.SetListBinding(lstWebUserName, dtusers, dtrecipe, "WebUser");
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisines, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WindowsFormsUtility.SetControlBinding(dtpDateDrafted, dtrecipe);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, dtrecipe);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, dtrecipe);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, dtrecipe);
            WindowsFormsUtility.SetControlBinding(txtAmountCalories, dtrecipe);

            this.Show();
        }

        private bool IsValid()
        {
            string msg = "";

            if (txtRecipeName.Text.Trim() == "")
            {
                msg += "Recipe name is required.\n";
            }
            if (txtAmountCalories.Text.Trim() == "")
            {
                msg += "Amount Calories is required.\n";
            }
            if (lstWebUserName.SelectedIndex == -1)
            {
                msg += "User is required.\n";
            }
            if (lstCuisineName.SelectedIndex == -1)
            {
                msg += "Cuisine is required.\n";
            }
            if(msg != "")
            {
                MessageBox.Show(msg, "Recipe");
                return false;
            }
            return true;
        }

        private void Save()
        {
            if (IsValid() == false)
            {
                return;
            }

            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }


        private void Delete()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
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
