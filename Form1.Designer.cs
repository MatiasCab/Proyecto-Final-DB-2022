namespace Aplicacion_1
{
    partial class Form1
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
            this.rolesGrid = new System.Windows.Forms.DataGridView();
            this.roleColumnTR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aplicativosGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.appNameColumnGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicativosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // rolesGrid
            // 
            this.rolesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleColumnTR});
            this.rolesGrid.Location = new System.Drawing.Point(12, 125);
            this.rolesGrid.Name = "rolesGrid";
            this.rolesGrid.Size = new System.Drawing.Size(216, 303);
            this.rolesGrid.TabIndex = 2;
            this.rolesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesGrid_CellContentClick);
            // 
            // roleColumnTR
            // 
            this.roleColumnTR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleColumnTR.HeaderText = "Rol";
            this.roleColumnTR.Name = "roleColumnTR";
            this.roleColumnTR.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ubicacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Roles habilitados:";
            // 
            // aplicativosGrid
            // 
            this.aplicativosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aplicativosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appNameColumnGrid});
            this.aplicativosGrid.Location = new System.Drawing.Point(234, 105);
            this.aplicativosGrid.Name = "aplicativosGrid";
            this.aplicativosGrid.Size = new System.Drawing.Size(552, 323);
            this.aplicativosGrid.TabIndex = 6;
            this.aplicativosGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aplicativosGrid_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(441, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aplicativos";
            // 
            // appNameColumnGrid
            // 
            this.appNameColumnGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appNameColumnGrid.HeaderText = "Nombre";
            this.appNameColumnGrid.Name = "appNameColumnGrid";
            this.appNameColumnGrid.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aplicativosGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rolesGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rolesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicativosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView rolesGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView aplicativosGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleColumnTR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn appNameColumnGrid;
    }
}

