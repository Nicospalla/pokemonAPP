namespace PokemonApp
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPokemon = new System.Windows.Forms.DataGridView();
            this.picboxPokemon = new System.Windows.Forms.PictureBox();
            this.btnAgregarPpal = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFis = new System.Windows.Forms.Button();
            this.btnEliminarLog = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltroAv = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroAv = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltroAv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemon
            // 
            this.dgvPokemon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPokemon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemon.Location = new System.Drawing.Point(12, 61);
            this.dgvPokemon.MultiSelect = false;
            this.dgvPokemon.Name = "dgvPokemon";
            this.dgvPokemon.ReadOnly = true;
            this.dgvPokemon.RowHeadersWidth = 51;
            this.dgvPokemon.RowTemplate.Height = 24;
            this.dgvPokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemon.Size = new System.Drawing.Size(739, 285);
            this.dgvPokemon.TabIndex = 0;
            this.dgvPokemon.SelectionChanged += new System.EventHandler(this.dgvPokemon_SelectionChanged);

            // 
            // picboxPokemon
            // 
            this.picboxPokemon.Location = new System.Drawing.Point(769, 61);
            this.picboxPokemon.Name = "picboxPokemon";
            this.picboxPokemon.Size = new System.Drawing.Size(264, 285);
            this.picboxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPokemon.TabIndex = 1;
            this.picboxPokemon.TabStop = false;
            // 
            // btnAgregarPpal
            // 
            this.btnAgregarPpal.Location = new System.Drawing.Point(12, 353);
            this.btnAgregarPpal.Name = "btnAgregarPpal";
            this.btnAgregarPpal.Size = new System.Drawing.Size(147, 36);
            this.btnAgregarPpal.TabIndex = 2;
            this.btnAgregarPpal.Text = "Agregar Pokemon";
            this.btnAgregarPpal.UseVisualStyleBackColor = true;
            this.btnAgregarPpal.Click += new System.EventHandler(this.btnAgregarPpal_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(165, 353);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(168, 36);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar Pokemon";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFis
            // 
            this.btnEliminarFis.Location = new System.Drawing.Point(339, 352);
            this.btnEliminarFis.Name = "btnEliminarFis";
            this.btnEliminarFis.Size = new System.Drawing.Size(168, 36);
            this.btnEliminarFis.TabIndex = 4;
            this.btnEliminarFis.Text = "Eliminar Pokemon";
            this.btnEliminarFis.UseVisualStyleBackColor = true;
            this.btnEliminarFis.Click += new System.EventHandler(this.btnEliminarFis_Click);
            // 
            // btnEliminarLog
            // 
            this.btnEliminarLog.Location = new System.Drawing.Point(513, 353);
            this.btnEliminarLog.Name = "btnEliminarLog";
            this.btnEliminarLog.Size = new System.Drawing.Size(168, 36);
            this.btnEliminarLog.TabIndex = 5;
            this.btnEliminarLog.Text = "Eliminar Logico";
            this.btnEliminarLog.UseVisualStyleBackColor = true;
            this.btnEliminarLog.Click += new System.EventHandler(this.btnEliminarLog_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(12, 29);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(51, 16);
            this.lblFiltro.TabIndex = 6;
            this.lblFiltro.Text = "Filtrar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(103, 29);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(264, 22);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnFiltroAv
            // 
            this.btnFiltroAv.Location = new System.Drawing.Point(638, 407);
            this.btnFiltroAv.Name = "btnFiltroAv";
            this.btnFiltroAv.Size = new System.Drawing.Size(97, 23);
            this.btnFiltroAv.TabIndex = 8;
            this.btnFiltroAv.Text = "Aceptar";
            this.btnFiltroAv.UseCompatibleTextRendering = true;
            this.btnFiltroAv.UseVisualStyleBackColor = true;
            this.btnFiltroAv.Click += new System.EventHandler(this.btnFiltroAv_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(14, 411);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(54, 16);
            this.lblCampo.TabIndex = 9;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(223, 411);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(52, 16);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblFiltroAv
            // 
            this.lblFiltroAv.AutoSize = true;
            this.lblFiltroAv.Location = new System.Drawing.Point(432, 411);
            this.lblFiltroAv.Name = "lblFiltroAv";
            this.lblFiltroAv.Size = new System.Drawing.Size(39, 16);
            this.lblFiltroAv.TabIndex = 11;
            this.lblFiltroAv.Text = "Filtro:";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(80, 407);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 24);
            this.cboCampo.TabIndex = 12;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(289, 407);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(121, 24);
            this.cboCriterio.TabIndex = 13;
            // 
            // txtFiltroAv
            // 
            this.txtFiltroAv.Location = new System.Drawing.Point(498, 408);
            this.txtFiltroAv.Name = "txtFiltroAv";
            this.txtFiltroAv.Size = new System.Drawing.Size(100, 22);
            this.txtFiltroAv.TabIndex = 14;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 452);
            this.Controls.Add(this.txtFiltroAv);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblFiltroAv);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnFiltroAv);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminarLog);
            this.Controls.Add(this.btnEliminarFis);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregarPpal);
            this.Controls.Add(this.picboxPokemon);
            this.Controls.Add(this.dgvPokemon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemon;
        private System.Windows.Forms.PictureBox picboxPokemon;
        private System.Windows.Forms.Button btnAgregarPpal;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFis;
        private System.Windows.Forms.Button btnEliminarLog;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltroAv;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroAv;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtFiltroAv;
    }
}

