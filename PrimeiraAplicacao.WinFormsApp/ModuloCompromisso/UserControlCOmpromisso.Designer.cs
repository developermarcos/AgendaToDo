namespace Apresentacao.ToDo.ModuloCompromisso
{
    partial class UserControlCompromisso
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAcoes = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.listBoxTodosCompromissos = new System.Windows.Forms.ListBox();
            this.tabControlCompromissos = new System.Windows.Forms.TabControl();
            this.listTodosCompromissos = new System.Windows.Forms.TabPage();
            this.tbCompromissosPassados = new System.Windows.Forms.TabPage();
            this.listBoxCompromissosPassados = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxCompromissosFuturos = new System.Windows.Forms.ListBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.panelAcoes.SuspendLayout();
            this.tabControlCompromissos.SuspendLayout();
            this.listTodosCompromissos.SuspendLayout();
            this.tbCompromissosPassados.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAcoes
            // 
            this.panelAcoes.Controls.Add(this.btnExcluir);
            this.panelAcoes.Controls.Add(this.btnEditar);
            this.panelAcoes.Controls.Add(this.btnCadastrar);
            this.panelAcoes.Location = new System.Drawing.Point(3, 3);
            this.panelAcoes.Name = "panelAcoes";
            this.panelAcoes.Size = new System.Drawing.Size(601, 85);
            this.panelAcoes.TabIndex = 3;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(304, 17);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(126, 53);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(159, 17);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(126, 53);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(15, 17);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(126, 53);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // listBoxTodosCompromissos
            // 
            this.listBoxTodosCompromissos.FormattingEnabled = true;
            this.listBoxTodosCompromissos.ItemHeight = 15;
            this.listBoxTodosCompromissos.Location = new System.Drawing.Point(0, 0);
            this.listBoxTodosCompromissos.Name = "listBoxTodosCompromissos";
            this.listBoxTodosCompromissos.Size = new System.Drawing.Size(889, 304);
            this.listBoxTodosCompromissos.TabIndex = 4;
            // 
            // tabControlCompromissos
            // 
            this.tabControlCompromissos.Controls.Add(this.listTodosCompromissos);
            this.tabControlCompromissos.Controls.Add(this.tbCompromissosPassados);
            this.tabControlCompromissos.Controls.Add(this.tabPage1);
            this.tabControlCompromissos.Location = new System.Drawing.Point(3, 94);
            this.tabControlCompromissos.Name = "tabControlCompromissos";
            this.tabControlCompromissos.SelectedIndex = 0;
            this.tabControlCompromissos.Size = new System.Drawing.Size(897, 329);
            this.tabControlCompromissos.TabIndex = 5;
            this.tabControlCompromissos.SelectedIndexChanged += new System.EventHandler(this.tabControlCompromissos_SelectedIndexChanged);
            // 
            // listTodosCompromissos
            // 
            this.listTodosCompromissos.Controls.Add(this.listBoxTodosCompromissos);
            this.listTodosCompromissos.Location = new System.Drawing.Point(4, 24);
            this.listTodosCompromissos.Name = "listTodosCompromissos";
            this.listTodosCompromissos.Padding = new System.Windows.Forms.Padding(3);
            this.listTodosCompromissos.Size = new System.Drawing.Size(889, 301);
            this.listTodosCompromissos.TabIndex = 0;
            this.listTodosCompromissos.Text = "Todos";
            this.listTodosCompromissos.UseVisualStyleBackColor = true;
            // 
            // tbCompromissosPassados
            // 
            this.tbCompromissosPassados.Controls.Add(this.listBoxCompromissosPassados);
            this.tbCompromissosPassados.Location = new System.Drawing.Point(4, 24);
            this.tbCompromissosPassados.Name = "tbCompromissosPassados";
            this.tbCompromissosPassados.Padding = new System.Windows.Forms.Padding(3);
            this.tbCompromissosPassados.Size = new System.Drawing.Size(889, 301);
            this.tbCompromissosPassados.TabIndex = 2;
            this.tbCompromissosPassados.Text = "Passados";
            this.tbCompromissosPassados.UseVisualStyleBackColor = true;
            // 
            // listBoxCompromissosPassados
            // 
            this.listBoxCompromissosPassados.FormattingEnabled = true;
            this.listBoxCompromissosPassados.ItemHeight = 15;
            this.listBoxCompromissosPassados.Location = new System.Drawing.Point(0, 1);
            this.listBoxCompromissosPassados.Name = "listBoxCompromissosPassados";
            this.listBoxCompromissosPassados.Size = new System.Drawing.Size(889, 304);
            this.listBoxCompromissosPassados.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxCompromissosFuturos);
            this.tabPage1.Controls.Add(this.btnFiltrar);
            this.tabPage1.Controls.Add(this.dateTimePickerFim);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePickerInicio);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(889, 301);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Futuros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxCompromissosFuturos
            // 
            this.listBoxCompromissosFuturos.FormattingEnabled = true;
            this.listBoxCompromissosFuturos.ItemHeight = 15;
            this.listBoxCompromissosFuturos.Location = new System.Drawing.Point(4, 45);
            this.listBoxCompromissosFuturos.Name = "listBoxCompromissosFuturos";
            this.listBoxCompromissosFuturos.Size = new System.Drawing.Size(882, 259);
            this.listBoxCompromissosFuturos.TabIndex = 5;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(565, 11);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(112, 23);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.Location = new System.Drawing.Point(312, 11);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerFim.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inicio";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(49, 11);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerInicio.TabIndex = 0;
            // 
            // UserControlCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlCompromissos);
            this.Controls.Add(this.panelAcoes);
            this.Name = "UserControlCompromisso";
            this.Size = new System.Drawing.Size(903, 426);
            this.panelAcoes.ResumeLayout(false);
            this.tabControlCompromissos.ResumeLayout(false);
            this.listTodosCompromissos.ResumeLayout(false);
            this.tbCompromissosPassados.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAcoes;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ListBox listBoxTodosCompromissos;
        private System.Windows.Forms.TabControl tabControlCompromissos;
        private System.Windows.Forms.TabPage listTodosCompromissos;
        private System.Windows.Forms.TabPage tbCompromissosPassados;
        private System.Windows.Forms.ListBox listBoxCompromissosPassados;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ListBox listBoxCompromissosFuturos;
    }
}
