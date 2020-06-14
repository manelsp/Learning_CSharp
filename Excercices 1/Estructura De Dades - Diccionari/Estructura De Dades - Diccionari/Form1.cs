using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_De_Dades___Diccionari
{
    public partial class Dictionary : Form
    {
        Dictionary <char, string> DictionaryLetters = new Dictionary <char, string>();

        public Dictionary()
        {
            InitializeComponent();
        }

        private void buttonGenerarDiccionari_Click(object sender, EventArgs e)
        {
            DictionaryClass dictionaryClass = new DictionaryClass();

            DictionaryLetters = dictionaryClass.CreateDictionary();

            labelAlerts.Text = "Diccionari generat correctament";
            labelAlerts.ForeColor = Color.Green;

            labelAlerts.Visible = true;
        }

        private void buttonMostrarDiccionari_Click(object sender, EventArgs e)
        {
            listBoxLetters.Items.Clear();
            listBoxCode.Items.Clear();

            foreach (var item in DictionaryLetters)
            {
                listBoxLetters.Items.Add(item.Key.ToString());
                listBoxCode.Items.Add(item.Value);
            }

            if(DictionaryLetters.Count == 0)
            {
                labelAlerts.Text = "Genera el diccionari";
                labelAlerts.ForeColor = Color.Red;

                labelAlerts.Visible = true;
            }
            else
            {
                labelAlerts.Text = "Diccionari imprimit correctament";
                labelAlerts.ForeColor = Color.Green; 
            }
        }

        private void textBoxSequenciaDeLletres_KeyPress(object sender, KeyPressEventArgs e)
        {
            char letter; 

            foreach (var item in DictionaryLetters)
            {
                letter = Char.ToUpper(e.KeyChar);

                if (letter == item.Key)
                {
                    textBoxEquivalentSequenciaDeLletres.Text += item.Value; 
                }
            }
        }

        private void buttonInvertirCodificacio_Click(object sender, EventArgs e)
        {
            char letter;
            string numberString = "";
            int number;
            int valueNumber;

            textBoxInvertirCodificacio.Clear();

            for (int i = 0; i < textBoxEquivalentSequenciaDeLletres.Text.Length; i++)
            {
                letter = textBoxEquivalentSequenciaDeLletres.Text[i];

                numberString += letter; 

                if ((i+1)%4 == 0)
                {
                    number = int.Parse(numberString); 

                    foreach (var item in DictionaryLetters)
                    {
                        valueNumber = int.Parse(item.Value); 

                        if (valueNumber == number)
                        {
                            textBoxInvertirCodificacio.Text += item.Key;
                        }
                    }

                    numberString = ""; 
                }
            }

        }

        private void buttonEsborrarVocals_Click(object sender, EventArgs e)
        {
            DictionaryLetters.Remove('A');
            DictionaryLetters.Remove('E');
            DictionaryLetters.Remove('I');
            DictionaryLetters.Remove('O');
            DictionaryLetters.Remove('U');

            labelAlerts.Text = "Vocals eliminades";
        }
    }
}
