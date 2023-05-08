using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ordinals_sniper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            new Thread(WindowsForms.Form1.Show).Start();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.Add("link", "Link");
            dataGridView1.Columns.Add("price", "Price");
            dataGridView1.Rows.Add("pixel-pepes", "0.169");
            dataGridView1.Rows.Add("bitcoinpunks", "0.070706");
            dataGridView1.Rows.Add("unisat-og-pass", "0.29");

        }
    }
}
