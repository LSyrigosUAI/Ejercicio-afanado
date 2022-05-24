using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Curso
    {
        public event EventHandler tomoExamen; // declarar el evento

        public List<Alumno> alumnos = new List<Alumno>();

        public void AgregarAlumnos(Alumno alumno)
        {
            alumnos.Add(alumno);
            tomoExamen += alumno.RendirExamen; // asocio el handler al evento
        }

        public void TomarExamen()
        {
            tomoExamen(this, null);
        }

    }
}
