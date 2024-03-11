namespace UIGestaoAcademia
{
    partial class FormQrCode
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
            components = new System.ComponentModel.Container();
            pictureBoxQrCode = new PictureBox();
            vendaBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxQrCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxQrCode
            // 
            pictureBoxQrCode.Dock = DockStyle.Fill;
            pictureBoxQrCode.Location = new Point(0, 0);
            pictureBoxQrCode.Name = "pictureBoxQrCode";
            pictureBoxQrCode.Size = new Size(933, 919);
            pictureBoxQrCode.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxQrCode.TabIndex = 1;
            pictureBoxQrCode.TabStop = false;
            // 
            // vendaBindingSource
            // 
            vendaBindingSource.DataSource = typeof(Models.Venda);
            // 
            // FormQrCode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 919);
            Controls.Add(pictureBoxQrCode);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormQrCode";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormQrCode_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxQrCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxQrCode;
        private BindingSource vendaBindingSource;
    }
}