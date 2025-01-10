namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_query = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.textBox_add = new System.Windows.Forms.TextBox();
            this.label_add = new System.Windows.Forms.Label();
            this.label_add2 = new System.Windows.Forms.Label();
            this.textBox_add2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(311, 105);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(159, 20);
            this.textBox_login.TabIndex = 0;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(311, 144);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(159, 20);
            this.textBox_password.TabIndex = 1;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(311, 179);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(159, 23);
            this.button_connect.TabIndex = 2;
            this.button_connect.Text = "Połącz z bazą";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(308, 89);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(33, 13);
            this.label_login.TabIndex = 3;
            this.label_login.Text = "Login";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(308, 128);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(36, 13);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Hasło";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.Visible = false;
            // 
            // button_query
            // 
            this.button_query.Location = new System.Drawing.Point(100, 227);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(159, 23);
            this.button_query.TabIndex = 6;
            this.button_query.Text = "Odśwież";
            this.button_query.UseVisualStyleBackColor = true;
            this.button_query.Visible = false;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(578, 179);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(61, 23);
            this.button_add.TabIndex = 7;
            this.button_add.Text = "Dodaj";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(295, 227);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(159, 23);
            this.button_remove.TabIndex = 10;
            this.button_remove.Text = "Usuń element";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Visible = false;
            // 
            // textBox_add
            // 
            this.textBox_add.Location = new System.Drawing.Point(496, 87);
            this.textBox_add.Name = "textBox_add";
            this.textBox_add.Size = new System.Drawing.Size(224, 20);
            this.textBox_add.TabIndex = 8;
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Location = new System.Drawing.Point(493, 71);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(75, 13);
            this.label_add.TabIndex = 9;
            this.label_add.Text = "Dodaj element";
            // 
            // label_add2
            // 
            this.label_add2.AutoSize = true;
            this.label_add2.Location = new System.Drawing.Point(493, 112);
            this.label_add2.Name = "label_add2";
            this.label_add2.Size = new System.Drawing.Size(57, 13);
            this.label_add2.TabIndex = 12;
            this.label_add2.Text = "Ilość sztuk";
            // 
            // textBox_add2
            // 
            this.textBox_add2.Location = new System.Drawing.Point(496, 128);
            this.textBox_add2.Name = "textBox_add2";
            this.textBox_add2.Size = new System.Drawing.Size(82, 20);
            this.textBox_add2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 303);
            this.Controls.Add(this.label_add2);
            this.Controls.Add(this.textBox_add2);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.label_add);
            this.Controls.Add(this.textBox_add);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_query);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.TextBox textBox_add;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.Label label_add2;
        private System.Windows.Forms.TextBox textBox_add2;
    }
}

