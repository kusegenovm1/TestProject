using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Array.Resize(ref book, book.Length + 1);

            book[listView1.Items.Count].Fam = textBox1.Text;
            book[listView1.Items.Count].Poch = textBox2.Text;
            book[listView1.Items.Count].Tel = textBox3.Text;
            book[listView1.Items.Count].GodR = textBox4.Text;
            book[listView1.Items.Count].MestR = textBox5.Text;
            book[listView1.Items.Count].Zam = textBox6.Text;

            ListViewItem lvi = new ListViewItem(textBox1.Text);
            lvi.SubItems.Add(book[listView1.Items.Count].Poch);
            lvi.SubItems.Add(book[listView1.Items.Count].Tel);
            lvi.SubItems.Add(book[listView1.Items.Count].GodR);
            lvi.SubItems.Add(book[listView1.Items.Count].MestR);
            lvi.SubItems.Add(book[listView1.Items.Count].Zam);
            listView1.Items.Add(lvi);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        TelBook[] book = new TelBook[0];

        private void button2_Click(object sender, EventArgs e)
        {
            int k = 0;
            string Fam, Poch, Tel, GodR, MestR, Zam;
            this.listView1.Items.Clear();

            for (int i = 0; i < book.Length; i++)
            {
                Fam = textBox1.Text;
                Poch = textBox2.Text;
                Tel = textBox3.Text;
                GodR = textBox4.Text;
                MestR = textBox5.Text;
                Zam = textBox6.Text;
                if ((book[i].Fam == Fam || Fam == "") && (book[i].Poch == Poch || Poch == "") && (book[i].Tel == Tel || Tel == "") && (book[i].GodR == GodR || GodR == "") && (book[i].MestR == MestR || MestR == "") && (book[i].Zam == Zam || Zam == ""))
                {
                    ListViewItem lvi = new ListViewItem(book[i].Fam);
                    lvi.SubItems.Add(book[i].Poch);
                    lvi.SubItems.Add(book[i].Tel);
                    lvi.SubItems.Add(book[i].GodR);
                    lvi.SubItems.Add(book[i].MestR);
                    lvi.SubItems.Add(book[i].Zam);
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            for (int i = 0; i < book.Length; i++)
            {
                ListViewItem lvi = new ListViewItem(book[i].Fam);
                lvi.SubItems.Add(book[i].Poch);
                lvi.SubItems.Add(book[i].Tel);
                lvi.SubItems.Add(book[i].GodR);
                lvi.SubItems.Add(book[i].MestR);
                lvi.SubItems.Add(book[i].Zam);
                listView1.Items.Add(lvi);
            }
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    struct TelBook
    {
        public string Fam, Poch, Tel, GodR, MestR, Zam;
    }

}
