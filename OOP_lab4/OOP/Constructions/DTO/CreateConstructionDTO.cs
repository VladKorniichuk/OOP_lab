using OOP.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructions.DTO
{
    internal class CreateConstructionDTO
    {
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public BuildMaterialEnum BuildMaterial { get; set; }
    }
}
