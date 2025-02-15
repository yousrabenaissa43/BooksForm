
using BLsite ; 
namespace DALsite
{
    public static class LibraryManager
    {
        // Ajoute un SpellBook dans la base de données.
        public static void AddSpellBook(int serial, string title, MagicType typeOfMagic)
        {
            using (var context = new LibraryContext())
            {
                var spellBook = new SpellBook { Serial = serial , Title = title,  magicType = typeOfMagic }; 
                context.SpellBooks?.Add(spellBook);
                spellBook.CalculatedExtandedValue();
                context.SaveChanges();
            }
        }

        // Ajoute un RecipeBook dans la base de données.
        public static void AddRecipeBook(int serial, string title,  int numberOfRecipes)
        {
            using (var context = new LibraryContext())
            {
                var recipeBook = new RecipeBook { Serial = serial, Title = title, NumberOfRecipes = numberOfRecipes };
                recipeBook.CalculatedExtandedValue();
                context.RecipeBooks?.Add(recipeBook);
                context.SaveChanges();
            }
        }
        /// Ajoute un livre (SpellBook ou RecipeBook) en fonction des paramètres.
        public static void AddBook(int serial, string title,int value, MagicType? typeOfMagic, int? numberOfRecipes)
        {
            using (var context = new LibraryContext())
            {
                if (typeOfMagic.HasValue) // Si un type de magie est fourni, c'est un SpellBook
                {
                    var spellBook = new SpellBook { Serial = serial, Title = title, magicType = typeOfMagic.Value };
                    context.SpellBooks.Add(spellBook);
                }
                else if (numberOfRecipes.HasValue) // Si un nombre de recettes est fourni, c'est un RecipeBook
                {
                    var recipeBook = new RecipeBook { Serial = serial, Title = title, Value = value, NumberOfRecipes = numberOfRecipes.Value };
                    context.RecipeBooks.Add(recipeBook);
                }

                context.SaveChanges();
            }
        }
        // Ajoute un Author
        public static void AddAuthor( string name, string biography)
        {
            using (var context = new LibraryContext())
            {
                var author = new Author { Name = name, Biography = biography };
                context.Authors.Add(author);
                context.SaveChanges();
            }
        }
        // Ajoute un LibraryMember
        public static void AddLibraryMember( string fullName, string email)
        {
            using (var context = new LibraryContext())
            {
                var member = new LibraryMember { FullName = fullName, Email = email };
                context.LibraryMembers.Add(member);
                context.SaveChanges();
            }
        }
        // Ajoute un Loan
        public static void AddLoan( int bookId, int memberId, DateTime loanDate, DateTime dueDate, DateTime? returnDate = null)
        {
            using (var context = new LibraryContext())
            {
                var loan = new Loan
                {
                    
                    BookId = bookId,
                    MemberId = memberId,
                    LoanDate = loanDate,
                    DueDate = dueDate,
                    ReturnDate = returnDate
                };
                context.Loans.Add(loan);
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
        //Récupère tous les Authors 
        public static List<Author> GetAuthors()
        {
            using (var context = new LibraryContext())
            {
                return context.Authors.ToList();
            }
        }
        //Récupère tous les LibraryMembers
        public static List<LibraryMember> GetLibraryMembers()
        {
            using (var context = new LibraryContext())
            {
                return context.LibraryMembers.ToList();
            }
        }
        //Récupère tous les Loans
        public static List<Loan> GetLoans()
        {
            using (var context = new LibraryContext())
            {
                return context.Loans.ToList();
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