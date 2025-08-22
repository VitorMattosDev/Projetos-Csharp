namespace LINQ
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
            this.lista = new System.Windows.Forms.ListBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnAgregacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 31;
            this.lista.Location = new System.Drawing.Point(12, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(490, 500);
            this.lista.TabIndex = 0;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(544, 12);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(244, 41);
            this.txtConsulta.TabIndex = 1;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(559, 74);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(229, 82);
            this.btnExecutar.TabIndex = 2;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhere.Location = new System.Drawing.Point(559, 162);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(229, 82);
            this.btnWhere.TabIndex = 3;
            this.btnWhere.Text = "Where";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderBy.Location = new System.Drawing.Point(559, 250);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(229, 82);
            this.btnOrderBy.TabIndex = 4;
            this.btnOrderBy.Text = "OrderBy";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGroupBy.Location = new System.Drawing.Point(559, 338);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(229, 82);
            this.btnGroupBy.TabIndex = 5;
            this.btnGroupBy.Text = "GroupBy";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnAgregacao
            // 
            this.btnAgregacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregacao.Location = new System.Drawing.Point(559, 426);
            this.btnAgregacao.Name = "btnAgregacao";
            this.btnAgregacao.Size = new System.Drawing.Size(229, 82);
            this.btnAgregacao.TabIndex = 6;
            this.btnAgregacao.Text = "Operadores de Agregação";
            this.btnAgregacao.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.btnAgregacao);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnAgregacao;
    }
}

