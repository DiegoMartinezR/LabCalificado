using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LabCalificado
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var stack = new StackLayout();

            var btn1 = new Button();
            btn1.Text = "Boton 01";
            btn1.Clicked += btn01;

            var btn2 = new Button();
            btn2.Text = "Boton 02";
            btn2.Clicked += btn02;

            var btn3 = new Button();
            btn2.Text = "Boton 03";
            btn2.Clicked += btn03;

            var btn4 = new Button();
            btn2.Text = "Boton 04";
            btn2.Clicked += btn04;

            var btn5 = new Button();
            btn2.Text = "Boton 05";
            btn2.Clicked += btn05;

            Content = stack;

        }

        async private void btn02(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ejercicio1());
        }

        async private void btn01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ejercicio2());
        }
        async private void btn03(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ejercicio3());
        }

        async private void btn04(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ejercicio4());
        }
        async private void btn05(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ejercicio5());
        }

    }
}
