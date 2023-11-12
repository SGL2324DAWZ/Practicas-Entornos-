namespace prueba1SGL
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
            txtPrecio = new TextBox();
            txtTelegrama = new TextBox();
            label2 = new Label();
            bCalcular = new Button();
            label1 = new Label();
            rbOrdinario = new RadioButton();
            rbUrgente = new RadioButton();
            SuspendLayout();
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(246, 351);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(331, 27);
            txtPrecio.TabIndex = 11;
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(175, 108);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(443, 100);
            txtTelegrama.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 354);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 9;
            label2.Text = "Coste:";
            // 
            // bCalcular
            // 
            bCalcular.Location = new Point(561, 249);
            bCalcular.Name = "bCalcular";
            bCalcular.Size = new Size(159, 57);
            bCalcular.TabIndex = 8;
            bCalcular.Text = "Calcular";
            bCalcular.UseVisualStyleBackColor = true;
            bCalcular.Click += bCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 73);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 6;
            label1.Text = "Texto:";
            // 
            // rbOrdinario
            // 
            rbOrdinario.AutoSize = true;
            rbOrdinario.Location = new Point(175, 265);
            rbOrdinario.Name = "rbOrdinario";
            rbOrdinario.Size = new Size(93, 24);
            rbOrdinario.TabIndex = 12;
            rbOrdinario.TabStop = true;
            rbOrdinario.Text = "Ordinario";
            rbOrdinario.UseVisualStyleBackColor = true;
            // 
            // rbUrgente
            // 
            rbUrgente.AutoSize = true;
            rbUrgente.Location = new Point(274, 265);
            rbUrgente.Name = "rbUrgente";
            rbUrgente.Size = new Size(83, 24);
            rbUrgente.TabIndex = 13;
            rbUrgente.TabStop = true;
            rbUrgente.Text = "Urgente";
            rbUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbUrgente);
            Controls.Add(rbOrdinario);
            Controls.Add(txtPrecio);
            Controls.Add(txtTelegrama);
            Controls.Add(label2);
            Controls.Add(bCalcular);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrecio;
        private TextBox txtTelegrama;
        private Label label2;
        private Button bCalcular;
        private Label label1;
        private RadioButton rbOrdinario;
        private RadioButton rbUrgente;
    }
}