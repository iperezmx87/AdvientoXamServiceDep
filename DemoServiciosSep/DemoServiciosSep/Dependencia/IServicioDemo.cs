using System;

namespace DemoServiciosSep.Dependencia
{
    public interface IServicioDemo
    {
        // obtener version del app
        string ObtenerVersionApp();

        // callback
        void EjecutaCallback(Func<string, bool> callback);

        // evento
        event EventHandler<string> EjecutaEvento;
        void EjecutaConEvento();

        // sdk especifico
        void EjecutaSdkEspecifico();
    }
}
