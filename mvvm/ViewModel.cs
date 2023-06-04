using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace mvvm
{
    public class ViewModel : Employee, IValueConverter
    {
        public ViewModel() { }
        private bool is_shown_obj;
        public bool Is_shown
        {
            get { return is_shown_obj; }
            set
            {
                is_shown_obj = value;
                On_prop_chang("Is_shown");
            }
        }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Payment[] payments = { Payment.fee, Payment.hourly_wage, Payment.salary };
            Charge = payments[0].ToString();
            Choice[] choices = { Choice.salary, Choice.bet };
            Selection = choices[0].ToString();
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) { throw new NotImplementedException(); }
    }
}