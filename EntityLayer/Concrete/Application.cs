using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Application
    {
        [Key]
        public int ApplicationID { get; set; }

        public int UserID { get; set; }

        [Required]
        [StringLength(maximumLength: 60, MinimumLength = 3, ErrorMessage = "Adınızın minimum uzunluğu 3 ve maksimum uzunluğu 60 olmalıdır")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 60, MinimumLength = 2, ErrorMessage = "Soyadınızın minimum uzunluğu 2 ve maksimum uzunluğu 60 olmalıdır")]
        public string Surname { get; set; }

        [Required]
        [StringLength(maximumLength: 500, MinimumLength = 2, ErrorMessage = "Proje isminizin minimum uzunluğu 2 olmalıdır")]
        public string Project_name { get; set; }

        [Required]
        [StringLength(maximumLength: 500, MinimumLength = 2, ErrorMessage = "Proje açıklamanızın minimum uzunluğu 2 olmalıdır")]
        public string Description { get; set; }

        [Required]
        [StringLength(500)]
        public string ProjectType { get; set; }

        //public DateTime RecordDate { get; set; }

        public int ProjectStatus { get; set; }

        public bool ApplicationStatus { get; set; }

        [ForeignKey("UserID")]
        public virtual User User { get; set; }
    }
}




