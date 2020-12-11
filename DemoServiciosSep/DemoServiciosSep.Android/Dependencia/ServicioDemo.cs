using DemoServiciosSep.Dependencia;
using DemoServiciosSep.Droid.Dependencia;
using Plugin.CurrentActivity;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(ServicioDemo))]
namespace DemoServiciosSep.Droid.Dependencia
{
    public class ServicioDemo : IServicioDemo
    {
        public event EventHandler<string> EjecutaEvento;

        public async void EjecutaCallback(Func<string, bool> callback)
        {
            if (callback != null)
            {
                System.Diagnostics.Debug.WriteLine("ejecutando el metodo desde el proyecto nativo");

                await Task.Delay(1000);

                callback.Invoke("hola a todos");
            }
        }

        public void EjecutaConEvento()
        {
            System.Diagnostics.Debug.WriteLine("ejecutando el metodo con un evento");

            EjecutaEvento?.Invoke(this, "Mensaje devuelto desde el evento");
        }

        public void EjecutaSdkEspecifico()
        {
            throw new NotImplementedException();
        }

        public string ObtenerVersionApp()
        {
            return CrossCurrentActivity.Current.AppContext.PackageManager.GetPackageInfo(
                CrossCurrentActivity.Current.AppContext.PackageName, 0).VersionName;
        }
    }
}