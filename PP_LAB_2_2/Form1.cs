using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_LAB_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var context = new records();
            currency cur = new currency();
            string _date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            cur.record_date = _date;

            if (comboBox1.Text != "")
            {
                var curre = (from s in context.currencies
                             where s.record_date == _date && s.name == comboBox1.Text
                             select s).ToList<currency>();

                if (curre.Count() == 0) //jak nie ma w bazie
                {
                    await cur.load(_date);
                    cur.name = comboBox1.Text;
                    cur.exchange = cur.rates[comboBox1.Text];
                    context.currencies.Add(cur);
                    listView1.Items.Add(comboBox1.Text + "[" + _date + "]" + ": " + cur.rates[comboBox1.Text] + " [json]");

                }
                else //jak jest w bazie
                {
                    listView1.Items.Add(comboBox1.Text + "[" + _date + "]" + ": " + curre[0].exchange + " [BD]");
                }
            }
            context.SaveChanges();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar1.MaxDate = DateTime.Now;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
