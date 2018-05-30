using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bravosoftbll
{
    public partial class LoginParte2 : Form
    {
        public LoginParte2()
        {
            InitializeComponent();

            
        }

        

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void Usuario_Click(object sender, EventArgs e)        {
            Usuario.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.PasswordChar = Convert.ToChar("*");
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            BaseDeDatodpTableAdapters.usuariosTableAdapter Usuarios = new BaseDeDatodpTableAdapters.usuariosTableAdapter();
            BaseDeDatodp.usuariosDataTable Temp = new BaseDeDatodp.usuariosDataTable();


            Temp = Usuarios.Login(Usuario.Text, textBox1.Text);
            if (Temp.Count > 0)
            {
                MessageBox.Show("Bienvenido " + Temp[0].Nombre);
                Login.Visible = false;
                panel1.Visible = false;
                

               
                
                
            }

            
        }

        

        
    }
}
