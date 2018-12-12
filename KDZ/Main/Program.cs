using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                try
                {
                    Application.Run(new applicationForm());
                }
                catch (OutOfMemoryException)
                {
                    var result = MessageBox.Show(
                        "Произошла ошибка приближения, программа будет перезапущена, слишком большое приближение на слишком большом разрешении, для выхода нажмите отмена", "Ошибка-рыбка", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        Application.Run(new applicationForm());
                    }
                }
            }
        }
    }
}
