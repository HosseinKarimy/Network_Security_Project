using Models;
using Models.DTO;

namespace WInFormUI
{
    public partial class MainForm : Form
    {
        private UserDTO _user;
        public EventHandler UserAuthenticated;
        public MainForm()
        {
            InitializeComponent();
            UserAuthenticated += UserAuthed;
        }

        private void UserAuthed(object? sender, EventArgs e)
        {
            Panel_Main.Controls.Clear();
            _user = (sender as UserDTO)!;

            var showDataForm = new ShowDataForm(_user)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            Panel_Main.Controls.Add(showDataForm);
            showDataForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var AuthUC = new AuthenticationProcessUC(UserAuthenticated);
            Panel_Main.Controls.Add(AuthUC);
        }
    }
}
