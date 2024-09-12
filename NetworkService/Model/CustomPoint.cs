using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NetworkService.Model
{
    public class CustomPoint : BindableBase
    {
        public double x;
        public double y;
        public string displayValue;
        public Brush background;


        public double X
        {
            get { return x; }
            set
            {
                x = value;
                RaisePropertyChanged("X");
            }
        }

        public double Y
        {
            get { return y; }
            set
            {
                y = value;
                RaisePropertyChanged("Y");
            }
        }

        public string DisplayValue
        {
            get { return displayValue; }
            set
            {
                displayValue = value;
                RaisePropertyChanged("DisplayValue");
            }
        }

        public Brush Background
        {
            get { return background; }
            set
            {
                background = value;
                RaisePropertyChanged("Background");
            }
        }
    }
}
