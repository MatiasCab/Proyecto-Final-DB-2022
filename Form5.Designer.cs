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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkRol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pregunta1 = new System.Windows.Forms.ComboBox();
            this.pregunta2 = new System.Windows.Forms.ComboBox();
            this.pregunta3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // userCI
            // 
            this.userCI.Location = new System.Drawing.Point(31, 86);
            this.userCI.Name = "userCI";
            this.userCI.Size = new System.Drawing.Size(100, 20);
            this.userCI.TabIndex = 0;
            // 
            // departamento
            // 
            this.departamento.Location = new System.Drawing.Point(31, 196);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(100, 20);
            this.departamento.TabIndex = 1;
            // 
            // userName
            // 
            this.userName.Location = new System.Drawing.Point(31, 34);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(100, 20);
            this.userName.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(31, 222);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 3;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(31, 60);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 20);
            this.lastName.TabIndex = 4;
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(31, 160);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(100, 20);
            this.Direccion.TabIndex = 5;
            // 
            // Ciudad
            // 
            this.Ciudad.Location = new System.Drawing.Point(31, 125);
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Size = new System.Drawing.Size(100, 20);
            this.Ciudad.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // respuesta3
            // 
            this.respuesta3.Location = new System.Drawing.Point(433, 216);
            this.respuesta3.Name = "respuesta3";
            this.respuesta3.Size = new System.Drawing.Size(100, 20);
            this.respuesta3.TabIndex = 11;
            // 
            // respuesta2
            // 
            this.respuesta2.Location = new System.Drawing.Point(433, 125);
            this.respuesta2.Name = "respuesta2";
            this.respuesta2.Size = new System.Drawing.Size(100, 20);
            this.respuesta2.TabIndex = 12;
            // 
            // respuesta1
            // 
            this.respuesta1.Location = new System.Drawing.Point(433, 60);
            this.respuesta1.Name = "respuesta1";
            this.respuesta1.Size = new System.Drawing.Size(100, 20);
            this.respuesta1.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkRol,
            this.rolName});
            this.dataGridView1.Location = new System.Drawing.Point(561, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(279, 166);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkRol
            // 
            this.checkRol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.checkRol.FillWeight = 10F;
            this.checkRol.HeaderText = "";
            this.checkRol.Name = "checkRol";
            this.checkRol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkRol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rolName
            // 
            this.rolName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rolName.HeaderText = "Nombre del rol";
            this.rolName.Name = "rolName";
            // 
            // pregunta1
            // 
            this.pregunta1.FormattingEnabled = true;
            this.pregunta1.Location = new System.Drawing.Point(246, 58);
            this.pregunta1.Name = "pregunta1";
            this.pregunta1.Size = new System.Drawing.Size(121, 21);
            this.pregunta1.TabIndex = 15;
            this.pregunta1.SelectedIndexChanged += new System.EventHandler(this.pregunta1_SelectedIndexChanged);
            this.pregunta1.SelectedValueChanged += new System.EventHandler(this.pregunta1_SelectedValueChanged);
            // 
            // pregunta2
            // 
            this.pregunta2.FormattingEnabled = true;
            this.pregunta2.Location = new System.Drawing.Point(246, 125);
            this.pregunta2.Name = "pregunta2";
            this.pregunta2.Size = new System.Drawing.Size(121, 21);
            this.pregunta2.TabIndex = 16;
            this.pregunta2.SelectedValueChanged += new System.EventHandler(this.pregunta2_SelectedValueChanged);
            // 
            // pregunta3
            // 
            this.pregunta3.FormattingEnabled = true;
            this.pregunta3.Location = new System.Drawing.Point(246, 215);
            this.pregunta3.Name = "pregunta3";
            this.pregunta3.Size = new System.Drawing.Size(121, 21);
            this.pregunta3.TabIndex = 17;
            this.pregunta3.SelectedValueChanged += new System.EventHandler(this.pregunta3_SelectedValueChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.pregunta3);
            this.Controls.Add(this.pregunta2);
            this.Controls.Add(this.pregunta1);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkRol;
        private System.Windows.Forms.ComboBox pregunta1;
        private System.Windows.Forms.ComboBox pregunta2;
        private System.Windows.Forms.ComboBox pregunta3;
    }
}