using BusinessLogicalLayer;
using Entities;
using Shared;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using WFPresentationLayer;

namespace WfPresentationLayer
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        Hash hash = new Hash();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = hash.ComputeSha256Hash(txtSenha.Text);
            Login login = new Login(email, senha);
            LoginBLL loginBLL = new LoginBLL();
            SingleResponse<Funcionario> singleResponse = loginBLL.Logar(login);
            if (!singleResponse.HasSuccess)
            {
                MessageBox.Show(singleResponse.Message);
            }
            else
            {
                FuncionarioLogin.id = singleResponse.Item.ID;
                FuncionarioLogin.nome = singleResponse.Item.Nome;
                FuncionarioLogin.tipoFuncionarioId = singleResponse.Item.TipoFuncionarioId;
                this.Hide();
                FormFuncionario formFuncionario = new FormFuncionario();
                formFuncionario.ShowDialog();
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            DALValidator dALValidator = new DALValidator();
            dALValidator.Verify();
            //Process.Start(new ProcessStartInfo { FileName = "https://github.com/TheShelow", UseShellExecute = true });
        }

    }
}