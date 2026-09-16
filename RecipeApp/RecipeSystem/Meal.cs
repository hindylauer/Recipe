namespace RecipeSystem
{
    public class Meal
    {
        public static DataTable Load(int mealid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("MealGet");
            cmd.Parameters["@MealId"].Value = mealid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetList()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("MealGetList");
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetWebUserList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("WebUserGet");
            cmd.Parameters["@All"].Value = 1;
            cmd.Parameters["@IncludeBlank"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtmeal)
        {
            if (dtmeal.Rows.Count == 0)
            {
                throw new Exception("Cannot call Meal Save method because there are no rows in the table.");
            }
            DataRow r = dtmeal.Rows[0];
            SQLUtility.SaveDataRow(r, "MealUpdate");
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["MealId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("MealDelete");
            SQLUtility.SetParamValue(cmd, "@MealId", id);
            SQLUtility.ExecuteSql(cmd);
        }

    }
}
