using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYHOCSINH
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        OverlayWindowOptions options = new OverlayWindowOptions(
        
        backColor: Color.Black,
        opacity: 0.5,
        fadeIn: false,
        fadeOut: false
        );
        IOverlaySplashScreenHandle ShowProgressPanel(Control control, OverlayWindowOptions option)
        {
            return SplashScreenManager.ShowOverlayForm(control, option);
        }
        private void mnHanhKiem_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Func.handle = ShowProgressPanel(this, options);
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }
        void openForm(Type typeForm)
        {
            foreach(var frm in MdiChildren)
            {
                if(frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        private void mnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmMonHoc));

        }
    }
}