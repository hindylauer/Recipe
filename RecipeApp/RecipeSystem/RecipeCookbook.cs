namespace RecipeSystem
{
    public class RecipeCookbook
    {
        public static DataTable LoadByCookbookId(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeCookbookGet");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveTable(DataTable dt, int cookbookid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["CookbookId"] = cookbookid;
            }
            SQLUtility.SaveDataTable(dt, "RecipeCookbookUpdate");
        }

        public static void Delete(int recipecookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeCookbookDelete");
            cmd.Parameters["@RecipeCookbookId"].Value = recipecookbookid;
            SQLUtility.ExecuteSql(cmd);
        }

        public static int AutoCreateCookbook(int webuserid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeCookbookUserGet");
            SQLUtility.SetParamValue(cmd, "@WebUserId", webuserid);

            DataTable dtrecipes = SQLUtility.GetDataTable(cmd);

            if(dtrecipes.Rows.Count == 0)
            {
                throw new Exception("This user has no recipes.");
            }

            DataTable dtcookbook = Cookbook.Load(0);
            DataRow r = dtcookbook.Rows.Add();

            r["WebUserId"] = webuserid;
            r["CookbookName"] = dtrecipes.Rows[0]["CookbookName"];
            r["CookbookPrice"] = dtrecipes.Rows.Count * 1.33m;
            r["DateCookbookCreated"] = DateTime.Today;
            r["Active"] = false;

            int cookbookid = Cookbook.Save(dtcookbook);

            DataTable dtrecipecookbook = RecipeCookbook.LoadByCookbookId(cookbookid);

            foreach(DataRow reciperow in dtrecipes.Rows)
            {
                DataRow dr = dtrecipecookbook.Rows.Add();

                dr["RecipeId"] = reciperow["RecipeId"];
                dr["CookbookId"] = cookbookid;
                dr["RecipeSequence"] = reciperow["RecipeSequence"];
            }

            RecipeCookbook.SaveTable(dtrecipecookbook, cookbookid);

            return cookbookid;

            
        }

    }
}
