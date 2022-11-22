using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;
using entidades.Excepciones;

namespace Vista
{
    public partial class frmLoggin : Form
    {
        private Administracion gestion;
        public frmLoggin()
        {
            InitializeComponent();
            this.gestion = new Administracion();
        }

        private void btnCargarAdmin_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUser.Text) && string.IsNullOrEmpty(txtPass.Text))
            {
                txtUser.Text = "admin";
                txtPass.Text = "admin";
            }
            else 
            {
                MessageBox.Show("Error, limpia los campos");
            }
        }

        private bool BuscarAdmin(string user, string pass) 
        {
            bool todoOk = false;
            List<Admin> list = new List<Admin>();
            if (user != null && pass != null) 
            {
                list = GestorSQL.LeerAdmin();
                foreach(Admin item in list) 
                {
                    if(item.Nombre == this.txtUser.Text && item.Apellido == this.txtPass.Text) 
                    {
                        todoOk = true;
                        break;
                    }

                }
            }
            return todoOk;
        }
        private bool BuscarProfesor(string user, string pass)
        {
            bool todoOk = false;
            List<Profesor> list = new List<Profesor>();
            if (user != null && pass != null)
            {
                list = GestorSQL.LeerProfesor();
                foreach (Profesor item in list)
                {
                    if (item.Nombre == this.txtUser.Text && item.Apellido == this.txtPass.Text)
                    {
                        todoOk = true;
                        break;
                    }
 
                }
            }
            return todoOk;
        }
        private bool BuscarAlumno(string user, string pass)
        {
            bool todoOk = false;
            List<Alumno> list = new List<Alumno>();
            if (user != null && pass != null)
            {
                list = GestorSQL.LeerAlumno();
                foreach (Alumno item in list)
                {
                    if (item.Nombre == this.txtUser.Text && item.Apellido == this.txtPass.Text)
                    {
                        todoOk = true;
                        break;
                    }

                }
            }
            return todoOk;
        }
 

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (!String.IsNullOrEmpty(txtUser.Text) && !String.IsNullOrEmpty(txtPass.Text))
                {

                    if (BuscarAdmin(txtUser.Text, txtPass.Text))
                    {
                        //abrir form admin

                        frmAdminPrincipal frm = new frmAdminPrincipal(this.gestion);
                        frm.ShowDialog();

                    }
                    else if (BuscarProfesor(txtUser.Text, txtPass.Text))
                    {
                        List<Profesor> list = GestorSQL.LeerProfesor();
                        Profesor profAux = new Profesor();
                        foreach (Profesor profesor in list) 
                        {
                            if(profesor.Nombre == txtUser.Text && profesor.Apellido == txtPass.Text) 
                            {
                                profAux = profesor;
                                break;
                            }
                        }
                        frmProfesorPrincipal frm = new frmProfesorPrincipal(this.gestion, profAux);
                        frm.ShowDialog();
                        //abrir form profesor
                    }
                    else if (BuscarAlumno(txtUser.Text, txtPass.Text))
                    {
                        //abrir form alumno
                        List<Alumno> list = GestorSQL.LeerAlumno();
                        Alumno alumnoAux = new Alumno();
                        foreach(Alumno alumno in list) 
                        {
                            if(alumno.Nombre == txtUser.Text && alumno.Apellido == txtPass.Text) 
                            {
                                alumnoAux = alumno;
                                break;
                            }
                        }
                        frmAlumnoPrincipal frm = new frmAlumnoPrincipal(this.gestion, alumnoAux);
                        frm.ShowDialog();
                    }
                    else 
                    {
                        MessageBox.Show("No se encontro el usuario", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(UsuarioNoExisteExcepcion ex) 
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception) 
            {
                MessageBox.Show("Error!");
            }
            
        }

        private void frmLoggin_Load(object sender, EventArgs e)
        {
            try 
            {
            }
            catch(CargaInvalidaSQLExcepcion ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception) 
            {
                MessageBox.Show("Error!");
            }


        }

        private void btnCargarProfesor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) && string.IsNullOrEmpty(txtPass.Text))
            {
                txtUser.Text = "profesor";
                txtPass.Text = "profesor";
            }
            else
            {
                MessageBox.Show("Error, limpia los campos");
            }
        }

        private void btnCargarAlumno_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtUser.Text) && string.IsNullOrEmpty(txtPass.Text))
            {
                txtUser.Text = "alumno";
                txtPass.Text = "alumno";
            }
            else
            {
                MessageBox.Show("Error, limpia los campos");
            }
        }
    }
}
