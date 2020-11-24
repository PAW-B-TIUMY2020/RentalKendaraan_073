using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_073.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }

        [Required(ErrorMessage = "Nama Kendaraan Wajib Diisi")]
        public string NamaKendaraan { get; set; }

        [Required(ErrorMessage = "No Polisi Wajib Diisi")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "No Polisi Hanya Boleh Diisi Dengan Angka")]
        public string NoPolisi { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage = "No STNK Hanya Boleh Diisi Dengan Angka")]
        [Required(ErrorMessage = "No STNK Wajib Diisi")]
        public string NoStnk { get; set; }

        public int? IdJenisKendaraan { get; set; }

        [Required(ErrorMessage = "Ketersediaan Wajib Diisi")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
