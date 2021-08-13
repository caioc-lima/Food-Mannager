
namespace Food_Mannager
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MENU_LATERAL = new System.Windows.Forms.Panel();
            this.MENU_SUPERIOR = new System.Windows.Forms.Panel();
            this.BTN_MINIMIZED = new System.Windows.Forms.PictureBox();
            this.BTN_SLIDE = new System.Windows.Forms.PictureBox();
            this.BTN_CLOSE = new System.Windows.Forms.PictureBox();
            this.PANEL_CONTENT = new System.Windows.Forms.Panel();
            this.MENU_SUPERIOR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_MINIMIZED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_SLIDE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CLOSE)).BeginInit();
            this.SuspendLayout();
            // 
            // MENU_LATERAL
            // 
            this.MENU_LATERAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(70)))), ((int)(((byte)(90)))));
            this.MENU_LATERAL.Dock = System.Windows.Forms.DockStyle.Left;
            this.MENU_LATERAL.Location = new System.Drawing.Point(0, 0);
            this.MENU_LATERAL.Name = "MENU_LATERAL";
            this.MENU_LATERAL.Size = new System.Drawing.Size(250, 599);
            this.MENU_LATERAL.TabIndex = 0;
            // 
            // MENU_SUPERIOR
            // 
            this.MENU_SUPERIOR.Controls.Add(this.BTN_MINIMIZED);
            this.MENU_SUPERIOR.Controls.Add(this.BTN_SLIDE);
            this.MENU_SUPERIOR.Controls.Add(this.BTN_CLOSE);
            this.MENU_SUPERIOR.Dock = System.Windows.Forms.DockStyle.Top;
            this.MENU_SUPERIOR.Location = new System.Drawing.Point(250, 0);
            this.MENU_SUPERIOR.Name = "MENU_SUPERIOR";
            this.MENU_SUPERIOR.Size = new System.Drawing.Size(964, 55);
            this.MENU_SUPERIOR.TabIndex = 1;
            this.MENU_SUPERIOR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MENU_SUPERIOR_MouseDown);
            // 
            // BTN_MINIMIZED
            // 
            this.BTN_MINIMIZED.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_MINIMIZED.Image = global::Food_Mannager.Properties.Resources.minimizar__1_;
            this.BTN_MINIMIZED.Location = new System.Drawing.Point(896, 12);
            this.BTN_MINIMIZED.Name = "BTN_MINIMIZED";
            this.BTN_MINIMIZED.Size = new System.Drawing.Size(25, 25);
            this.BTN_MINIMIZED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTN_MINIMIZED.TabIndex = 2;
            this.BTN_MINIMIZED.TabStop = false;
            this.BTN_MINIMIZED.Click += new System.EventHandler(this.BTN_MINIMIZED_Click);
            // 
            // BTN_SLIDE
            // 
            this.BTN_SLIDE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SLIDE.Image = global::Food_Mannager.Properties.Resources.botao_de_menu_de_tres_linhas_horizontais;
            this.BTN_SLIDE.Location = new System.Drawing.Point(6, 7);
            this.BTN_SLIDE.Name = "BTN_SLIDE";
            this.BTN_SLIDE.Size = new System.Drawing.Size(40, 40);
            this.BTN_SLIDE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTN_SLIDE.TabIndex = 1;
            this.BTN_SLIDE.TabStop = false;
            this.BTN_SLIDE.Click += new System.EventHandler(this.BTN_SLIDE_Click);
            // 
            // BTN_CLOSE
            // 
            this.BTN_CLOSE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CLOSE.Image = global::Food_Mannager.Properties.Resources.error__1_;
            this.BTN_CLOSE.Location = new System.Drawing.Point(927, 12);
            this.BTN_CLOSE.Name = "BTN_CLOSE";
            this.BTN_CLOSE.Size = new System.Drawing.Size(25, 25);
            this.BTN_CLOSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BTN_CLOSE.TabIndex = 0;
            this.BTN_CLOSE.TabStop = false;
            this.BTN_CLOSE.Click += new System.EventHandler(this.BTN_CLOSE_Click);
            // 
            // PANEL_CONTENT
            // 
            this.PANEL_CONTENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PANEL_CONTENT.Location = new System.Drawing.Point(250, 55);
            this.PANEL_CONTENT.Name = "PANEL_CONTENT";
            this.PANEL_CONTENT.Size = new System.Drawing.Size(964, 544);
            this.PANEL_CONTENT.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1214, 599);
            this.Controls.Add(this.PANEL_CONTENT);
            this.Controls.Add(this.MENU_SUPERIOR);
            this.Controls.Add(this.MENU_LATERAL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MENU_SUPERIOR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BTN_MINIMIZED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_SLIDE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_CLOSE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MENU_LATERAL;
        private System.Windows.Forms.Panel MENU_SUPERIOR;
        private System.Windows.Forms.PictureBox BTN_CLOSE;
        private System.Windows.Forms.PictureBox BTN_SLIDE;
        private System.Windows.Forms.Panel PANEL_CONTENT;
        private System.Windows.Forms.PictureBox BTN_MINIMIZED;
    }
}

