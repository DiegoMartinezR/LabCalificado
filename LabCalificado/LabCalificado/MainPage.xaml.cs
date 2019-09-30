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
           // InitializeComponent();

            var stack = new StackLayout();

            var btn1 = new Button();
            btn1.Text = "StackLayout";
            btn1.Clicked += btn01;

            var btn2 = new Button();
            btn2.Text = "Grid";
            btn2.Clicked += btn02;

            var btn3 = new Button();
            btn3.Text = "H.Navigations";
            btn3.Clicked += btn03;

            var btn4 = new Button();
            btn4.Text = "TabbedPage";
            btn4.Clicked += btn04;

            var btn5 = new Button();
            btn5.Text = "Datepicker";
            btn5.Clicked += btn05;

            var btn6 = new Button();
            btn6.Text = "Form";
            btn6.Clicked += btn06;

            stack.Children.Add(btn1);
            stack.Children.Add(btn2);
            stack.Children.Add(btn3);
            stack.Children.Add(btn4);
            stack.Children.Add(btn5);
            stack.Children.Add(btn6);

            Content = stack;

        }

        async private void btn01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ejercicio1());
        }

        async private void btn02(object sender, EventArgs e)
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

        async private void btn06(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ejercicio6());
        }
    }
}
