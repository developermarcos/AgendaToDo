namespace Apresentacao.ToDo.ModuloContato
{
    partial class TelaSelecionaContato
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
            this.listBoxContatos = new System.Windows.Forms.ListBox();
            this.btnSelecioanr = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxContatos
            // 
            this.listBoxContatos.FormattingEnabled = true;
            this.listBoxContatos.ItemHeight = 15;
            this.listBoxContatos.Location = new System.Drawing.Point(24, 37);
            this.listBoxContatos.Name = "listBoxContatos";
            this.listBoxContatos.Size = new System.Drawing.Size(739, 319);
            this.listBoxContatos.TabIndex = 0;
            // 
            // btnSelecioanr
            // 
            this.btnSelecioanr.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelecioanr.Location = new System.Drawing.Point(24, 389);
            this.btnSelecioanr.Name = "btnSelecioanr";
            this.btnSelecioanr.Size = new System.Drawing.Size(102, 37);
            this.btnSelecioanr.TabIndex = 9;
            this.btnSelecioanr.Text = "Selecionar";
            this.btnSelecioanr.UseVisualStyleBackColor = true;
            this.btnSelecioanr.Click += new System.EventHandler(this.btnSelecioanr_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(201, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 37);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaSelecionaContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelecioanr);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.listBoxContatos);
            this.Name = "TelaSelecionaContato";
            this.Text = "TelaSelecionaContato";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxContatos;
        private System.Windows.Forms.Button btnSelecioanr;
        private System.Windows.Forms.Button btnCancelar;
    }
}