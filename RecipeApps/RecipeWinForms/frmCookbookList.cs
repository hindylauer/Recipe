namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            gData.CellDoubleClick += GData_CellDoubleClick;
            gData.KeyDown += GData_KeyDown;
            btnNewCookbook.Click += BtnNewCookbook_Click;
            this.Activated += FrmCookbook_Activated;
        }


        private void FrmCookbook_Activated(object? sender, EventArgs e)
        {
            BindData();
            ShowCookbookColumns();
        }

        private void BindData()
        {
            DataTable dt = Cookbook.GetList();
            gData.DataSource = dt;
            gData.AllowUserToAddRows = false;
            gData.ReadOnly = true;
        }

        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;

            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gData, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), id);
            }

        }

        private void ShowCookbookColumns()
        {
            gData.Columns["CookbookId"].Visible = false;

            gData.Columns["CookbookName"].HeaderText = "Cookbook Name";
            gData.Columns["CookbookName"].DisplayIndex = 0;

            gData.Columns["Author"].HeaderText = "User";
            gData.Columns["Author"].DisplayIndex = 1;

            gData.Columns["NumRecipes"].HeaderText = "Num Recipes";
            gData.Columns["NumRecipes"].DisplayIndex = 2;

            gData.Columns["CookbookPrice"].HeaderText = "Price";
            gData.Columns["CookbookPrice"].DisplayIndex = 3;

            WindowsFormsUtility.FormatGridForEdit(gData, "Cookbook");
        }


        private void GData_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gData.SelectedRows.Count > 0)
            {
                ShowCookbookForm(gData.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void GData_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }

    }
}
