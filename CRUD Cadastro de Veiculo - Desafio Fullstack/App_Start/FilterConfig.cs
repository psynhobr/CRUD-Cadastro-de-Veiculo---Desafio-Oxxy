using System.Web;
using System.Web.Mvc;

namespace CRUD_Cadastro_de_Veiculo___Desafio_Fullstack
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
