using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VascoVasconcellos.DAO.Models;

[MySqlCollation("utf8_general_ci")]
public partial class Modelagem
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? Modelagemcol { get; set; }
}
