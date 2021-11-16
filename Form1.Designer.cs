
namespace Encryptor_V00A2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Home = new System.Windows.Forms.Panel();
            this.Security = new System.Windows.Forms.Panel();
            this.delay = new System.Windows.Forms.Timer(this.components);
            this.LoadingScreen = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Home.SuspendLayout();
            this.Security.SuspendLayout();
            this.LoadingScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Home.Controls.Add(this.Security);
            this.Home.Location = new System.Drawing.Point(0, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(420, 560);
            this.Home.TabIndex = 0;
            // 
            // Security
            // 
            this.Security.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Security.Controls.Add(this.LoadingScreen);
            this.Security.Controls.Add(this.pictureBox2);
            this.Security.Location = new System.Drawing.Point(0, 0);
            this.Security.Name = "Security";
            this.Security.Size = new System.Drawing.Size(420, 560);
            this.Security.TabIndex = 1;
            // 
            // delay
            // 
            this.delay.Interval = 500;
            // 
            // LoadingScreen
            // 
            this.LoadingScreen.BackColor = System.Drawing.Color.Firebrick;
            this.LoadingScreen.BackgroundImage = global::Encryptor_V00A2.Properties.Resources.Encryptor_a2;
            this.LoadingScreen.Controls.Add(this.button1);
            this.LoadingScreen.Controls.Add(this.pictureBox1);
            this.LoadingScreen.Location = new System.Drawing.Point(0, 0);
            this.LoadingScreen.Name = "LoadingScreen";
            this.LoadingScreen.Size = new System.Drawing.Size(420, 560);
            this.LoadingScreen.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Encryptor_V00A2.Properties.Resources.readyButton1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(172, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 72);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_hover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Encryptor_V00A2.Properties.Resources.Encryptor_a2;
            this.pictureBox1.Image = global::Encryptor_V00A2.Properties.Resources.Encryptor_a2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 560);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Encryptor_V00A2.Properties.Resources.buttonCLick;
            this.pictureBox2.Image = global::Encryptor_V00A2.Properties.Resources.login;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(420, 560);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 560);
            this.Controls.Add(this.Home);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Home.ResumeLayout(false);
            this.Security.ResumeLayout(false);
            this.LoadingScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Home;
        private System.Windows.Forms.Panel Security;
        private System.Windows.Forms.Panel LoadingScreen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer delay;
    }
}

