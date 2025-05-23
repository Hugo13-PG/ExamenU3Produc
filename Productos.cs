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
    public partial class PRODUCTO : Form
    {
        Datos datos = new Datos();        
        public PRODUCTO()
        {
            InitializeComponent();
        }
        private void Actualizar()
        {
            DataSet ds;
            ds = datos.comandoDS("SELECT ID AS [ID Producto], " +
                              "Nombre, Descripcion, Precio, Stock, FechaRegistro " +
                              "FROM Producto");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];

            }
        }

        private void PRODUCTO_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizaProductos actualiza = new ActualizaProductos(dataGridView1[0, e.RowIndex].Value.ToString(),
          dataGridView1[1, e.RowIndex].Value.ToString(), dataGridView1[2, e.RowIndex].Value.ToString(),
          dataGridView1[3, e.RowIndex].Value.ToString(), dataGridView1[4, e.RowIndex].Value.ToString(),
          dataGridView1[5, e.RowIndex].Value.ToString());
            actualiza.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insertar_pro insertar = new Insertar_pro();
            insertar.Show();
        }

        private void PRODUCTO_Activated(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
