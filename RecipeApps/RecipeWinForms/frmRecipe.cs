using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }


        public void ShowForm(int recipeid)
        {
            string sql = "select r.*, w.WebUserName, c.CuisineName from recipe r left join WebUser w on r.WebUserId = w.WebUserId left join Cuisine c on r.CuisineId = c.CuisineId where r.RecipeId =" + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            txtUser.DataBindings.Add("Text", dt, "WebUserName");
            txtCuisine.DataBindings.Add("Text", dt, "CuisineName");
            dtpDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            lblDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            lblDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            lblRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            txtAmountCalories.DataBindings.Add("Text", dt, "AmountCalories");

            this.Show();
        }


    }
}
