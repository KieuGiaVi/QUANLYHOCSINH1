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
    
    public partial class tb_GiaoVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_GiaoVien()
        {
            this.tb_GiaoVien_Lop = new HashSet<tb_GiaoVien_Lop>();
        }
    
        public int MaGV { get; set; }
        public string HoTen { get; set; }
        public string Ten { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public Nullable<int> Updated_By { get; set; }
        public Nullable<System.DateTime> Updated_Date { get; set; }
        public Nullable<int> Deleted_By { get; set; }
        public Nullable<System.DateTime> Deleted_Date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_GiaoVien_Lop> tb_GiaoVien_Lop { get; set; }
    }
}
