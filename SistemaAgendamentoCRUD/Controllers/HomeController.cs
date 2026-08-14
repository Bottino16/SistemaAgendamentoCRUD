using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaAgendamentoCRUD.Data;
using System.Threading.Tasks;

namespace SistemaAgendamentoCRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Busca a contagem real direto do SQL Server
            ViewBag.TotalAgendamentos = await _context.Agendamentos.CountAsync();
            ViewBag.TotalUsuarios = await _context.Usuarios.CountAsync();
            ViewBag.TotalServicos = await _context.Servicos.CountAsync();

            return View();
        }
    }
}