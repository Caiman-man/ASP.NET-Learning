using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Ivanov_ASP.NET_04.Models
{
    public partial class Actor
    {
        [Key]
        [Column("actor_id")]
        public int ActorId { get; set; }
        [Column("name")]
        [StringLength(60)]
        public string Name { get; set; }
        [Column("age")]
        [StringLength(3)]
        public string Age { get; set; }
        [Column("birthdate", TypeName = "datetime")]
        public DateTime? Birthdate { get; set; }
        [Column("a_country")]
        [StringLength(20)]
        public string ACountry { get; set; }
        [Column("photo")]
        [StringLength(50)]
        public string Photo { get; set; }
    }
}
