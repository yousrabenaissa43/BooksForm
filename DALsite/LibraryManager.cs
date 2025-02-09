
using BLsite ; 
namespace DALsite
{
    public static class LibraryManager
    {
        // Ajoute un SpellBook dans la base de données.
        public static void AddSpellBook(int serial, string title,int value,  MagicType typeOfMagic)
        {
            using (var context = new LibraryContext())
            {
                var spellBook = new SpellBook { Serial = serial , Title = title, Value = value ,  magicType = typeOfMagic }; 
                context.SpellBooks?.Add(spellBook);
                context.SaveChanges();
            }
        }

        // Ajoute un RecipeBook dans la base de données.
        public static void AddRecipeBook(int serial, string title, int value, int numberOfRecipes)
        {
            using (var context = new LibraryContext())
            {
                var recipeBook = new RecipeBook { Serial = serial, Title = title, Value = value, NumberOfRecipes = numberOfRecipes };
                context.RecipeBooks?.Add(recipeBook);
                context.SaveChanges();
            }
        }
        /// Ajoute un livre (SpellBook ou RecipeBook) en fonction des paramètres.
        public static void AddBook(int serial, string title, MagicType? typeOfMagic, int? numberOfRecipes)
        {
            using (var context = new LibraryContext())
            {
                if (typeOfMagic.HasValue) // Si un type de magie est fourni, c'est un SpellBook
                {
                    var spellBook = new SpellBook(serial, title, typeOfMagic.Value );
                    context.SpellBooks.Add(spellBook);
                }
                else if (numberOfRecipes.HasValue) // Si un nombre de recettes est fourni, c'est un RecipeBook
                {
                    var recipeBook = new RecipeBook ( serial,  title,  numberOfRecipes.Value );
                    context.RecipeBooks.Add(recipeBook);
                }

                context.SaveChanges();
            }
        }

        // Récupère tous les SpellBooks de la base de données.
        public static List<SpellBook> GetAllSpellBooks()
        {
            using (var context = new LibraryContext())
            {
                return context.SpellBooks.ToList();
            }
        }

        //Récupère tous les RecipeBooks de la base de données.
        public static List<RecipeBook> GetAllRecipeBooks()
        {
            using (var context = new LibraryContext())
            {
                return context.RecipeBooks.ToList();
            }
        }

        // Récupère tous les livres (SpellBooks et RecipeBooks) de la base de données.
        public static List<Book> GetAllBooks()
        {
            using (var context = new LibraryContext())
            {
                var books = new List<Book>();
                books.AddRange(context.SpellBooks);
                books.AddRange(context.RecipeBooks);
                return books;
            }
        }
    }
}