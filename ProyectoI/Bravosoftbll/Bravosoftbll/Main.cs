using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Bravosoftbll
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        [DllImport("user32.dll",EntryPoint="ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll",EntryPoint="SendMessage")]
        private extern static void SendMessage(System.IntPtr  hwnd,int wmdg, int wparam, int iparadm);


        private void Cuerpo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width==250) {
                MenuVertical.Width=70;
            }
                else

                MenuVertical.Width=250;

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Restaurar.Visible = true;
            Minimizar.Visible = false;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Minimizar.Visible = true;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Barra_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void Barra_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        
        }

        private void Barra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage (this.Handle, 0x112,0xf012,0);


        }

        private void AbrirFormInPanel(Object formhijo)
        {
            if (this.Cuerpo.Controls.Count > 0)
                this.Cuerpo.Controls.RemoveAt(0);
            Form Fh = formhijo as Form;
            Fh.TopLevel = false;
            Fh.Dock = DockStyle.Fill;
            this.Cuerpo.Controls.Add(Fh);
            this.Cuerpo.Tag=(Fh);
            Fh.Show();
        }

        private void Empleado_Click(object sender, EventArgs e)
        {
        AbrirFormInPanel(new Empleado());
        }

        private void Contrato_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Contrato());
        }

        private void Area_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Area());
        }

        private void Vacantes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Vacantes());
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Registro());
        }

        private void Main_Load(object sender, EventArgs e)
        {
           

            
          
            
            MenuL.Visible = false;
            MenuVertical.Visible = false;
         

            AbrirFormInPanel(new LoginParte2());

            
           



        }

        private void Cuerpo_Paint_1(object sender, PaintEventArgs e)
        {

        }

         




        
        
        }
       
         
       
    }

