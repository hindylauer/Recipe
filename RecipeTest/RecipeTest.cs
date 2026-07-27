using CPUFramework;
using NUnit.Framework.Legacy;
using System.Data;
using System.Numerics;
using System.Security.Cryptography;

namespace RecipeTest
{
    public class RecipeTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=tcp:dev-hindy.database.windows.net,1433;Initial Catalog = HeartyHearthDB;Persist Security Info=False;User ID =hindyadmin; Password=15DoverShalom!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30");
        }

        [Test]
        [TestCase("Chocolate cake", 1, 2, "2020-12-10")]
        [TestCase("Cheese cake", 2, 3, "2021-11-09")]
        public void InsertNewRecipe(string recipename, int webuserid, int cuisineid, DateTime datedrafted)
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
            Assume.That(recipeid > 0, "Can't run test, no recipes in the DB");
            int maxcalories = SQLUtility.GetFirstColumnFirstRowValue("select max(AmountCalories) from recipe");

            maxcalories = maxcalories + 1;
            recipename = recipename +  " " + DateTime.Now.ToString();

            TestContext.WriteLine("insert recipe with AmountCalories = " + maxcalories);

            r["recipename"] = recipename;
            r["webuserid"] = webuserid;
            r["cuisineid"] = cuisineid;
            r["datedrafted"] = datedrafted;
            r["amountcalories"] = maxcalories;

            Recipe.Save(dt);

            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where amountcalories = " + maxcalories);

            ClassicAssert.IsTrue(newid > 0, "recipe with amountcalories = " + maxcalories + " is not found in DB");
            TestContext.WriteLine("Recipe with " + maxcalories + " is found in DB with pk value = " + newid);
           
        }

        [Test]
        public void ChangeExistingRecipeName()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");

            string recipename = SQLUtility.GetFirstColumnFirstRowString("select recipename from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("recipename for recipeid " + recipeid + " is " + recipename);

            recipename = recipename + " great recipe";
            TestContext.WriteLine("change recipename to " + recipename);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["recipename"] = recipename;

            Recipe.Save(dt);
            string newrecipename = SQLUtility.GetFirstColumnFirstRowString("select recipename from recipe where recipeid = " + recipeid);
            ClassicAssert.AreEqual(newrecipename, recipename, "recipename for recipe (" + recipeid + ") = " + newrecipename);

        }

        [Test]
        public void ChangeExistingRecipeDateDrafted()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");

            DateTime datedrafted = SQLUtility.GetFirstColumnFirstRowsDateTime("select datedrafted from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("datedrafted for recipeid " + recipeid + " is " + datedrafted);

            datedrafted = datedrafted.AddDays(1);
            TestContext.WriteLine("change datedrafted to " + datedrafted);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["datedrafted"] = datedrafted;
            
            Recipe.Save(dt);
            DateTime newdatedrafted = SQLUtility.GetFirstColumnFirstRowsDateTime("select datedrafted from recipe where recipeid = " + recipeid);
            ClassicAssert.AreEqual(datedrafted, newdatedrafted, "datedrafted for recipe (" + recipeid + ") = " + newdatedrafted);
            TestContext.WriteLine("datedrafted for recipe(" + recipeid + ") = " + newdatedrafted);
        }


        [Test]
        public void ChangeExistingRecipeToInvalidDateDrafted()
        {
            int recipeid = GetExistingPublishedRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");

            DateTime datedrafted = SQLUtility.GetFirstColumnFirstRowsDateTime("select datedrafted from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("datedrafted for recipeid " + recipeid + " is " + datedrafted);

            DateTime datepublished = SQLUtility.GetFirstColumnFirstRowsDateTime("select datepublished from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("datepublished for recipeid " + recipeid + " is " + datepublished);


            datedrafted = datepublished.AddDays(1);
            TestContext.WriteLine("change datedrafted to " + datedrafted);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["datedrafted"] = datedrafted;

            Exception ex = ClassicAssert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }


        [Test]
        public void ChangeExistingRecipeToInvalidRecipeName()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");

            string recipename = SQLUtility.GetFirstColumnFirstRowString("select recipename from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("recipename for recipeid " + recipeid + " is " + recipename);

            string otherrecipename = SQLUtility.GetFirstColumnFirstRowString("select recipename from recipe where recipeid <> " + recipeid);
            TestContext.WriteLine("recipename for a different recipe is  " + otherrecipename);

            TestContext.WriteLine("change " + recipename + " to " + otherrecipename);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["recipename"] = otherrecipename;

            Exception ex = ClassicAssert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);

        }


        [Test]
        public void ChangeExistingRecipeAmountCalories()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");

            int amountcalories = SQLUtility.GetFirstColumnFirstRowValue("select amountcalories from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("amountcalories for recipeid " + recipeid + " is " + amountcalories);

            amountcalories = amountcalories + 1;
            TestContext.WriteLine("change amount calories to " + amountcalories);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["amountcalories"] = amountcalories;

            Recipe.Save(dt);
            int newamountcalories = SQLUtility.GetFirstColumnFirstRowValue("select amountcalories from recipe where recipeid = " + recipeid);
            ClassicAssert.AreEqual(amountcalories, newamountcalories, "amountcalories for recipe (" + recipeid + ") = " + newamountcalories);
            TestContext.WriteLine("amountcalories for recipe(" + recipeid + ") = " + newamountcalories);
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.RecipeId, r.WebUserId, r.CuisineId, r.RecipeName, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.AmountCalories, r.RecipeImage from recipe r left join RecipeIngredient ri on ri.RecipeId = r.RecipeId left join Direction d on d.RecipeId = r.RecipeId left join RecipeCourseMeal rcm on rcm.RecipeId = r.RecipeId left join RecipeCookBook rcb on rcb.RecipeId = r.recipeid where ri.RecipeId is null and d.RecipeId is null and rcm.RecipeId is null and rcb.RecipeId is null");
            int recipeid = 0;
            Assume.That(dt.Rows.Count > 0, "no recipes without related records in DB, can't test");

            recipeid = (int)dt.Rows[0]["recipeid"];
            TestContext.WriteLine("existing recipe without related records: " + recipeid);

            Recipe.Delete(dt);

            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);

            ClassicAssert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in DB");

            TestContext.WriteLine("Record with recipeid " + recipeid + " doesn't exist in DB");
            
        }

        [Test]
        public void DeleteRecipeWithRecipeIngredient()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.RecipeId, r.WebUserId, r.CuisineId, r.RecipeName, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.AmountCalories, r.RecipeImage from recipe r join RecipeIngredient ri on ri.RecipeId = r.RecipeId left join Direction d on d.RecipeId = r.RecipeId left join RecipeCourseMeal rcm on rcm.RecipeId = r.RecipeId left join RecipeCookBook rcb on rcb.RecipeId = r.recipeid");
            int recipeid = 0;
            if(dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
            }
            Assume.That(recipeid > 0, "No recipes with recipeingredient in DB, can't run test");

            TestContext.WriteLine("existing recipe with recipeingredient, with id = " + recipeid);
            TestContext.WriteLine("ensure that app cannot delete " + recipeid);

            Exception ex = ClassicAssert.Throws<Exception>(() => Recipe.Delete(dt));

            TestContext.WriteLine(ex.Message);

        }



        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, can't run test");
            TestContext.WriteLine("existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);

            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];

            ClassicAssert.IsTrue(loadedid == recipeid, (int)dt.Rows[0]["recipeid"] + " <> " + recipeid);
            TestContext.WriteLine("loaded recipe (" + loadedid + ")");
        }

        [Test]
        public void GetListOfRecipes()
        {
            int recipecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe");
            Assume.That(recipecount > 0, "No recipes in DB, can't test");
            TestContext.WriteLine("Num of recipes in DB = " + recipecount);
            TestContext.WriteLine("Ensure that number of rows returned by app matches " + recipecount);

            DataTable dt = Recipe.GetRecipeList();

            ClassicAssert.IsTrue(dt.Rows.Count == recipecount, "num rows returned by app (" + dt.Rows.Count + ") <>" + recipecount);
            TestContext.WriteLine("Number of rows in recipe returned by the app = " + dt.Rows.Count);
        }

        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe order by newid()");
        }

        private int GetExistingPublishedRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe where datepublished is not null order by newid()");
        }
    }
}
