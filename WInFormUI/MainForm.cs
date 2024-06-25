namespace WInFormUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var AuthUC = new AuthenticationProcessUC();
            Panel_Main.Controls.Add(AuthUC);
        }
    }
}
