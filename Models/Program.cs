using Financeiro_teste.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteYakissoba
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inicializar banco de dados
            DatabaseHelper db = new DatabaseHelper();

            // Abrir formulário principal
            Application.Run(new FrmPrincipal());
        }
    }
}