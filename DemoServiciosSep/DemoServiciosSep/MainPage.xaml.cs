using DemoServiciosSep.Dependencia;
using System;
using Xamarin.Forms;

namespace DemoServiciosSep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Demo Servicios", $"Versión: {DependencyService.Get<IServicioDemo>().ObtenerVersionApp()}", "Ok");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var ServDemo = DependencyService.Get<IServicioDemo>();

            if (ServDemo != null)
            {
                ServDemo.EjecutaCallback((mensaje) => {
                    System.Diagnostics.Debug.WriteLine(mensaje);

                    return true;
                });
            }
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            var ServDemo = DependencyService.Get<IServicioDemo>();

            if (ServDemo != null) {
                ServDemo.EjecutaEvento += (s, mensaje) => {
                    DisplayAlert("Demo Servicios", mensaje, "Ok");
                };

                ServDemo.EjecutaConEvento();
            }
        }
    }
}
