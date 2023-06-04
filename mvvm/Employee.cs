using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace mvvm
{
    enum Payment { salary, hourly_wage, fee }
    enum Choice { salary, bet }
    public class Employee : INotifyPropertyChanged
    {
        private string name, charge, selection;//имя, тип оплаты и выбор (зарплата или ставка)
        private int hours;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                On_prop_chang("Name");
            }
        }
        public string Charge
        {
            get { return charge; }
            set
            {
                charge = value;
                On_prop_chang("Charge");
            }
        }
        public string Selection
        {
            get { return selection; }
            set
            {
                selection = value;
                On_prop_chang("Selection");
            }
        }
        public int Hours
        {
            get { return hours; }
            set
            {
                hours = value;
                On_prop_chang("Hours");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void On_prop_chang(string prop_name) { PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop_name)); }
    }
}