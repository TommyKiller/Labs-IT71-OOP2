using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lab2
{
    public abstract class Transport : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private Route route;
        public Route Route
        {
            get
            {
                return route;
            }
            set
            {
                route = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Route"));
            }
        }
        public ID ID { get; }
        public string Company { get; set; }

        public Transport(ID id, string owner_company)
        {
            ID = id;
            Company = owner_company;
        }

        public Transport(Transport car)
        {
            ID = car.ID;
            Company = car.Company;
            Route = car.Route;
        }

        public abstract void FillUp(int value);

        public abstract void Move();

        public override string ToString()
        {
            return "Car " + ID.ToString();
        }
    }
}
