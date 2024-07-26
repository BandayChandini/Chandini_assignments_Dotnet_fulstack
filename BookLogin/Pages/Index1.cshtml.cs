using BookLogin.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLogin.Pages
{
    public class Index1Model : PageModel
    {
        static List<Book> books = new List<Book>()
        {
            new Book(){BookId=1,Name="Abc",Price=1000,Language="english",Author="xyz"},
            new Book(){BookId=2,Name="Abd",Price=2000,Language="telugu",Author="xyz"},
            new Book(){BookId=3,Name="Abe",Price=1500,Language="hindi",Author="xyz"},
        };
        [BindProperty]
        public Book Book { get; set; }
        public List<Book> List
        {
            get { return books; }
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            books.Add(Book);
            return RedirectToPage("Index1");
        }
    }
}
