using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspnetCore;
using AspnetCore.Data;
using Microsoft.AspNetCore.Http;

namespace AspnetCore.Controllers
{
    public class Core02062Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public Core02062Controller(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Core02062
        public async Task<IActionResult> Index()
        {
            return View(await _context.Contact1ss.ToListAsync());
        }

        // GET: Core02062/Details/5
        //public async Task<IActionResult> Details(string? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var contact1 = await _context.Contact1ss.SingleOrDefaultAsync(m => m.Accountno == id);
        //    if (contact1 == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(contact1);
        //}

        // GET: Core02062/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Core02062/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Accountno,Company,Contact,Recid")] Contact1 contact1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contact1);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(contact1);
        }

        // GET: Core02062/Edit/5
        //public async Task<IActionResult> Edit(string? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    //var contact1 = await _context.Contact1ss.SingleOrDefaultAsync(m => m.Accountno == id);
        //    //if (contact1 == null)
        //    //{
        //    //    return NotFound();
        //    //}
        //    //return View(contact1);
        //    return View( );
        //}

        // POST: Core02062/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Accountno,Company,Contact,Recid")] Contact1 contact1,FormCollection form,string [] a)
        {
            Microsoft.Extensions.Primitives.StringValues c = new Microsoft.Extensions.Primitives.StringValues("");
            List<string> b=new List<string> ();
            form.TryGetValue("a", out  c);
            if (id != contact1.Accountno)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contact1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Contact1Exists(contact1.Accountno))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(contact1);
        }

        // GET: Core02062/Delete/5
        //public async Task<IActionResult> Delete(string? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var contact1 = await _context.Contact1ss.SingleOrDefaultAsync(m => m.Accountno == id);
        //    if (contact1 == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(contact1);
        //}

        // POST: Core02062/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var contact1 = await _context.Contact1ss.SingleOrDefaultAsync(m => m.Accountno == id);
            _context.Contact1ss.Remove(contact1);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool Contact1Exists(string id)
        {
            _context.Database.ExecuteSqlCommand("select * from Table");
            _context.Database.ExecuteSqlCommandAsync("select * from Table");
            return _context.Contact1ss.Any(e => e.Accountno == id);
        }
    }
}
