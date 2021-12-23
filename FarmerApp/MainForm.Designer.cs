
namespace FarmerApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.showButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.showButton);
            this.panel1.Controls.Add(this.listBox);
            this.panel1.Controls.Add(this.checkedListBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(767, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 3;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(277, 332);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(200, 75);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Enter";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.LightGray;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(538, 19);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(200, 388);
            this.listBox.TabIndex = 1;
            // 
            // checkedListBox
            // 
            this.checkedListBox.BackColor = System.Drawing.Color.LightGray;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Баклажан",
            "Буряк",
            "Гарбуз",
            "Горох",
            "Диня",
            "Кавун",
            "Капуста",
            "Кабачок",
            "Квасоля",
            "Картопля",
            "Кукурудза",
            "Морква",
            "Огірок",
            "Помідор",
            "Перець",
            "Пшениця",
            "Редис",
            "Ріпа",
            "Соя",
            "Цибуля",
            "Часник",
            "Ячмінь"});
            this.checkedListBox.Location = new System.Drawing.Point(12, 29);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(200, 378);
            this.checkedListBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.PictureBox closeButton;
    }
}