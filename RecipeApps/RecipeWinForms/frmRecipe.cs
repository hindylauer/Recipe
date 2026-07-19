using System.Data;
using CPUWindowsFormsFramework;
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
                dtrecipe.Rows.Add();
            }
            DataTable dtusers = Recipe.GetRecipeList();
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



        private void Save()
        {
            Recipe.Save(dtrecipe);
        }


        private void Delete()
        {
            Recipe.Delete(dtrecipe);
            this.Close();
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
