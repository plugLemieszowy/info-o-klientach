using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Info_o_klientach
{
    public partial class Form2 : Form
    {
        public TextBox[] text_boxy = new TextBox[11];
        public StronaGlowna strona_glowna;
        public Form2(StronaGlowna obiekt)
        {
            InitializeComponent();
            StronaGlowna.wiersz_z_okna_wpisowego = "";
            strona_glowna= obiekt;
        }
        public Form2(StronaGlowna obiekt,string[] tab)
        {
            InitializeComponent();
            start();
            int p = 0;
            for(int i = 0;i<tab.Length;i++)
            { 
                if (!(i == 4 || i == 5 || (i > 9 && i < 18) || (i > 19 && i < 23)))
                {
                    try
                    {
                        text_boxy[p].Text = tab[i];
                        p++;
                    }catch { }
                }
            }
            strona_glowna = obiekt;
        }
        private void start()
        {
            StronaGlowna.wiersz_z_okna_wpisowego = "";

            text_boxy[0] = textBox1;
            text_boxy[1] = textBox2;
            text_boxy[2] = textBox3;
            text_boxy[3] = textBox4;
            text_boxy[4] = textBox5;
            text_boxy[5] = textBox6;
            text_boxy[6] = textBox7;
            text_boxy[7] = textBox8;
            text_boxy[8] = textBox9;
            text_boxy[9] = textBox10;
            text_boxy[10] = textBox11; 
        } 
        private void button1_Click(object sender, EventArgs e)
        { 
            string nazwa_edytowanego_labela = StronaGlowna.index_edytowanego_wersu.ToString() + '~';
            int i = 0;
            for(int p = 0;p<StronaGlowna.liczba_kolumn;p++)
            {
                if (!(p == 4 || p == 5 || (p > 9 && p < 18) || (p > 19 && p < 23)))
                {
                    try
                    {
                        StronaGlowna.po_nazwie_przypisanie_wartosc_dla_labela(nazwa_edytowanego_labela + p.ToString(), text_boxy[i].Text, strona_glowna);
                        i++;
                    }
                    catch
                    {
                        MessageBox.Show(i.ToString() + " " + p.ToString());
                    }
                }
            }
        }
    }
}
