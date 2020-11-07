using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_073.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }

        [Required(ErrorMessage = "Nama Customer Wajib Diisi")]
        public string NamaCustomer { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "NIK Tidak Valid")]
        [Required(ErrorMessage = "NIK Customer Wajib Diisi")]
        public string Nik { get; set; }

        [Required(ErrorMessage = "Alamat Customer Wajib Diisi")]
        public string Alamat { get; set; }

        [MinLength(11, ErrorMessage = "No HP Tidak Valid")]
        [MaxLength(13, ErrorMessage = "No HP Tidak Valid")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "No HP Hanya Boleh Diisi Dengan Angka")]
        [Required(ErrorMessage = "No HP Wajib Diisi")]
        public string NoHp { get; set; }

        public int? IdGender { get; set; }

        public Gender IdCustomerNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
