using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConyGreen.DAO.Models;

public partial class Pesquisa
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Codigo { get; set; }

    [StringLength(225)]
    public string Descricao { get; set; } = null!;
}
