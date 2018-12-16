using System.Collections.Generic;

namespace TransportLibrary
{
    public static class ConvertData
    {
        public static List<Transport> DictToList(Dictionary<CarID, Transport> data)
        {
            List<Transport> list = new List<Transport>();

            foreach(CarID id in data.Keys)
            {
                list.Add(data[id]);
            }

            return list;
        }

        public static List<Route> DictToList(Dictionary<RouteID, Route> data)
        {
            List<Route> list = new List<Route>();

            foreach (RouteID id in data.Keys)
            {
                list.Add(data[id]);
            }

            return list;
        }
        
        public static Dictionary<CarID, Transport> ListToDict(List<Transport> data)
        {
            Dictionary<CarID, Transport> dict = new Dictionary<CarID, Transport>();

            foreach(Transport car in data)
            {
                dict.Add(car.ID, car);
            }

            return dict;
        }

        public static Dictionary<RouteID, Route> ListToDict(List<Route> data)
        {
            Dictionary<RouteID, Route> dict = new Dictionary<RouteID, Route>();

            foreach (Route route in data)
            {
                dict.Add(route.ID, route);
            }

            return dict;
        }
    }
}
