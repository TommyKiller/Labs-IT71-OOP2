using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TransportLibrary;
using SerializeLibrary;

namespace TransportLab
{
    static class CityTransport
    {
        public static ApplicationContext Context { get; set; }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BinarySerializer serializer = new BinarySerializer();
            //Transport.Cars = serializer.Load<CarID, Transport>(@"d:\txt.txt");
            //Route.Routes = serializer.Load<RouteID, Route>(@"d:\txt1.txt");
            Transport.Cars = new Dictionary<CarID, Transport>();
            Route.Routes = new Dictionary<RouteID, Route>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Context = new ApplicationContext(new MainMenu());
            Application.Run(Context);

            serializer.Save<CarID, Transport>(@"d:\txt.txt", Transport.Cars);
            serializer.Save<RouteID, Route>(@"d:\txt1.txt", Route.Routes);
        }
    }
}
