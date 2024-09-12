using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace NetworkService.Model
{
	public class CircleMarker : BindableBase
	{
		private string cmType;
		private int cmValue;
		private string cmDate;
		private string cmTime;
		private Thickness cmMargin;
		private Brush cmColor;

		public CircleMarker()
		{

		}

		public CircleMarker(string cmType, int cmValue, string cmDate, string cmTime)
		{
			CmType = cmType;
			CmValue = cmValue;
			CmDate = cmDate;
			CmTime = cmTime;
		}

		public string CmType
		{
			get { return cmType; }
			set
			{
				cmType = value;
				RaisePropertyChanged("CmType");
			}
		}

		public int CmValue
		{
			get { return cmValue; }
			set
			{
				cmValue = value;
				CmMargin = new Thickness(0, 0, 0, cmValue / 100);
				switch (cmType)
				{
					case "SolarPanel":
						CmColor = (cmValue > 5 && cmValue < 1) ? Brushes.Red : Brushes.Green;
						break;
					case "WindGenerator":
						CmColor = (cmValue < 1 && cmValue > 5) ? Brushes.Red : Brushes.Green;
						break;
					default:
						CmMargin = new Thickness(0, 0, 0, 0);
						CmColor = Brushes.LightGray;
						break;
				}
				RaisePropertyChanged("CmValue");
			}
		}

		public string CmDate
		{
			get { return cmDate; }
			set
			{
				cmDate = value;
				RaisePropertyChanged("CmDate");
			}
		}

		public string CmTime
		{
			get { return cmTime; }
			set
			{
				cmTime = value;
				RaisePropertyChanged("CmTime");
			}
		}

		public Thickness CmMargin
		{
			get { return cmMargin; }
			set
			{
				cmMargin = value;
				RaisePropertyChanged("CmMargin");
			}
		}

		public Brush CmColor
		{
			get { return cmColor; }
			set
			{
				cmColor = value;
				RaisePropertyChanged("CmColor");
			}
		}
	}
}
