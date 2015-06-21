using PWIProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PWIProj.DAL
{
    public class RecipiesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RecipiesContext>
    {
        protected override void Seed(RecipiesContext context)
        {
//            var students = new List<Recipe>
//            {
//            new Recipe{Category=RecipeCategory.Drink, Title="Alexander", Description="Famous dring created from cream, brandy and chocolate liquer", IngredientsList={"Brandy", "Chocolate Liqeur", "Cream", "Ice"}, AddDate = DateTime.Parse("2005-09-01"), PictureURL="http://farm9.staticflickr.com/8479/8246034506_029fd92a96_o.jpg"}
//            };

//            students.ForEach(s => context.Students.Add(s));
//            context.SaveChanges();
        }
    }
}