namespace WinFormsApp2
{
    partial class Inicio
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
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.enviar = new System.Windows.Forms.Button();
            this.viewMensagem = new System.Windows.Forms.DataGridView();
            this.exibir = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewMensagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtMensagem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMensagem.Location = new System.Drawing.Point(133, 400);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(436, 27);
            this.txtMensagem.TabIndex = 0;
            // 
            // enviar
            // 
            this.enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enviar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.enviar.Location = new System.Drawing.Point(633, 400);
            this.enviar.Name = "enviar";
            this.enviar.Size = new System.Drawing.Size(79, 27);
            this.enviar.TabIndex = 1;
            this.enviar.Text = "Enviar";
            this.enviar.UseVisualStyleBackColor = true;
            this.enviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // viewMensagem
            // 
            this.viewMensagem.AllowUserToOrderColumns = true;
            this.viewMensagem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.viewMensagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewMensagem.Location = new System.Drawing.Point(133, 84);
            this.viewMensagem.Name = "viewMensagem";
            this.viewMensagem.RowTemplate.Height = 25;
            this.viewMensagem.Size = new System.Drawing.Size(579, 295);
            this.viewMensagem.TabIndex = 2;
            this.viewMensagem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewMensagem_CellContentClick);
            // 
            // exibir
            // 
            this.exibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exibir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exibir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.exibir.Location = new System.Drawing.Point(133, 49);
            this.exibir.Name = "exibir";
            this.exibir.Size = new System.Drawing.Size(75, 29);
            this.exibir.TabIndex = 3;
            this.exibir.Text = "Exibir";
            this.exibir.UseVisualStyleBackColor = true;
            this.exibir.Click += new System.EventHandler(this.exibir_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(575, 400);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(52, 27);
            this.txtId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(133, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite uma mensagem...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(579, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(30)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(890, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.exibir);
            this.Controls.Add(this.viewMensagem);
            this.Controls.Add(this.enviar);
            this.Controls.Add(this.txtMensagem);
            this.Name = "Inicio";
            this.RightToLeftLayout = true;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.viewMensagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtMensagem;
        private Button enviar;
        private DataGridView viewMensagem;
        private Button exibir;
        private TextBox txtId;
        private Label label1;
        private Label label2;
    }
}