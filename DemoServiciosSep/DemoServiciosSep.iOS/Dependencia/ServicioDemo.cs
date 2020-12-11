using DemoServiciosSep.Dependencia;
using DemoServiciosSep.iOS.Dependencia;
using Foundation;
using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(ServicioDemo))]
namespace DemoServiciosSep.iOS.Dependencia
{
    public class ServicioDemo : IServicioDemo
    {
        public event EventHandler<string> EjecutaEvento;

        public void EjecutaCallback(Func<bool> callback)
        {
            throw new NotImplementedException();
        }

        public void EjecutaConEvento()
        {
            throw new NotImplementedException();
        }

        public void EjecutaSdkEspecifico()
        {
            throw new NotImplementedException();
        }

        public string ObtenerVersionApp()
        {
            return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleVersion").ToString();
        }
    }
}