using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Ivanov_ASP.NET_03.Models
{
    public partial class Movie
    {
        [Key]
        [Column("movie_id")]
        public int MovieId { get; set; }
        [Column("title")]
        [StringLength(60)]
        public string Title { get; set; }
        [Column("m_year")]
        [StringLength(4)]
        public string MYear { get; set; }
        [Column("budget", TypeName = "money")]
        public decimal? Budget { get; set; }
        [Column("m_country")]
        [StringLength(20)]
        public string MCountry { get; set; }
        [Column("description")]
        [StringLength(200)]
        public string Description { get; set; }
        [Column("poster")]
        [StringLength(70)]
        public string Poster { get; set; }
    }
}
