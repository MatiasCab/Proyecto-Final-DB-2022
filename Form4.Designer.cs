namespace Aplicacion_1
{
    partial class Form4
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
            this.menusGrid = new System.Windows.Forms.DataGridView();
            this.menuName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.rolesAplicativosGrid = new System.Windows.Forms.DataGridView();
            this.rolesApp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menusGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesAplicativosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menusGrid
            // 
            this.menusGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menusGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menuName});
            this.menusGrid.Location = new System.Drawing.Point(262, 66);
            this.menusGrid.Name = "menusGrid";
            this.menusGrid.Size = new System.Drawing.Size(526, 291);
            this.menusGrid.TabIndex = 0;
            this.menusGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menusGrid_CellClick);
            // 
            // menuName
            // 
            this.menuName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.menuName.HeaderText = "Nombre";
            this.menuName.Name = "menuName";
            this.menuName.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENUS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rolesAplicativosGrid
            // 
            this.rolesAplicativosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesAplicativosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rolesApp});
            this.rolesAplicativosGrid.Location = new System.Drawing.Point(12, 66);
            this.rolesAplicativosGrid.Name = "rolesAplicativosGrid";
            this.rolesAplicativosGrid.Size = new System.Drawing.Size(240, 291);
            this.rolesAplicativosGrid.TabIndex = 2;
            this.rolesAplicativosGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesAplicativosGrid_CellClick);
            // 
            // rolesApp
            // 
            this.rolesApp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rolesApp.HeaderText = "Roles aplicativos";
            this.rolesApp.Name = "rolesApp";
            this.rolesApp.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ROLES APLICATIVOS";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rolesAplicativosGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menusGrid);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.menusGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesAplicativosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView menusGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView rolesAplicativosGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolesApp;
    }
}