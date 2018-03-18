using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerShow
{
    public partial class ListForm : Form
    {

        private Dictionary<String, String> dic;
        public TimerShowDlg t;
        public ListForm(Dictionary<String, String> dic1)
        {
            InitializeComponent();
            dic = new Dictionary<string, string>();
            //t = ((TimerShowDlg)this.Owner);
            this.dic = dic1;

        }
        public ListForm( )
        {
            InitializeComponent();
            dic = new Dictionary<string, string>();
           // t = ((TimerShowDlg)this.Owner);
            //this.dic = dic1;

        }

        public void  setTimePriceList( Dictionary<String,String> d) 
        {
            this.dic = d;

        }
        public void showDic()
        {
            this.listBox1.Items.Clear();
            
            foreach (KeyValuePair<String, String> pair in dic)
            {
               // if (!this.listBox1.Items.Contains(pair))
                {
                    this.listBox1.Items.Add(pair.Key + "|" + pair.Value);
                }

                this.tmpbox.Text = pair.Key + " | " + pair.Value;
            }

            this.listBox1.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.showDic();
        }
    }
}
