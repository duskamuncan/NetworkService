using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;


namespace NetworkService.Model
{
    public class Type : ValidationBase
    {

        private string name;

        private string pathToPhoto = "C:\\Users\\Duska\\Desktop\\NetworkService\\NetworkService\\Images\\none.jpg";

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    pathToPhoto = ComboBoxImages.PredefinedImages.DERTypes[value];
                    RaisePropertyChanged("Name");
                }
            }
        }

        public string PathToPhoto
        {
            get { return pathToPhoto; }
            set
            {
                if (pathToPhoto != value)
                {
                    pathToPhoto = value;
                    RaisePropertyChanged("PathToPhoto");
                }
            }
        }

        protected override void ValidateSelf()
        {
            if (this.Name == null)
            {
                this.ValidationErrors["Name"] = "Type must be selected.";
            }
        }
    }
}
