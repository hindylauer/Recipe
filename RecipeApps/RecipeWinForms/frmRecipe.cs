using CPUFramework;
using System.Data;
using CPUWindowsFormsFramework;


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
            string sql = "select r.*, w.WebUserName, c.CuisineName from recipe r left join WebUser w on r.WebUserId = w.WebUserId left join Cuisine c on r.CuisineId = c.CuisineId where r.RecipeId =" + recipeid.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            if(recipeid == 0)
            {
                dtrecipe.Rows.Add();
            }
            DataTable dtusers = SQLUtility.GetDataTable("select w.WebUserId, w.WebUserName from webuser w");
            DataTable dtcuisines = SQLUtility.GetDataTable("select c.CuisineId, c.CuisineName from Cuisine c");

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
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";

            if(id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                    $"WebUserId = '{r["WebUserId"]}',",
                    $"CuisineId = '{r["CuisineId"]}',",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"DateDrafted = '{r["DateDrafted"]}',",
                    $"AmountCalories = '{r["AmountCalories"]}'",
                    $"where RecipeId = {r["RecipeId"]}"); 
            }
            else
            {
                sql = "insert recipe(WebUserId, CuisineId, RecipeName, DateDrafted, AmountCalories)";
                sql += $"select {r["WebUserId"]}, {r["CuisineId"]}, '{r["RecipeName"]}', '{r["DateDrafted"]}', {r["AmountCalories"]}";
            }

            SQLUtility.ExecuteSql(sql);
        }


        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSql(sql);
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
