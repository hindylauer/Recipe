namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            btnNewRecipe.Click += BtnNewRecipe_Click;
            gData.CellDoubleClick += GData_CellDoubleClick;
            gData.KeyDown += GData_KeyDown;
            this.Activated += FrmRecipeList_Activated;
        }



        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
            ShowRecipeColumns();
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;

            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }

        }



        private void BindData()
        {
            DataTable dt = Recipe.GetList();
            gData.DataSource = dt;
            
            gData.AllowUserToAddRows = false;
            gData.ReadOnly = true;
        }

        private void ShowRecipeColumns()
        {
            gData.Columns["RecipeName"].DisplayIndex = 0;
            gData.Columns["RecipeName"].HeaderText = "Recipe Name";

            gData.Columns["RecipeStatus"].DisplayIndex = 1;
            gData.Columns["RecipeStatus"].HeaderText = "Status";

            gData.Columns["WebUserName"].DisplayIndex = 2;
            gData.Columns["WebUserName"].HeaderText = "User";

            gData.Columns["AmountCalories"].DisplayIndex = 3;
            gData.Columns["AmountCalories"].HeaderText = "Calories";

            gData.Columns["NumIngredients"].DisplayIndex = 4;
            gData.Columns["NumIngredients"].HeaderText = "Num Ingredients";

            gData.Columns["RecipeId"].Visible = false;

            WindowsFormsUtility.FormatGridForEdit(gData, "Recipe");
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }


        private void GData_KeyDown(object? sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && gData.SelectedRows.Count > 0)
            {
                ShowRecipeForm(gData.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void GData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
                ShowRecipeForm(e.RowIndex);
        }

    }
}
