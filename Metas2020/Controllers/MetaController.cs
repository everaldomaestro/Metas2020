using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Metas2020.Models;
using Metas2020.Data.Context;
using Microsoft.AspNetCore.Mvc.Rendering;
using AutoMapper;
using Metas2020.Domain.Entity;

namespace Metas2020.Controllers
{
    public class MetaController : Controller
    {
        private readonly ILogger<MetaController> _logger;
        private readonly MetaContext _contex;
        private readonly IMapper _mapper;

        public MetaController(ILogger<MetaController> logger, MetaContext contex, IMapper mapper)
        {
            _logger = logger;
            _contex = contex;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region CriarMeta
        public IActionResult CriarMeta()
        {
            ViewBagsCriarMeta();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CriarMeta(CriarMetaViewModel criarMeta)
        {
            if (!ModelState.IsValid)
            {
                ViewBagsCriarMeta();
                return View(criarMeta);
            }

            var meta = _mapper.Map<Meta>(criarMeta);
            _contex.Metas.Add(meta);

            if(_contex.SaveChanges() > 0)
            {
                return View("CriarEstrategia", meta);
            }
            else
            {
                return View("Error");
            }
        }

        #endregion

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region ViewBags
        private void ViewBagsCriarMeta()
        {
            ViewBagUsuarios();
            ViewBagAreas();
        }

        private void ViewBagUsuarios()
        {
            ViewBag.Usuarios = new SelectList(_contex.Usuarios.OrderBy(x=>x.Nome).ToList(),"UsuarioId","Nome");
        }

        private void ViewBagAreas()
        {
            ViewBag.Areas = new SelectList(_contex.Areas.OrderBy(x => x.Descricao).ToList(), "AreaId", "Descricao");
        }
        #endregion
    }
}
