using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ZpiCapgeminiProduction5.Models
{
    [MetadataType(typeof(GRACZMetadata))]
    public partial class GRACZ
    {
        
    }

    public class GRACZMetadata
    {
        [Required(ErrorMessage = "Podaj Login !!", AllowEmptyStrings = false)]
        public string Login { get; set; }
        [Required(ErrorMessage = "Podaj hasło !!", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Długość hasła musiby być z przedziału 5-50  !!.")]
        public string Hasło { get; set; }
        [Required(ErrorMessage = "Podaj Imie !!", AllowEmptyStrings = false)]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Podaj Nazwisko !!", AllowEmptyStrings = false)]
        public string Nazwisko { get; set; }
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$",
                    ErrorMessage = "Podaj mail !!")]
        public string E_mail { get; set; }
    }
}