using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MyBTP
{
    public partial class FormResumem : Form
    {
        public FormResumem()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FormResumem_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mYBTPDataSet1.COLABORADOR'. Você pode movê-la ou removê-la conforme necessário.
            this.cOLABORADORTableAdapter1.Fill(this.mYBTPDataSet1.COLABORADOR);
            // TODO: esta linha de código carrega dados na tabela 'mYBTPDataSet.COLABORADOR'. Você pode movê-la ou removê-la conforme necessário.
            this.cOLABORADORTableAdapter.Fill(this.mYBTPDataSet.COLABORADOR);
             dataGridView2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {              
            
        }
    }
}
