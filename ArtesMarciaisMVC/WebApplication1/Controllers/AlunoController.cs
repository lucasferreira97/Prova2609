using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    public class AlunoController : Controller
    {     
        private ApplicationDbContext _context;

        public AlunoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: /Aluno/
        public ActionResult Index()
        {
            var alunos = _context.Alunos.Include(a => a.TipoDeAssociacao.Nome).Include(a => a.Faixa.Nome);
            return View(alunos);
        }

        public ActionResult Details(int id)
        {
            var aluno = _context.Alunos.SingleOrDefault(a => a.Id == id);
            
            if (aluno == null)
                return HttpNotFound();

            return View(aluno);
        }
	}
}