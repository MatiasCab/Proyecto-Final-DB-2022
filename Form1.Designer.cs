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
            this.dataGridVPermisos = new System.Windows.Forms.DataGridView();
            this.permissionsTableUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionsTableAppId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionsTableNegRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionsSolDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionsAuthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionsTableState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVPermisos
            // 
            this.dataGridVPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.permissionsTableUserId,
            this.permissionsTableAppId,
            this.permissionsTableNegRol,
            this.permissionsSolDate,
            this.permissionsAuthDate,
            this.permissionsTableState});
            this.dataGridVPermisos.Location = new System.Drawing.Point(12, 99);
            this.dataGridVPermisos.Name = "dataGridVPermisos";
            this.dataGridVPermisos.Size = new System.Drawing.Size(643, 174);
            this.dataGridVPermisos.TabIndex = 0;
            // 
            // permissionsTableUserId
            // 
            this.permissionsTableUserId.HeaderText = "USER ID";
            this.permissionsTableUserId.Name = "permissionsTableUserId";
            // 
            // permissionsTableAppId
            // 
            this.permissionsTableAppId.HeaderText = "APP ID";
            this.permissionsTableAppId.Name = "permissionsTableAppId";
            // 
            // permissionsTableNegRol
            // 
            this.permissionsTableNegRol.HeaderText = "ROL DE NEGOCIO";
            this.permissionsTableNegRol.Name = "permissionsTableNegRol";
            // 
            // permissionsSolDate
            // 
            this.permissionsSolDate.HeaderText = "FECHA DE SOLICITUD";
            this.permissionsSolDate.Name = "permissionsSolDate";
            // 
            // permissionsAuthDate
            // 
            this.permissionsAuthDate.HeaderText = "FECHA DE AUTORIZACION";
            this.permissionsAuthDate.Name = "permissionsAuthDate";
            // 
            // permissionsTableState
            // 
            this.permissionsTableState.HeaderText = "ESTADO";
            this.permissionsTableState.Name = "permissionsTableState";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "CARGAR DATOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridVPermisos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVPermisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionsTableUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionsTableAppId;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionsTableNegRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionsSolDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionsAuthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionsTableState;
        private System.Windows.Forms.Button button1;
    }
}

