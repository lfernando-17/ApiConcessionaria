﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ApiConcessionaria.Models
{
    public partial class Cliente
    {
        [Key]
        public int Id { get; set; }
        public int? Cpf { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string Nome { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string Email { get; set; }
        public int? Telefone { get; set; }
        public int? Cnh { get; set; }
        public int? IdCarro { get; set; }
        [NotMapped]
        public virtual Carro Carro { get; set; }
    }
}