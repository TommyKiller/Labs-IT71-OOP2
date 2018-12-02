using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportLibrary;

namespace Lab2
{
    static class CityTransport
    {
        public static ApplicationContext Context { get; set; }
        public static Dictionary<CarID, Transport> Cars { get; set; }
        public static Dictionary<RouteID, Route> Routes { get; set; }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Cars = new Dictionary<CarID, Transport>();
            Routes = new Dictionary<RouteID, Route>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Context = new ApplicationContext(new MainMenu());
            Application.Run(Context);
        }
    }
}
