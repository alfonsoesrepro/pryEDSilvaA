using pryEDSilvaA.BD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEDSilvaA.Formularios
{
    public partial class frmOperaciones : Form
    {
        private clsBaseDatos bd = new clsBaseDatos();

        public frmOperaciones()
        {
            InitializeComponent();

            
            // Selecciona un campo específico
            cmdProyeccionSimple.Click += (s, e) => bd.Listar(dgvTabla, "SELECT Titulo FROM Libro");

            // Selecciona varios campos
            cmdProyeccionMulti.Click += (s, e) => bd.Listar(dgvTabla, "SELECT Titulo, Precio, Cantidad FROM Libro");

            // Junta datos de dos tablas relacionadas
            cmdJuntar.Click += (s, e) => bd.Listar(dgvTabla,
                "SELECT Libro.Titulo, Autor.Nombre FROM Libro INNER JOIN Autor ON Libro.IdAutor = Autor.IdAutor");

            // Selecciona registros que cumplen una condición
            cmdSeleccionSimple.Click += (s, e) => bd.Listar(dgvTabla, "SELECT * FROM Libro WHERE Precio > 100");

            // Selecciona registros que cumplen múltiples condiciones
            cmdSeleccionMulti.Click += (s, e) => bd.Listar(dgvTabla,
                "SELECT * FROM Libro WHERE Precio > 50 AND Cantidad > 0");
            
            // Selecciona registros que cumplen una condición compleja
            cmdSeleccionConvolucion.Click += (s, e) => bd.Listar(dgvTabla,
                "SELECT * FROM Libro WHERE IdAutor IN (SELECT IdAutor FROM Autor WHERE Nombre LIKE 'J%')");

            // Une resultados de dos consultas
            cmdUnion.Click += (s, e) => bd.Listar(dgvTabla,
                "SELECT Titulo FROM Libro WHERE Precio < 50 UNION SELECT Titulo FROM Libro WHERE Precio > 200");

            // Devuelve registros comunes a dos consultas
            cmdInterseccion.Click += (s, e) => bd.Listar(dgvTabla,
                "SELECT L.Titulo FROM Libro L INNER JOIN Autor A ON L.IdAutor = A.IdAutor WHERE A.Nombre LIKE 'G%'");

            // Devuelve registros que están en una consulta pero no en otra
            cmdDiferencia.Click += (s, e) => bd.Listar(dgvTabla,
                "SELECT Titulo FROM Libro WHERE IdIdioma = 1 AND IdLibro NOT IN (SELECT IdLibro FROM Libro WHERE IdIdioma = 2)");
        }
    }
}