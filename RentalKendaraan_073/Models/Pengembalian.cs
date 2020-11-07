using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_073.Models
{
    public partial class Pengembalian
    {
        public int IdPengembalian { get; set; }
        public DateTime? TglPengembalian { get; set; }
        public int? IdPeminjaman { get; set; }
        public int? IdKondisi { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Denda Hanya Boleh Diisi Dengan Angka")]
        [Required(ErrorMessage = "Denda Wajib Diisi")]
        public int? Denda { get; set; }

        public KondisiKendaraan IdKondisiNavigation { get; set; }
        public Peminjaman IdPeminjamanNavigation { get; set; }
    }
}
