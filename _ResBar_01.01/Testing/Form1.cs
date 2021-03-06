﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ResBarLib;

namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            
               // List<Categoria> categorias = new List<Categoria>();
                List<producto> prod = new List<producto>();
                
               // prod = ManejadorProductos.ObtenerxCategoria(1);
                //prod = ManejadorProductos.Buscar("po",2);
                //prod = ManejadorCategorias.Obtener(false);
                dataGridView1.DataSource = prod;
            
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            producto p2 = new producto();
            p2.idProducto = 11;
            p2.nombre = "prueba";
            p2.precio = 10.00;
            p2.categoria.idCategoria = 2;
            p2.area = 'c';

            try
            {
                if (ManejadorProductos.Insertar(p2) > 0)
                {
                    MessageBox.Show("Registro Insertado");
                }
                else
                {
                    MessageBox.Show("No se inserto");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            producto p2 = new producto();
            p2.idProducto = 11;
            p2.nombre = "pruebaActualizar";
            p2.precio = 15.00;
            p2.categoria.idCategoria = 2;
            p2.area = 'c';

            try
            {
                if (ManejadorProductos.Actualizar(p2) > 0)
                {
                    MessageBox.Show("Registro Actualizado");
                }
                else
                {
                    MessageBox.Show("No se Actualizo");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            producto p2 = new producto();
            p2.idProducto = 11;
            p2.nombre = "pruebaActualizar";
            p2.precio = 15.00;
            p2.categoria.idCategoria = 2;
            p2.area = 'c';

            try
            {
                if (ManejadorProductos.Eliminar(p2) > 0)
                {
                    MessageBox.Show("Registro Eliminado");
                }
                else
                {
                    MessageBox.Show("No se Elimino");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
