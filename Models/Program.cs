using Financeiro_teste.Forms;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro_teste.Models
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Inicializar o banco de dados
            DatabaseHelper db = new DatabaseHelper();

            //Abrir o Formulario principal
            Application.Run(new FrmPrincipal());

        }
    }
}
