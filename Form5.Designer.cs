namespace Aplicacion_1
{
    partial class Form5
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
            this.userCI = new System.Windows.Forms.TextBox();
            this.departamento = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Ciudad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.respuesta3 = new System.Windows.Forms.TextBox();
            this.respuesta2 = new System.Windows.Forms.TextBox();
            this.respuesta1 = new System.Windows.Forms.TextBox();
            this.pregunta1 = new System.Windows.Forms.ComboBox();
            this.pregunta2 = new System.Windows.Forms.ComboBox();
            this.pregunta3 = new System.Windows.Forms.ComboBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.aplicativosGrid = new System.Windows.Forms.DataGridView();
            this.appSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolesGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aplicativosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // userCI
            // 
            this.userCI.Location = new System.Drawing.Point(92, 85);
            this.userCI.Name = "userCI";
            this.userCI.Size = new System.Drawing.Size(100, 20);
            this.userCI.TabIndex = 0;
            // 
            // departamento
            // 
            this.departamento.Location = new System.Drawing.Point(92, 163);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(100, 20);
            this.departamento.TabIndex = 1;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(92, 34);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 20);
            this.userName.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(92, 189);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(92, 59);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 4;
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(92, 137);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(100, 20);
            this.Direccion.TabIndex = 5;
            // 
            // Ciudad
            // 
            this.Ciudad.Location = new System.Drawing.Point(92, 111);
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Size = new System.Drawing.Size(100, 20);
            this.Ciudad.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 105);
            this.button1.TabIndex = 7;
            this.button1.Text = "Registrarse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // respuesta3
            // 
            this.respuesta3.Location = new System.Drawing.Point(433, 125);
            this.respuesta3.Name = "respuesta3";
            this.respuesta3.Size = new System.Drawing.Size(161, 20);
            this.respuesta3.TabIndex = 11;
            // 
            // respuesta2
            // 
            this.respuesta2.Location = new System.Drawing.Point(433, 85);
            this.respuesta2.Name = "respuesta2";
            this.respuesta2.Size = new System.Drawing.Size(161, 20);
            this.respuesta2.TabIndex = 12;
            // 
            // respuesta1
            // 
            this.respuesta1.Location = new System.Drawing.Point(433, 41);
            this.respuesta1.Name = "respuesta1";
            this.respuesta1.Size = new System.Drawing.Size(161, 20);
            this.respuesta1.TabIndex = 13;
            // 
            // pregunta1
            // 
            this.pregunta1.FormattingEnabled = true;
            this.pregunta1.Location = new System.Drawing.Point(218, 40);
            this.pregunta1.Name = "pregunta1";
            this.pregunta1.Size = new System.Drawing.Size(209, 21);
            this.pregunta1.TabIndex = 15;
            this.pregunta1.SelectedIndexChanged += new System.EventHandler(this.pregunta1_SelectedIndexChanged);
            this.pregunta1.SelectedValueChanged += new System.EventHandler(this.pregunta1_SelectedValueChanged);
            // 
            // pregunta2
            // 
            this.pregunta2.FormattingEnabled = true;
            this.pregunta2.Location = new System.Drawing.Point(218, 84);
            this.pregunta2.Name = "pregunta2";
            this.pregunta2.Size = new System.Drawing.Size(209, 21);
            this.pregunta2.TabIndex = 16;
            this.pregunta2.SelectedValueChanged += new System.EventHandler(this.pregunta2_SelectedValueChanged);
            // 
            // pregunta3
            // 
            this.pregunta3.FormattingEnabled = true;
            this.pregunta3.Location = new System.Drawing.Point(218, 125);
            this.pregunta3.Name = "pregunta3";
            this.pregunta3.Size = new System.Drawing.Size(209, 21);
            this.pregunta3.TabIndex = 17;
            this.pregunta3.SelectedValueChanged += new System.EventHandler(this.pregunta3_SelectedValueChanged);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(13, 40);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(41, 13);
            this.Nombre.TabIndex = 18;
            this.Nombre.Text = "Nmbre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Cedula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ciudad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Departamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Contraseña:";
            // 
            // aplicativosGrid
            // 
            this.aplicativosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aplicativosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appSelected,
            this.dataGridViewTextBoxColumn1});
            this.aplicativosGrid.Location = new System.Drawing.Point(459, 189);
            this.aplicativosGrid.Name = "aplicativosGrid";
            this.aplicativosGrid.Size = new System.Drawing.Size(274, 166);
            this.aplicativosGrid.TabIndex = 25;
            // 
            // appSelected
            // 
            this.appSelected.FillWeight = 10F;
            this.appSelected.HeaderText = "";
            this.appSelected.Name = "appSelected";
            this.appSelected.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Aplicativo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // rolesGrid
            // 
            this.rolesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.rolesGrid.Location = new System.Drawing.Point(218, 189);
            this.rolesGrid.Name = "rolesGrid";
            this.rolesGrid.Size = new System.Drawing.Size(235, 166);
            this.rolesGrid.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Roles";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 379);
            this.Controls.Add(this.rolesGrid);
            this.Controls.Add(this.aplicativosGrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.pregunta3);
            this.Controls.Add(this.pregunta2);
            this.Controls.Add(this.pregunta1);
            this.Controls.Add(this.respuesta1);
            this.Controls.Add(this.respuesta2);
            this.Controls.Add(this.respuesta3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ciudad);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.departamento);
            this.Controls.Add(this.userCI);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aplicativosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userCI;
        private System.Windows.Forms.TextBox departamento;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox Ciudad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox respuesta3;
        private System.Windows.Forms.TextBox respuesta2;
        private System.Windows.Forms.TextBox respuesta1;
        private System.Windows.Forms.ComboBox pregunta1;
        private System.Windows.Forms.ComboBox pregunta2;
        private System.Windows.Forms.ComboBox pregunta3;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView aplicativosGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn appSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView rolesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}