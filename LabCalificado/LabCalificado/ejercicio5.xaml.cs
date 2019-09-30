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
    public partial class ejercicio5 : ContentPage
    {
        public ejercicio5()
        {
            InitializeComponent();



                datepicker.MinimumDate = new DateTime(2019, 1, 1);
                datepicker.MaximumDate = new DateTime(2019, 12, 31);
                datepicker.Date = new DateTime(2019, 9, 30);


        }
    }
}