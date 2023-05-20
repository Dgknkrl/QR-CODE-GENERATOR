namespace QR_CODE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pctrQR = new PictureBox();
            txtQR = new TextBox();
            btnQR = new Button();
            ((System.ComponentModel.ISupportInitialize)pctrQR).BeginInit();
            SuspendLayout();
            // 
            // pctrQR
            // 
            pctrQR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pctrQR.BackColor = Color.Transparent;
            pctrQR.BackgroundImageLayout = ImageLayout.None;
            pctrQR.Location = new Point(70, 35);
            pctrQR.Name = "pctrQR";
            pctrQR.Size = new Size(306, 306);
            pctrQR.SizeMode = PictureBoxSizeMode.Zoom;
            pctrQR.TabIndex = 0;
            pctrQR.TabStop = false;
            // 
            // txtQR
            // 
            txtQR.Anchor = AnchorStyles.None;
            txtQR.Font = new Font("Dosis", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtQR.Location = new Point(434, 153);
            txtQR.Margin = new Padding(0);
            txtQR.MaxLength = 260;
            txtQR.Name = "txtQR";
            txtQR.PlaceholderText = "enter a text";
            txtQR.Size = new Size(258, 28);
            txtQR.TabIndex = 1;
            txtQR.TextAlign = HorizontalAlignment.Center;
            // 
            // btnQR
            // 
            btnQR.Anchor = AnchorStyles.None;
            btnQR.BackColor = Color.Transparent;
            btnQR.BackgroundImageLayout = ImageLayout.None;
            btnQR.FlatAppearance.BorderColor = Color.PaleGreen;
            btnQR.FlatStyle = FlatStyle.Flat;
            btnQR.Font = new Font("Dosis", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnQR.Location = new Point(698, 149);
            btnQR.MaximumSize = new Size(97, 36);
            btnQR.MinimumSize = new Size(97, 36);
            btnQR.Name = "btnQR";
            btnQR.Size = new Size(97, 36);
            btnQR.TabIndex = 3;
            btnQR.Text = "CREATE";
            btnQR.UseVisualStyleBackColor = false;
            btnQR.Click += btnQR_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backgorund2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQR);
            Controls.Add(txtQR);
            Controls.Add(pctrQR);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "QR CODE GENERATOR";
            ((System.ComponentModel.ISupportInitialize)pctrQR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctrQR;
        private TextBox txtQR;
        private Button btnQR;
    }
}