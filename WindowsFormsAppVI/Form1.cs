using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppVI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnINCLUIR_Click(object sender, EventArgs e)
        {
            if (txtNOME.Text != "" && txtCURSO.Text != "" && txtCIDADE.Text != "") 
            {
                dgvALUNOS.Rows.Add(txtNOME.Text, txtCURSO.Text, txtCIDADE.Text);
                MessageBox.Show("Aluno cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtNOME.Clear();
            txtCURSO.Clear();
            txtCIDADE.Clear();
            txtNOME.Focus();
            lblTOTAL.Text = dgvALUNOS.RowCount.ToString();
        }

        private void btnFECHAR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnREMOVER_Click(object sender, EventArgs e)
        {
            if (dgvALUNOS.RowCount > 0)
            {
                dgvALUNOS.Rows.RemoveAt(dgvALUNOS.CurrentRow.Index);
                MessageBox.Show("Cadastro excluído com sucesso", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lblTOTAL.Text = dgvALUNOS.RowCount.ToString();
            txtNOME.Focus();
        }

        private void btnTODOS_Click(object sender, EventArgs e)
        {
            dgvALUNOS.Rows.Clear();
            txtNOME.Focus();
        }

        private void btnALTERAR_Click(object sender, EventArgs e)
        {
            if (txtALTERARn.Text != "" && txtALTERARk.Text != "" && txtALTERARc.Text != "")
            {
                dgvALUNOS.CurrentRow.Cells["Nome"].Value = txtALTERARn.Text;
                dgvALUNOS.CurrentRow.Cells["Curso"].Value = txtALTERARk.Text;
                dgvALUNOS.CurrentRow.Cells["Cidade"].Value = txtALTERARc.Text;
                txtNOME.Focus();
                txtALTERARn.Clear();
                txtALTERARk.Clear();
                txtALTERARc.Clear();
                MessageBox.Show("Cadastro alterado com sucesso", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvALUNOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvALUNOS.RowCount > 0)
            {
                txtALTERARn.Text = dgvALUNOS.CurrentRow.Cells["Nome"].Value.ToString();
                txtALTERARk.Text = dgvALUNOS.CurrentRow.Cells["Curso"].Value.ToString();
                txtALTERARc.Text = dgvALUNOS.CurrentRow.Cells["Cidade"].Value.ToString();
                txtALTERARn.Focus();
            }
        }
    }
}
