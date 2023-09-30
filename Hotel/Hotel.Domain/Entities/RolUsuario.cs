﻿using School.Domain.Core;
using System;

namespace Hotel.Domain.Entities
{
    public class RolUsuario :BaseEntity
    {
        public int RolUsuarioId { get; set;}
        public string? Descripcion {  get; set;}
        public bool? Estado { get; set;}
        public DateTime? FechaCreacion { get; set;} 
    }
}
