namespace TiendecitaGines
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtPrecio = new TextBox();
            txtProducto = new TextBox();
            pbImage = new PictureBox();
            btnNew = new Button();
            btnDelete = new Button();
            btnImage = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            txtNumBocadillos = new Label();
            btnSave = new Button();
            cbCalentito = new CheckBox();
            txtStock = new NumericUpDown();
            combTipoPan = new ComboBox();
            btnSaveBocadillo = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnAddImage = new Button();
            openAddImage = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 52);
            label1.Margin = new Padding(50, 30, 50, 0);
            label1.Name = "label1";
            label1.Size = new Size(1101, 91);
            label1.TabIndex = 0;
            label1.Text = "TIENDECITA GINES";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(36, 260);
            label2.Margin = new Padding(15, 20, 20, 0);
            label2.Name = "label2";
            label2.Size = new Size(205, 59);
            label2.TabIndex = 1;
            label2.Text = "Producto";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 346);
            label3.Margin = new Padding(15, 20, 20, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 59);
            label3.TabIndex = 2;
            label3.Text = "Stock";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(36, 418);
            label4.Margin = new Padding(15, 20, 20, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 59);
            label4.TabIndex = 3;
            label4.Text = "Precio";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(36, 497);
            label5.Margin = new Padding(15, 20, 20, 0);
            label5.Name = "label5";
            label5.Size = new Size(256, 59);
            label5.TabIndex = 4;
            label5.Text = "Tipo de Pan";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(36, 576);
            label6.Margin = new Padding(15, 20, 20, 0);
            label6.Name = "label6";
            label6.Size = new Size(202, 59);
            label6.TabIndex = 5;
            label6.Text = "Calentito";
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecio.Location = new Point(315, 415);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(302, 64);
            txtPrecio.TabIndex = 6;
            // 
            // txtProducto
            // 
            txtProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtProducto.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtProducto.Location = new Point(315, 255);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(302, 64);
            txtProducto.TabIndex = 10;
            txtProducto.TextChanged += txtProducto_TextChanged;
            // 
            // pbImage
            // 
            pbImage.Anchor = AnchorStyles.Right;
            pbImage.Location = new Point(651, 253);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(486, 382);
            pbImage.TabIndex = 11;
            pbImage.TabStop = false;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnNew.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.ForeColor = Color.Black;
            btnNew.Location = new Point(342, 173);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(250, 64);
            btnNew.TabIndex = 12;
            btnNew.Text = "Nuevo";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Left;
            btnDelete.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Firebrick;
            btnDelete.Location = new Point(36, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(250, 64);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnImage
            // 
            btnImage.Anchor = AnchorStyles.Right;
            btnImage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnImage.Location = new Point(651, 173);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(486, 64);
            btnImage.TabIndex = 14;
            btnImage.Text = "Cambiar Imagen";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = AnchorStyles.None;
            btnPrev.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrev.Location = new Point(36, 657);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(500, 64);
            btnPrev.TabIndex = 15;
            btnPrev.Text = "⬅ Anterior";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.None;
            btnNext.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.Location = new Point(637, 657);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(500, 64);
            btnNext.TabIndex = 16;
            btnNext.Text = "Siguiente ⮕";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += button5_Click;
            // 
            // txtNumBocadillos
            // 
            txtNumBocadillos.Anchor = AnchorStyles.None;
            txtNumBocadillos.AutoSize = true;
            txtNumBocadillos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumBocadillos.Location = new Point(553, 668);
            txtNumBocadillos.Name = "txtNumBocadillos";
            txtNumBocadillos.Size = new Size(66, 45);
            txtNumBocadillos.TabIndex = 17;
            txtNumBocadillos.Text = "0/0";
            txtNumBocadillos.Click += txtNumBocadillos_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(36, 743);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(1101, 64);
            btnSave.TabIndex = 18;
            btnSave.Text = "GUARDAR ARCHIVO";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbCalentito
            // 
            cbCalentito.AutoSize = true;
            cbCalentito.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            cbCalentito.Location = new Point(301, 576);
            cbCalentito.Name = "cbCalentito";
            cbCalentito.Size = new Size(331, 54);
            cbCalentito.TabIndex = 20;
            cbCalentito.Text = "Admite Calentito";
            cbCalentito.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            txtStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtStock.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtStock.Location = new Point(314, 336);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(304, 64);
            txtStock.TabIndex = 21;
            // 
            // combTipoPan
            // 
            combTipoPan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            combTipoPan.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            combTipoPan.FormattingEnabled = true;
            combTipoPan.Items.AddRange(new object[] { "Andaluza", "Gallega", "Viena" });
            combTipoPan.Location = new Point(316, 494);
            combTipoPan.Name = "combTipoPan";
            combTipoPan.Size = new Size(303, 67);
            combTipoPan.TabIndex = 22;
            combTipoPan.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnSaveBocadillo
            // 
            btnSaveBocadillo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnSaveBocadillo.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveBocadillo.ForeColor = Color.Black;
            btnSaveBocadillo.Location = new Point(342, 173);
            btnSaveBocadillo.Name = "btnSaveBocadillo";
            btnSaveBocadillo.Size = new Size(250, 64);
            btnSaveBocadillo.TabIndex = 23;
            btnSaveBocadillo.Text = "Guardar";
            btnSaveBocadillo.UseVisualStyleBackColor = true;
            btnSaveBocadillo.Click += btnSaveBocadillo_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // btnAddImage
            // 
            btnAddImage.Anchor = AnchorStyles.Right;
            btnAddImage.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddImage.Location = new Point(651, 173);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(486, 64);
            btnAddImage.TabIndex = 24;
            btnAddImage.Text = "Agregar Imagen";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += button1_Click;
            // 
            // openAddImage
            // 
            openAddImage.FileOk += openAddImage_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1174, 829);
            Controls.Add(btnAddImage);
            Controls.Add(btnSaveBocadillo);
            Controls.Add(combTipoPan);
            Controls.Add(txtStock);
            Controls.Add(cbCalentito);
            Controls.Add(btnSave);
            Controls.Add(txtNumBocadillos);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(btnImage);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(pbImage);
            Controls.Add(txtProducto);
            Controls.Add(txtPrecio);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(1200, 900);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtPrecio;
        private TextBox txtProducto;
        private PictureBox pbImage;
        private Button btnNew;
        private Button btnDelete;
        private Button btnImage;
        private Button btnPrev;
        private Button btnNext;
        private Label txtNumBocadillos;
        private Button btnSave;
        private CheckBox cbCalentito;
        private NumericUpDown txtStock;
        private ComboBox combTipoPan;
        private Button btnSaveBocadillo;
        private OpenFileDialog openFileDialog1;
        private Button btnAddImage;
        private OpenFileDialog openAddImage;
    }
}