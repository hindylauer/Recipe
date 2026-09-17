namespace RecipeWinForms
{
    public partial class frmAutoCreateCookbook : Form
    {
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            BindData();
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }



        private void BindData()
        {
            DataTable dt = DataMaintenance.GetDataList("WebUser");

            dt.Columns.Add("WebUserFullName");

            foreach (DataRow r in dt.Rows)
            {
                r["WebUserFullName"] =
                    r["WebUserFirstName"] + " " + r["WebUserLastName"];
            }

            lstWebUserName.DataSource = dt;
            lstWebUserName.ValueMember = "WebUserId";
            lstWebUserName.DisplayMember = "WebUserFullName";
        }

        private void AutoCreateCookbookWithItsRecipes()
        {
            int basedonid = WindowsFormsUtility.GetIdFromComboBox(lstWebUserName);
            Cursor = Cursors.WaitCursor;

            try
            {
                int cookbookid = RecipeCookbook.AutoCreateCookbook(basedonid);

                frmMain main = (frmMain)this.MdiParent;
                main.OpenForm(typeof(frmCookbook), cookbookid, true);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            AutoCreateCookbookWithItsRecipes();
        }
    }
}
