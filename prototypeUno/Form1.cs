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

        //private void AbrirFormHija(object formhija) //Funcion con un objeto
        //{            //Panel que contiene al nuevo formulario
        //    if (this.panelContenido.Controls.Count > 0)  // existen elementros de control en el panel de contenido
        //        this.panelContenido.Controls.RemoveAt(0); // si ya existen controles u otros forms, los elimina
        //    Form fh = formhija as Form;  // Creacion de un formulario. Adquiere el nombre del formulario heredado 
        //    fh.TopLevel = false;   //Es un formulario secundario
        //    fh.Dock = DockStyle.Fill; //se acopla al tamaño del form contenedor
        //    this.panelContenido.Controls.Add(fh); // agrega el formulario 
        //    this.panelContenido.Tag = fh; 
        //    fh.Show();
        //}
        private void AbrirFormulario<MiForm>() where MiForm : Form, new ()
        {
            Form formulario;
            formulario = panelContenido.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelContenido.Controls.Add(formulario);
                panelContenido.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void BtnPractica1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<formPractica1>();
            BtnPractica1.BackColor = Color.FromArgb(0, 80, 200);

        }

        private void BtnPractica2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<formPractica2>();
            BtnPractica2.BackColor = Color.FromArgb(0, 80, 200);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BtnInicio_Click(null, e); //permite que el form Inicio se abra al iniciar la aplicación 
         
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["formPractica1"] == null)
                BtnPractica1.BackColor = Color.FromArgb(26, 32, 40);
            if (Application.OpenForms["formPractica2"] == null)
                BtnPractica2.BackColor = Color.FromArgb(26, 32, 40);
        }



    }

    
}
