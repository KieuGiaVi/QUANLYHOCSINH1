using BussinessLayer;
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
using DataAccessLayer;

namespace QUANLYHOCSINH
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }
        bool _them;
        MONHOC _monhoc;
        int _id = 0;
        void LoadData()
        {
            gcDanhSach.DataSource = _monhoc.getList();
            gvDanhSach.OptionsBehavior.Editable = false;
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = true;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            _showHide(true);
            _monhoc = new MONHOC();
            LoadData();
        }
        void _showHide (bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = kt;
            btnSua.Enabled = kt;
            btnXoa.Enabled = kt;
            btnDong.Enabled = kt;
            btnIn.Enabled = kt;
            txtTenMH.Enabled = !kt;
            spinHeSo.Enabled = !kt;
            spinSoTiet.Enabled = !kt;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
            _them = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           if(MessageBox.Show("Ban co chac chan muon xoa khong?","Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _monhoc.Delete(_id, Func.UserStatic.UID);

            }
            LoadData();
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SavaDate();
            LoadData();
            _showHide(true);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
            _them=false;
        }

        private void btnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        void SavaDate()
        {
            if(_them)
            {
                tb_MonHoc mh = new tb_MonHoc();
                mh.TenMH = txtTenMH.Text;
                mh.SoTiet = int.Parse(spinSoTiet.Text);
                mh.HeSo = int.Parse(spinHeSo.Text);
                mh.Created_By = Func.UserStatic.UID;
                mh.Created_Date = DateTime.Now;
                _monhoc.Add(mh);
            }
            else
            {
                tb_MonHoc mh = _monhoc.getItem(_id);
                mh.TenMH = txtTenMH.Text;
                mh.SoTiet = int.Parse(spinSoTiet.Text);
                mh.HeSo = int.Parse(spinHeSo.Text);
                mh.Created_By = Func.UserStatic.UID;
                mh.Created_Date = DateTime.Now;
                _monhoc.Update(mh);
            }
        }

        private void gvDanhSach_Click(object sender, EventArgs e)
        {
            if (gvDanhSach.RowCount > 0)
            {
                _id = int.Parse(gvDanhSach.GetFocusedRowCellValue("MaMH").ToString());
                txtTenMH.Text = gvDanhSach.GetFocusedRowCellValue("TenMH").ToString();
                spinHeSo.Text = gvDanhSach.GetFocusedRowCellValue("HeSo").ToString();
                spinSoTiet.Text = gvDanhSach.GetFocusedRowCellValue("SoTiet").ToString();
            }
        }

       
    }

}