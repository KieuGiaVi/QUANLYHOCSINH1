﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QUANLYHOCSINHEntities8 : DbContext
    {
        public QUANLYHOCSINHEntities8()
            : base("name=QUANLYHOCSINHEntities8")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_DanhMucLoi> tb_DanhMucLoi { get; set; }
        public virtual DbSet<tb_GiaoVien> tb_GiaoVien { get; set; }
        public virtual DbSet<tb_GiaoVien_Lop> tb_GiaoVien_Lop { get; set; }
        public virtual DbSet<tb_HocKy> tb_HocKy { get; set; }
        public virtual DbSet<tb_HocSinh> tb_HocSinh { get; set; }
        public virtual DbSet<tb_KetQua> tb_KetQua { get; set; }
        public virtual DbSet<tb_Lop> tb_Lop { get; set; }
        public virtual DbSet<tb_MonHoc> tb_MonHoc { get; set; }
        public virtual DbSet<tb_NamHoc> tb_NamHoc { get; set; }
        public virtual DbSet<tb_Truong> tb_Truong { get; set; }
        public virtual DbSet<tb_User> tb_User { get; set; }
        public virtual DbSet<tb_ViPham_CT> tb_ViPham_CT { get; set; }
        public virtual DbSet<tb_ViPham1> tb_ViPham1 { get; set; }
    }
}
