using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Encriptacio;

namespace Projecte1
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Enter_button_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //CLOSE BUTTON EVENTS
        private void Close_button_MouseMove(object sender, MouseEventArgs e)
        {
            Close_button.BackgroundImage = Main.Resources.RedClose_Icon;
        }

        private void Close_button_MouseLeave(object sender, EventArgs e)
        {
            Close_button.BackgroundImage = Main.Resources.Close_Icon;
        }

        //CHECK BUTTON EVENTS
        private void Enter_button_MouseMove(object sender, MouseEventArgs e)
        {
            Enter_button.BackgroundImage = Main.Resources.GreenCheck_Icon;
        }

        private void Enter_button_MouseLeave(object sender, EventArgs e)
        {
            Enter_button.BackgroundImage = Main.Resources.Check_Icon;
        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Entrar();
            }
        }

        AccesDades.ADO bd = new AccesDades.ADO();
        DataSet dts;
        string consulta;

        //FUNCTIONS 
        private void Entrar()
        {
            Encriptar E = new Encriptar();

            string contrasenyaEncriptada = "";

            consulta = "SELECT IDUSER, PASSWORD " +
                       "FROM USERS " +
                       "WHERE LOGIN = '" + textBox_username.Text.Trim() + "'";

            dts = bd.PortaDades(consulta);

            if (dts.Tables[0].Rows.Count == 1)
            {
                contrasenyaEncriptada = E.GenerarHash(textBox_password.Text.Trim());

                if (dts.Tables[0].Rows[0][1].ToString() == contrasenyaEncriptada)
                {
                    consulta = "SELECT USERS.IDUSER, USERS.USERNAME, USERS.PHOTO, USERCATEGORIES.ACCESSLEVEL " +
                               "FROM USERS, USERCATEGORIES " +
                               "WHERE USERS.IDUSERCATEGORY = USERCATEGORIES.IDUSERCATEGORY " +
                               "AND IDUSER = " + dts.Tables[0].Rows[0][0];

                    dts = bd.PortaDades(consulta);

                    Form_MainForm NextForm = new Form_MainForm(dts.Tables[0].Rows[0][0].ToString(), dts.Tables[0].Rows[0][1].ToString(), dts.Tables[0].Rows[0][2].ToString(), dts.Tables[0].Rows[0][3].ToString());
                    NextForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Entrar();
            }
        }
    }
}