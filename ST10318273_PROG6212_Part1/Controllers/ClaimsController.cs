namespace ST10318273_PROG6212_Part1.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ST10318273_PROG6212_Part1.Models;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Microsoft.AspNetCore.Http;

    public class ClaimsController : Controller
    {
        // Dummy in-memory data store
        private static List<Claim> claims = new List<Claim>();

        // GET: /Claims/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Claims/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Claim claim, List<IFormFile> supportingDocuments)
        {
            if (ModelState.IsValid)
            {
                claim.Status = "Submitted";
                claims.Add(claim);

                // Handle file uploads
                foreach (var file in supportingDocuments)
                {
                    if (file.Length > 0)
                    {
                        var filePath = Path.Combine("wwwroot/uploads", file.FileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                        claim.SupportingDocuments.Add(new SupportingDocument
                        {
                            ClaimID = claim.ClaimID,
                            DocumentType = file.ContentType,
                            FilePath = filePath
                        });
                    }
                }

                return RedirectToAction("Index");
            }
            return View(claim);
        }

        // GET: /Claims/Index
        public IActionResult Index()
        {
            return View(claims);
        }

        // GET: /Claims/Details/5
        public IActionResult Details(int id)
        {
            var claim = claims.FirstOrDefault(c => c.ClaimID == id);
            if (claim == null)
            {
                return NotFound();
            }
            return View(claim);
        }
    }
}