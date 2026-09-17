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

        //public static DataTable GetRecipe()
        //{
        //    DataTable dt = new();
        //    SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
        //    cmd.Parameters["@All"].Value = 1;
        //    dt = SQLUtility.GetDataTable(cmd);
        //    return dt;
        //}

        public static void Save(DataTable dtrecipe)
        {
            if(dtrecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call Recipe Save method because there are no rows in the table.");
            }
            DataRow r = dtrecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSql(cmd);
        }

        public static DataTable GetList()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            return SQLUtility.GetDataTable(cmd);

        }

        public static int CreateRecipeBasedOnPrevious(int basedonrecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeCreateBasedOnPrevious");
            SQLUtility.SetParamValue(cmd, "@BaseRecipeId", basedonrecipeid);
            SQLUtility.ExecuteSql(cmd);
            return (int)cmd.Parameters["@RecipeId"].Value;
        }
        


    }
}
