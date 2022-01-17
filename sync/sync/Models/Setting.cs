using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sync.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [MaxLength(250)]
        public string MainTitle { get; set; }
        [MaxLength(250)]
        public string MainConent { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(250)]
        public string FooterTitle { get; set; }
        [MaxLength(250)]
        public string FooterContent { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(250)]
        public string Phone { get; set; }
        [MaxLength(250)]
        public string Adrees { get; set; }



    }
}
