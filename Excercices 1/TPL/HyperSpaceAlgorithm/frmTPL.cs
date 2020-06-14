using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPL
{
    public partial class frmTPL : Form
    {
        public frmTPL()
        {
            InitializeComponent();
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            Task.Run(StartProcess);

            lstData1.Items.Clear();
            lstData1.BackColor = Color.White;

            lstData2.Items.Clear();
            lstData2.BackColor = Color.White;

            lstData3.Items.Clear();
            lstData3.BackColor = Color.White;
        }

        private void StartProcess()
        {
            string[] nomFitxer = { "1.txt", "2.txt", "3.txt" };

            char[] charArray = { ' ', '\n', '\r', '-', ',', '.', '?', '!', ':', ';', '[', ']', Convert.ToChar(39) };


            Parallel.ForEach(nomFitxer, s =>
            {
                Control[] lists = Controls.Find("lstData" + s.ToString().Substring(0, 1), true);

                DoChecks(File.ReadAllText(s).Split(charArray), ((ListBox)lists[0]));
            }); 
        }
       

        private void DoChecks(string[] words, ListBox list)
        {
            string[] Searchwords = { "white", "time", "that", "the", "empty", "door", "table" };
            string[] SearchLetter = { "A", "C", "W", "Z", "L", "S", "E" };
                       
            Random rnd = new Random();

            Parallel.Invoke(() => {

                string longWord = GetLongestWord(words);

                list.Invoke((MethodInvoker)delegate
                {
                   list.Items.Add(longWord);
                }); 
            },
            () => 
            {
                string commonWord = GetMostCommonWords(words, rnd.Next(4, 10), 5);

                list.Invoke((MethodInvoker)delegate
                {
                    list.Items.Add(commonWord);
                });
            },
            () => 
            {
                string commonWord = GetMostCommonWordsByLength(words, rnd.Next(4, 10), 5);
                list.Invoke((MethodInvoker)delegate
                {
                    list.Items.Add(commonWord);
                });
            },
            () =>
            {
                string countWord = GetCountForWord(words, Searchwords[rnd.Next(1, 7)]);

                list.Invoke((MethodInvoker)delegate
                {
                    list.Items.Add(countWord);
                });
            },
            () =>    
            {
                string letters = GetCountForLetter(words, SearchLetter[rnd.Next(1, 7)]);
                list.Invoke((MethodInvoker)delegate
                {
                    list.Items.Add(letters);
                });
            },
            () =>
            {
                 string lessCommon = GetLessCommonWords(words, rnd.Next(4, 10), 5);

                 list.Invoke((MethodInvoker)delegate
                 {
                     list.Items.Add(lessCommon);
                 });
            });

            list.Invoke((MethodInvoker)delegate
            {
                list.BackColor = Color.Green;
            });
        }

        #region HelperMethods

        private string  GetLongestWord(string[] words)
        {
            //cerca la paraula més llarga del llibre
            string longestWord =   ( 
                                     from word in words
                                     orderby word.Length descending
                                     select word).First();

            string resultat= " Task 1 - GetLongestWord: " + longestWord;
            return resultat;
        }
        

        private string GetMostCommonWords(string[] words, int len,  int quants)
        {

            // cerca les paraules que apareixen més cops d'una determinada llargada i ens mostren quines són i quants cops apareixen
            // l'argument quants indica quantes paraules hem de mostrar Si indiquem 5 vol dir que mostrem les 5 que surten més
            // per defecte passem sempre 5
            // l'argument len indica la llargada de les paraules i s'obtindrà a partir d'obtenir 
            // un nombre random entre 4 i 10 a la funció que fa la crida a aquesta

            var commonWords =   from word in words
                                where word.Length > len
                                group word by word into g
                                orderby g.Count() descending
                                select new { Word = g.Key, Count = g.Count() };

             commonWords = commonWords.Take(quants); 


            string resultat = " Task 2 - GetLongestWord with more than: " + len + "letters ";

            foreach (var item in commonWords)
            {
                resultat += item; 
            }

            return resultat;
        }


        private string GetMostCommonWordsByLength(string[] words, int len, int quants)
        {
            // cerca les paraules que apareixen més cops d'una determinada llargada i ens mostren quines són i quants cops apareixen
            // l'argument quants indica quantes paraules hem de mostrar Si indiquem 5 vol dir que mostrem les 5 que surten més
            // per defecte passem sempre 5
            // l'argument len indica la llargada de les paraules i s'obtindrà a partir d'obtenir un nombre random entre 4 i 10 a la funció que fa la crida a aquesta

            var wordsByLength = from word in words
                                where word.Length == len
                                group word by word into g
                                orderby g.Count() descending
                                select new { Word = g.Key, Count = g.Count() };

            wordsByLength = wordsByLength.Take(quants);

            string resultat = "Task 3 - GetMostCommonWordsByLength: " + len + "letters ";

            foreach (var item in wordsByLength)
            {
                resultat += item;
            }

            return resultat;
        }

        private string GetCountForWord(string[] words, string term)
        {
            // cerca quants cops apareix la paraula term en el llibre
            // l'argument term és cadascuna de les paraules que hi ha en l'array de paraules de DoChecks

            var countWords = from word in words
                                 where word.Contains(term)
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Count();

            countWords = countWords.Take(1);

            string resultat = "Task 4 - The word " + term + " occurs ";
            
            foreach (var item in countWords)
            {
                resultat += item;
            }

            return resultat;
        }

        private string GetCountForLetter(string[] words, string letter)
        {
            // cerca quants cops apareixen paraules que comencen amb la lletra indicada a l'argument letter 
            // l'argument letter és cadascuna de les lletres que hi ha en l'array de lletres de  DoChecks
            
            var countLetters = from word in words
                                 where word.Length > 0 && word.Substring(0, 1) == letter
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Count();

            countLetters = countLetters.Take(1);

            string resultat = "Task 5 - The word that start with: " + letter.ToUpper() + " occurs ";
            
            foreach (var res in countLetters)
            {
                resultat += res;
            }

            resultat += " times";
            return resultat;
        }

        private string  GetLessCommonWords(string[] words, int len, int quants)
        {
            // cerca quants cops apareixen les paraules que menys apareixen i que tenen una determinada llargada
            // l'argument quants indica quantes paraules hem de mostrar. Si indiquem 5 vol dir que mostrem les 5 que surten menys
            // per defecte passem sempre 5 
            // l'argument len indica la llargada de les paraules i s'obtindrà a partir d'obtenir 
            // un nombre random entre 4 i 10 a la funció que fa la crida a aquesta

            var lessCommon = from word in words
                                 where word.Length == len
                                 group word by word into g
                                 orderby g.Count() ascending
                                 select new { Word = g.Key, Count = g.Count() };

            lessCommon = lessCommon.Take(quants);

            string resultat = "Task 6 - GetLessCommonWordsByLength with " + len + " letters: ";
            foreach (var v in lessCommon)
            {
                resultat += v;
            }

            return resultat;
        }

        ///Falten les funcions que llegeixen el fitxer i en darrer cas el transformen en un array de strings amb les paraules. 
        ///Podeu utilitzar la funció de l'exemple com a base (CreateWordArray), però penseu que ara els fitxers són locals i no  una URL,
        ///i que potser caldrà fer-ho d'una forma una mica diferent per afavorir automatitzar el programa.

        #endregion
    }
}
