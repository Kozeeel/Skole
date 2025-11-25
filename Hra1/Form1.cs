namespace Hra1;

public partial class Form1 : Form
{
    private int _skore = 0;
    private Random _random;
    public Form1()
    {
        InitializeComponent();
        _random = new Random();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _skore++;
        label1.Text = "Skore: " + _skore;

        if (_skore == 3)
        {
            MessageBox.Show("You win!");
        }
    }

    private void CatchMeIfYouCan(object sender, EventArgs e)
    {
        button1.Left = _random.Next(0, this.Size.Width - button1.Size.Width);
        button1.Top = _random.Next(0, this.Size.Height - button1.Size.Height);
    }
}