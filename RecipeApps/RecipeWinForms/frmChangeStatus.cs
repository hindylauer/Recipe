namespace RecipeWinForms
{
    public partial class frmChangeStatus : Form
    {
        DataTable dtrecipe;
        int recipeid = 0;

        BindingSource bindsource = new();

        public frmChangeStatus()
        {
            InitializeComponent();
            btnDraft.Click += StatusChoice;
            btnPublish.Click += StatusChoice;
            btnArchive.Click += StatusChoice;
        }

        public void LoadForm(int recipeidval)
        {
            recipeid = recipeidval;
            dtrecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtrecipe;

            WindowsFormsUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bindsource);

            SetButtonState();
        }

        private void SetButtonState()
        {
            btnDraft.Enabled = true;
            btnPublish.Enabled = true;
            btnArchive.Enabled = true;

            string currentstatus = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeStatus");

            switch (currentstatus)
            {
                case "Drafted":
                    btnDraft.Enabled = false;
                    break;

                case "Published":
                    btnPublish.Enabled = false;
                    break;

                case "Archived":
                    btnArchive.Enabled = false;
                    break;
            }
        }

        private void StatusChoice(object? sender, EventArgs e)
        {
            Button btn = (Button)sender;

            var response = MessageBox.Show("Are you sure you want to change this recipe to " + btn.Text + "?", "Change Status", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }

            Application.UseWaitCursor = true;

            try
            {
                if(btn == btnDraft)
                {
                    dtrecipe.Rows[0]["DateDrafted"] = DateTime.Today;
                    dtrecipe.Rows[0]["DatePublished"] = DBNull.Value;
                    dtrecipe.Rows[0]["DateArchived"] = DBNull.Value;
                }
                else if(btn == btnPublish)
                {
                    dtrecipe.Rows[0]["DatePublished"] = DateTime.Today;
                    dtrecipe.Rows[0]["DateArchived"] = DBNull.Value;
                }
                else if(btn == btnArchive)
                {
                    dtrecipe.Rows[0]["DateArchived"] = DateTime.Today;
                }
                Recipe.Save(dtrecipe);
                dtrecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtrecipe;
                lblRecipeStatus.Text = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeStatus");
                SetButtonState();

                frmMain main = (frmMain)this.MdiParent;

                foreach (Form f in main.MdiChildren)
                {
                    if (f is frmRecipe)
                    {
                        frmRecipe recipe = (frmRecipe)f;
                        recipe.ReloadRecipe();
                        break;
                    }
                }

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

    }
}
