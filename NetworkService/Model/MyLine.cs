using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NetworkService.Model
{
	public class MyLine : BindableBase
	{
		private double x1;
		private double y1;
		private double x2;
		private double y2;

		private int source;			// Index source canvas-a
		private int destination;	// Index destination canvas-a

		public double X1
		{
			get { return x1; }
			set
			{
				x1 = value;
				RaisePropertyChanged("X1");
			}
		}

		public double Y1
		{
			get { return y1; }
			set
			{
				y1 = value;
				RaisePropertyChanged("Y1");
			}
		}

		public double X2
		{
			get { return x2; }
			set
			{
				x2 = value;
				RaisePropertyChanged("X2");
			}
		}

		public double Y2
		{
			get { return y2; }
			set
			{
				y2 = value;
				RaisePropertyChanged("Y2");
			}
		}

		public int Source
		{
			get { return source; }
			set
			{
				source = value;
				RaisePropertyChanged("Source");
			}
		}

		public int Destination
		{
			get { return destination; }
			set
			{
				destination = value;
				RaisePropertyChanged("Destination");
			}
		}
	}
}
