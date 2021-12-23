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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.registerButton.Size = new Size(150, this.registerButton.Height);
            this.passField.Size = new Size(this.passField.Width, 40);
            this.StartPosition = FormStartPosition.WindowsDefaultLocation;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_MouseEnter(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.FromArgb(0, 171, 111);
        }

        private void registerButton_MouseLeave(object sender, EventArgs e)
        {
            registerButton.BackColor = Color.White;
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
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void basicPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (nameField.Text == "" || passField.Text == "")
                return;

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`login`, `password`) VALUES (@login, @password)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = nameField.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Акаунт створено");
            }
            db.closeConnection();

        }
        public Boolean isUserExists()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @loginUsers", db.getConnection());

            command.Parameters.Add("@loginUsers", MySqlDbType.VarChar).Value = nameField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Даний користувач уже існує. Введіть нове ім'я");
                return true;
            }
            else
                return false;
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
