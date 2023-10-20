using _19_10.Models;
using _19_10.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace _19_10.Controllers
{
    public class BookController : Controller
    {


        //Dependecy Injection
        private readonly RepositoryBaglantisi _repositoryBaglantisi;

        public BookController(RepositoryBaglantisi repositoryBaglantisi)
        {
            _repositoryBaglantisi = repositoryBaglantisi;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }


        //[HttpPost]
        public IActionResult Create(Book book)
        {


            _repositoryBaglantisi.Add(book);
            _repositoryBaglantisi.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Getlist()
        {
            List<Book> books = _repositoryBaglantisi.Books.ToList();
            return View(books);

        }  
        [HttpGet ]
    public IActionResult Details(int id)

    {
        Book book = _repositoryBaglantisi.Books.Find(id);
            return View(book);
    }

       
    }
}

