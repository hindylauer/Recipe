namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            gData.CellDoubleClick += GData_CellDoubleClick;
            gData.KeyDown += GData_KeyDown;
            this.Activated += FrmMealList_Activated;
        }



        private void FrmMealList_Activated(object? sender, EventArgs e)
        {
            BindData();
            ShowMealColumns();
        }
        
        private void BindData()
        {
            DataTable dt = Meal.GetList();
            gData.DataSource = dt;

            
            gData.AllowUserToAddRows = false;
            gData.ReadOnly = true;
        }

        private void ShowMealForm(int rowindex)
        {
            int id = 0;

            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, "MealId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmMeal), id);
            }

        }

        private void ShowMealColumns()
        {
            gData.Columns["MealName"].DisplayIndex = 0;
            gData.Columns["MealName"].HeaderText = "Meal Name";

            gData.Columns["WebUser"].DisplayIndex = 1;
            gData.Columns["WebUser"].HeaderText = "User";

            gData.Columns["NumCalories"].DisplayIndex = 2;
            gData.Columns["NumCalories"].HeaderText = "Num Calories";

            gData.Columns["NumCourses"].DisplayIndex = 3;
            gData.Columns["NumCourses"].HeaderText = "Num Courses";

            gData.Columns["NumRecipes"].DisplayIndex = 4;
            gData.Columns["NumRecipes"].HeaderText = "Num Recipes";

            WindowsFormsUtility.FormatGridForEdit(gData, "Meal");
        }

        private void GData_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gData.SelectedRows.Count > 0)
            {
                ShowMealForm(gData.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void GData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }
            ShowMealForm(e.RowIndex);
        }
    }
}
