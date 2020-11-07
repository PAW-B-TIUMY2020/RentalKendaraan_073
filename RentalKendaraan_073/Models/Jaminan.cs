using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_073.Models
{
    public partial class Jaminan
    {
        public Jaminan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdJaminan { get; set; }
        [Required(ErrorMessage = "Nama Gender Wajib Diisi")]
        public string NamaJaminan { get; set; }

        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
