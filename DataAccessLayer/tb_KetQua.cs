//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_KetQua
    {
        public int MaKQ { get; set; }
        public Nullable<int> MaMH { get; set; }
        public Nullable<int> MaHS { get; set; }
        public Nullable<double> DiemKT { get; set; }
        public Nullable<double> DiemThiLan1 { get; set; }
        public Nullable<double> DiemThiLan2 { get; set; }
        public Nullable<double> DiemTB { get; set; }
        public string XepLoai { get; set; }
        public Nullable<int> MaNamHoc { get; set; }
        public Nullable<int> MaHocKy { get; set; }
        public Nullable<int> MaLop { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> Deleted_By { get; set; }
        public Nullable<System.DateTime> Deleted_Date { get; set; }
    
        public virtual tb_HocKy tb_HocKy { get; set; }
        public virtual tb_HocSinh tb_HocSinh { get; set; }
        public virtual tb_Lop tb_Lop { get; set; }
        public virtual tb_MonHoc tb_MonHoc { get; set; }
        public virtual tb_NamHoc tb_NamHoc { get; set; }
    }
}
