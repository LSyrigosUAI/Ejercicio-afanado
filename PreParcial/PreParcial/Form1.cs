using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace PreParcial
{
    public partial class Form1 : Form
    {

        Curso curso = new Curso();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            curso.AgregarAlumnos(new Alumno("1237") { Nombre = "Tongas", HorasEstudio = 51, });
            curso.AgregarAlumnos(new Alumno("1448") { Nombre = "Pedro", HorasEstudio = 1332, });
            curso.AgregarAlumnos(new Alumno("XDDD") { Nombre = "Plomo", HorasEstudio = 1, });
            curso.AgregarAlumnos(new Alumno("9012") { Nombre = "Juanicho", HorasEstudio = 555,});
            curso.AgregarAlumnos(new Alumno("1337") { Nombre = "Juanzet", HorasEstudio = 1337,  });
            curso.AgregarAlumnos(new Alumno("1517") { Nombre = "Geider", HorasEstudio = 20, });
            curso.AgregarAlumnos(new Alumno("151754") { Nombre = "Lauty", HorasEstudio = 31, });
            curso.AgregarAlumnos(new Alumno("145661") { Nombre = "Dani", HorasEstudio = 37, });
            Actualizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            curso.TomarExamen();
            Actualizar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Actualizar()
        {
            dgvN.DataSource = null;
            dgvN.DataSource = curso.alumnos;
        }
    }
}
