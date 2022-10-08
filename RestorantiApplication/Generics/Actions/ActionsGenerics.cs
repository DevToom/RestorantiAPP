using RestorantiApplication.Generics.Logs;
using RestorantiApplication.Views.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorantiApplication.Generics.Actions
{
    public static class ActionsGenerics
    {
        /// <summary>
        /// Quando for sair da aplicação.
        /// </summary>
        /// <returns></returns>
        public static bool Exit()
        {

            try
            {
                using (var form = new Exit())
                {
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.Yes)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro ao encerrar a aplicação. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
                return false;
            }
        }

        /// <summary>
        /// Quando for para confirmar qualquer operação.
        /// </summary>
        /// <returns></returns>
        public static bool ConfirmCustom(string Message)
        {
            try
            {
                using (var form = new ConfirmModal(Message))
                {
                    form.ShowDialog();
                    if (form.DialogResult == DialogResult.Yes)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                Logger.Write($"Erro técnico ao encerrar ao tentar confirmar uma operação. Exception: {ex.Message} StackTrace: {ex.StackTrace}");
                return false;
            }
        }


    }
}
