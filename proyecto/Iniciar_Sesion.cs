﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Iniciar_Sesion : Form
    {
        public Iniciar_Sesion()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
           Main parent = (Main)this.MdiParent;
           ConjuntoDatosUsuarioTableAdapters.usuariosTableAdapter usuario = new ConjuntoDatosUsuarioTableAdapters.usuariosTableAdapter();
           ConjuntoDatosUsuario.usuariosDataTable temp = new ConjuntoDatosUsuario.usuariosDataTable();

           temp = usuario.Login(txt_usuario.Text, txt_contraseña.Text);

           if (temp.Count > 0)
           {
               MessageBox.Show("Bienvenido " + temp[0].Nombre);

              if (temp[0].Tipo_Usuario == 1)
               {
                   parent.opcionesAdministrador();
               }
               else
               {
                   parent.opcionesUsuario();
               }

              this.Close();
           }
           else
           {
               MessageBox.Show("El usuario o la contraseña es incorrecto");
           }
            
        }

      
    }
}
