namespace Apresentacao.ToDo.ModelTarefa
{
    partial class UserControlTarefas
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
            this.btnAtualizarItem = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.listBoxTarefas = new System.Windows.Forms.ListBox();
            this.tabControlTarefas = new System.Windows.Forms.TabControl();
            this.Todos = new System.Windows.Forms.TabPage();
            this.Pendentes = new System.Windows.Forms.TabPage();
            this.Concluidas = new System.Windows.Forms.TabPage();
            this.listaPendentes = new System.Windows.Forms.ListBox();
            this.listaConcluidas = new System.Windows.Forms.ListBox();
            this.panelAcoes.SuspendLayout();
            this.tabControlTarefas.SuspendLayout();
            this.Todos.SuspendLayout();
            this.Pendentes.SuspendLayout();
            this.Concluidas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAcoes
            // 
            this.panelAcoes.Controls.Add(this.btnAtualizarItem);
            this.panelAcoes.Controls.Add(this.btnExcluir);
            this.panelAcoes.Controls.Add(this.btnEditar);
            this.panelAcoes.Controls.Add(this.btnCadastrar);
            this.panelAcoes.Location = new System.Drawing.Point(3, 3);
            this.panelAcoes.Name = "panelAcoes";
            this.panelAcoes.Size = new System.Drawing.Size(615, 85);
            this.panelAcoes.TabIndex = 1;
            // 
            // btnAtualizarItem
            // 
            this.btnAtualizarItem.Location = new System.Drawing.Point(448, 17);
            this.btnAtualizarItem.Name = "btnAtualizarItem";
            this.btnAtualizarItem.Size = new System.Drawing.Size(126, 53);
            this.btnAtualizarItem.TabIndex = 3;
            this.btnAtualizarItem.Text = "Atualizar Item";
            this.btnAtualizarItem.UseVisualStyleBackColor = true;
            this.btnAtualizarItem.Click += new System.EventHandler(this.btnAtualizarItem_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(304, 17);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(126, 53);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnexcluir_Click);
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
            // listBoxTarefas
            // 
            this.listBoxTarefas.FormattingEnabled = true;
            this.listBoxTarefas.ItemHeight = 15;
            this.listBoxTarefas.Location = new System.Drawing.Point(0, 0);
            this.listBoxTarefas.Name = "listBoxTarefas";
            this.listBoxTarefas.Size = new System.Drawing.Size(859, 289);
            this.listBoxTarefas.TabIndex = 2;
            // 
            // tabControlTarefas
            // 
            this.tabControlTarefas.Controls.Add(this.Todos);
            this.tabControlTarefas.Controls.Add(this.Pendentes);
            this.tabControlTarefas.Controls.Add(this.Concluidas);
            this.tabControlTarefas.Location = new System.Drawing.Point(18, 94);
            this.tabControlTarefas.Name = "tabControlTarefas";
            this.tabControlTarefas.SelectedIndex = 0;
            this.tabControlTarefas.Size = new System.Drawing.Size(867, 317);
            this.tabControlTarefas.TabIndex = 3;
            this.tabControlTarefas.SelectedIndexChanged += new System.EventHandler(this.tabControlTarefas_SelectedIndexChanged);
            // 
            // Todos
            // 
            this.Todos.Controls.Add(this.listBoxTarefas);
            this.Todos.Location = new System.Drawing.Point(4, 24);
            this.Todos.Name = "Todos";
            this.Todos.Padding = new System.Windows.Forms.Padding(3);
            this.Todos.Size = new System.Drawing.Size(859, 289);
            this.Todos.TabIndex = 0;
            this.Todos.Text = "Todos";
            this.Todos.UseVisualStyleBackColor = true;
            // 
            // Pendentes
            // 
            this.Pendentes.Controls.Add(this.listaPendentes);
            this.Pendentes.Location = new System.Drawing.Point(4, 24);
            this.Pendentes.Name = "Pendentes";
            this.Pendentes.Padding = new System.Windows.Forms.Padding(3);
            this.Pendentes.Size = new System.Drawing.Size(859, 289);
            this.Pendentes.TabIndex = 1;
            this.Pendentes.Text = "Pendentes";
            this.Pendentes.UseVisualStyleBackColor = true;
            // 
            // Concluidas
            // 
            this.Concluidas.Controls.Add(this.listaConcluidas);
            this.Concluidas.Location = new System.Drawing.Point(4, 24);
            this.Concluidas.Name = "Concluidas";
            this.Concluidas.Padding = new System.Windows.Forms.Padding(3);
            this.Concluidas.Size = new System.Drawing.Size(859, 289);
            this.Concluidas.TabIndex = 2;
            this.Concluidas.Text = "Concluidas";
            this.Concluidas.UseVisualStyleBackColor = true;
            // 
            // listaPendentes
            // 
            this.listaPendentes.FormattingEnabled = true;
            this.listaPendentes.ItemHeight = 15;
            this.listaPendentes.Location = new System.Drawing.Point(1, 2);
            this.listaPendentes.Name = "listaPendentes";
            this.listaPendentes.Size = new System.Drawing.Size(855, 289);
            this.listaPendentes.TabIndex = 0;
            // 
            // listaConcluidas
            // 
            this.listaConcluidas.FormattingEnabled = true;
            this.listaConcluidas.ItemHeight = 15;
            this.listaConcluidas.Location = new System.Drawing.Point(1, 1);
            this.listaConcluidas.Name = "listaConcluidas";
            this.listaConcluidas.Size = new System.Drawing.Size(855, 289);
            this.listaConcluidas.TabIndex = 0;
            // 
            // UserControlTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlTarefas);
            this.Controls.Add(this.panelAcoes);
            this.Name = "UserControlTarefas";
            this.Size = new System.Drawing.Size(903, 426);
            this.panelAcoes.ResumeLayout(false);
            this.tabControlTarefas.ResumeLayout(false);
            this.Todos.ResumeLayout(false);
            this.Pendentes.ResumeLayout(false);
            this.Concluidas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAcoes;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ListBox listBoxTarefas;
        private System.Windows.Forms.Button btnAtualizarItem;
        private System.Windows.Forms.TabControl tabControlTarefas;
        private System.Windows.Forms.TabPage Todos;
        private System.Windows.Forms.TabPage Pendentes;
        private System.Windows.Forms.TabPage Concluidas;
        private System.Windows.Forms.ListBox listaPendentes;
        private System.Windows.Forms.ListBox listaConcluidas;
    }
}
