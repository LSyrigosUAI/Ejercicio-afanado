using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Alumno
    {
        public Alumno(string pLegajo)
        {
            _Legajo = pLegajo;
        }

        public string Nombre { get; set; }
        public int HorasEstudio { get; set; }

        public enum Nota { Aprobado, Desaprobado, Promocionado }
        public Nota nota { get; set; }

        private string _Legajo;
        private string Legajo { get { return _Legajo; } }

        public void RendirExamen(object sender, EventArgs e)
        {
            if(HorasEstudio <= 20)
            {
                nota = Nota.Desaprobado;
            }
            if(HorasEstudio >=21 && HorasEstudio <=50)
            {
                nota = Nota.Aprobado;
            }
            if (HorasEstudio >= 51)
            {
                nota = Nota.Promocionado;
            } 

        }

    }
}
