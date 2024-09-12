using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkService.Model
{
    public class DER : ValidationBase
    {
        private string textId;
        private int id;
        private string name;
        private Type type;
        private double value;


        public string TextId
        {
            get { return textId; }
            set
            {
                if (textId != value)
                {
                    textId = value;
                    RaisePropertyChanged("TextId");
                }
            }
        }

        public int Id
        { get { return id; }

            set
            {
                if(id != value)
                {
                    id = value;
                    RaisePropertyChanged("Id");
                }
            }
        }

        public string Name
        {
            get { return name; }

            set
            {
                if (name != value)
                {
                    name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public Type Type
        {
            get { return type; }
            set
            {
                if (type != value)
                {
                    type = value;
                    Type.Name = value.Name;
                    Type.PathToPhoto = value.PathToPhoto;
                    RaisePropertyChanged("Type");
                }
            }
        }

        public double Value
        {
            get { return this.value; }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    RaisePropertyChanged("Value");
                }
            }
        }

        public bool IsValueValidForType()
        {
            bool isValid = true;

            if (Value <= 1 && Value >=5)
            {
                isValid = false;
            }

            return isValid;
        }

        protected override void ValidateSelf()
        {
            int tempId;
            bool parsingSuccess = int.TryParse(this.textId, out tempId);

            if (this.DoesIdAlreadyExist)
            {
                this.ValidationErrors["Id"] = "Id already exists.";
            }

            if (!parsingSuccess)
            {
                this.ValidationErrors["Id"] = "Id must be an integer.";
            }
            else if (tempId < 0)
            {
                this.ValidationErrors["Id"] = "Id can't be negative.";
            }

            if (string.IsNullOrWhiteSpace(this.textId))
            {
                this.ValidationErrors["Id"] = "Id is required.";
            }

            if (string.IsNullOrWhiteSpace(this.name))
            {
                this.ValidationErrors["Name"] = "Name is required.";
            }
        }

    }
}
