using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControls
{
    public class SWTextbox : TextBox
    {
        //PROPIEDADES
        public enum TipoDeDato { Texto, Numero, Fecha, Todo };

        private TipoDeDato _DatoCorrecto;
        private string _CampoBD;
        private string _ControlComboboxId;
        private bool _CampoVacio;
        private bool _EsForanea = false;
        private bool _DateIsValid = false;

        //Control Combobox Id
        public string ControlComboboxId
        {
            get { return _ControlComboboxId; }
            set { _ControlComboboxId = value; }
        }

        //ES FORANEA
        public bool EsForanea
        {
            get { return _EsForanea; }
            set { _EsForanea = value; }
        }

        //CAMPO VACIO
        public bool CampoVacio
        {
            get { return _CampoVacio; }
            set { _CampoVacio = value; }
        }

        //CAMPO BASE DATOS
        public string CampoBD
        {
            get { return _CampoBD; }
            set { _CampoBD = value; }
        }

        //DATO CORRECTO
        public TipoDeDato DatoCorrecto
        {
            get { return _DatoCorrecto; }
            set { _DatoCorrecto = value; }
        }

        //CONSTRUCTOR
        public SWTextbox()
        {
            InitializeComponent();
        }

        //INICIALITZACION DEL COMPONENTE
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextbox
            // 
            this.TextChanged += new System.EventHandler(this.SWTextbox_TextChanged);
            this.Enter += new System.EventHandler(this.FocoEnter);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TeclaKeyPress);
            this.Leave += new System.EventHandler(this.FocoLeave);
            this.ResumeLayout(false);

        }

        //EVENTOS   
        //DATO CORRECTO
        private void TeclaKeyPress(object sender, KeyPressEventArgs e)
        {
            //SOLO NUMEROS
            if (DatoCorrecto == TipoDeDato.Numero)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            //SOLO LETRAS
            else if (DatoCorrecto == TipoDeDato.Texto)
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (DatoCorrecto == TipoDeDato.Todo)
            {

                    e.Handled = false;
 
            }

            //FECHA
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/')) //TODO: Mejorar esto
                {
                    e.Handled = true;
                }
            }
        }

        //ENTRAR AL FOCUS 
        private void FocoEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        //TREURE EL FOCUS 
        private void FocoLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;

            //al perdre el focus comprovem si la data esta ben introduida
            if (DatoCorrecto == TipoDeDato.Fecha)
            {
                Regex regex = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");

                _DateIsValid = regex.IsMatch(this.Text.Trim());
            }
        }

        private void SWTextbox_TextChanged(object sender, EventArgs e)
        {
            if (_EsForanea)
            {
                Form myForm = this.FindForm();

                if (myForm != null)
                {
                    foreach (Control ctr in myForm.Controls)
                    {
                        if (ctr.Name == _ControlComboboxId)
                        {
                            try
                            {
                                ((SWCombobox)ctr).SelectedValue = Int32.Parse(this.Text);

                            }
                            catch (Exception)
                            {
                            }
                        }
                    }
                }
            }
        }
    }
}

