using System;
using System.Windows.Forms;
namespace Entrega3
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int alto = 10;
            int ancho = 10;
            int cantidad_mese = 20;
            int mes = 1;
            Mapa mapa1 = new Mapa();
            Terreno[,] opcion1 = new Terreno[10, 10];
            Label[,] labels;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}