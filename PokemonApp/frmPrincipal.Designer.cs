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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemon
            // 
            this.dgvPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemon.Location = new System.Drawing.Point(12, 23);
            this.dgvPokemon.MultiSelect = false;
            this.dgvPokemon.Name = "dgvPokemon";
            this.dgvPokemon.ReadOnly = true;
            this.dgvPokemon.RowHeadersWidth = 51;
            this.dgvPokemon.RowTemplate.Height = 24;
            this.dgvPokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemon.Size = new System.Drawing.Size(722, 285);
            this.dgvPokemon.TabIndex = 0;
            this.dgvPokemon.SelectionChanged += new System.EventHandler(this.dgvPokemon_SelectionChanged);
            // 
            // picboxPokemon
            // 
            this.picboxPokemon.Location = new System.Drawing.Point(769, 23);
            this.picboxPokemon.Name = "picboxPokemon";
            this.picboxPokemon.Size = new System.Drawing.Size(264, 285);
            this.picboxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPokemon.TabIndex = 1;
            this.picboxPokemon.TabStop = false;
            // 
            // btnAgregarPpal
            // 
            this.btnAgregarPpal.Location = new System.Drawing.Point(12, 315);
            this.btnAgregarPpal.Name = "btnAgregarPpal";
            this.btnAgregarPpal.Size = new System.Drawing.Size(147, 36);
            this.btnAgregarPpal.TabIndex = 2;
            this.btnAgregarPpal.Text = "Agregar Pokemon";
            this.btnAgregarPpal.UseVisualStyleBackColor = true;
            this.btnAgregarPpal.Click += new System.EventHandler(this.btnAgregarPpal_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(165, 315);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(168, 36);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar Pokemon";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFis
            // 
            this.btnEliminarFis.Location = new System.Drawing.Point(339, 314);
            this.btnEliminarFis.Name = "btnEliminarFis";
            this.btnEliminarFis.Size = new System.Drawing.Size(168, 36);
            this.btnEliminarFis.TabIndex = 4;
            this.btnEliminarFis.Text = "Eliminar Pokemon";
            this.btnEliminarFis.UseVisualStyleBackColor = true;
            this.btnEliminarFis.Click += new System.EventHandler(this.btnEliminarFis_Click);
            // 
            // btnEliminarLog
            // 
            this.btnEliminarLog.Location = new System.Drawing.Point(513, 315);
            this.btnEliminarLog.Name = "btnEliminarLog";
            this.btnEliminarLog.Size = new System.Drawing.Size(168, 36);
            this.btnEliminarLog.TabIndex = 5;
            this.btnEliminarLog.Text = "Eliminar Logico";
            this.btnEliminarLog.UseVisualStyleBackColor = true;
            this.btnEliminarLog.Click += new System.EventHandler(this.btnEliminarLog_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 363);
            this.Controls.Add(this.btnEliminarLog);
            this.Controls.Add(this.btnEliminarFis);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregarPpal);
            this.Controls.Add(this.picboxPokemon);
            this.Controls.Add(this.dgvPokemon);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPokemon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemon;
        private System.Windows.Forms.PictureBox picboxPokemon;
        private System.Windows.Forms.Button btnAgregarPpal;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFis;
        private System.Windows.Forms.Button btnEliminarLog;
    }
}

