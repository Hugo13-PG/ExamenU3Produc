using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenU3Produc
{
    public partial class Insertar_pro : Form
    {
        Datos datos = new Datos();
        public Insertar_pro()
        {
            InitializeComponent();
        }

        private void Insertar_pro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string precio = txtPrecio.Text;
            string desc = txtPrecio.Text;
            string nombre = txtNombre.Text;
            string cantidad = richTextBox1.Text;
            string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");


            
            string sql="INSERT INTO Producto (Nombre, Descripcion, Precio, Stock, FechaRegistro) " +
                      "VALUES ('" + nombre + "', '" + desc + "', '" + precio + "', '" + cantidad + "', '" + fecha + "');";
            if (datos.EjecutarComando(sql))
            {
                MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
