using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LabCalificado
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ejercicio2 : ContentPage
    {
        public ejercicio2()
        {
            InitializeComponent();

            var grid = new Grid();

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
           


            var topLeft = new Label { Text = "Top Left" };
            var topMid = new Label { Text = "Top Mid" };
            var topRight = new Label { Text = "Top Right" };
            var bottomLeft = new Label { Text = "Bottom Left" };
            var bottomMid = new Label { Text = "Bottom Mid" };
            var bottomRight = new Label { Text = "Bottom Right" };

            grid.Children.Add(topLeft, 0, 0);
            grid.Children.Add(topRight, 1, 0);
            grid.Children.Add(bottomLeft, 0, 1);
            grid.Children.Add(bottomRight, 1, 1);
            grid.Children.Add(bottomMid, 0, 2);
            grid.Children.Add(topMid,1, 2);


        }
    }
}