using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace GProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

            // View Gerente Admin Sistema
        public ActionResult CadGerente()
        {
            return View();
        }
            // Fim Gerente Admin Sistema

            // View Gerente de Projeto
            // view Criar projeto
        public ActionResult CreateProject()
        {
            return View();
        }
            // View Atribuir atividades
        public ActionResult AssignActivities()
        {
            return View();
        }
            // View Gerenciar Atividades
        public ActionResult ManageActivities()
        {
            return View();
        }
            // View	Selecionar membro para projeto
        public ActionResult SelectMemberProject()
        {
            return View();
        }
            // View Aprovar finalização de atividades
        public ActionResult ApproveFinalizationActivities()
        {
            return View();
        }
            // view Acompanhar atividades
        public ActionResult TrackActivities()
        {
            return View();
        }
            // view Visualizar projeto
        public ActionResult ViewProject()
        {
            return View();
        }
            // view Finalizar atividade
        public ActionResult EndActivity()
        {
            return View();
        }
            // view  Informa duração da atividade
        public ActionResult ReportsDurationActivity()
        {
            return View();
        }
        // view Executar atividades
        public ActionResult PerformActivities()
        {
            return View();
        }
        // view Informa impedimento de atividade
        public ActionResult ReportsActivityImpediment()
        {
            return View();
        }

    }
}
