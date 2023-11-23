using System;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TiendecitaGines
{
    public partial class Form1 : Form
    {
        private Program.Bocadillo bocadillo_actual;
        private List<Program.Bocadillo> lista_bocadillos;
        private string ruta;
        private int num_boc_act;
        private byte[] imagenActual;
        public Form1()
        {
            InitializeComponent();
            lista_bocadillos = new List<Program.Bocadillo>();
            ruta = Program.Init();
            btnPrev.Enabled = false;
            btnNext.Enabled = false;
            btnImage.Enabled = false;
            btnSaveBocadillo.Enabled = false;
            btnSaveBocadillo.Visible = false;
            btnAddImage.Visible = false;
            btnAddImage.Enabled = false;
            btnDelete.Enabled = false;
            DesactivarTextos();
            CargarDeArchivo();
        }


        private void ActivarTextos()
        {
            cbCalentito.Enabled = true;
            txtPrecio.Enabled = true;
            txtProducto.Enabled = true;
            txtStock.Enabled = true;
            combTipoPan.Enabled = true;
        }

        private void DesactivarTextos()
        {
            cbCalentito.Enabled = false;
            txtPrecio.Enabled = false;
            txtProducto.Enabled = false;
            txtStock.Enabled = false;
            combTipoPan.Enabled = false;
        }

        private void CargarBocadillo(int num)
        {
            int tipopan;
            txtNumBocadillos.Text = (num_boc_act + 1) + "/" + lista_bocadillos.Count;
            bocadillo_actual = lista_bocadillos[num];
            txtProducto.Text = bocadillo_actual.Nombre;
            txtPrecio.Text = bocadillo_actual.Precio.ToString();
            txtStock.Text = bocadillo_actual.Stock.ToString();
            cbCalentito.Checked = bocadillo_actual.Calentito;
            switch (bocadillo_actual.TipoPan)
            {
                case 'A':
                    tipopan = 0; break;
                case 'G':
                    tipopan = 1; break;
                case 'V':
                    tipopan = 2; break;
                default:
                    tipopan = 0; break;
            }
            combTipoPan.SelectedIndex = tipopan;
            Bitmap image = null;
            if (bocadillo_actual.Imagen != null)
            {
                using (var ms = new MemoryStream(bocadillo_actual.Imagen))
                {
                    image = new Bitmap(ms);
                }

            }
            pbImage.Image = image;
            if (num > 0) { btnPrev.Enabled = true; }
            else { btnPrev.Enabled = false; }
            if (num < lista_bocadillos.Count - 1) { btnNext.Enabled = true; }
            else { btnNext.Enabled = false; }
            btnImage.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            num_boc_act++;
            CargarBocadillo(num_boc_act);
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void CargarDeArchivo()
        {
            try
            {
                if (File.Exists(ruta))
                    lista_bocadillos = Program.CargarBocadillos(ruta);
                if (lista_bocadillos.Count > 0)
                {
                    num_boc_act = 0;
                    CargarBocadillo(num_boc_act);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txtNumBocadillos_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Program.GuardarBocadillos(lista_bocadillos, ruta);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnNew.Visible = false;
            btnNew.Enabled = false;
            btnSaveBocadillo.Enabled = true;
            btnSaveBocadillo.Visible = true;
            btnAddImage.Enabled = true;
            btnAddImage.Visible = true;
            btnImage.Enabled = false;
            btnImage.Visible = true;
            pbImage.Image = null;
            btnImage.Enabled = false;
            ActivarTextos();
            if (bocadillo_actual == null)
                limpiarTextos();
        }

        private void limpiarTextos()
        {
            txtProducto.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            cbCalentito.Checked = false;
            combTipoPan.SelectedIndex = 0;
            pbImage.Image = null;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            num_boc_act--;
            CargarBocadillo(num_boc_act);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveBocadillo_Click(object sender, EventArgs e)
        {
            /* btnNew.Visible = false;
             btnNew.Enabled = false;
             btnSaveBocadillo.Enabled = true;
             btnSaveBocadillo.Visible = true;
             ActivarTextos();
             txtProducto.Text = "";
             txtPrecio.Text = "";
             txtStock.Text = "";
             txtTipoPan.Text = "";
             cbCalentito.Checked = false;
             combTipoPan.SelectedIndex = 0;
             */
            char tipopan;
            switch (combTipoPan.SelectedIndex)
            {
                case 0:
                    tipopan = 'A'; break;
                case 1:
                    tipopan = 'G'; break;
                case 2:
                    tipopan = 'V'; break;
                default:
                    tipopan = 'A'; break;
            }
            try
            {
                Program.Bocadillo nuevo_boc = new Program.Bocadillo(txtProducto.Text, (int)txtStock.Value, double.Parse(txtPrecio.Text), tipopan, cbCalentito.Checked);
                lista_bocadillos.Add(nuevo_boc);
                if (imagenActual != null)
                {
                    nuevo_boc.Imagen = new byte[imagenActual.Length];
                    imagenActual.CopyTo(nuevo_boc.Imagen, 0);
                }
                num_boc_act = lista_bocadillos.Count - 1;
            }
            catch (Exception ex)
            {

            }
            finally { MostrarSiHay(); }

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Get the path of specified file
            string filePath = openFileDialog1.FileName;

            //Read the contents of the file into a stream
            var fileStream = openFileDialog1.OpenFile();

            if (fileStream != null)
            {
                bocadillo_actual.Imagen = new byte[fileStream.Length];
                using (MemoryStream ms = new MemoryStream())
                {
                    fileStream.CopyTo(ms);
                    bocadillo_actual.Imagen = ms.ToArray();
                    pbImage.Image = Bitmap.FromStream(ms);
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.Filter = "Image files (*.png;*.bmp;*.jpg;*.jpeg)|*.png;*.bmp;*.jpg;*.jpeg|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!btnSaveBocadillo.Visible)
            {
                lista_bocadillos.Remove(bocadillo_actual);
                if (num_boc_act >= lista_bocadillos.Count)
                    num_boc_act--;
                txtNumBocadillos.Text = (num_boc_act + 1) + "/" + lista_bocadillos.Count;
                MostrarSiHay();
            }
            else
                MostrarSiHay();
        }

        private void MostrarSiHay()
        {
            if (lista_bocadillos.Count > 0)
            {
                CargarBocadillo(num_boc_act);
                btnImage.Visible = true;
                btnImage.Enabled = true;
            }
            else
            {
                limpiarTextos();
                btnDelete.Enabled = false;
                btnImage.Visible = true;
                btnImage.Enabled = false;
            }
            imagenActual = null;
            DesactivarTextos();
            btnNew.Visible = true;
            btnNew.Enabled = true;
            btnSaveBocadillo.Enabled = false;
            btnSaveBocadillo.Visible = false;
            btnAddImage.Visible = false;
            btnAddImage.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openAddImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openAddImage.Filter = "Image files (*.png;*.bmp;*.jpg;*.jpeg)|*.png;*.bmp;*.jpg;*.jpeg|All files (*.*)|*.*";
            openAddImage.FilterIndex = 1;
            openAddImage.RestoreDirectory = true;
            openAddImage.FileName = "";
            openAddImage.ShowDialog();
        }

        private void openAddImage_FileOk(object sender, CancelEventArgs e)
        {
            //Get the path of specified file
            string filePath = openAddImage.FileName;

            //Read the contents of the file into a stream
            var fileStream = openAddImage.OpenFile();

            if (fileStream != null)
            {
                imagenActual = new byte[fileStream.Length];
                using (MemoryStream ms = new MemoryStream())
                {
                    fileStream.CopyTo(ms);
                    imagenActual = ms.ToArray();
                    pbImage.Image = Bitmap.FromStream(ms);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.GuardarBocadillos(lista_bocadillos, ruta);
        }
    }
}