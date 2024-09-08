namespace LoginPresentacion
{
    partial class FormLogin
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
            LBNombreUsu = new Label();
            LBPass = new Label();
            TBNomUsu = new TextBox();
            TBPass = new TextBox();
            BTNLimpiar = new Button();
            BTNConfirmar = new Button();
            SuspendLayout();
            // 
            // LBNombreUsu
            // 
            LBNombreUsu.AutoSize = true;
            LBNombreUsu.Location = new Point(191, 100);
            LBNombreUsu.Name = "LBNombreUsu";
            LBNombreUsu.Size = new Size(94, 15);
            LBNombreUsu.TabIndex = 0;
            LBNombreUsu.Text = "Nombre Usuario";
            
            // 
            // LBPass
            // 
            LBPass.AutoSize = true;
            LBPass.Location = new Point(204, 229);
            LBPass.Name = "LBPass";
            LBPass.Size = new Size(69, 15);
            LBPass.TabIndex = 1;
            LBPass.Text = "Conteaseña";
            // 
            // TBNomUsu
            // 
            TBNomUsu.Location = new Point(169, 149);
            TBNomUsu.Name = "TBNomUsu";
            TBNomUsu.Size = new Size(139, 23);
            TBNomUsu.TabIndex = 2;
            // 
            // TBPass
            // 
            TBPass.Location = new Point(169, 282);
            TBPass.Name = "TBPass";
            TBPass.PasswordChar = '*';
            TBPass.Size = new Size(139, 23);
            TBPass.TabIndex = 3;
            // 
            // BTNLimpiar
            // 
            BTNLimpiar.Location = new Point(141, 388);
            BTNLimpiar.Name = "BTNLimpiar";
            BTNLimpiar.Size = new Size(75, 23);
            BTNLimpiar.TabIndex = 4;
            BTNLimpiar.Text = "Limpiar";
            BTNLimpiar.UseVisualStyleBackColor = true;
            // 
            // BTNConfirmar
            // 
            BTNConfirmar.Location = new Point(269, 388);
            BTNConfirmar.Name = "BTNConfirmar";
            BTNConfirmar.Size = new Size(75, 23);
            BTNConfirmar.TabIndex = 5;
            BTNConfirmar.Text = "Confirmar";
            BTNConfirmar.UseVisualStyleBackColor = true;
            BTNConfirmar.Click += BTNConfirmar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(498, 620);
            Controls.Add(BTNConfirmar);
            Controls.Add(BTNLimpiar);
            Controls.Add(TBPass);
            Controls.Add(TBNomUsu);
            Controls.Add(LBPass);
            Controls.Add(LBNombreUsu);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBNombreUsu;
        private Label LBPass;
        private TextBox TBNomUsu;
        private TextBox TBPass;
        private Button BTNLimpiar;
        private Button BTNConfirmar;
    }
}
