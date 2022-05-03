namespace AgendaToDo.WinFor
{
    partial class TelaCrudTarefas
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.labelNumero = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.rBtnBaixa = new System.Windows.Forms.RadioButton();
            this.rBtnMedia = new System.Windows.Forms.RadioButton();
            this.rBtnAlta = new System.Windows.Forms.RadioButton();
            this.panelPrioridade = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listaItens = new System.Windows.Forms.ListBox();
            this.btnAdicionarItens = new System.Windows.Forms.Button();
            this.txtBoxItensTarefa = new System.Windows.Forms.TextBox();
            this.panelPrioridade.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(206, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 37);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(29, 181);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 37);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(29, 9);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(51, 15);
            this.labelNumero.TabIndex = 2;
            this.labelNumero.Text = "Numero";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(101, 9);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(58, 15);
            this.labelDescricao.TabIndex = 3;
            this.labelDescricao.Text = "Descricao";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(29, 31);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.ReadOnly = true;
            this.textBoxNumero.Size = new System.Drawing.Size(57, 23);
            this.textBoxNumero.TabIndex = 4;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(101, 31);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(271, 23);
            this.textBoxDescricao.TabIndex = 5;
            // 
            // rBtnBaixa
            // 
            this.rBtnBaixa.AutoSize = true;
            this.rBtnBaixa.Location = new System.Drawing.Point(4, 21);
            this.rBtnBaixa.Name = "rBtnBaixa";
            this.rBtnBaixa.Size = new System.Drawing.Size(53, 19);
            this.rBtnBaixa.TabIndex = 6;
            this.rBtnBaixa.TabStop = true;
            this.rBtnBaixa.Text = "Baixa";
            this.rBtnBaixa.UseVisualStyleBackColor = true;
            // 
            // rBtnMedia
            // 
            this.rBtnMedia.AutoSize = true;
            this.rBtnMedia.Location = new System.Drawing.Point(72, 21);
            this.rBtnMedia.Name = "rBtnMedia";
            this.rBtnMedia.Size = new System.Drawing.Size(58, 19);
            this.rBtnMedia.TabIndex = 7;
            this.rBtnMedia.TabStop = true;
            this.rBtnMedia.Text = "Media";
            this.rBtnMedia.UseVisualStyleBackColor = true;
            // 
            // rBtnAlta
            // 
            this.rBtnAlta.AutoSize = true;
            this.rBtnAlta.Location = new System.Drawing.Point(160, 21);
            this.rBtnAlta.Name = "rBtnAlta";
            this.rBtnAlta.Size = new System.Drawing.Size(46, 19);
            this.rBtnAlta.TabIndex = 8;
            this.rBtnAlta.TabStop = true;
            this.rBtnAlta.Text = "Alta";
            this.rBtnAlta.UseVisualStyleBackColor = true;
            // 
            // panelPrioridade
            // 
            this.panelPrioridade.Controls.Add(this.rBtnBaixa);
            this.panelPrioridade.Controls.Add(this.rBtnAlta);
            this.panelPrioridade.Controls.Add(this.rBtnMedia);
            this.panelPrioridade.Location = new System.Drawing.Point(29, 73);
            this.panelPrioridade.Name = "panelPrioridade";
            this.panelPrioridade.Size = new System.Drawing.Size(343, 58);
            this.panelPrioridade.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prioridade";
            // 
            // listaItens
            // 
            this.listaItens.FormattingEnabled = true;
            this.listaItens.ItemHeight = 15;
            this.listaItens.Location = new System.Drawing.Point(406, 70);
            this.listaItens.Name = "listaItens";
            this.listaItens.Size = new System.Drawing.Size(483, 139);
            this.listaItens.TabIndex = 11;
            // 
            // btnAdicionarItens
            // 
            this.btnAdicionarItens.Location = new System.Drawing.Point(406, 23);
            this.btnAdicionarItens.Name = "btnAdicionarItens";
            this.btnAdicionarItens.Size = new System.Drawing.Size(102, 37);
            this.btnAdicionarItens.TabIndex = 12;
            this.btnAdicionarItens.Text = "Adicionar Itens";
            this.btnAdicionarItens.UseVisualStyleBackColor = true;
            this.btnAdicionarItens.Click += new System.EventHandler(this.btnAdicionarItens_Click);
            // 
            // txtBoxItensTarefa
            // 
            this.txtBoxItensTarefa.Location = new System.Drawing.Point(514, 31);
            this.txtBoxItensTarefa.Name = "txtBoxItensTarefa";
            this.txtBoxItensTarefa.Size = new System.Drawing.Size(375, 23);
            this.txtBoxItensTarefa.TabIndex = 13;
            // 
            // TelaCrudTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 224);
            this.Controls.Add(this.txtBoxItensTarefa);
            this.Controls.Add(this.btnAdicionarItens);
            this.Controls.Add(this.listaItens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelPrioridade);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "TelaCrudTarefas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCrud";
            this.panelPrioridade.ResumeLayout(false);
            this.panelPrioridade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.RadioButton rBtnBaixa;
        private System.Windows.Forms.RadioButton rBtnMedia;
        private System.Windows.Forms.RadioButton rBtnAlta;
        private System.Windows.Forms.Panel panelPrioridade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaItens;
        private System.Windows.Forms.Button btnAdicionarItens;
        private System.Windows.Forms.TextBox txtBoxItensTarefa;
    }
}