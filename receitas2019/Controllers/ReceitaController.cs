using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using receitas2019.Repositories.Interface;
using Receitas2019.Core.Models;
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

        public IActionResult List(string categoria)
        {
            string _categoria = categoria;
            IEnumerable<Receita> receitas;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                receitas = _receitaRepository.Receitas.OrderBy(r => r.Id);
                categoriaAtual = "Todos as receitas";
            }
            else
            {
                receitas = _receitaRepository.Receitas.Where(r => r.CategoriaId.Equals(categoria)).OrderBy(r => r.Nome);

                if (string.Equals("Doce", _categoria, StringComparison.OrdinalIgnoreCase))
                    receitas = _receitaRepository.Receitas.Where(r => r.CategoriaId.Equals(1)).OrderBy(r => r.Nome);
                else
                    receitas = _receitaRepository.Receitas.Where(r => r.CategoriaId.Equals(2)).OrderBy(r => r.Nome);

                categoriaAtual = categoria;
            }

            var receitasListViewModel = new ReceitasListViewModel
            {
                Receitas = receitas,
                CategoriaAtual = categoriaAtual
            };

            return View(receitasListViewModel);
        }
        public ViewResult Details(int receitaId)
        {
            var receita = _receitaRepository.Receitas.FirstOrDefault(r => r.Id == receitaId);
            if (receita == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(receita);
        }

        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Receita> receitas;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                receitas = _receitaRepository.Receitas.OrderBy(r => r.Id);
            }
            else
            {
                receitas = _receitaRepository.Receitas.Where(p => p.Tag.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Receita/List.cshtml", new ReceitasListViewModel { Receitas = receitas, CategoriaAtual = "Todos as receitas" });
        }
    }
}