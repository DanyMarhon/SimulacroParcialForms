namespace SimulacroParcialForms
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textGeneratriz = new TextBox();
            textAltura = new TextBox();
            textRadio = new TextBox();
            textResultadoArea = new TextBox();
            textResultadoVolumen = new TextBox();
            BtnCalcular = new Button();
            BtnLimpiar = new Button();
            BtnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 39);
            label1.Name = "label1";
            label1.Size = new Size(200, 17);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el valor de la Generatríz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 85);
            label2.Name = "label2";
            label2.Size = new Size(175, 17);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el valor de la Altura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 134);
            label3.Name = "label3";
            label3.Size = new Size(161, 17);
            label3.TabIndex = 2;
            label3.Text = "Ingrese el valor del Radio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(21, 279);
            label4.Name = "label4";
            label4.Size = new Size(128, 17);
            label4.TabIndex = 3;
            label4.Text = "El área del cono es :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(21, 323);
            label5.Name = "label5";
            label5.Size = new Size(155, 17);
            label5.TabIndex = 4;
            label5.Text = "El volumen del cono es :";
            // 
            // textGeneratriz
            // 
            textGeneratriz.Location = new Point(256, 37);
            textGeneratriz.Name = "textGeneratriz";
            textGeneratriz.PlaceholderText = "Valor G";
            textGeneratriz.Size = new Size(213, 25);
            textGeneratriz.TabIndex = 5;
            textGeneratriz.TextChanged += GeneratrizTextChanged;
            // 
            // textAltura
            // 
            textAltura.Location = new Point(256, 84);
            textAltura.Name = "textAltura";
            textAltura.PlaceholderText = "Valor H";
            textAltura.Size = new Size(213, 25);
            textAltura.TabIndex = 6;
            textAltura.TextChanged += AlturaTextChanged;
            // 
            // textRadio
            // 
            textRadio.Location = new Point(256, 133);
            textRadio.Name = "textRadio";
            textRadio.PlaceholderText = "Valor R";
            textRadio.Size = new Size(213, 25);
            textRadio.TabIndex = 7;
            textRadio.TextChanged += RadioTextChanged;
            // 
            // textResultadoArea
            // 
            textResultadoArea.Location = new Point(214, 278);
            textResultadoArea.Name = "textResultadoArea";
            textResultadoArea.ReadOnly = true;
            textResultadoArea.Size = new Size(191, 25);
            textResultadoArea.TabIndex = 8;
            textResultadoArea.TextAlign = HorizontalAlignment.Right;
            textResultadoArea.TextChanged += ResultadoAreaText;
            // 
            // textResultadoVolumen
            // 
            textResultadoVolumen.Location = new Point(214, 322);
            textResultadoVolumen.Name = "textResultadoVolumen";
            textResultadoVolumen.ReadOnly = true;
            textResultadoVolumen.Size = new Size(191, 25);
            textResultadoVolumen.TabIndex = 9;
            textResultadoVolumen.TextAlign = HorizontalAlignment.Right;
            textResultadoVolumen.TextChanged += ResultadoVolumenText;
            // 
            // BtnCalcular
            // 
            BtnCalcular.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalcular.Image = (Image)resources.GetObject("BtnCalcular.Image");
            BtnCalcular.ImageAlign = ContentAlignment.TopCenter;
            BtnCalcular.Location = new Point(506, 24);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(133, 116);
            BtnCalcular.TabIndex = 10;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.TextAlign = ContentAlignment.BottomCenter;
            BtnCalcular.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // BtnLimpiar
            // 
            BtnLimpiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLimpiar.Image = (Image)resources.GetObject("BtnLimpiar.Image");
            BtnLimpiar.ImageAlign = ContentAlignment.TopCenter;
            BtnLimpiar.Location = new Point(506, 146);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new Size(133, 120);
            BtnLimpiar.TabIndex = 11;
            BtnLimpiar.Text = "Limpiar";
            BtnLimpiar.TextAlign = ContentAlignment.BottomCenter;
            BtnLimpiar.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnLimpiar.UseVisualStyleBackColor = true;
            BtnLimpiar.Click += BtnLimpiar_Click;
            // 
            // BtnSalir
            // 
            BtnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSalir.Image = (Image)resources.GetObject("BtnSalir.Image");
            BtnSalir.Location = new Point(506, 273);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(133, 118);
            BtnSalir.TabIndex = 12;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.BottomCenter;
            BtnSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(667, 418);
            Controls.Add(BtnSalir);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnCalcular);
            Controls.Add(textResultadoVolumen);
            Controls.Add(textResultadoArea);
            Controls.Add(textRadio);
            Controls.Add(textAltura);
            Controls.Add(textGeneratriz);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Calculador de área y volumen de conos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textGeneratriz;
        private TextBox textAltura;
        private TextBox textRadio;
        private TextBox textResultadoArea;
        private TextBox textResultadoVolumen;
        private Button BtnCalcular;
        private Button BtnLimpiar;
        private Button BtnSalir;
    }
}