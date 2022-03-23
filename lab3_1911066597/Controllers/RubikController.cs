using lab3_1911066597.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab3_1911066597.Controllers
{
    public class RubikController : Controller
    {
        // GET: Rubik
        public ActionResult Index()
        {
            return View(Rubik.GetAll());
            
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
                return HttpNotFound();
            Rubik find = Rubik.FindRubikByID(id.Value);
            if (find == null)
                return HttpNotFound();
            return View(find);
        }

        public ActionResult Create()
        {
            return View(new Rubik());
        }
        [HttpPost]

        public ActionResult Create(Rubik newRubik)
        {
            if (ModelState.IsValid)
            {
                newRubik.Insert();
                return View("Index", Rubik.GetAll());
            }
            else
            {
                return View("Create", newRubik);
            }
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
                return HttpNotFound();
            Rubik find = Rubik.FindRubikByID(id.Value);
            if (find == null)
                return HttpNotFound();
            return View(find);
        }
        [HttpDelete]

        public ActionResult Delete(Rubik DeleteRuBiks)
        {
            if (ModelState.IsValid)
            {
                DeleteRuBiks.DeleteRubik();
                return View("Index", Rubik.GetAll());
            }
            else
            {
                return View("Delete", DeleteRuBiks);
            }
        }

        public string ProcessUpload(HttpPostedFileBase file)
        {
            if (file == null)
            {
                return "";
            }
            file.SaveAs(Server.MapPath("~/Content/images/" + file.FileName));
            return "/Content/images/" + file.FileName;
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
                return HttpNotFound();
            Rubik find = Rubik.FindRubikByID(id.Value);
            if (find == null)
                return HttpNotFound();
            return View(find);
        }
        [HttpPost]

        public ActionResult Edit(Rubik RubikEdit)
        {
            if (ModelState.IsValid)
            {
                RubikEdit.Insert();
                return View("Index", Rubik.GetAll());
            }
            else
            {
                return View("Edit", RubikEdit);
            }
        }

    }
}