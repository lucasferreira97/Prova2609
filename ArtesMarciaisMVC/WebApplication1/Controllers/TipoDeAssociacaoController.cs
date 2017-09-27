using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TipoDeAssociacaoController : Controller
    {
        private ApplicationDbContext _context;

        public TipoDeAssociacaoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: /Faixa/
        public ActionResult Index()
        {
            var tpa = _context.TiposDeAssociacao.ToList();
            return View(tpa);
        }

        public ActionResult Details(int id)
        {
            var tpa = _context.TiposDeAssociacao.SingleOrDefault(a => a.Id == id);

            if (tpa == null)
                return HttpNotFound();

            return View(tpa);
        }
	}
}