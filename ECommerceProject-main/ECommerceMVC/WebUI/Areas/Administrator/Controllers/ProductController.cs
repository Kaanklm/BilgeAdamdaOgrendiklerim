using Common;
using Model.Entity;
using Service.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUI.Areas.Administrator.Controllers
{
    [Authorize(Roles ="admin,sales")]
    public class ProductController : Controller
    {
        ProductService productService = new ProductService();
        SubCategoryService subCategoryService = new SubCategoryService();
        CategoryService categoryService = new CategoryService();
        public ActionResult Index()
        {
            ViewBag.Categories = categoryService.GetList();
            return View(productService.GetDefault(x=>x.Status==Core.CoreEnum.Status.Active));
        }

        public ActionResult Add()
        {
            ViewBag.SubCategories = new SelectList(subCategoryService.GetList(), "ID", "SubCategoryName");
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product newProduct,HttpPostedFileBase ProductImagePath)
        {
           newProduct.ProductImagePath= ImageUploader.UploadImage("~/Content/productImages", ProductImagePath);
            productService.Add(newProduct);
            return RedirectToAction("Index");
        }

        public ActionResult UpdateProduct(Guid id)
        {
            ViewBag.SubCategories = new SelectList(subCategoryService.GetList(), "ID", "SubCategoryName");
            if (id != null)
            {
               Product updated= productService.GetDefault(x => x.ID == id).FirstOrDefault();
                return View(updated);
            }
            else
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product updated,HttpPostedFileBase ProductImagePath)
        {
            updated.ProductImagePath = ImageUploader.UploadImage("~/Content/productImages/", ProductImagePath);
           string result= productService.Update(updated);
            TempData["result"] = result;
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProduct(Guid id)
        {
            if (id != null)
            {
                Product deleted = productService.GetDefault(x => x.ID == id).FirstOrDefault();
                return View(deleted);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult DeleteProduct(Product deleted)
        {
            if (deleted != null)
            {
                deleted.Status = Core.CoreEnum.Status.Deleted;
                string result = productService.Update(deleted);
                TempData["result"] = result;
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

    }
}