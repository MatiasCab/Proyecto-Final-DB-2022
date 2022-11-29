namespace Aplicacion_1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.userIdPerGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appColumnPerGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleNegColumnPerGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solDateColumnPerGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autDateColumnPerGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateColumnPerGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplicativo actual:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdPerGrid,
            this.appColumnPerGrid,
            this.roleNegColumnPerGrid,
            this.solDateColumnPerGrid,
            this.autDateColumnPerGrid,
            this.stateColumnPerGrid});
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 329);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(257, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Solicitudes de permisos:";
            // 
            // userIdPerGrid
            // 
            this.userIdPerGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userIdPerGrid.HeaderText = "C.I";
            this.userIdPerGrid.Name = "userIdPerGrid";
            this.userIdPerGrid.ReadOnly = true;
            // 
            // appColumnPerGrid
            // 
            this.appColumnPerGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appColumnPerGrid.HeaderText = "Aplicativo";
            this.appColumnPerGrid.Name = "appColumnPerGrid";
            this.appColumnPerGrid.ReadOnly = true;
            // 
            // roleNegColumnPerGrid
            // 
            this.roleNegColumnPerGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleNegColumnPerGrid.HeaderText = "Rol de Negocio";
            this.roleNegColumnPerGrid.Name = "roleNegColumnPerGrid";
            this.roleNegColumnPerGrid.ReadOnly = true;
            // 
            // solDateColumnPerGrid
            // 
            this.solDateColumnPerGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.solDateColumnPerGrid.HeaderText = "Fecha de solicitud";
            this.solDateColumnPerGrid.Name = "solDateColumnPerGrid";
            this.solDateColumnPerGrid.ReadOnly = true;
            // 
            // autDateColumnPerGrid
            // 
            this.autDateColumnPerGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.autDateColumnPerGrid.HeaderText = "Fecha de autorización";
            this.autDateColumnPerGrid.Name = "autDateColumnPerGrid";
            this.autDateColumnPerGrid.ReadOnly = true;
            // 
            // stateColumnPerGrid
            // 
            this.stateColumnPerGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stateColumnPerGrid.HeaderText = "Estado";
            this.stateColumnPerGrid.Name = "stateColumnPerGrid";
            this.stateColumnPerGrid.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdPerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn appColumnPerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNegColumnPerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn solDateColumnPerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn autDateColumnPerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateColumnPerGrid;
        private System.Windows.Forms.Button button1;
    }
}