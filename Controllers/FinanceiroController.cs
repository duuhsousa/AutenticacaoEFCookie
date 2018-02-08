using AutenticacaoEFCookie.Dados;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AutenticacaoEFCookie.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Collections.Generic;
using System.Security.Claims;

namespace AutenticacaoEFCookie.Controllers
{
    [Authorize(Roles="Financeiro")]
    public class FinanceiroController : Controller
    {
        public IActionResult Index(){
            return View();
        }

    }
}