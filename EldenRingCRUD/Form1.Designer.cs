namespace EldenRingCRUD
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
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.picBoss = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblDrops = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVerSalvos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoss)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(44, 75);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(212, 20);
            this.txtBusca.TabIndex = 0;
            this.txtBusca.TextChanged += new System.EventHandler(this.txtBusca_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AllowDrop = true;
            this.btnBuscar.Location = new System.Drawing.Point(44, 114);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(212, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // picBoss
            // 
            this.picBoss.Location = new System.Drawing.Point(320, 60);
            this.picBoss.Name = "picBoss";
            this.picBoss.Size = new System.Drawing.Size(400, 350);
            this.picBoss.TabIndex = 2;
            this.picBoss.TabStop = false;
            this.picBoss.Click += new System.EventHandler(this.picBoss_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(799, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name: ";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblHp
            // 
            this.lblHp.AutoSize = true;
            this.lblHp.Location = new System.Drawing.Point(799, 119);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(28, 13);
            this.lblHp.TabIndex = 4;
            this.lblHp.Text = "HP: ";
            this.lblHp.Click += new System.EventHandler(this.lblHp_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(799, 154);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(54, 13);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Location: ";
            this.lblLocation.Click += new System.EventHandler(this.lblLocation_Click);
            // 
            // lblDrops
            // 
            this.lblDrops.AutoSize = true;
            this.lblDrops.Location = new System.Drawing.Point(799, 192);
            this.lblDrops.Name = "lblDrops";
            this.lblDrops.Size = new System.Drawing.Size(41, 13);
            this.lblDrops.TabIndex = 6;
            this.lblDrops.Text = "Drops: ";
            this.lblDrops.Click += new System.EventHandler(this.lblDrops_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.Location = new System.Drawing.Point(799, 231);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(220, 120);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description: ";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(385, 433);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(270, 39);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVerSalvos
            // 
            this.btnVerSalvos.Location = new System.Drawing.Point(349, 504);
            this.btnVerSalvos.Name = "btnVerSalvos";
            this.btnVerSalvos.Size = new System.Drawing.Size(348, 49);
            this.btnVerSalvos.TabIndex = 9;
            this.btnVerSalvos.Text = "Ver Bosses Salvos";
            this.btnVerSalvos.UseVisualStyleBackColor = true;
            this.btnVerSalvos.Click += new System.EventHandler(this.btnVerSalvos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 570);
            this.Controls.Add(this.btnVerSalvos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDrops);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblHp);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picBoss);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBusca);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox picBoss;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblDrops;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVerSalvos;
    }
}

