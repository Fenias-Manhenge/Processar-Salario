using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processar_Salario
{
    public partial class  Form1 : Form  
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);

            if (codigo > 0 && hasCode(codigo) == false)
            {
                lstCodigo.Items.Add(codigo);
            }
            if (txtNome == null)
            {
                MessageBox.Show("Nome obrigatorio!", "Campo nullo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lstNome.Items.Add(txtNome.Text);
            lstContacto.Items.Add(long.Parse(txtContacto.Text));

            if(rbnMasculino.Checked == true)
            {
                lstSexo.Items.Add(rbnMasculino.Text);
            }else if (rbnFemenino.Checked == true)
            {
                lstSexo.Items.Add(rbnFemenino.Text);
            }

            lstDiasTrab.Items.Add(int.Parse(txtDias.Text));
            lstSalario.Items.Add(double.Parse(txtSalario.Text));
        }

        private Boolean hasCode(int code)
        {
            Boolean has = false;
            for (int i = 0; i < lstCodigo.Items.Count; i++) 
                if (int.Parse(lstCodigo.Items[i].ToString()) == code)
                {
                    has = true;
                    MessageBox.Show("Codigo existente!" , "Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
                return has;
        }

        private void lstCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblContacto1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            lstSalMensal.Items.Clear();
            for (int i = 0; i < lstDiasTrab.Items.Count; i++)
            {
                lstSalMensal.Items.Add(int.Parse(lstDiasTrab.Items[i].ToString()) * double.Parse(lstSalario.Items[i].ToString()));
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
