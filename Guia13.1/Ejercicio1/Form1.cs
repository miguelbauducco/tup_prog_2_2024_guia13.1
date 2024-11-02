using Ejercicio1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Agencia agencia = new Agencia();

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Ticket t = null;

                if (radioButton1.Checked)
                {
                    string patente = textBox1.Text;
                    Vehiculo v = agencia.BuscarVehiculo(patente);

                    if (v != null)
                    {
                        t = new Denuncia(v);
                        agencia.AgregarTicket(t);
                    }
                    else
                    {
                        MessageBox.Show("Vehiculo no registrado");
                    }
                }
                if (radioButton2.Checked)
                {
                    long dni = Convert.ToInt32(textBox2.Text);
                    t = new Cliente(dni);
                    agencia.AgregarTicket(t);
                }
                listBox1.Items.Add(t);
            }
            catch (DniInvalidoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                { MessageBox.Show(ex.Message); }
            }
        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
