namespace Apresentacao.ToDo.ModuloContato
{
    partial class UserControlContato
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
            this.btnAgruparCargo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.listBoxContatos = new System.Windows.Forms.ListBox();
            this.panelAcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAcoes
            // 
            this.panelAcoes.Controls.Add(this.btnAgruparCargo);
            this.panelAcoes.Controls.Add(this.btnExcluir);
            this.panelAcoes.Controls.Add(this.btnEditar);
            this.panelAcoes.Controls.Add(this.btnCadastrar);
            this.panelAcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAcoes.Location = new System.Drawing.Point(0, 0);
            this.panelAcoes.Name = "panelAcoes";
            this.panelAcoes.Size = new System.Drawing.Size(903, 85);
            this.panelAcoes.TabIndex = 2;
            // 
            // btnAgruparCargo
            // 
            this.btnAgruparCargo.Location = new System.Drawing.Point(448, 17);
            this.btnAgruparCargo.Name = "btnAgruparCargo";
            this.btnAgruparCargo.Size = new System.Drawing.Size(126, 53);
            this.btnAgruparCargo.TabIndex = 3;
            this.btnAgruparCargo.Text = "Agrupar por Cargo";
            this.btnAgruparCargo.UseVisualStyleBackColor = true;
            this.btnAgruparCargo.Click += new System.EventHandler(this.btnAgruparCargo_Click);
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
            // listBoxContatos
            // 
            this.listBoxContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxContatos.FormattingEnabled = true;
            this.listBoxContatos.ItemHeight = 15;
            this.listBoxContatos.Location = new System.Drawing.Point(0, 85);
            this.listBoxContatos.Name = "listBoxContatos";
            this.listBoxContatos.Size = new System.Drawing.Size(903, 341);
            this.listBoxContatos.TabIndex = 3;
            // 
            // UserControlContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxContatos);
            this.Controls.Add(this.panelAcoes);
            this.Name = "UserControlContato";
            this.Size = new System.Drawing.Size(903, 426);
            this.panelAcoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAcoes;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ListBox listBoxContatos;
        private System.Windows.Forms.Button btnAgruparCargo;
    }
}
