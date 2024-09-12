using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;

namespace NetworkService.Model
{
    public class LineModel :BindableBase
    {
        public Point startPoint;
        public Point endPoint;
        public Brush lineColor;
        public double strokeThickness;
        public string displayValue;
        public DoubleCollection strokeDashArray;


        public string DisplayValue
        {
            get { return displayValue; }
            set
            {
                displayValue = value;
                RaisePropertyChanged("DisplayValue");
            }
        }

        public Point StartPoint 
        {
            get { return startPoint; }
            set 
            { 
                startPoint = value;
                RaisePropertyChanged("StartPoint");
            }
        }

        public Point EndPoint
        {
            get { return endPoint; }
            set
            {
                endPoint = value;
                RaisePropertyChanged("EndPoint");
            }
        }

        public Brush LineColor
        {
            get { return lineColor; }
            set
            {
                lineColor = value;
                RaisePropertyChanged("LineColor");
            }
        }

        public double StrokeThickness
        {
            get { return strokeThickness; }
            set
            {
                strokeThickness = value;
                RaisePropertyChanged("StrokeThickness");
            }
        }

        public DoubleCollection StrokeDashArray
        {
            get { return strokeDashArray; }
            set
            {
                strokeDashArray = value;
                RaisePropertyChanged("StrokeDashArray");
            }
        }

    }
}
