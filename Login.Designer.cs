
namespace Food_Mannager
{
    partial class Login
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
            this.MENU_SUPERIOR_LOGIN = new System.Windows.Forms.Panel();
            this.BT_MINIMIZED = new System.Windows.Forms.PictureBox();
            this.BTN_CLOSE = new System.Windows.Forms.PictureBox();
            this.TITTLE_LOGIN = new System.Windows.Forms.Label();
            this.LABEL_EMAIL_LOGIN = new System.Windows.Forms.Label();
            this.TXT_EMAIL_LOGIN = new System.Windows.Forms.TextBox();
            this.TXT_SENHA_LOGIN = new System.Windows.Forms.TextBox();
            this.LABEL_SENHA_LOGIN = new System.Windows.Forms.Label();
            this.TXT_CODE_LOGIN = new System.Windows.Forms.TextBox();
            this.LABEL_CODE_LOGIN = new System.Windows.Forms.Label();
            this.BTN_LOGIN = new System.Windows.Forms.Button();
            this.LABEL_AGUARDE_LOGIN = new System.Windows.Forms.Label();
            this.BTN_RESGISTRAR = new System.Windows.Forms.Button();
            this.IMG_PROCESSING = new System.Windows.Forms.PictureBox();
            this.MENU_SUPERIOR_LOGIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BT_MINIMIZED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CLOSE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_PROCESSING)).BeginInit();
            this.SuspendLayout();
            // 
            // MENU_SUPERIOR_LOGIN
            // 
            this.MENU_SUPERIOR_LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.MENU_SUPERIOR_LOGIN.Controls.Add(this.BT_MINIMIZED);
            this.MENU_SUPERIOR_LOGIN.Controls.Add(this.BTN_CLOSE);
            this.MENU_SUPERIOR_LOGIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.MENU_SUPERIOR_LOGIN.Location = new System.Drawing.Point(0, 0);
            this.MENU_SUPERIOR_LOGIN.Name = "MENU_SUPERIOR_LOGIN";
            this.MENU_SUPERIOR_LOGIN.Size = new System.Drawing.Size(743, 55);
            this.MENU_SUPERIOR_LOGIN.TabIndex = 1;
            this.MENU_SUPERIOR_LOGIN.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MENU_SUPERIOR_LOGIN_MouseDown);
            // 
            // BT_MINIMIZED
            // 
            this.BT_MINIMIZED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_MINIMIZED.Image = global::Food_Mannager.Properties.Resources.minimizar;
            this.BT_MINIMIZED.Location = new System.Drawing.Point(654, 12);
            this.BT_MINIMIZED.Name = "BT_MINIMIZED";
            this.BT_MINIMIZED.Size = new System.Drawing.Size(25, 25);
            this.BT_MINIMIZED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BT_MINIMIZED.TabIndex = 2;
            this.BT_MINIMIZED.TabStop = false;
            this.BT_MINIMIZED.Click += new System.EventHandler(this.BT_MINIMIZED_Click);
            // 
            // BTN_CLOSE
            // 
            this.BTN_CLOSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CLOSE.Image = global::Food_Mannager.Properties.Resources.error;
            this.BTN_CLOSE.Location = new System.Drawing.Point(685, 12);
            this.BTN_CLOSE.Name = "BTN_CLOSE";
            this.BTN_CLOSE.Size = new System.Drawing.Size(25, 25);
            this.BTN_CLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTN_CLOSE.TabIndex = 1;
            this.BTN_CLOSE.TabStop = false;
            this.BTN_CLOSE.Click += new System.EventHandler(this.BTN_CLOSE_Click);
            // 
            // TITTLE_LOGIN
            // 
            this.TITTLE_LOGIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.TITTLE_LOGIN.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITTLE_LOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.TITTLE_LOGIN.Location = new System.Drawing.Point(0, 55);
            this.TITTLE_LOGIN.Name = "TITTLE_LOGIN";
            this.TITTLE_LOGIN.Size = new System.Drawing.Size(743, 83);
            this.TITTLE_LOGIN.TabIndex = 2;
            this.TITTLE_LOGIN.Text = "LOGIN";
            this.TITTLE_LOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LABEL_EMAIL_LOGIN
            // 
            this.LABEL_EMAIL_LOGIN.AutoSize = true;
            this.LABEL_EMAIL_LOGIN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_EMAIL_LOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.LABEL_EMAIL_LOGIN.Location = new System.Drawing.Point(159, 165);
            this.LABEL_EMAIL_LOGIN.Name = "LABEL_EMAIL_LOGIN";
            this.LABEL_EMAIL_LOGIN.Size = new System.Drawing.Size(67, 23);
            this.LABEL_EMAIL_LOGIN.TabIndex = 4;
            this.LABEL_EMAIL_LOGIN.Text = "Email:";
            // 
            // TXT_EMAIL_LOGIN
            // 
            this.TXT_EMAIL_LOGIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_EMAIL_LOGIN.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TXT_EMAIL_LOGIN.Location = new System.Drawing.Point(163, 192);
            this.TXT_EMAIL_LOGIN.Name = "TXT_EMAIL_LOGIN";
            this.TXT_EMAIL_LOGIN.Size = new System.Drawing.Size(403, 32);
            this.TXT_EMAIL_LOGIN.TabIndex = 5;
            this.TXT_EMAIL_LOGIN.TextChanged += new System.EventHandler(this.TXT_EMAIL_LOGIN_TextChanged);
            // 
            // TXT_SENHA_LOGIN
            // 
            this.TXT_SENHA_LOGIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_SENHA_LOGIN.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TXT_SENHA_LOGIN.Location = new System.Drawing.Point(163, 267);
            this.TXT_SENHA_LOGIN.Name = "TXT_SENHA_LOGIN";
            this.TXT_SENHA_LOGIN.Size = new System.Drawing.Size(403, 32);
            this.TXT_SENHA_LOGIN.TabIndex = 7;
            this.TXT_SENHA_LOGIN.TextChanged += new System.EventHandler(this.TXT_SENHA_LOGIN_TextChanged);
            // 
            // LABEL_SENHA_LOGIN
            // 
            this.LABEL_SENHA_LOGIN.AutoSize = true;
            this.LABEL_SENHA_LOGIN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_SENHA_LOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.LABEL_SENHA_LOGIN.Location = new System.Drawing.Point(159, 240);
            this.LABEL_SENHA_LOGIN.Name = "LABEL_SENHA_LOGIN";
            this.LABEL_SENHA_LOGIN.Size = new System.Drawing.Size(76, 23);
            this.LABEL_SENHA_LOGIN.TabIndex = 6;
            this.LABEL_SENHA_LOGIN.Text = "Senha:";
            // 
            // TXT_CODE_LOGIN
            // 
            this.TXT_CODE_LOGIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_CODE_LOGIN.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TXT_CODE_LOGIN.Location = new System.Drawing.Point(163, 345);
            this.TXT_CODE_LOGIN.Name = "TXT_CODE_LOGIN";
            this.TXT_CODE_LOGIN.Size = new System.Drawing.Size(403, 32);
            this.TXT_CODE_LOGIN.TabIndex = 9;
            this.TXT_CODE_LOGIN.Visible = false;
            // 
            // LABEL_CODE_LOGIN
            // 
            this.LABEL_CODE_LOGIN.AutoSize = true;
            this.LABEL_CODE_LOGIN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_CODE_LOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.LABEL_CODE_LOGIN.Location = new System.Drawing.Point(159, 318);
            this.LABEL_CODE_LOGIN.Name = "LABEL_CODE_LOGIN";
            this.LABEL_CODE_LOGIN.Size = new System.Drawing.Size(77, 23);
            this.LABEL_CODE_LOGIN.TabIndex = 8;
            this.LABEL_CODE_LOGIN.Text = "Code: ";
            this.LABEL_CODE_LOGIN.Visible = false;
            // 
            // BTN_LOGIN
            // 
            this.BTN_LOGIN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_LOGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.BTN_LOGIN.FlatAppearance.BorderSize = 0;
            this.BTN_LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_LOGIN.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BTN_LOGIN.ForeColor = System.Drawing.Color.White;
            this.BTN_LOGIN.Location = new System.Drawing.Point(384, 443);
            this.BTN_LOGIN.Name = "BTN_LOGIN";
            this.BTN_LOGIN.Size = new System.Drawing.Size(127, 41);
            this.BTN_LOGIN.TabIndex = 10;
            this.BTN_LOGIN.Text = "Entrar";
            this.BTN_LOGIN.UseVisualStyleBackColor = false;
            this.BTN_LOGIN.Click += new System.EventHandler(this.BTN_LOGIN_Click);
            // 
            // LABEL_AGUARDE_LOGIN
            // 
            this.LABEL_AGUARDE_LOGIN.AutoSize = true;
            this.LABEL_AGUARDE_LOGIN.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_AGUARDE_LOGIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.LABEL_AGUARDE_LOGIN.Location = new System.Drawing.Point(288, 369);
            this.LABEL_AGUARDE_LOGIN.Name = "LABEL_AGUARDE_LOGIN";
            this.LABEL_AGUARDE_LOGIN.Size = new System.Drawing.Size(157, 34);
            this.LABEL_AGUARDE_LOGIN.TabIndex = 11;
            this.LABEL_AGUARDE_LOGIN.Text = "Aguarde...";
            this.LABEL_AGUARDE_LOGIN.Visible = false;
            // 
            // BTN_RESGISTRAR
            // 
            this.BTN_RESGISTRAR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BTN_RESGISTRAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.BTN_RESGISTRAR.FlatAppearance.BorderSize = 0;
            this.BTN_RESGISTRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_RESGISTRAR.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BTN_RESGISTRAR.ForeColor = System.Drawing.Color.White;
            this.BTN_RESGISTRAR.Location = new System.Drawing.Point(219, 443);
            this.BTN_RESGISTRAR.Name = "BTN_RESGISTRAR";
            this.BTN_RESGISTRAR.Size = new System.Drawing.Size(127, 41);
            this.BTN_RESGISTRAR.TabIndex = 12;
            this.BTN_RESGISTRAR.Text = "Registrar";
            this.BTN_RESGISTRAR.UseVisualStyleBackColor = false;
            this.BTN_RESGISTRAR.Click += new System.EventHandler(this.BTN_RESGISTRAR_Click);
            // 
            // IMG_PROCESSING
            // 
            this.IMG_PROCESSING.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IMG_PROCESSING.Image = global::Food_Mannager.Properties.Resources.ajax_loader;
            this.IMG_PROCESSING.Location = new System.Drawing.Point(267, 174);
            this.IMG_PROCESSING.Name = "IMG_PROCESSING";
            this.IMG_PROCESSING.Size = new System.Drawing.Size(198, 165);
            this.IMG_PROCESSING.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IMG_PROCESSING.TabIndex = 3;
            this.IMG_PROCESSING.TabStop = false;
            this.IMG_PROCESSING.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(743, 525);
            this.Controls.Add(this.BTN_RESGISTRAR);
            this.Controls.Add(this.LABEL_AGUARDE_LOGIN);
            this.Controls.Add(this.IMG_PROCESSING);
            this.Controls.Add(this.BTN_LOGIN);
            this.Controls.Add(this.TXT_CODE_LOGIN);
            this.Controls.Add(this.LABEL_CODE_LOGIN);
            this.Controls.Add(this.TXT_SENHA_LOGIN);
            this.Controls.Add(this.LABEL_SENHA_LOGIN);
            this.Controls.Add(this.TXT_EMAIL_LOGIN);
            this.Controls.Add(this.LABEL_EMAIL_LOGIN);
            this.Controls.Add(this.TITTLE_LOGIN);
            this.Controls.Add(this.MENU_SUPERIOR_LOGIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.MENU_SUPERIOR_LOGIN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BT_MINIMIZED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CLOSE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_PROCESSING)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel MENU_SUPERIOR_LOGIN;
        private System.Windows.Forms.PictureBox BTN_CLOSE;
        private System.Windows.Forms.PictureBox BT_MINIMIZED;
        private System.Windows.Forms.Label TITTLE_LOGIN;
        private System.Windows.Forms.PictureBox IMG_PROCESSING;
        private System.Windows.Forms.Label LABEL_EMAIL_LOGIN;
        private System.Windows.Forms.TextBox TXT_EMAIL_LOGIN;
        private System.Windows.Forms.TextBox TXT_SENHA_LOGIN;
        private System.Windows.Forms.Label LABEL_SENHA_LOGIN;
        private System.Windows.Forms.TextBox TXT_CODE_LOGIN;
        private System.Windows.Forms.Label LABEL_CODE_LOGIN;
        private System.Windows.Forms.Button BTN_LOGIN;
        private System.Windows.Forms.Label LABEL_AGUARDE_LOGIN;
        private System.Windows.Forms.Button BTN_RESGISTRAR;
    }
}