using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FirstMVC.Models;

namespace FirstMVC.Controllers
{
    public class LoginDetailController : Controller
    {
        private DbReleaseManagement db = new DbReleaseManagement();

        // GET: LoginDetail
       /* public async Task<ActionResult> Index()
        {
            return View(await db.loginDetails.ToListAsync());
        }*/
        public ActionResult Index()
        {
            return View( db.loginDetails.ToList());
        }
        // GET: LoginDetail/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoginDetails loginDetails = await db.loginDetails.FindAsync(id);
            if (loginDetails == null)
            {
                return HttpNotFound();
            }
            return View(loginDetails);
        }

        // GET: LoginDetail/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginDetail/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "UserName,Password,Role")] LoginDetails loginDetails)
        {
            if (ModelState.IsValid)
            {
                db.loginDetails.Add(loginDetails);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(loginDetails);
        }

        // GET: LoginDetail/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoginDetails loginDetails = await db.loginDetails.FindAsync(id);
            if (loginDetails == null)
            {
                return HttpNotFound();
            }
            return View(loginDetails);
        }

        // POST: LoginDetail/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "UserName,Password,Role")] LoginDetails loginDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loginDetails).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(loginDetails);
        }

        // GET: LoginDetail/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoginDetails loginDetails = await db.loginDetails.FindAsync(id);
            if (loginDetails == null)
            {
                return HttpNotFound();
            }
            return View(loginDetails);
        }

        // POST: LoginDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            LoginDetails loginDetails = await db.loginDetails.FindAsync(id);
            db.loginDetails.Remove(loginDetails);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
