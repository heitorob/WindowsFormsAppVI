namespace WindowsFormsAppVI
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnINCLUIR = new System.Windows.Forms.Button();
            this.btnREMOVER = new System.Windows.Forms.Button();
            this.btnFECHAR = new System.Windows.Forms.Button();
            this.btnTODOS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTOTAL = new System.Windows.Forms.Label();
            this.txtNOME = new System.Windows.Forms.TextBox();
            this.txtCURSO = new System.Windows.Forms.TextBox();
            this.txtALTERARn = new System.Windows.Forms.TextBox();
            this.dgvALUNOS = new System.Windows.Forms.DataGridView();
            this.btnALTERAR = new System.Windows.Forms.Button();
            this.txtALTERARk = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCIDADE = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Curso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtALTERARc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvALUNOS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnINCLUIR
            // 
            this.btnINCLUIR.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINCLUIR.Location = new System.Drawing.Point(151, 174);
            this.btnINCLUIR.Name = "btnINCLUIR";
            this.btnINCLUIR.Size = new System.Drawing.Size(140, 61);
            this.btnINCLUIR.TabIndex = 0;
            this.btnINCLUIR.TabStop = false;
            this.btnINCLUIR.Text = "Incluir";
            this.btnINCLUIR.UseVisualStyleBackColor = true;
            this.btnINCLUIR.Click += new System.EventHandler(this.btnINCLUIR_Click);
            // 
            // btnREMOVER
            // 
            this.btnREMOVER.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREMOVER.Location = new System.Drawing.Point(348, 174);
            this.btnREMOVER.Name = "btnREMOVER";
            this.btnREMOVER.Size = new System.Drawing.Size(140, 61);
            this.btnREMOVER.TabIndex = 0;
            this.btnREMOVER.TabStop = false;
            this.btnREMOVER.Text = "Remover";
            this.btnREMOVER.UseVisualStyleBackColor = true;
            this.btnREMOVER.Click += new System.EventHandler(this.btnREMOVER_Click);
            // 
            // btnFECHAR
            // 
            this.btnFECHAR.Font = new System.Drawing.Font("Maiandra GD", 12.75F);
            this.btnFECHAR.Location = new System.Drawing.Point(486, 748);
            this.btnFECHAR.Name = "btnFECHAR";
            this.btnFECHAR.Size = new System.Drawing.Size(95, 49);
            this.btnFECHAR.TabIndex = 0;
            this.btnFECHAR.TabStop = false;
            this.btnFECHAR.Text = "Fechar Sistema";
            this.btnFECHAR.UseVisualStyleBackColor = true;
            this.btnFECHAR.Click += new System.EventHandler(this.btnFECHAR_Click);
            // 
            // btnTODOS
            // 
            this.btnTODOS.Font = new System.Drawing.Font("Maiandra GD", 12.75F);
            this.btnTODOS.Location = new System.Drawing.Point(385, 748);
            this.btnTODOS.Name = "btnTODOS";
            this.btnTODOS.Size = new System.Drawing.Size(95, 49);
            this.btnTODOS.TabIndex = 0;
            this.btnTODOS.TabStop = false;
            this.btnTODOS.Text = "Excluir Todos";
            this.btnTODOS.UseVisualStyleBackColor = true;
            this.btnTODOS.Click += new System.EventHandler(this.btnTODOS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 11.75F);
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Felix Titling", 11.75F);
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alterar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Felix Titling", 11.75F);
            this.label4.Location = new System.Drawing.Point(34, 763);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total de Alunos:";
            // 
            // lblTOTAL
            // 
            this.lblTOTAL.AutoSize = true;
            this.lblTOTAL.Font = new System.Drawing.Font("Felix Titling", 11.75F);
            this.lblTOTAL.Location = new System.Drawing.Point(273, 763);
            this.lblTOTAL.Name = "lblTOTAL";
            this.lblTOTAL.Size = new System.Drawing.Size(18, 19);
            this.lblTOTAL.TabIndex = 3;
            this.lblTOTAL.Text = "0";
            // 
            // txtNOME
            // 
            this.txtNOME.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOME.Location = new System.Drawing.Point(151, 36);
            this.txtNOME.Name = "txtNOME";
            this.txtNOME.Size = new System.Drawing.Size(337, 29);
            this.txtNOME.TabIndex = 1;
            // 
            // txtCURSO
            // 
            this.txtCURSO.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCURSO.Location = new System.Drawing.Point(151, 82);
            this.txtCURSO.Name = "txtCURSO";
            this.txtCURSO.Size = new System.Drawing.Size(337, 29);
            this.txtCURSO.TabIndex = 2;
            // 
            // txtALTERARn
            // 
            this.txtALTERARn.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtALTERARn.Location = new System.Drawing.Point(151, 562);
            this.txtALTERARn.Name = "txtALTERARn";
            this.txtALTERARn.Size = new System.Drawing.Size(337, 29);
            this.txtALTERARn.TabIndex = 4;
            // 
            // dgvALUNOS
            // 
            this.dgvALUNOS.AllowUserToAddRows = false;
            this.dgvALUNOS.AllowUserToDeleteRows = false;
            this.dgvALUNOS.AllowUserToOrderColumns = true;
            this.dgvALUNOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvALUNOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Curso,
            this.Cidade});
            this.dgvALUNOS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvALUNOS.Location = new System.Drawing.Point(37, 250);
            this.dgvALUNOS.Name = "dgvALUNOS";
            this.dgvALUNOS.ReadOnly = true;
            this.dgvALUNOS.Size = new System.Drawing.Size(544, 210);
            this.dgvALUNOS.TabIndex = 5;
            this.dgvALUNOS.TabStop = false;
            this.dgvALUNOS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvALUNOS_CellClick);
            // 
            // btnALTERAR
            // 
            this.btnALTERAR.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnALTERAR.Location = new System.Drawing.Point(506, 661);
            this.btnALTERAR.Name = "btnALTERAR";
            this.btnALTERAR.Size = new System.Drawing.Size(75, 32);
            this.btnALTERAR.TabIndex = 0;
            this.btnALTERAR.TabStop = false;
            this.btnALTERAR.Text = "Alterar";
            this.btnALTERAR.UseVisualStyleBackColor = true;
            this.btnALTERAR.Click += new System.EventHandler(this.btnALTERAR_Click);
            // 
            // txtALTERARk
            // 
            this.txtALTERARk.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtALTERARk.Location = new System.Drawing.Point(151, 608);
            this.txtALTERARk.Name = "txtALTERARk";
            this.txtALTERARk.Size = new System.Drawing.Size(337, 29);
            this.txtALTERARk.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Felix Titling", 11.75F);
            this.label5.Location = new System.Drawing.Point(34, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Felix Titling", 11.75F);
            this.label6.Location = new System.Drawing.Point(34, 618);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Curso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Felix Titling", 11.75F);
            this.label7.Location = new System.Drawing.Point(34, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cidade:";
            // 
            // txtCIDADE
            // 
            this.txtCIDADE.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCIDADE.Location = new System.Drawing.Point(151, 128);
            this.txtCIDADE.Name = "txtCIDADE";
            this.txtCIDADE.Size = new System.Drawing.Size(337, 29);
            this.txtCIDADE.TabIndex = 3;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Curso
            // 
            this.Curso.HeaderText = "Curso";
            this.Curso.Name = "Curso";
            this.Curso.ReadOnly = true;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Felix Titling", 11.75F);
            this.label8.Location = new System.Drawing.Point(34, 671);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Cidade:";
            // 
            // txtALTERARc
            // 
            this.txtALTERARc.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtALTERARc.Location = new System.Drawing.Point(151, 661);
            this.txtALTERARc.Name = "txtALTERARc";
            this.txtALTERARc.Size = new System.Drawing.Size(337, 29);
            this.txtALTERARc.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 824);
            this.ControlBox = false;
            this.Controls.Add(this.dgvALUNOS);
            this.Controls.Add(this.txtALTERARc);
            this.Controls.Add(this.txtALTERARk);
            this.Controls.Add(this.txtALTERARn);
            this.Controls.Add(this.txtCIDADE);
            this.Controls.Add(this.txtCURSO);
            this.Controls.Add(this.txtNOME);
            this.Controls.Add(this.lblTOTAL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTODOS);
            this.Controls.Add(this.btnALTERAR);
            this.Controls.Add(this.btnFECHAR);
            this.Controls.Add(this.btnREMOVER);
            this.Controls.Add(this.btnINCLUIR);
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvALUNOS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnINCLUIR;
        private System.Windows.Forms.Button btnREMOVER;
        private System.Windows.Forms.Button btnFECHAR;
        private System.Windows.Forms.Button btnTODOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTOTAL;
        private System.Windows.Forms.TextBox txtNOME;
        private System.Windows.Forms.TextBox txtCURSO;
        private System.Windows.Forms.TextBox txtALTERARn;
        private System.Windows.Forms.DataGridView dgvALUNOS;
        private System.Windows.Forms.Button btnALTERAR;
        private System.Windows.Forms.TextBox txtALTERARk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Curso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtALTERARc;
    }
}

