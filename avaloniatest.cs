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
        // Implement your logic for the "Nuevo" button click
    }

    private void btnDelete_Click(object sender, RoutedEventArgs e)
    {
        // Implement your logic for the "Eliminar" button click
    }

    private void btnImage_Click(object sender, RoutedEventArgs e)
    {
        // Implement your logic for the "Cambiar Imagen" button click
    }

    private void btnPrev_Click(object sender, RoutedEventArgs e)
    {
        // Implement your logic for the "⬅ Anterior" button click
    }

    private void btnNext_Click(object sender, RoutedEventArgs e)
    {
        // Implement your logic for the "Siguiente ⮕" button click
    }

    private void btnSave_Click(object sender, RoutedEventArgs e)
    {
        // Implement your logic for the "GUARDAR ARCHIVO" button click
    }

    private void btnSaveBocadillo_Click(object sender, RoutedEventArgs e)
    {
        // Implement your logic for the "Guardar" button click
    }

    private void btnAddImage_Click(object sender, RoutedEventArgs e)
    {
        // Implement your logic for the "Agregar Imagen" button click
    }
}
