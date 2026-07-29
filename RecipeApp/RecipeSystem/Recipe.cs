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
                    $"WebUserId =  {SQLUtility.SqlValue(r["WebUserId"])}",
                    $"CuisineId =  {SQLUtility.SqlValue(r["CuisineId"])}",
                    $"RecipeName = {SQLUtility.SqlValue(r["RecipeName"])}",
                    $"DateDrafted = {SQLUtility.SqlValue(r["DateDrafted"])}",
                    $"AmountCalories = {SQLUtility.SqlValue(r["AmountCalories"])}",
                    $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert recipe(WebUserId, CuisineId, RecipeName, DateDrafted, AmountCalories) ";
                sql += $"select {SQLUtility.SqlValue(r["WebUserId"])}, {SQLUtility.SqlValue(r["CuisineId"])}, {SQLUtility.SqlValue(r["RecipeName"])}, {SQLUtility.SqlValue(r["DateDrafted"])}, {SQLUtility.SqlValue(r["AmountCalories"])}";
            }

            SQLUtility.ExecuteSql(sql);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSql(cmd);
        }


    }
}
