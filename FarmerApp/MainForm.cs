using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

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
            this.closeButton.BackColor = Color.FromName("Gray");
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        string[] checkedItemsArray;


        private void showButton_Click(object sender, EventArgs e)
        {
            checkedItemsArray = checkedListBox.CheckedItems.Cast<string>().ToArray();
            PermutationOfElements elemets = new PermutationOfElements();
            
            elemets.setArray(checkedItemsArray);
            listBox.DataSource = PermutationOfElements.getBest;
        }
    }
}
