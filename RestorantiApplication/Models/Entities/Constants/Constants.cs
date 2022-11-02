using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantiApplication.Models.Entities.Constants
{
    public class Constants
    {
        public const string CONFIRM_OPERATION = "Você confirma essa operação?";
        public const string CONFIRM_MESSAGE_LOGOUT = "Você realmente deseja sair da sua conta?";
        /// <summary>
        /// Nomes das views que possívelmente podem estar aberto na página principal ( Categorias, Produtos, Usuários, Mesas ).
        /// </summary>
        public const string MAIN_PAGE_FORMS_OPEN = "Categorys;Kitchen;Products;Tables";
        /// <summary>
        /// Nome dos status da mesa, caso tenha novos adicionar a divisão por ponto e vírgula
        /// </summary>
        public const string TABLE_STATUS = "DISPONÍVEL;OCUPADA";

    }
}
