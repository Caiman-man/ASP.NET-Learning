using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Ivanov_ASP.NET_03.Models
{
    [Table("ActorMovie")]
    public partial class ActorMovie
    {
        [Key]
        [Column("actor_id")]
        public int ActorId { get; set; }
        [Key]
        [Column("movie_id")]
        public int MovieId { get; set; }
    }
}
