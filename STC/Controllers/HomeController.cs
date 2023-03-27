using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using STC.Helpers;
using STC.Models;
using STC.Repository.Interfaces;
using STC.Services;
using System.Diagnostics;

namespace STC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ServiceApi api;
        private IRepositoryCompeticion repocomp;
        private IRepositoryInsertarDeApi repoApi;

        public HomeController(ILogger<HomeController> logger, IRepositoryInsertarDeApi repoApi,IRepositoryCompeticion repocompeticion)
        {
            _logger = logger;
            this.repocomp= repocompeticion;
            this.repoApi = repoApi;
            this.api = new ServiceApi();
        }

        public async Task<IActionResult> Index()
        {
         
            DateTime dia = DateTime.Today;

            Competicion competicion = this.repoApi.BaseFindCompeticion(140);
            List<Partido> partidosespañoles = await this.repoApi.GetPartidosDiaComp(dia, competicion.IdCompeticion);
            ModelCompeticionPartidos modelespañol = new ModelCompeticionPartidos();
            modelespañol.partidos = partidosespañoles;
            modelespañol.competicion= competicion;
       


            Competicion competicionFrancesa = this.repoApi.BaseFindCompeticion(61);
            List<Partido> partidosfranceses = await this.repoApi.GetPartidosDiaComp(dia, competicionFrancesa.IdCompeticion);
            ModelCompeticionPartidos modelFranceses = new ModelCompeticionPartidos();

            modelFranceses.competicion = competicionFrancesa;
            modelFranceses.partidos = partidosfranceses;


            Competicion premier = this.repoApi.BaseFindCompeticion(39);
            List<Partido> partidospremier = await this.repoApi.GetPartidosDiaComp(dia, premier.IdCompeticion);
            ModelCompeticionPartidos modelpremier = new ModelCompeticionPartidos();

            modelpremier.competicion = premier;
            modelpremier.partidos = partidospremier;



            Competicion seriea = this.repoApi.BaseFindCompeticion(135);
            List<Partido> partidosseriea = await this.repoApi.GetPartidosDiaComp(dia, seriea.IdCompeticion);
            ModelCompeticionPartidos modelseriea = new ModelCompeticionPartidos();

            modelseriea.competicion = seriea;
            modelseriea.partidos = partidosseriea;
            
            Competicion bundes = this.repoApi.BaseFindCompeticion(78);
            List<Partido> partidosbundes = await this.repoApi.GetPartidosDiaComp(dia, bundes.IdCompeticion);
            ModelCompeticionPartidos modelsbundes = new ModelCompeticionPartidos();

            modelsbundes.competicion = bundes;
            modelsbundes.partidos = partidosbundes;


            List<ModelCompeticionPartidos> modelos = new List<ModelCompeticionPartidos>();
            modelos.Add(modelespañol);
            modelos.Add(modelFranceses);
            modelos.Add(modelpremier);
            modelos.Add(modelseriea);
            modelos.Add(modelsbundes);


            return View(modelos);
        }

        [HttpGet("{fecha}")]
        public async Task<IActionResult> Index(string fecha)
        {
            DateTime dia = Convert.ToDateTime(fecha);

            Competicion competicion = this.repoApi.BaseFindCompeticion(140);
            List<Partido> partidosespañoles = await this.repoApi.GetPartidosDiaComp(dia, competicion.IdCompeticion);
            ModelCompeticionPartidos modelespañol = new ModelCompeticionPartidos();
            modelespañol.partidos = partidosespañoles;
            modelespañol.competicion = competicion;
        


            Competicion competicionFrancesa = this.repoApi.BaseFindCompeticion(61);
            List<Partido> partidosfranceses = await this.repoApi.GetPartidosDiaComp(dia, competicionFrancesa.IdCompeticion);
            ModelCompeticionPartidos modelFranceses = new ModelCompeticionPartidos();

            modelFranceses.competicion = competicionFrancesa;
            modelFranceses.partidos = partidosfranceses;


            Competicion premier = this.repoApi.BaseFindCompeticion(39);
            List<Partido> partidospremier = await this.repoApi.GetPartidosDiaComp(dia, premier.IdCompeticion);
            ModelCompeticionPartidos modelpremier = new ModelCompeticionPartidos();

            modelpremier.competicion = premier;
            modelpremier.partidos = partidospremier;


            Competicion seriea = this.repoApi.BaseFindCompeticion(135);
            List<Partido> partidosseriea = await this.repoApi.GetPartidosDiaComp(dia, seriea.IdCompeticion);
            ModelCompeticionPartidos modelseriea = new ModelCompeticionPartidos();

            modelseriea.competicion = seriea;
            modelseriea.partidos = partidosseriea;

            Competicion bundes = this.repoApi.BaseFindCompeticion(78);
            List<Partido> partidosbundes = await this.repoApi.GetPartidosDiaComp(dia, bundes.IdCompeticion);
            ModelCompeticionPartidos modelsbundes = new ModelCompeticionPartidos();

            modelsbundes.competicion = bundes;
            modelsbundes.partidos = partidosbundes;

            List<ModelCompeticionPartidos> modelos = new List<ModelCompeticionPartidos>();
            modelos.Add(modelespañol);
            modelos.Add(modelFranceses);
            modelos.Add(modelpremier);
            modelos.Add(modelseriea);
            modelos.Add(modelsbundes);
            return View(modelos);
        }
   

        public async Task<IActionResult> _PartidoDetalles(int idpartido)
        {

            ModelPartidoCompleto model = await this.repoApi.BaseFindModeloPartidoYEventos(idpartido);
            VenueB venue = await this.repoApi.BaseFindVenue(model.partido.IdVenue);
            ViewData["VENUE"] = venue;
            return PartialView(model);
        }
      public async Task<IActionResult> CompeticionAsync(int idComp, int season)
        {
            ModelCompeticionStandings model = new ModelCompeticionStandings();
            Competicion competicion = this.repocomp.BaseFindCompeticion(idComp);
            model.competicion = competicion;
            List<EquipoCompStats> equiposStats = await this.repocomp.GetCompeticionStandings(idComp, season);
            model.equipoCompStats = equiposStats;
            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}