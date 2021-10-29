using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Tabomtrak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            WritePl1();
            WritePl2();
        }
        void WritePl1()
        {
            System.Collections.ArrayList yeni = new System.Collections.ArrayList();
            IDatabase sql = new SqlData();
            for (int i = 0; i < 6; i++)
            {
            start:
                sql.P1_Write();
                label7.Text = sql.L1;
                label1.Text = sql.L2;
                label2.Text = sql.L3;
                label3.Text = sql.L4;
                label4.Text = sql.L5;
                label5.Text = sql.L6;
                label6.Text = sql.L7;
                for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                {
                    if (dataGridView1.Rows[j].Cells[0].Value.ToString() == label7.Text)
                        goto start;
                }
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = label7.Text;
                dataGridView1.Rows[i].Cells[1].Value = label1.Text;
                dataGridView1.Rows[i].Cells[2].Value = label2.Text;
                dataGridView1.Rows[i].Cells[3].Value = label3.Text;
                dataGridView1.Rows[i].Cells[4].Value = label4.Text;
                dataGridView1.Rows[i].Cells[5].Value = label5.Text;
                dataGridView1.Rows[i].Cells[6].Value = label6.Text;
            }
                /*  listBox1.Items.Add(label7.Text + " " + label1.Text + " " + label2.Text + " " + label3.Text + " " + label4.Text + " " + label5.Text + " " + label6.Text);
                 foreach (string item in listBox1.Items)// listbox'a herbiri farkli deger yazilmak isteniyorsa
                 {
                     if (yeni.Contains(item) == false)
                     {
                         yeni.Add(item);
                         goto start;
                     }
                 }
                 listBox1.Items.Clear();
                 listBox1.Items.AddRange(yeni.ToArray());
            }
           if(listBox1.Items.Count > 7)
            {
                for (int i = listBox1.Items.Count; i > 7; i--)                
                    listBox1.Items.RemoveAt(i-1);   
            }*/
        }
        void WritePl2()
        {
            System.Collections.ArrayList yeni = new System.Collections.ArrayList();
            IDatabase sql = new SqlData();
            for (int i = 0; i < 6; i++)
            {
            start:
                sql.P2_Write();
                label7.Text = sql.L1;
                label1.Text = sql.L2;
                label2.Text = sql.L3;
                label3.Text = sql.L4;
                label4.Text = sql.L5;
                label5.Text = sql.L6;
                label6.Text = sql.L7;
                for (int j = 0; j < dataGridView2.Rows.Count - 1; j++) 
                {
                    if (dataGridView2.Rows[j].Cells[0].Value.ToString() == label7.Text)
                        goto start;
                }
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].Cells[0].Value = label7.Text;
                dataGridView2.Rows[i].Cells[1].Value = label1.Text;
                dataGridView2.Rows[i].Cells[2].Value = label2.Text;
                dataGridView2.Rows[i].Cells[3].Value = label3.Text;
                dataGridView2.Rows[i].Cells[4].Value = label4.Text;
                dataGridView2.Rows[i].Cells[5].Value = label5.Text;
                dataGridView2.Rows[i].Cells[6].Value = label6.Text;
            }
        }
        int sayac = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            sayac -= 1;
            label_timer.Text = sayac.ToString();
            if (sayac == 0)
            {
                timer1.Stop();
                label_timer.Text = "00";
                label_timer.ForeColor = Color.Red;
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox5.Visible = false;
                label12.Visible = false;
                button1.Visible = true;
                point += 1;
                if (point == 2)
                {
                    c.Blue = label_askor.Text;
                    c.Red = label_bskor.Text;
                    groupBox1.Visible = false;
                    groupBox3.Visible = false;
                    groupBox2.Visible = false;
                    groupBox5.Visible = false;
                    button1.Visible = false;
                    label9.Visible = true;
                    button2.Visible = true;
                    c.Skor();
                    label9.Text = c.Winner;
                }
            }
        }
        int point = 0;
        int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac = 10;
            timer1.Start();
            label_timer.ForeColor = Color.Green;
            label12.Visible = true;
            groupBox1.Visible = true;
            groupBox3.Visible = true;
            groupBox2.Visible = true;
            groupBox5.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            LabelYaz();
            if (point % 2 == 0)
                label12.Text = "Turn: Team A";
            else
                label12.Text = "Turn: Team B";
        }
        Meter meters = new Meter();
        int blue_point, red_point;
        private void green_Button_Click(object sender, EventArgs e)
        {
            if (point % 2 == 0)
            {
                dataGridView1.Rows.RemoveAt(n);
                n = 0;
                blue_point = meters.Blue_Add;
                label_askor.Text = blue_point.ToString();
                LabelYaz();
            }
            else
            {
                dataGridView2.Rows.RemoveAt(n);
                n = 0;
                red_point = meters.Red_Add;
                label_bskor.Text = red_point.ToString();
                LabelYaz();             
            }
        }
        private void red_Button_Click(object sender, EventArgs e)
        {
            if (point % 2 == 0)
            {
                dataGridView1.Rows.RemoveAt(n);
                n = 0;
                blue_point = meters.Blue_Eject;
                label_askor.Text = blue_point.ToString();
                LabelYaz();
            }
            else 
            {
                dataGridView2.Rows.RemoveAt(n);
                n = 0;
                red_point = meters.Red_Eject;
                label_bskor.Text = red_point.ToString();
                LabelYaz();         
            }
        }
        private void yellow_Button_Click(object sender, EventArgs e)
        {
            n += 1;
            if (point % 2 == 0)
            {
                if (n == dataGridView1.Rows.Count - 1)
                    n = 0;
            }
            else
            {
                if (n == dataGridView2.Rows.Count - 1)
                    n = 0;
            }
                LabelYaz();
        }
        void LabelYaz()
        {
            if (point % 2 == 0)
            {
                if (dataGridView1.Rows.Count -1 == 0)
                {
                    timer1.Stop();
                    groupBox1.Visible = false;
                    groupBox5.Visible = false;
                    button1.Visible = true;
                    point += 1;
                }
                else 
                { 
                    label7.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
                    label1.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
                    label2.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
                    label3.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
                    label4.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
                    label5.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();
                }
            }
            else
            {
                if (dataGridView2.Rows.Count - 1 == 0)
                {
                    timer1.Stop();
                    c.Blue = label_askor.Text;
                    c.Red = label_bskor.Text;
                    groupBox1.Visible = false;
                    groupBox3.Visible = false;
                    groupBox2.Visible = false;
                    groupBox5.Visible = false;
                    button1.Visible = false;
                    button2.Visible = true;
                    label9.Visible = true;
                    label12.Visible = false;
                    point += 1;
                    c.Skor();
                    label9.Text = c.Winner;             
                }
                else
                {
                    label7.Text = dataGridView2.Rows[n].Cells[0].Value.ToString();
                    label1.Text = dataGridView2.Rows[n].Cells[1].Value.ToString();
                    label2.Text = dataGridView2.Rows[n].Cells[2].Value.ToString();
                    label3.Text = dataGridView2.Rows[n].Cells[3].Value.ToString();
                    label4.Text = dataGridView2.Rows[n].Cells[4].Value.ToString();
                    label5.Text = dataGridView2.Rows[n].Cells[5].Value.ToString();
                }
            }
        }
        Calculate c = new Calculate();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}