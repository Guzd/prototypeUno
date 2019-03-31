using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototypeUno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirFormHija(object formhija) //Funcion con un objeto
        {            //Panel que contiene al nuevo formulario
            if (this.panelContenido.Controls.Count > 0)  // existen elementros de control en el panel de contenido
                this.panelContenido.Controls.RemoveAt(0); // si ya existen controles u otros forms, los elimina
            Form fh = formhija as Form;  // Creacion de un formulario. Adquiere el nombre del formulario heredado 
            fh.TopLevel = false;   //Es un formulario secundario
            fh.Dock = DockStyle.Fill; //se acopla al tamaño del form contenedor
            this.panelContenido.Controls.Add(fh); // agrega el formulario 
            this.panelContenido.Tag = fh; 
            fh.Show();
        }

        private void BtnPractica1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new formPractica1());
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            BtnInicio_Click(null, e);
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new formInicio());
        }
    }

    
}
