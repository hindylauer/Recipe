namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
            CenterDataGridView();
        }

        private void BindData()
        {
            DataTable dt = DataMaintenance.GetDashboard();
            gData.DataSource = dt;
            ShowDashboardColumns();
        }

        private void CenterDataGridView()
        {
            gData.Width =
                gData.RowHeadersWidth +
                gData.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) + 2;

            gData.Height =
                gData.ColumnHeadersHeight +
                gData.Rows.GetRowsHeight(DataGridViewElementStates.Visible) + 2;

            gData.Left = (this.ClientSize.Width - gData.Width) / 2;
        }
        private void ShowForm(Type formtype)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(formtype);
            }
        }

        private void ShowDashboardColumns()
        {
            gData.Columns["DashboardType"].HeaderText = "Type";
            gData.Columns["Num"].HeaderText = "Number";
            gData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gData.RowHeadersWidth = 25;
            gData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            gData.AllowUserToAddRows = false;
            gData.ReadOnly = true;
        }
        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmCookbookList));
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmMealList));
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmRecipeList));
        }


    }
}
