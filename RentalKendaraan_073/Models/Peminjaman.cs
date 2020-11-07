using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_073.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }

        public int IdPeminjaman { get; set; }
        public DateTime? TglPeminjaman { get; set; }
        public int? IdKendaraan { get; set; }
        public int? IdCustomer { get; set; }

        public int? IdJaminan { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "No HP Hanya Boleh Diisi Dengan Angka")]
        [Required(ErrorMessage = "Biaya Wajib Diisi")]
        public int? Biaya { get; set; }

        public Jaminan IdCustomer1 { get; set; }
        public Customer IdCustomerNavigation { get; set; }
        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
