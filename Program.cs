using System;
using System.Collections.Generic;

namespace SistemaAsistencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Universidad.Estudiante> estudiantes = new List<Universidad.Estudiante>
            {
                new Universidad.Estudiante("Eli", 10),
                new Universidad.Estudiante("Juan Carlos", 10),
                new Universidad.Estudiante("Cirilo", 10),
                new Universidad.Estudiante("Erving", 7),
                new Universidad.Estudiante("Engels", 8),
                new Universidad.Estudiante("Noel", 7),
                new Universidad.Estudiante("Sharon", 9),
                new Universidad.Estudiante("Dylang", 8),

            };

            // Registrar asistencias
            estudiantes[0].RegistrarAsistencia(8); 
            estudiantes[1].RegistrarAsistencia(6); 
            estudiantes[2].RegistrarAsistencia(5);
            estudiantes[3].RegistrarAsistencia(5);
            estudiantes[4].RegistrarAsistencia(8);
            estudiantes[5].RegistrarAsistencia(4);
            estudiantes[6].RegistrarAsistencia(6);
            estudiantes[7].RegistrarAsistencia(5);

            // Mostrar información de cada estudiante
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine(estudiante.ObtenerInformacion());
            }
        }
    }
}

