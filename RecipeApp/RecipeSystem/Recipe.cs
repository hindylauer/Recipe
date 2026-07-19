using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using CPUFramework;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipes(string recipe)
        {
            string sql = "select RecipeId, RecipeName, RecipeStatus, AmountCalories from recipe r where RecipeName like '%" + recipe + "%'";

            DataTable dt = SQLUtility.GetDataTable(sql);

            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            string sql = "select r.*, w.WebUserName, c.CuisineName from recipe r left join WebUser w on r.WebUserId = w.WebUserId left join Cuisine c on r.CuisineId = c.CuisineId where r.RecipeId =" + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetWebUserList()
        {
            return SQLUtility.GetDataTable("select w.WebUserId, w.WebUserName from webuser w");
        }

        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("select c.CuisineId, c.CuisineName from Cuisine c");
        }

        public static DataTable GetRecipeList()
        {
            return SQLUtility.GetDataTable("select RecipeId, RecipeName, RecipeStatus, AmountCalories from Recipe");
        }

        public static void Save(DataTable dtrecipe)
        {
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";

            if (id > 0)
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

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            string sql = "delete recipe where RecipeId = " + id;
            SQLUtility.ExecuteSql(sql);
        }


    }
}
