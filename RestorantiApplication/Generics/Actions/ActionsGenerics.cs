using RestorantiApplication.Generics.Logs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantiApplication.Generics.Actions
{
    public static class ActionsGenerics
    {
        //Quando for sair da aplicação.
        public static bool Exit()
        {

            try
            {
                if (MessageBox.Show("Você deseja sair ?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao encerrar a aplicação. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
                return false;
            }
        }
    }
}
