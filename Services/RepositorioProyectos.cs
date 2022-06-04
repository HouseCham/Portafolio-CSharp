using Portafolio.Models;

namespace Portafolio.Services
{
    public interface IRepositorioProyectos
    {
        List<ProyectoDTO> ObtenerProyetos();
    }

    public class RepositorioProyectos : IRepositorioProyectos
    {
        public List<ProyectoDTO> ObtenerProyetos()
        {
            return new List<ProyectoDTO>()
            {
                new ProyectoDTO()
                {
                    Title = "Amazon",
                    Description = "E-commerce realizado en ESP.Core",
                    Link = "http://amazon.com"
                },
                new ProyectoDTO()
                {
                    Title = "Mercado Libre",
                    Description = "E-commerce realizado en ESP.Core",
                    Link = "http://amazon.com"
                },
                new ProyectoDTO()
                {
                    Title = "Ella Postreria",
                    Description = "E-commerce realizado en ESP.Core",
                    Link = "http://amazon.com"
                }
            };
        }
    }
}
