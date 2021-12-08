namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ev();
        }

        private void ev()
        {
            Label label = new Label();
            label.Location = new Point(30, 30);
            label.Visible = true;
            label.Text = "Hello";
            label.AutoSize = true;
            label.BackColor = Color.Red;
            label.ForeColor = Color.Green;
            label.Size = new Size(115, 45);



        }
    }
}