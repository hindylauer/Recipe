using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CPUFramework;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipes(string recipe)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipe;
            cmd.Parameters["@All"].Value = string.IsNullOrWhiteSpace(recipe);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetWebUserList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("WebUserGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;            
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetRecipeList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtrecipe)
        {
            DataRow r = dtrecipe.Rows[0];
            int id = 0;
            if(r["RecipeId"] != DBNull.Value)
            {
                id = (int)r["RecipeId"];
            }
                
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
                sql = "insert recipe(WebUserId, CuisineId, RecipeName, DateDrafted, AmountCalories) ";
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
