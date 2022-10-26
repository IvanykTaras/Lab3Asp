using Book.Models;
using Microsoft.AspNetCore.Mvc;

namespace Book.Controllers
{

    public class BookController : Controller
    {
        public static string urlImg = "https://assets.reedpopcdn.com/pok-mon-go-jak-zdoby-pikachu-jako-startowego-pokemona-14689433339.png/BROK/resize/690%3E/format/jpg/quality/75/pok-mon-go-jak-zdoby-pikachu-jako-startowego-pokemona-14689433339.png";
        
        public static int booksId = 0;
        
        private static List<BookViewModel> _books = new List<BookViewModel>()
        {
            new BookViewModel(){
                Id = booksId++, 
                Author = "Canady Trump",
                DateOfPublication = new DateTime(2002,08,1).Date,
                PageNumber = 600,
                Img = urlImg,
                Price = 6.00,
                PubHouse = "MyHouse",
                Title="Green Book",
                Types = BookType.Anime 
            },
            new BookViewModel(){
                Id = booksId++, 
                Author = "Canady Trump",
                DateOfPublication = new DateTime(2002,08,1).Date,
                PageNumber = 600,
                Img = urlImg,
                Price = 6.00,
                PubHouse = "MyHouse",
                Title="Green Book",
                Types = BookType.Anime 
            },
            new BookViewModel(){
                Id = booksId++,
                Author = "Canady Trump",
                DateOfPublication = new DateTime(2002,08,1).Date,
                PageNumber = 600,
                Img = urlImg,
                Price = 6.00,
                PubHouse = "MyHouse",
                Title="Green Book",
                Types = BookType.Anime
            },
        };
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [HttpPost]
        public IActionResult BookForm(BookViewModel bookViewModel)
        {

            BookViewModel book = new BookViewModel();
            if (ModelState.IsValid)
            {
                _books.Add(bookViewModel);
                return View(book);
            }
            else
            {

                return View();
            }

        }

        [HttpGet]
        public IActionResult EditForm(int id) {

            return View();
        }
        
    }

    
}
