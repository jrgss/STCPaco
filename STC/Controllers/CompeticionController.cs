using Microsoft.AspNetCore.Mvc;
using STC.Models;
using STC.Repository.Interfaces;

namespace STC.Controllers
{
    public class CompeticionController : Controller
    {
        //private IRepositoryComptemp repocomptemp;
        private IRepositoryCompeticion repocomp;
        
        public CompeticionController(//IRepositoryComptemp repocomptemp,
                                     IRepositoryCompeticion repocomp)
        {
            //this.repocomptemp = repocomptemp;
            this.repocomp = repocomp;
        }

        public IActionResult Index( )
        {
            return View();
        }
        public async Task<IActionResult> CompeticionAsync(int idComp,int season)
        {
            ModelCompeticionStandings model = new ModelCompeticionStandings();
            Competicion competicion = this.repocomp.BaseFindCompeticion(idComp);
            model.competicion=competicion;
            List<EquipoCompStats> equiposStats = await this.repocomp.GetCompeticionStandings(idComp, season);
            model.equipoCompStats = equiposStats;
            return View(model);
        }
        public async Task<IActionResult>_UltimosPartidos(int idcomp,int season,int? posicion)
        {
            ModelCompeticionPartidos modelo;
            if (posicion == null)
            {
                modelo = await this.repocomp.GetUltimosPartidosComp(idcomp, season,5, 0);
                ViewData["REGISTROS"] = modelo.registros;
                ViewData["POSICION"] = 0;
                ViewData["PARTIDO"] = modelo.partidos[0];
           
            }
            else
            {
                modelo = await this.repocomp.GetUltimosPartidosComp(idcomp, season,5, posicion.Value);
                ViewData["REGISTROS"] = modelo.registros;
                ViewData["POSICION"] = posicion.Value;
                ViewData["PARTIDO"] = modelo.partidos[0];
            }
            return PartialView(modelo);
        }
        public async Task<IActionResult> _ResumenPartidosCompeticion(int idcomp,int season)
        {
            Partido ultimoPartido= await this.repocomp.GetUltimoPartidoDisputado(idcomp,season);
            ResumenPartidosCompeticion resumen= new ResumenPartidosCompeticion();
            resumen.UltimoPartido=ultimoPartido;
            List<Partido> ProximosPartidos=await this.repocomp.GetProximosPartidos(idcomp, season,3);
            resumen.ProximosPartidos= ProximosPartidos;
            return PartialView(resumen);
        }
    }
}
