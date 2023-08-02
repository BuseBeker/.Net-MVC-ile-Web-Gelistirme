using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [Display(Name = "Adınız")]
        [StringLength(maximumLength: 60, MinimumLength = 3, ErrorMessage = "Adınızın minimum uzunluğu 3 ve maksimum uzunluğu 60 olmalıdır")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Soyadınız")]
        [StringLength(maximumLength: 60, MinimumLength = 2, ErrorMessage = "Soyadınızın minimum uzunluğu 2 ve maksimum uzunluğu 60 olmalıdır")]
        public string Surname { get; set; }


        //[RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Geçerli Email Adresi Girin!")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Telefon Numarası")]
        [RegularExpression(@"^\d{1,12}$", ErrorMessage = "Lütfen 12 Haneli Telefon Numarası Girin")]
        public string Phone { get; set; }


        [Required]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(maximumLength: 60, MinimumLength = 3, ErrorMessage = "Kullanıcı adınızın minimum uzunluğu 3 ve maksimum uzunluğu 60 olmalıdır")]
        public string Rumuz { get; set; }

        [Required]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",  //[Display(Name = "dd/MM/yyyy")]
                        ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime BirthdayDate { get; set; } //System.DateTime

        [StringLength(500)]
        [Display(Name = "Hobiler")]
        public string Hobbies { get; set; }

        public bool UserStatus { get; set; }

        // public DateTime RecordDate { get; set; } //System.DateTime

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Application> Applications { get; set; } //public virtual ICollection<Application> Applications
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<UserRole> UserRoles { get; set; } //public virtual ICollection<UserRole> UserRoles
        //public ICollection<Role> Roles { get; set; }
    }
}
