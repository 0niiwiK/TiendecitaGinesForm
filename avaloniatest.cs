using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using System;

public class MainWindow : Window
{
    private Grid grid;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private TextBox txtPrecio;
    private TextBox txtProducto;
    private Image pbImage;
    private Button btnNew;
    private Button btnDelete;
    private Button btnImage;
    private Button btnPrev;
    private Button btnNext;
    private TextBlock txtNumBocadillos;
    private Button btnSave;
    private CheckBox cbCalentito;
    private NumericUpDown txtStock;
    private ComboBox combTipoPan;
    private Button btnSaveBocadillo;
    private OpenFileDialog openFileDialog1;
    private Button btnAddImage;
    private OpenFileDialog openAddImage;
    private CheckBox cbCalentar;

    public MainWindow()
    {
        AvaloniaXamlLoader.Load(this);
        InitializeControls();
    }

    private void InitializeControls()
    {
        grid = this.FindControl<Grid>("grid");
        label1 = this.FindControl<Label>("label1");
        label2 = this.FindControl<Label>("label2");
        label3 = this.FindControl<Label>("label3");
        label4 = this.FindControl<Label>("label4");
        label5 = this.FindControl<Label>("label5");
        label6 = this.FindControl<Label>("label6");
        txtPrecio = this.FindControl<TextBox>("txtPrecio");
        txtProducto = this.FindControl<TextBox>("txtProducto");
        pbImage = this.FindControl<Image>("pbImage");
        btnNew = this.FindControl<Button>("btnNew");
        btnDelete = this.FindControl<Button>("btnDelete");
        btnImage = this.FindControl<Button>("btnImage");
        btnPrev = this.FindControl<Button>("btnPrev");
        btnNext = this.FindControl<Button>("btnNext");
        txtNumBocadillos = this.FindControl<TextBlock>("txtNumBocadillos");
        btnSave = this.FindControl<Button>("btnSave");
        cbCalentito = this.FindControl<CheckBox>("cbCalentito");
        txtStock = this.FindControl<NumericUpDown>("txtStock");
        combTipoPan = this.FindControl<ComboBox>("combTipoPan");
        btnSaveBocadillo = this.FindControl<Button>("btnSaveBocadillo");
        openFileDialog1 = new OpenFileDialog();
        btnAddImage = this.FindControl<Button>("btnAddImage");
        openAddImage = new OpenFileDialog();
        cbCalentar = this.FindControl<CheckBox>("cbCalentar");

        // Add event handlers here

        btnNew.Click += btnNew_Click;
        btnDelete.Click += btnDelete_Click;
        btnImage.Click += btnImage_Click;
        btnPrev.Click += btnPrev_Click;
        btnNext.Click += btnNext_Click;
        btnSave.Click += btnSave_Click;
        btnSaveBocadillo.Click += btnSaveBocadillo_Click;
        btnAddImage.Click += btnAddImage_Click;

        // Set grid layout
        grid.ColumnDefinitions = new ColumnDefinitions("*,*");
        grid.RowDefinitions = new RowDefinitions("Auto, Auto, Auto, Auto, Auto, Auto, Auto, Auto, Auto, Auto");

        Grid.SetColumn(label1, 0);
        Grid.SetColumnSpan(label1, 2);
        Grid.SetRow(label1, 0);

        Grid.SetColumn(label2, 0);
        Grid.SetRow(label2, 1);

        Grid.SetColumn(label3, 0);
        Grid.SetRow(label3, 2);

        Grid.SetColumn(label4, 0);
        Grid.SetRow(label4, 3);

        Grid.SetColumn(label5, 0);
        Grid.SetRow(label5, 4);

        Grid.SetColumn(label6, 0);
        Grid.SetRow(label6, 5);

        Grid.SetColumn(txtProducto, 1);
        Grid.SetRow(txtProducto, 1);

        Grid.SetColumn(txtStock, 1);
        Grid.SetRow(txtStock, 2);

        Grid.SetColumn(txtPrecio, 1);
        Grid.SetRow(txtPrecio, 3);

        Grid.SetColumn(combTipoPan, 1);
        Grid.SetRow(combTipoPan, 4);

        Grid.SetColumn(cbCalentito, 1);
        Grid.SetRow(cbCalentito, 5);

        Grid.SetColumn(btnSaveBocadillo, 1);
        Grid.SetRow(btnSaveBocadillo, 6);

        Grid.SetColumn(btnPrev, 0);
        Grid.SetRow(btnPrev, 7);

        Grid.SetColumn(txtNumBocadillos, 1);
        Grid.SetRow(txtNumBocadillos, 7);

        Grid.SetColumn(btnNext, 1);
        Grid.SetRow(btnNext, 7);

        Grid.SetColumn(btnSave, 0);
        Grid.SetColumnSpan(btnSave, 2);
        Grid.SetRow(btnSave, 8);

        Grid.SetColumn(pbImage, 0);
        Grid.SetColumnSpan(pbImage, 2);
        Grid.SetRow(pbImage, 9);

        Grid.SetColumn(btnAddImage, 1);
        Grid.SetRow(btnAddImage, 10);
    }

    // Add your event handlers here
   private void btnNew_Click(object sender, RoutedEventArgs e)
{
    limpiarTextos();
    ActivarTextos();
    btnSaveBocadillo.Enabled = true;
    btnSaveBocadillo.Visible = true;
    btnAddImage.Visible = true;
    btnAddImage.Enabled = true;
    btnImage.Enabled = false;
    btnImage.Visible = true;
    pbImage.Source = null;
    cbCalentar.Visible = false;
    cbCalentito.Visible = true;
    cbCalentito.IsChecked = false;
}

private void btnDelete_Click(object sender, RoutedEventArgs e)
{
    if (lista_bocadillos.Count > 0)
    {
        lista_bocadillos.Remove(bocadillo_actual);
        if (num_boc_act >= lista_bocadillos.Count)
            num_boc_act--;

        txtNumBocadillos.Text = (num_boc_act + 1) + "/" + lista_bocadillos.Count;
        MostrarSiHay();
    }
}

private void btnImage_Click(object sender, RoutedEventArgs e)
{
    openFileDialog1.InitialDirectory = carpetaIncial;
    openFileDialog1.Filter = "Image files (*.png;*.bmp;*.jpg;*.jpeg)|*.png;*.bmp;*.jpg;*.jpeg|All files (*.*)|*.*";
    openFileDialog1.FilterIndex = 1;
    openFileDialog1.RestoreDirectory = true;
    openFileDialog1.FileName = "";
    openFileDialog1.ShowDialog(this);
}

private void btnPrev_Click(object sender, RoutedEventArgs e)
{
    if (num_boc_act > 0)
    {
        num_boc_act--;
        CargarBocadillo(num_boc_act);
    }
}

private void btnNext_Click(object sender, RoutedEventArgs e)
{
    if (num_boc_act < lista_bocadillos.Count - 1)
    {
        num_boc_act++;
        CargarBocadillo(num_boc_act);
    }
}

private void btnSave_Click(object sender, RoutedEventArgs e)
{
    Program.GuardarBocadillos(lista_bocadillos, ruta);
}

private void btnSaveBocadillo_Click(object sender, RoutedEventArgs e)
{
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
        Program.Bocadillo nuevo_boc = new Program.Bocadillo(txtProducto.Text, (int)txtStock.Value, double.Parse(txtPrecio.Text), tipopan, cbCalentito.IsChecked ?? false);
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
        // Handle exception, e.g., show an error message
    }
    finally
    {
        MostrarSiHay();
    }
}

private void btnAddImage_Click(object sender, RoutedEventArgs e)
{
    openAddImage.InitialDirectory = carpetaIncial;
    openAddImage.Filter = "Image files (*.png;*.bmp;*.jpg;*.jpeg)|*.png;*.bmp;*.jpg;*.jpeg|All files (*.*)|*.*";
    openAddImage.FilterIndex = 1;
    openAddImage.RestoreDirectory = true;
    openAddImage.FileName = "";
    openAddImage.ShowDialog(this);
}

private void btnImage_Click_WinForms(object sender, RoutedEventArgs e)
    {
        openFileDialog1.InitialDirectory = carpetaIncial;
        openFileDialog1.Filter = "Image files (*.png;*.bmp;*.jpg;*.jpeg)|*.png;*.bmp;*.jpg;*.jpeg|All files (*.*)|*.*";
        openFileDialog1.FilterIndex = 1;
        openFileDialog1.RestoreDirectory = true;
        openFileDialog1.FileName = "";
        openFileDialog1.ShowDialog(this); // Pass the current window instance as the owner
    }

    private void btnAddImage_Click_WinForms(object sender, RoutedEventArgs e)
    {
        openAddImage.InitialDirectory = carpetaIncial;
        openAddImage.Filter = "Image files (*.png;*.bmp;*.jpg;*.jpeg)|*.png;*.bmp;*.jpg;*.jpeg|All files (*.*)|*.*";
        openAddImage.FilterIndex = 1;
        openAddImage.RestoreDirectory = true;
        openAddImage.FileName = "";
        openAddImage.ShowDialog(this); // Pass the current window instance as the owner
    }

    private void btnSaveBocadillo_Click_WinForms(object sender, RoutedEventArgs e)
    {
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
        carpetaIncial = openFileDialog1.FileName;

        //Read the contents of the file into a stream
        var fileStream = openFileDialog1.OpenFile();

        if (fileStream != null)
        {
            bocadillo_actual.Imagen = new byte[fileStream.Length];
            using (MemoryStream ms = new MemoryStream())
            {
                fileStream.CopyTo(ms);
                bocadillo_actual.Imagen = ms.ToArray();
                pbImage.Source = new Bitmap(ms);
            }
        }
    }

    private void openAddImage_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {
        //Get the path of specified file
        string filePath = openAddImage.FileName;
        carpetaIncial = openAddImage.FileName;

        //Read the contents of the file into a stream
        var fileStream = openAddImage.OpenFile();

        if (fileStream != null)
        {
            imagenActual = new byte[fileStream.Length];
            using (MemoryStream ms = new MemoryStream())
            {
                fileStream.CopyTo(ms);
                imagenActual = ms.ToArray();
                pbImage.Source = new Bitmap(ms);
            }
        }
    }
}
