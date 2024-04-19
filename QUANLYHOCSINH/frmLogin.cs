using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using BussinessLayer;

namespace QUANLYHOCSINH
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        USERS _user;
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            int lg = _user.Login (txtUsername.Text, txtPass.Text);
            if(lg == 1)
            {
                Func.UserStatic = _user.getItem(txtUsername.Text);
                MainForm main = (MainForm)Application.OpenForms["MainForm"];
                main.lblFullName.Caption = Func.UserStatic.FULLNAME;
                if (Func.handle != null)
                {
                    SplashScreenManager.CloseOverlayForm(Func.handle);
                }
                this.Close();
            }
           else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _user = new USERS();
        }
    }
}