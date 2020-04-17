using System;
using System.Windows.Forms;

namespace Dados
{
    public class ExceptionErro
    {
        public static void ExibirMenssagemException(Exception exception, string msgPersonlizada = "")
        {
            if (exception != null)
            {
                if (exception.InnerException != null)
                {
                    if (exception.InnerException.InnerException != null)
                        MessageBox.Show(@"Erro 01 : " + exception.Message + @"Erro 02 : ", exception.InnerException.InnerException.Message + ", " + exception.StackTrace, MessageBoxButtons.OK,MessageBoxIcon.Error);
                    else
                        MessageBox.Show(@"Erro 01: " + exception.Message + @"Erro 02 :", exception.InnerException.Message + ", " + exception.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(@"Erro 01: " + exception.Message + @"Erro 02 :", exception.InnerException.Message + ", " + exception.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
