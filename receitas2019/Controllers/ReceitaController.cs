using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using receitas2019.Repositories.Interface;
using Receitas2019.Web.ViewModels;

namespace receitas2019.Controllers
{
    public class ReceitaController : Controller
    {
        private readonly IReceitaRepository _receitaRepository;

        public ReceitaController(IReceitaRepository receitaRepository)
        {
            _receitaRepository = receitaRepository;
        }

        public IActionResult List()
        {
            var receitasListViewModel = new ReceitasListViewModel();
            receitasListViewModel.Receitas = _receitaRepository.Receitas;
            return View(receitasListViewModel);
        }
    }
}