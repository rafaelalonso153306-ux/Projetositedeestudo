using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Projetositedeestudo.Contexts;
using Projetositedeestudo.Models;

namespace Projetositedeestudo.Controllers
{
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        BancoDoProjetoContext context = new BancoDoProjetoContext();

        public IActionResult Index()
        {
            //forma de listar todos os itens da tabela de (equipe)
            // var listajogador = context.Usuarios.Include("IdNavigation").ToList();
            // passar a tela 
            // ViewBag.listajogador = listajogador;
            var listaCursos = context.Cursos.ToList();

            ViewBag.ListaCursos = listaCursos;

            //forma de listar todos os itens da tabela de (Usuario)
            var listaUsuarios = context.Usuarios.ToList();
            // passar a tela 
            ViewBag.listaUsuarios = listaUsuarios;
            
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(Usuario usuario)
        {
            try
            {
                //armazenar a equipe no banco de dados
                context.Add(usuario);

                // // Registrar as alterações no banco de dados  
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return RedirectToAction("Index");
        }

        [Route("ExcluirUsuario/{id}")]
        public IActionResult ExcluirUsuario(int id)
        {
            // pegar o id de refe=rencia e vou procurar a equipe no banco de dados 
            Usuario usuario = context.Usuarios.FirstOrDefault(x => x.Id == id);
            // select *from Equipe where id == (valor da equipe da tabela)

            context.Remove(usuario);

            context.SaveChanges();

            return RedirectToAction("Index");
        }

        [Route("Atualizar/{id}")]
        public IActionResult Atualizar(int id)
        {
            Usuario usuario = context.Usuarios.FirstOrDefault(x => x.Id == id);

            ViewBag.Usuario = usuario;

            return View();
        }
        [Route("AtualizarUsuario")]
        public IActionResult AtualizarUsuario(Usuario usuario)
        {
            context.Usuarios.Update(usuario);

            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}