using BLsite;
using DALsite;

namespace BookForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeForm());
            //LibraryManager.AddSpellBook(1, "cookies", MagicType.Transmutation);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
           
            //Book book1 = new SpellBook(1, "cookies", MagicType.Transmutation);
           
            /*List<Book> books = LibraryManager.GetAllBooks();
            foreach (Book book in books)
            {
               Console.WriteLine( book.getInfos());

            }*/
            
        }
    }
}