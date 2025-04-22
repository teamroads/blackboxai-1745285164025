using Microsoft.AspNetCore.Mvc;
using PlacementApp.Models;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace PlacementApp.Controllers
{
    public class PlacementController : Controller
    {
        // Display welcome page
        public IActionResult Index()
        {
            return View();
        }

        // Display placement info form
        public IActionResult PlacementInfo()
        {
            return View();
        }

        // Handle placement info form submission
        [HttpPost]
        public IActionResult PlacementInfo(Models.PlacementInfo model)
        {
            if (ModelState.IsValid)
            {
                // TODO: Save placement info to database or storage
                ViewBag.Message = "Placement info saved successfully.";
                ModelState.Clear();
                return View();
            }
            return View(model);
        }

        // Display vendor management form
        public IActionResult VendorManagement()
        {
            return View();
        }

        // Handle vendor management form submission
        [HttpPost]
        public async Task<IActionResult> VendorManagement(IFormFile msaFile, IFormFile voidCheque, IFormCollection form)
        {
            // Save MSA file
            if (msaFile != null && msaFile.Length > 0)
            {
                var msaPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "msa", msaFile.FileName);
                Directory.CreateDirectory(Path.GetDirectoryName(msaPath));
                using (var stream = new FileStream(msaPath, FileMode.Create))
                {
                    await msaFile.CopyToAsync(stream);
                }
            }

            // Save void cheque file
            if (voidCheque != null && voidCheque.Length > 0)
            {
                var chequePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "voidcheque", voidCheque.FileName);
                Directory.CreateDirectory(Path.GetDirectoryName(chequePath));
                using (var stream = new FileStream(chequePath, FileMode.Create))
                {
                    await voidCheque.CopyToAsync(stream);
                }
            }

            // TODO: Save vendor details from form collection
            ViewBag.Message = "Vendor details and files uploaded successfully.";
            return View();
        }

        // Display bank details form
        public IActionResult BankDetails()
        {
            return View();
        }

        // Handle bank details form submission
        [HttpPost]
        public IActionResult BankDetails(IFormCollection form)
        {
            // TODO: Process bank details
            ViewBag.Message = "Bank details saved successfully.";
            return View();
        }
    }
}
