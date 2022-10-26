using Book.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book.Controllers
{

    public class BookController : Controller
    {
        public static string urlImg = "https://assets.reedpopcdn.com/pok-mon-go-jak-zdoby-pikachu-jako-startowego-pokemona-14689433339.png/BROK/resize/690%3E/format/jpg/quality/75/pok-mon-go-jak-zdoby-pikachu-jako-startowego-pokemona-14689433339.png";
        
        public static int booksId = 0;
        
        public static List<BookViewModel> books = new List<BookViewModel>()
        {
            new BookViewModel(){
                Id = booksId++, 
                Author = "Canady Trump",
                DateOfPublication = new DateTime(2002,08,1).Date,
                Price = 6.00,
                Title="Green Book",
                Types = BookType.Anime 
            },
            new BookViewModel(){
                Id = booksId++, 
                Author = "Canady Trump",
                DateOfPublication = new DateTime(2002,08,1).Date,
                Price = 6.00,
                Title="Green Book",
                Types = BookType.Anime 
            },
            new BookViewModel(){
                Id = booksId++,
                Author = "Canady Trump",
                DateOfPublication = new DateTime(2002,08,1).Date,
                Price = 6.00,
                Title="Green Book",
                Types = BookType.Anime
            },
        };


        //================
        //Main
        //================
        public IActionResult Index()
        {
            
            return View(books);
        }


        //================
        //Create
        //================

        [HttpGet]
        [HttpPost]
        public IActionResult BookForm(BookViewModel bookViewModel)
        {

            BookViewModel book = new BookViewModel();
            if (ModelState.IsValid)
            {

                bookViewModel.Id = booksId++;
                books.Add(bookViewModel);
                return View(book);
            }
            else
            {
                return View(book);
            }

        }


        //================
        //Edit
        //================

        [HttpGet]
        public IActionResult BookEdit([FromRoute] int id) {
            BookViewModel book = books[id];
            return View(book);
        }
        [HttpPost]
        public IActionResult BookEdit([FromForm] BookViewModel bookViewModel)
        {
            
            books = books.Select(book => book.Id == bookViewModel.Id ? bookViewModel : book).ToList();

            return View("Index", books);
        }

        //================
        //Delete
        //================
        [HttpGet]
        public IActionResult BookDelete([FromRoute] int id)
        {
            books = books.Where(e=>e.Id != id).ToList();
            return View("Index",books);
        }
        
    }

    
}
