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
            string sql = "select * from recipe r where r.RecipeId =" + recipeid.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            lblRecipe.DataBindings.Add("Text", dt, "RecipeName");
            txtDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            txtDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            txtDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            txtRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            txtAmountCalories.DataBindings.Add("Text", dt, "AmountCalories");

            this.Show();
        }
    }
}
