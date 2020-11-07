using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_073.Models
{
    public partial class Gender
    {
        public int IdGender { get; set; }

        [Required(ErrorMessage = "Nama Gender Wajib Diisi")]
        public string NamaGender { get; set; }
        [Required(ErrorMessage = "Nama Customer Wajib Diisi")]
        public Customer Customer { get; set; }
    }
}
