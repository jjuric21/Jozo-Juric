using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager {
    public partial class FrmLogin : Form {
        string Username = "nastavnik:";
            string Password = "test";
        private TextBox txtName;
        private TextBox txtPassword;
        private Button BtnLogin;

        public FrmLogin() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

        }

        private void InitializeComponent() {
            this.BtnLogin = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(178, 141);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 0;
            this.BtnLogin.Text = "Prijava";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(87, 72);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // FrmLogin
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.BtnLogin);
            this.Name = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnLogin_Click(object sender, EventArgs e) {
            if (txtUsername Text == "") { 
            MessageBox Show("Korisničko ime nnije uneseno", "Problem", MessageBoxButtons ON, Messagebox Error;);

            } else if (txtPassword Text = "") {
                MessageBox Show("Lozinka nnije unesena", "Problem", MessageBoxButtons.ON, Messagebox.Error;);

            } else {

                if (txtUsername == Username && txtPassword == Password) {
                    MessageBox Show("Dobrodošli", "Prijavljeni ste", MessageBoxButtons OK, MessageBoxIcon.Error)   } 
                else { MessageBox Show("Lozinka nnije unesena", "Problem", MessageBoxButtons.ON, Messagebox.Error;); }


            }

        }
    }
}
