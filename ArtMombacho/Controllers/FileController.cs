using ArtMombacho.DAL;
using System.Web.Mvc;

namespace ArtMombacho.Controllers
{
    public class FileController : Controller
    {
        private ArtMombachoContext db = new ArtMombachoContext();
        //
        // GET: /File/
        public ActionResult Index(int id)
        {
            var fileToRetrieve = db.Files.Find(id);
            return File(fileToRetrieve.Content, fileToRetrieve.ContentType);
        }
    }
}