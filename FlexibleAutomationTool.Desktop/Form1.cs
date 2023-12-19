

namespace FlexibleAutomationTool.Desktop
{
    public partial class Form1 : Form
    {
        private List<MouseEventArgs> _mouseEventArgs = new List<MouseEventArgs>();
        private List<KeyEventArgs> _keyEventArgs = new List<KeyEventArgs>();

        public Form1()
        {
            this.KeyDown += MainKey;
            this.MouseClick += MouseClickk;
            InitializeComponent();
        }

        private void MouseClickk(object? sender, MouseEventArgs e)
        {
            _mouseEventArgs.Add(e);
        }

        private void MainKey(object? sender, KeyEventArgs e)
        {
            _keyEventArgs.Add(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveLists()
        {
            
        }
    }
}