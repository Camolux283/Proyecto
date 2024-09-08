using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
namespace CamarasYRespaldosPresentacion
{
    partial class FormCamarasYRespaldos
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
            tabCamarasYRespaldos = new TabControl();
            TabPageMostrarCamaras = new TabPage();
            PBCamaraSegundoPiso1 = new PictureBox();
            PBCamaraRampaSegundoPiso = new PictureBox();
            PBCamaraSegundoPiso2 = new PictureBox();
            PBCamaraPrimerPiso = new PictureBox();
            PBCamaraAfueraSalaDeMaquinas = new PictureBox();
            PBCamaraRampaPrimerPiso = new PictureBox();
            PBCamaraMotos = new PictureBox();
            PBCamaraDeposito = new PictureBox();
            PBCamaraTaller = new PictureBox();
            PBCamaraLavadero = new PictureBox();
            PBCamaraGerencia = new PictureBox();
            PBCamaraEntrada2 = new PictureBox();
            PBCamaraEntrada1 = new PictureBox();
            BTNRespaldo = new Button();
            TabPageMostrarCamara = new TabPage();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            tabCamarasYRespaldos.SuspendLayout();
            TabPageMostrarCamaras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PBCamaraSegundoPiso1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraRampaSegundoPiso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraSegundoPiso2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraPrimerPiso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraAfueraSalaDeMaquinas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraRampaPrimerPiso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraMotos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraDeposito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraTaller).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraLavadero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraGerencia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraEntrada2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraEntrada1).BeginInit();
            TabPageMostrarCamara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabCamarasYRespaldos
            // 
            tabCamarasYRespaldos.Controls.Add(TabPageMostrarCamaras);
            tabCamarasYRespaldos.Controls.Add(TabPageMostrarCamara);
            tabCamarasYRespaldos.Location = new Point(-5, 0);
            tabCamarasYRespaldos.Name = "tabCamarasYRespaldos";
            tabCamarasYRespaldos.SelectedIndex = 0;
            tabCamarasYRespaldos.Size = new Size(971, 635);
            tabCamarasYRespaldos.TabIndex = 0;
            // 
            // TabPageMostrarCamaras
            // 
            TabPageMostrarCamaras.BackColor = Color.Wheat;
            TabPageMostrarCamaras.Controls.Add(PBCamaraSegundoPiso1);
            TabPageMostrarCamaras.Controls.Add(PBCamaraRampaSegundoPiso);
            TabPageMostrarCamaras.Controls.Add(PBCamaraSegundoPiso2);
            TabPageMostrarCamaras.Controls.Add(PBCamaraPrimerPiso);
            TabPageMostrarCamaras.Controls.Add(PBCamaraAfueraSalaDeMaquinas);
            TabPageMostrarCamaras.Controls.Add(PBCamaraRampaPrimerPiso);
            TabPageMostrarCamaras.Controls.Add(PBCamaraMotos);
            TabPageMostrarCamaras.Controls.Add(PBCamaraDeposito);
            TabPageMostrarCamaras.Controls.Add(PBCamaraTaller);
            TabPageMostrarCamaras.Controls.Add(PBCamaraLavadero);
            TabPageMostrarCamaras.Controls.Add(PBCamaraGerencia);
            TabPageMostrarCamaras.Controls.Add(PBCamaraEntrada2);
            TabPageMostrarCamaras.Controls.Add(PBCamaraEntrada1);
            TabPageMostrarCamaras.Controls.Add(BTNRespaldo);
            TabPageMostrarCamaras.Location = new Point(4, 24);
            TabPageMostrarCamaras.Name = "TabPageMostrarCamaras";
            TabPageMostrarCamaras.Padding = new Padding(3);
            TabPageMostrarCamaras.Size = new Size(963, 607);
            TabPageMostrarCamaras.TabIndex = 0;
            TabPageMostrarCamaras.Text = "MostrarTodasLasCamaras";
            // 
            // PBCamaraSegundoPiso1
            // 
            PBCamaraSegundoPiso1.BackColor = Color.White;
            PBCamaraSegundoPiso1.Location = new Point(739, 250);
            PBCamaraSegundoPiso1.Name = "PBCamaraSegundoPiso1";
            PBCamaraSegundoPiso1.Size = new Size(215, 116);
            PBCamaraSegundoPiso1.TabIndex = 12;
            PBCamaraSegundoPiso1.TabStop = false;
            // 
            // PBCamaraRampaSegundoPiso
            // 
            PBCamaraRampaSegundoPiso.BackColor = Color.White;
            PBCamaraRampaSegundoPiso.Location = new Point(494, 250);
            PBCamaraRampaSegundoPiso.Name = "PBCamaraRampaSegundoPiso";
            PBCamaraRampaSegundoPiso.Size = new Size(215, 116);
            PBCamaraRampaSegundoPiso.TabIndex = 11;
            PBCamaraRampaSegundoPiso.TabStop = false;
            // 
            // PBCamaraSegundoPiso2
            // 
            PBCamaraSegundoPiso2.BackColor = Color.White;
            PBCamaraSegundoPiso2.Location = new Point(6, 372);
            PBCamaraSegundoPiso2.Name = "PBCamaraSegundoPiso2";
            PBCamaraSegundoPiso2.Size = new Size(215, 116);
            PBCamaraSegundoPiso2.TabIndex = 11;
            PBCamaraSegundoPiso2.TabStop = false;
            // 
            // PBCamaraPrimerPiso
            // 
            PBCamaraPrimerPiso.BackColor = Color.White;
            PBCamaraPrimerPiso.Location = new Point(250, 250);
            PBCamaraPrimerPiso.Name = "PBCamaraPrimerPiso";
            PBCamaraPrimerPiso.Size = new Size(215, 116);
            PBCamaraPrimerPiso.TabIndex = 10;
            PBCamaraPrimerPiso.TabStop = false;
            // 
            // PBCamaraAfueraSalaDeMaquinas
            // 
            PBCamaraAfueraSalaDeMaquinas.BackColor = Color.White;
            PBCamaraAfueraSalaDeMaquinas.Location = new Point(6, 250);
            PBCamaraAfueraSalaDeMaquinas.Name = "PBCamaraAfueraSalaDeMaquinas";
            PBCamaraAfueraSalaDeMaquinas.Size = new Size(215, 116);
            PBCamaraAfueraSalaDeMaquinas.TabIndex = 9;
            PBCamaraAfueraSalaDeMaquinas.TabStop = false;
            // 
            // PBCamaraRampaPrimerPiso
            // 
            PBCamaraRampaPrimerPiso.BackColor = Color.White;
            PBCamaraRampaPrimerPiso.Location = new Point(739, 128);
            PBCamaraRampaPrimerPiso.Name = "PBCamaraRampaPrimerPiso";
            PBCamaraRampaPrimerPiso.Size = new Size(215, 116);
            PBCamaraRampaPrimerPiso.TabIndex = 8;
            PBCamaraRampaPrimerPiso.TabStop = false;
            // 
            // PBCamaraMotos
            // 
            PBCamaraMotos.BackColor = Color.White;
            PBCamaraMotos.Location = new Point(494, 128);
            PBCamaraMotos.Name = "PBCamaraMotos";
            PBCamaraMotos.Size = new Size(215, 116);
            PBCamaraMotos.TabIndex = 7;
            PBCamaraMotos.TabStop = false;
            // 
            // PBCamaraDeposito
            // 
            PBCamaraDeposito.BackColor = Color.White;
            PBCamaraDeposito.Location = new Point(250, 128);
            PBCamaraDeposito.Name = "PBCamaraDeposito";
            PBCamaraDeposito.Size = new Size(215, 116);
            PBCamaraDeposito.TabIndex = 6;
            PBCamaraDeposito.TabStop = false;
            // 
            // PBCamaraTaller
            // 
            PBCamaraTaller.BackColor = Color.White;
            PBCamaraTaller.Location = new Point(6, 128);
            PBCamaraTaller.Name = "PBCamaraTaller";
            PBCamaraTaller.Size = new Size(215, 116);
            PBCamaraTaller.TabIndex = 5;
            PBCamaraTaller.TabStop = false;
            // 
            // PBCamaraLavadero
            // 
            PBCamaraLavadero.BackColor = Color.White;
            PBCamaraLavadero.Location = new Point(739, 6);
            PBCamaraLavadero.Name = "PBCamaraLavadero";
            PBCamaraLavadero.Size = new Size(215, 116);
            PBCamaraLavadero.TabIndex = 4;
            PBCamaraLavadero.TabStop = false;
            // 
            // PBCamaraGerencia
            // 
            PBCamaraGerencia.BackColor = Color.White;
            PBCamaraGerencia.Location = new Point(494, 6);
            PBCamaraGerencia.Name = "PBCamaraGerencia";
            PBCamaraGerencia.Size = new Size(215, 116);
            PBCamaraGerencia.TabIndex = 3;
            PBCamaraGerencia.TabStop = false;
            // 
            // PBCamaraEntrada2
            // 
            PBCamaraEntrada2.BackColor = Color.White;
            PBCamaraEntrada2.Location = new Point(250, 6);
            PBCamaraEntrada2.Name = "PBCamaraEntrada2";
            PBCamaraEntrada2.Size = new Size(215, 116);
            PBCamaraEntrada2.TabIndex = 2;
            PBCamaraEntrada2.TabStop = false;
            // 
            // PBCamaraEntrada1
            // 
            PBCamaraEntrada1.BackColor = Color.White;
            PBCamaraEntrada1.Location = new Point(6, 6);
            PBCamaraEntrada1.Name = "PBCamaraEntrada1";
            PBCamaraEntrada1.Size = new Size(215, 116);
            PBCamaraEntrada1.TabIndex = 1;
            PBCamaraEntrada1.TabStop = false;
            // 
            // BTNRespaldo
            // 
            BTNRespaldo.Location = new Point(832, 573);
            BTNRespaldo.Name = "BTNRespaldo";
            BTNRespaldo.Size = new Size(122, 23);
            BTNRespaldo.TabIndex = 0;
            BTNRespaldo.Text = "RealizarRespaldo";
            BTNRespaldo.UseVisualStyleBackColor = true;
            // 
            // TabPageMostrarCamara
            // 
            TabPageMostrarCamara.BackColor = Color.Wheat;
            TabPageMostrarCamara.Controls.Add(pictureBox1);
            TabPageMostrarCamara.Controls.Add(comboBox1);
            TabPageMostrarCamara.Location = new Point(4, 24);
            TabPageMostrarCamara.Name = "TabPageMostrarCamara";
            TabPageMostrarCamara.Padding = new Padding(3);
            TabPageMostrarCamara.Size = new Size(963, 607);
            TabPageMostrarCamara.TabIndex = 1;
            TabPageMostrarCamara.Text = "MostrarCamaraPorCamara";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(134, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(653, 356);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(269, 18);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(337, 23);
            comboBox1.TabIndex = 0;
            // 
            // FormCamarasYRespaldos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(965, 632);
            Controls.Add(tabCamarasYRespaldos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormCamarasYRespaldos";
            Text = "Camaras y Respaldos";
            tabCamarasYRespaldos.ResumeLayout(false);
            TabPageMostrarCamaras.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PBCamaraSegundoPiso1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraRampaSegundoPiso).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraSegundoPiso2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraPrimerPiso).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraAfueraSalaDeMaquinas).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraRampaPrimerPiso).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraMotos).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraDeposito).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraTaller).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraLavadero).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraGerencia).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraEntrada2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PBCamaraEntrada1).EndInit();
            TabPageMostrarCamara.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabCamarasYRespaldos;
        private TabPage TabPageMostrarCamaras;
        private TabPage TabPageMostrarCamara;
        private Button BTNRespaldo;
        private PictureBox PBCamaraSegundoPiso1;
        private PictureBox PBCamaraRampaSegundoPiso;
        private PictureBox PBCamaraSegundoPiso2;
        private PictureBox PBCamaraPrimerPiso;
        private PictureBox PBCamaraAfueraSalaDeMaquinas;
        private PictureBox PBCamaraRampaPrimerPiso;
        private PictureBox PBCamaraMotos;
        private PictureBox PBCamaraDeposito;
        private PictureBox PBCamaraTaller;
        private PictureBox PBCamaraLavadero;
        private PictureBox PBCamaraGerencia;
        private PictureBox PBCamaraEntrada2;
        private PictureBox PBCamaraEntrada1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
    }
}
