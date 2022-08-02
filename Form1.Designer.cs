namespace Conversor_de_Temperatura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCelsius = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFarenheit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKelvin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor Temperaturas    ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite o valor em Graus Celsius.";
            // 
            // tbCelsius
            // 
            this.tbCelsius.Location = new System.Drawing.Point(16, 69);
            this.tbCelsius.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbCelsius.Name = "tbCelsius";
            this.tbCelsius.Size = new System.Drawing.Size(192, 20);
            this.tbCelsius.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor convertido para Farenheit";
            // 
            // tbFarenheit
            // 
            this.tbFarenheit.Location = new System.Drawing.Point(16, 133);
            this.tbFarenheit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbFarenheit.Name = "tbFarenheit";
            this.tbFarenheit.Size = new System.Drawing.Size(192, 20);
            this.tbFarenheit.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor Convertido para Kelvin";
            // 
            // tbKelvin
            // 
            this.tbKelvin.Location = new System.Drawing.Point(16, 199);
            this.tbKelvin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbKelvin.Name = "tbKelvin";
            this.tbKelvin.Size = new System.Drawing.Size(192, 20);
            this.tbKelvin.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 243);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbKelvin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFarenheit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCelsius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCelsius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFarenheit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKelvin;
        private System.Windows.Forms.Button button1;
    }
}

