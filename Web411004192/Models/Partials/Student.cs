using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web411004192.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
    }

    public class StudentMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="請填寫此欄位")]
        [StringLength(10,ErrorMessage ="請勿超過10各自串")]
        [Display(Name="姓名")]
        public string Name { get; set; }

        [Required(ErrorMessage ="請填寫學號")]
        [Display(Name ="學號")]
        [StringLength(10,ErrorMessage = "請輸入1~10")]
        public string Namber { get; set; }

        [Required(ErrorMessage = "請填寫Email")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="必田欄位")]
        [Display(Name = "是否註冊")]
        public bool IsActive { get; set; }
    }

}