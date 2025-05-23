using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ExamenU3Produc
{
    public partial class ActualizaProductos : Form
    {
        public ActualizaProductos(string id, string nombre, string desc, string precio,  string cantidad, string fecha)
        {
            InitializeComponent();
            txtId.Text = id;
            txtNombre.Text = nombre;
            txtCantidad3.Text = cantidad;
            txtPrecio.Text = precio;
            richTextBox1.Text = desc;
            dateTimePicker1.Text = fecha;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            string id = txtId.Text,
              nombre = txtNombre.Text ,
            cantidad = txtCantidad3.Text,
            precio = txtCantidad3.Text,
            desc=richTextBox1.Text,
            fecha=dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");

            Datos datos = new Datos();

            string sql="UPDATE Producto SET " +
       " Nombre='" + txtNombre.Text +
       "',  Descripcion='" + richTextBox1.Text +
       "',  Precio='" + txtPrecio.Text +
       "',  Stock='" + txtCantidad3 +
       "',  FechaRegistro='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +
       "' WHERE ID='" + txtId.Text + "'";
            if (datos.EjecutarComando(sql))
            {
                MessageBox.Show("Registro actualizado", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseaes eliminar?", "Sistema", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string id = txtId.Text;
                Datos datos = new Datos();

                // Preguntar al usuario si realmente quiere eliminar
                DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Confirmar Eliminación",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Eliminar el usuario
                    bool eliminado = datos.EjecutarComando("DELETE FROM Producto WHERE ID = " + id);

                    if (eliminado)
                    {
                        // Resetear el ID para que se reorganice
                        datos.EjecutarComando("DBCC CHECKIDENT ('Producto', RESEED, 0);");

                        MessageBox.Show("Usuario eliminado y IDs reorganizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el usuario. Verifica el ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ActualizaProductos_Load(object sender, EventArgs e)
        {

        }
    }
}

