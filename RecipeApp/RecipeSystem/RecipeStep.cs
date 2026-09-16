namespace RecipeSystem
{
    public class RecipeStep
    {
        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("DirectionGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveTable(DataTable dt, int recipeid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            {
                r["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, "DirectionUpdate");
        }

        public static void Delete(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("DirectionDelete");
            cmd.Parameters["@DirectionId"].Value = recipeid;
            SQLUtility.ExecuteSql(cmd);
        }
    }
}
