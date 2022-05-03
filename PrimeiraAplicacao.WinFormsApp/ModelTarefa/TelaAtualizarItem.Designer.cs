namespace Apresentacao.ToDo.ModelTarefa
{
    partial class TelaAtualizarItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listaItensPendentes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTarefaSelecionada = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBtnConcluido = new System.Windows.Forms.RadioButton();
            this.rBtnPendente = new System.Windows.Forms.RadioButton();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.listaItensConcluidos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item tarefa";
            // 
            // listaItensPendentes
            // 
            this.listaItensPendentes.FormattingEnabled = true;
            this.listaItensPendentes.ItemHeight = 15;
            this.listaItensPendentes.Location = new System.Drawing.Point(316, 44);
            this.listaItensPendentes.Name = "listaItensPendentes";
            this.listaItensPendentes.Size = new System.Drawing.Size(221, 319);
            this.listaItensPendentes.TabIndex = 1;
            this.listaItensPendentes.DoubleClick += new System.EventHandler(this.listaItens_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecione o item que deseja alterar com dois cliques";
            // 
            // textBoxTarefaSelecionada
            // 
            this.textBoxTarefaSelecionada.Enabled = false;
            this.textBoxTarefaSelecionada.Location = new System.Drawing.Point(12, 27);
            this.textBoxTarefaSelecionada.Name = "textBoxTarefaSelecionada";
            this.textBoxTarefaSelecionada.ReadOnly = true;
            this.textBoxTarefaSelecionada.Size = new System.Drawing.Size(281, 23);
            this.textBoxTarefaSelecionada.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtnConcluido);
            this.panel1.Controls.Add(this.rBtnPendente);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 27);
            this.panel1.TabIndex = 4;
            // 
            // rBtnConcluido
            // 
            this.rBtnConcluido.AutoSize = true;
            this.rBtnConcluido.Location = new System.Drawing.Point(84, 3);
            this.rBtnConcluido.Name = "rBtnConcluido";
            this.rBtnConcluido.Size = new System.Drawing.Size(80, 19);
            this.rBtnConcluido.TabIndex = 1;
            this.rBtnConcluido.Text = "Concluído";
            this.rBtnConcluido.UseVisualStyleBackColor = true;
            // 
            // rBtnPendente
            // 
            this.rBtnPendente.AutoSize = true;
            this.rBtnPendente.Location = new System.Drawing.Point(3, 3);
            this.rBtnPendente.Name = "rBtnPendente";
            this.rBtnPendente.Size = new System.Drawing.Size(75, 19);
            this.rBtnPendente.TabIndex = 0;
            this.rBtnPendente.Text = "Pendente";
            this.rBtnPendente.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(12, 89);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(116, 40);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(177, 89);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 40);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(12, 317);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 40);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(177, 317);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // listaItensConcluidos
            // 
            this.listaItensConcluidos.FormattingEnabled = true;
            this.listaItensConcluidos.ItemHeight = 15;
            this.listaItensConcluidos.Location = new System.Drawing.Point(559, 44);
            this.listaItensConcluidos.Name = "listaItensConcluidos";
            this.listaItensConcluidos.Size = new System.Drawing.Size(221, 319);
            this.listaItensConcluidos.TabIndex = 9;
            this.listaItensConcluidos.DoubleClick += new System.EventHandler(this.listaItensConcluidos_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pendentes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Concluídos";
            // 
            // TelaAtualizarItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 369);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listaItensConcluidos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxTarefaSelecionada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaItensPendentes);
            this.Controls.Add(this.label1);
            this.Name = "TelaAtualizarItem";
            this.Text = "TelaAtualizarItem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaItensPendentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTarefaSelecionada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rBtnConcluido;
        private System.Windows.Forms.RadioButton rBtnPendente;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listaItensConcluidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}