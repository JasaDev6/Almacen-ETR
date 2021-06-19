
namespace Almacen_ETR
{
    partial class OutputForm
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
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.textBoxTDestino = new System.Windows.Forms.TextBox();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LabelDateOutput = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LabelULab = new System.Windows.Forms.Label();
            this.LabelBDI = new System.Windows.Forms.Label();
            this.LabelNserie = new System.Windows.Forms.Label();
            this.LabelModelo = new System.Windows.Forms.Label();
            this.LabelMarca = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmDeparture = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Location = new System.Drawing.Point(222, 64);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(234, 22);
            this.textBoxDestino.TabIndex = 0;
            // 
            // textBoxTDestino
            // 
            this.textBoxTDestino.Location = new System.Drawing.Point(222, 119);
            this.textBoxTDestino.Name = "textBoxTDestino";
            this.textBoxTDestino.Size = new System.Drawing.Size(234, 22);
            this.textBoxTDestino.TabIndex = 1;
            // 
            // textBoxObs
            // 
            this.textBoxObs.Location = new System.Drawing.Point(222, 257);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(234, 75);
            this.textBoxObs.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Destino (*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tablero de destino (*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de Salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Observaciones";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.LabelDateOutput);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxDestino);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxTDestino);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxObs);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(618, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 385);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SALIDA DEL EQUIPO";
            // 
            // LabelDateOutput
            // 
            this.LabelDateOutput.AutoSize = true;
            this.LabelDateOutput.Location = new System.Drawing.Point(310, 192);
            this.LabelDateOutput.Name = "LabelDateOutput";
            this.LabelDateOutput.Size = new System.Drawing.Size(0, 16);
            this.LabelDateOutput.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.LabelULab);
            this.groupBox1.Controls.Add(this.LabelBDI);
            this.groupBox1.Controls.Add(this.LabelNserie);
            this.groupBox1.Controls.Add(this.LabelModelo);
            this.groupBox1.Controls.Add(this.LabelMarca);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(59, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 385);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION DEL EQUIPO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "ULab";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "BDI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "NSerie";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Modelo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Marca";
            // 
            // LabelULab
            // 
            this.LabelULab.AutoSize = true;
            this.LabelULab.Location = new System.Drawing.Point(265, 322);
            this.LabelULab.Name = "LabelULab";
            this.LabelULab.Size = new System.Drawing.Size(45, 16);
            this.LabelULab.TabIndex = 5;
            this.LabelULab.Text = "ULab";
            // 
            // LabelBDI
            // 
            this.LabelBDI.AutoSize = true;
            this.LabelBDI.Location = new System.Drawing.Point(265, 260);
            this.LabelBDI.Name = "LabelBDI";
            this.LabelBDI.Size = new System.Drawing.Size(33, 16);
            this.LabelBDI.TabIndex = 4;
            this.LabelBDI.Text = "BDI";
            // 
            // LabelNserie
            // 
            this.LabelNserie.AutoSize = true;
            this.LabelNserie.Location = new System.Drawing.Point(265, 191);
            this.LabelNserie.Name = "LabelNserie";
            this.LabelNserie.Size = new System.Drawing.Size(56, 16);
            this.LabelNserie.TabIndex = 3;
            this.LabelNserie.Text = "NSerie";
            // 
            // LabelModelo
            // 
            this.LabelModelo.AutoSize = true;
            this.LabelModelo.Location = new System.Drawing.Point(265, 125);
            this.LabelModelo.Name = "LabelModelo";
            this.LabelModelo.Size = new System.Drawing.Size(60, 16);
            this.LabelModelo.TabIndex = 1;
            this.LabelModelo.Text = "Modelo";
            // 
            // LabelMarca
            // 
            this.LabelMarca.AutoSize = true;
            this.LabelMarca.Location = new System.Drawing.Point(265, 70);
            this.LabelMarca.Name = "LabelMarca";
            this.LabelMarca.Size = new System.Drawing.Size(51, 16);
            this.LabelMarca.TabIndex = 0;
            this.LabelMarca.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "REGISTRO DE SALIDA EQUIPO";
            // 
            // btnConfirmDeparture
            // 
            this.btnConfirmDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmDeparture.Location = new System.Drawing.Point(59, 500);
            this.btnConfirmDeparture.Name = "btnConfirmDeparture";
            this.btnConfirmDeparture.Size = new System.Drawing.Size(171, 43);
            this.btnConfirmDeparture.TabIndex = 12;
            this.btnConfirmDeparture.Text = "Confirmar salida";
            this.btnConfirmDeparture.UseVisualStyleBackColor = true;
            this.btnConfirmDeparture.Click += new System.EventHandler(this.btnConfirmDeparture_Click);
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1191, 570);
            this.Controls.Add(this.btnConfirmDeparture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OutputForm";
            this.Text = "Salida de almacen";
            this.Load += new System.EventHandler(this.OutputForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.TextBox textBoxTDestino;
        private System.Windows.Forms.TextBox textBoxObs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmDeparture;
        private System.Windows.Forms.Label LabelULab;
        private System.Windows.Forms.Label LabelBDI;
        private System.Windows.Forms.Label LabelNserie;
        private System.Windows.Forms.Label LabelModelo;
        private System.Windows.Forms.Label LabelMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LabelDateOutput;
    }
}