
namespace FarmerApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.basicPanel = new System.Windows.Forms.Panel();
            this.registerLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.passPicture = new System.Windows.Forms.PictureBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.namePicture = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.basicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // basicPanel
            // 
            this.basicPanel.BackColor = System.Drawing.Color.LightGray;
            this.basicPanel.Controls.Add(this.registerLabel);
            this.basicPanel.Controls.Add(this.closeButton);
            this.basicPanel.Controls.Add(this.enterButton);
            this.basicPanel.Controls.Add(this.passField);
            this.basicPanel.Controls.Add(this.passPicture);
            this.basicPanel.Controls.Add(this.nameField);
            this.basicPanel.Controls.Add(this.namePicture);
            this.basicPanel.Controls.Add(this.titleLabel);
            this.basicPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.basicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicPanel.Location = new System.Drawing.Point(0, 0);
            this.basicPanel.Name = "basicPanel";
            this.basicPanel.Size = new System.Drawing.Size(682, 453);
            this.basicPanel.TabIndex = 0;
            this.basicPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.basicPanel_MouseDown);
            this.basicPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.basicPanel_MouseMove);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(111)))));
            this.registerLabel.Location = new System.Drawing.Point(266, 330);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(127, 18);
            this.registerLabel.TabIndex = 7;
            this.registerLabel.Text = "Зареєструватися";
            this.registerLabel.Click += new System.EventHandler(this.registerLabel_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(649, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // enterButton
            // 
            this.enterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(245)))), ((int)(((byte)(219)))));
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Sitka Small", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterButton.Location = new System.Drawing.Point(278, 384);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(100, 30);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "Увійти";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(156, 263);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(415, 30);
            this.passField.TabIndex = 5;
            this.passField.UseSystemPasswordChar = true;
            // 
            // passPicture
            // 
            this.passPicture.Image = ((System.Drawing.Image)(resources.GetObject("passPicture.Image")));
            this.passPicture.Location = new System.Drawing.Point(100, 263);
            this.passPicture.Name = "passPicture";
            this.passPicture.Size = new System.Drawing.Size(50, 50);
            this.passPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passPicture.TabIndex = 4;
            this.passPicture.TabStop = false;
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField.Location = new System.Drawing.Point(156, 167);
            this.nameField.Multiline = true;
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(415, 50);
            this.nameField.TabIndex = 3;
            // 
            // namePicture
            // 
            this.namePicture.Image = ((System.Drawing.Image)(resources.GetObject("namePicture.Image")));
            this.namePicture.Location = new System.Drawing.Point(100, 167);
            this.namePicture.Name = "namePicture";
            this.namePicture.Size = new System.Drawing.Size(50, 50);
            this.namePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.namePicture.TabIndex = 2;
            this.namePicture.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Stencil", 40.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(682, 116);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "FARMER";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.basicPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.basicPanel.ResumeLayout(false);
            this.basicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel basicPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox passPicture;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.PictureBox namePicture;
        private System.Windows.Forms.Label registerLabel;
    }
}