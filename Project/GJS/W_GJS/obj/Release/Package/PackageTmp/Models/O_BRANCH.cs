﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace W_GJS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class O_BRANCH
    {
        [Display(Name = "Chi nhánh")]
        public long BRANCH_CD { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin !!!")]
        [DataType(DataType.Text)]
        [Display(Name = "Mã chi nhánh")]
        public string BRANCH_CODE { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin !!!")]
        [DataType(DataType.Text)]
        [Display(Name = "Tên chi nhánh")]
        public string BRANCH_NAME { get; set; }
        [Display(Name = "Khu vực")]
        public Nullable<long> CITIES_CD { get; set; }
        [Display(Name = "Thành phố")]
        public Nullable<long> CITIES_DETAIL_CD { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin !!!")]
        [DataType(DataType.Text)]
        [Display(Name = "Địa chỉ")]
        public string ADDRESS { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin !!!")]
        [DataType(DataType.Text)]
        [Display(Name = "Kinh độ")]
        public string LONGITUDE { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin !!!")]
        [DataType(DataType.Text)]
        [Display(Name = "Vĩ độ")]
        public string LATITUDE { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập thông tin !!!")]
        [DataType(DataType.Text)]
        [Display(Name = "Số điện thoại")]
        public string PHONE { get; set; }
        public Nullable<long> STATUS { get; set; }
        public Nullable<bool> ACTIVE { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
    
        public virtual O_CITIES O_CITIES { get; set; }
        public virtual D_CITIES_DETAIL D_CITIES_DETAIL { get; set; }
    }
}
