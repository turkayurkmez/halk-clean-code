namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxProductName.Text;
            decimal price = decimal.Parse(textBoxPrice.Text);
            ProductService productService = new ProductService();
            var affectedRowsCount = productService.CreateProduct(name, price);
            string message = affectedRowsCount == 0 ? "Ba?ar?s?z" : "Ba?ar?l?";
            MessageBox.Show(message);
        }




    }
}