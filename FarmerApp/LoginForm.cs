using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 40);
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromName("LightGray");
        }
        Point lastPoint;

        private void basicPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void basicPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string loginUser = nameField.Text;
            string passUser = passField.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @loginUsers AND `password` = @passUser", db.getConnection());

            command.Parameters.Add("@loginUsers", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@passUser", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.openConnection();

            if (table.Rows.Count > 0)
            {
                this.Hide();

                MainForm mainform = new MainForm();
                mainform.Show();
            }
            db.closeConnection();
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();

            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

    }
}
