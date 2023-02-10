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
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Info_o_klientach//pamietaj zeby dodac ze dwoch naraz nie zanzaczasz!!
{
    public partial class StronaGlowna : Form
    {
        public static string wiersz_z_okna_wpisowego;

        private static int szerokosc_komorki = 117;
        private static int wysokosc_komorki = 30;

        private string[] odczyt;//tablica wierszy odczytanych z pliku

        public static int liczba_kolumn;
        private int liczba_wierszy;

        private string[,] dane;//kazda pojedyncza komorka [numer wersu,numer komorki]
        private string obslugiwany_plik;
        //  private int edytowane_komorki = 0;
        private bool czy_wybrano_plik = false;
        private int numer_pliku;
        public string[] ustawienia;
        public bool pierwsza_tabela = true;

        public static int index_edytowanego_wersu;
        public static int index_poprzedni_edytowanego_wersu;
        public StronaGlowna()
        {
            InitializeComponent();
            ustawienia = zczytaj(@"config.txt");
            numer_pliku = Convert.ToInt32(ustawienia[0]);
        }

        private void wygeneruj_tabele()
        {
            panel1.Controls.Clear();
            dopisz(obslugiwany_plik, "");//jezeli zapisujemy cos w pliku ta linijka pozwala na zapisanie w nowej lini

            odczyt = zczytaj(obslugiwany_plik);
            if (pierwsza_tabela)
            {
                liczba_kolumn = odczyt[0].Split(';').Length;
                pierwsza_tabela = false;
            }
            liczba_wierszy = odczyt.Length;
            dane = new string[liczba_wierszy, liczba_kolumn];

            // uzupelnia wartos tablicy danych
            for (int i = 0; i < liczba_wierszy; i++)
            {
                for (int p = 0; p < liczba_kolumn; p++)
                {
                    dane[i, p] = odczyt[i].Split(';')[p];
                }
            }

            //printuje wersy
            int y = 0;
            for (int i = 0; i < 128; i++)
            {
                int puste = 0;
                for (int p = 0; p < liczba_kolumn; p++)
                {
                    if (p == 4 || p == 5 || (p > 9 && p < 18) || (p > 19 && p < 23) && (dane[i, p] == "" || dane[i, p] == null))
                    {
                        puste++;
                    }
                    else
                    {
                        stworz_label(szerokosc_komorki * (p - puste), y * wysokosc_komorki, szerokosc_komorki, wysokosc_komorki, dane[i, p], i.ToString() + '~' + p.ToString());
                    }
                }
                y++;
            }
        }
        private string[] zczytaj(string co_zczytuje)
        {
            StreamReader bazaR = new StreamReader(co_zczytuje);
            string linia;
            int index = 0;
            string[] plik = new string[liczba_wierszy_bez_nulla(co_zczytuje)];
            while ((linia = bazaR.ReadLine()) != null && (linia = bazaR.ReadLine()) != "")
            {
                plik[index] = linia;
                index++;
            }
            bazaR.Close();
            return plik;
        }
        private string wybierz_plik()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:\\Users\\" + Environment.UserName + "\\Downloads";
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return (openFileDialog1.FileName);
            }
            return "";
        }
        private string wybierz_folder()
        {
            FolderBrowserDialog wybierz_folder = new FolderBrowserDialog();
            wybierz_folder.ShowDialog();
            return wybierz_folder.SelectedPath;
        }
        private int liczba_wierszy_bez_nulla(string co_zczytuje)
        {
            int i = 0;

            StreamReader bazaR = new StreamReader(co_zczytuje);
            while (bazaR.ReadLine() != null && bazaR.ReadLine() != "")
            {
                i++;
            }
            bazaR.Close();
            return i;
        }
        private void dopisz(string gdzie_zapisz, string co_zapisz)
        {
            File.AppendAllLines(gdzie_zapisz, new[] { co_zapisz });
        }
        private void stworz_label(int x, int y, int x_rozmiar, int y_rozmiar, string wartosc, string nazwa)
        {
            Label label = new Label();
            label.Text = wartosc;
            label.Name = nazwa;
            label.Location = new Point(x, y);
            label.Size = new Size(x_rozmiar, y_rozmiar);
            label.BorderStyle = BorderStyle.Fixed3D;
            label.DoubleClick += zaznaczanie;
            panel1.Controls.Add(label);
        }
        /* private void edytuj(object sender, EventArgs e)
         {
             Label text = (Label)sender;
             TextBox textbox = new TextBox();
             textbox.Text = text.Text;
             textbox.Name = text.Name;
             textbox.Location = new Point(text.Location.X, text.Location.Y);
             textbox.Size = new Size(szerokosc_komorki, wysokosc_komorki);
             textbox.DoubleClick += zatwierdz_edycje_podwojnym_kliknieciem;
             textbox.KeyDown += zatwierdz_edycje_enterem;
             panel1.Controls.Remove(text);
             textbox.SelectionStart = textbox.Text.Length;
             panel1.Controls.Add(textbox);
         }
         private void zatwierdz_edycje_podwojnym_kliknieciem(object sender, EventArgs e)
         {   //edytowane_komorki--;

             TextBox textbox = (TextBox)sender;
             string x = textbox.Name.Split('~')[1];
             string y = textbox.Name.Split('~')[0];

             dane[Convert.ToInt32(y), Convert.ToInt32(x)] = textbox.Text;

             panel1.Controls.Remove(textbox);
             stworz_label(textbox.Location.X, textbox.Location.Y, szerokosc_komorki, wysokosc_komorki, textbox.Text, textbox.Name);

         }
         private void zatwierdz_edycje_enterem(object sender, KeyEventArgs e)
         {
             //edytowane_komorki--;

             if (e.KeyCode == Keys.Enter)
             {
                 TextBox textbox = (TextBox)sender;
                 string x = textbox.Name.Split('~')[1];
                 string y = textbox.Name.Split('~')[0];

                 dane[Convert.ToInt32(y), Convert.ToInt32(x)] = textbox.Text;

                 panel1.Controls.Remove(textbox);
                 stworz_label(textbox.Location.X, textbox.Location.Y, szerokosc_komorki, wysokosc_komorki, textbox.Text, textbox.Name);
             }
         }*/

        private void edytuj_linie(object sender, EventArgs e)
        {
            string[] tab = new string[liczba_kolumn];
            for (int i = 0; i < liczba_kolumn; i++)
            {
                tab[i] = dane[index_edytowanego_wersu, i];
            }
            Form2 edycja = new Form2(this,tab);
            edycja.Show();
        }
        private void zaznaczanie(object sender, EventArgs e)
        {
            Label text = (Label)sender;
            string s = text.Name.Split('~')[0];
            index_edytowanego_wersu = Convert.ToInt32(s);
            for (int i = 0; i < liczba_kolumn; i++)
            {
                try
                {
                    Label label = (Label)panel1.Controls.Find(s + '~' + i.ToString(), false)[0];
                    label.BackColor = Color.LightSteelBlue;
                }
                catch
                {

                }
            }
        }
        public string zmiana_danych_w_string()
        {
            string wynik = "";
            for (int i = 0; i < liczba_wierszy; i++)
            {
                for (int p = 0; p < liczba_kolumn; p++)
                {
                    if (i != liczba_wierszy)
                    {
                        wynik += dane[i, p] + ';';
                    }
                }
                wynik += Environment.NewLine;
            }
            return wynik;
        }

        private void otworz_plik(object sender, EventArgs e)
        {
            string plik = wybierz_plik();
            if (plik != "")
            {
                if (plik.Substring(plik.Length - 3, 3) == "csv")
                {
                    obslugiwany_plik = plik;
                    wygeneruj_tabele();
                    czy_wybrano_plik = true;
                }
                else
                {
                    MessageBox.Show("Program obsługuje tlyko pliki csv");
                    otworz_plik(sender, e);
                }
            }
        }

        private void zapisz_plik(object sender, EventArgs e)
        {
            if (czy_wybrano_plik)
            {
                //if(edytowane_komorki == 0)
                {
                    string folder = wybierz_folder();

                    dopisz(folder + "\\olek.csv", zmiana_danych_w_string());

                }
                //else
                {
                    // MessageBox.Show("Nie można zapisać, ponieważ "+edytowane_komorki+" komórek jest nadal w edycji");
                }
            }
            else
            {
                MessageBox.Show("Nie mam czego zapisać");
            }
        }
        private void wybierz_klienta(object sender, EventArgs e)
        {
            
        }
        public static void po_nazwie_przypisanie_wartosc_dla_labela(string nazwa,string wartosc,StronaGlowna obiekt)
        {
            try
            {
                obiekt.panel1.Controls.Find(nazwa, true)[0].Text = wartosc;
            }
            catch
            {
                MessageBox.Show(nazwa+wartosc);
            }
        } 
        private void dodaj_wpis(object sender, EventArgs e)
        {
            Form2 dodawanie = new Form2(this);
            dodawanie.Show();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            string config = "";
            foreach (string u in ustawienia)
            {
                //MessageBox.Show(u);
                config += u;
            }
            //MessageBox.Show(config);
            File.WriteAllText(@"config.txt", "0");
        }
    }
}
