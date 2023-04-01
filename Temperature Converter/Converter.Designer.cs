namespace Temperature_Converter
{
    partial class TemperatureConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemperatureConverter));
            tbCelsius = new TextBox();
            lblCelsius = new Label();
            lblKelvin = new Label();
            tbKelvin = new TextBox();
            btnConvert = new Button();
            tbFarenheit = new TextBox();
            lblFarenheit = new Label();
            btnDelete = new Button();
            btnCopyFarenheit = new Button();
            btnCopyCelsius = new Button();
            btnCopyKelvin = new Button();
            SuspendLayout();
            // 
            // tbCelsius
            // 
            tbCelsius.Location = new Point(90, 70);
            tbCelsius.Name = "tbCelsius";
            tbCelsius.Size = new Size(113, 23);
            tbCelsius.TabIndex = 1;
            tbCelsius.TextChanged += tbCelcius_TextChanged;
            // 
            // lblCelsius
            // 
            lblCelsius.AutoSize = true;
            lblCelsius.Location = new Point(40, 76);
            lblCelsius.Name = "lblCelsius";
            lblCelsius.Size = new Size(44, 15);
            lblCelsius.TabIndex = 3;
            lblCelsius.Text = "Celsius";
            lblCelsius.Click += lblCelcius_Click;
            // 
            // lblKelvin
            // 
            lblKelvin.AutoSize = true;
            lblKelvin.Location = new Point(45, 123);
            lblKelvin.Name = "lblKelvin";
            lblKelvin.Size = new Size(39, 15);
            lblKelvin.TabIndex = 5;
            lblKelvin.Text = "Kelvin";
            // 
            // tbKelvin
            // 
            tbKelvin.Location = new Point(90, 117);
            tbKelvin.Name = "tbKelvin";
            tbKelvin.Size = new Size(113, 23);
            tbKelvin.TabIndex = 4;
            tbKelvin.TextChanged += tbKelvin_TextChanged;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(36, 154);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 6;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // tbFarenheit
            // 
            tbFarenheit.Location = new Point(90, 22);
            tbFarenheit.Name = "tbFarenheit";
            tbFarenheit.Size = new Size(113, 23);
            tbFarenheit.TabIndex = 7;
            tbFarenheit.TextChanged += tbFarenheit_TextChanged;
            // 
            // lblFarenheit
            // 
            lblFarenheit.AutoSize = true;
            lblFarenheit.Location = new Point(28, 28);
            lblFarenheit.Name = "lblFarenheit";
            lblFarenheit.Size = new Size(56, 15);
            lblFarenheit.TabIndex = 8;
            lblFarenheit.Text = "Farenheit";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(145, 154);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCopyFarenheit
            // 
            btnCopyFarenheit.Image = (Image)resources.GetObject("btnCopyFarenheit.Image");
            btnCopyFarenheit.Location = new Point(209, 22);
            btnCopyFarenheit.Name = "btnCopyFarenheit";
            btnCopyFarenheit.Size = new Size(26, 26);
            btnCopyFarenheit.TabIndex = 10;
            btnCopyFarenheit.UseVisualStyleBackColor = true;
            btnCopyFarenheit.Click += btnCopyFarenheit_Click;
            // 
            // btnCopyCelsius
            // 
            btnCopyCelsius.Image = (Image)resources.GetObject("btnCopyCelsius.Image");
            btnCopyCelsius.Location = new Point(209, 70);
            btnCopyCelsius.Name = "btnCopyCelsius";
            btnCopyCelsius.Size = new Size(26, 26);
            btnCopyCelsius.TabIndex = 11;
            btnCopyCelsius.UseVisualStyleBackColor = true;
            btnCopyCelsius.Click += btnCopyCelsius_Click;
            // 
            // btnCopyKelvin
            // 
            btnCopyKelvin.Image = (Image)resources.GetObject("btnCopyKelvin.Image");
            btnCopyKelvin.Location = new Point(209, 117);
            btnCopyKelvin.Name = "btnCopyKelvin";
            btnCopyKelvin.Size = new Size(26, 26);
            btnCopyKelvin.TabIndex = 12;
            btnCopyKelvin.UseVisualStyleBackColor = true;
            btnCopyKelvin.Click += btnCopyKelvin_Click;
            // 
            // TemperatureConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 189);
            Controls.Add(btnCopyKelvin);
            Controls.Add(btnCopyCelsius);
            Controls.Add(btnCopyFarenheit);
            Controls.Add(btnDelete);
            Controls.Add(lblFarenheit);
            Controls.Add(tbFarenheit);
            Controls.Add(btnConvert);
            Controls.Add(lblKelvin);
            Controls.Add(tbKelvin);
            Controls.Add(lblCelsius);
            Controls.Add(tbCelsius);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TemperatureConverter";
            Text = "Temperature Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbCelsius;
        private Label lblCelsius;
        private Label lblKelvin;
        private TextBox tbKelvin;
        private Button btnConvert;
        private TextBox tbFarenheit;
        private Label lblFarenheit;
        private Button btnDelete;
        private Button btnCopyFarenheit;
        private Button btnCopyCelsius;
        private Button btnCopyKelvin;
    }
}