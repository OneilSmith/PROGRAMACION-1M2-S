using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistencia
{
    public class Universidad
    {
        public class Estudiante
        {
            public string Nombre { get; private set; }
            public int SesionesTotales { get; private set; }
            public int SesionesAsistidas { get; private set; }

            public Estudiante(string nombre, int sesionesTotales)
            {
                Nombre = nombre;
                SesionesTotales = sesionesTotales;
                SesionesAsistidas = 0;
            }

            public void RegistrarAsistencia(int sesiones)
            {
                SesionesAsistidas += sesiones;
            }

            public class Asistencia
            {
                public static double CalcularPorcentajeAsistencia(int sesionesAsistidas, int sesionesTotales)
                {
                    if (sesionesTotales == 0) return 0;
                    return (double)sesionesAsistidas / sesionesTotales * 100;
                }

                public static bool CumpleMinimoAsistencia(int sesionesAsistidas, int sesionesTotales, double minimo = 75)
                {
                    double porcentaje = CalcularPorcentajeAsistencia(sesionesAsistidas, sesionesTotales);
                    return porcentaje >= minimo;
                }
            }

            public string ObtenerInformacion()
            {
                double porcentaje = Asistencia.CalcularPorcentajeAsistencia(SesionesAsistidas, SesionesTotales);
                bool cumpleMinimo = Asistencia.CumpleMinimoAsistencia(SesionesAsistidas, SesionesTotales);
                string estado = cumpleMinimo ? "Aprobado" : "No Aprobado";

                return $"Nombre: {Nombre}, Sesiones Totales: {SesionesTotales}, " +
                       $"Sesiones Asistidas: {SesionesAsistidas}, " +
                       $"Porcentaje de Asistencia: {Math.Round(porcentaje, 2)}%, " +
                       $"Estado: {estado}";
            }
        }
    }
}