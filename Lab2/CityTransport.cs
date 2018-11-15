using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    static class CityTransport
    {
        public static ApplicationContext Context { get; set; }
        public static Dictionary<ID, Transport> Cars { get; set; }
        public static Dictionary<ID, Route> Routes { get; set; }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Cars = new Dictionary<ID, Transport>();
            Routes = new Dictionary<ID, Route>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Context = new ApplicationContext(new MainMenu());
            Application.Run(Context);
        }
    }
}
