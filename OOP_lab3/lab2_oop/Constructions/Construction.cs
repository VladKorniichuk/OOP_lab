using lab2_oop.Constructions.Models;
using O.Constructions.DTO;
using OOP.Constructions.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_oop.Constructions
{
    internal class Construction
    {
        public Construction() 
        {
            Height = 23;
            Width = 43;
            Entrances = 3;
            HumanCapacity = 2;
            BuildMaterial = "Material";
        }

        public Construction(CreateConstructionDTO construction)
        {
            Height = construction.Height;
            Width = construction.Width;
            Entrances = construction.Entrances;
            HumanCapacity = construction.HumanCapacity;
            BuildMaterial = construction.BuildMaterial;
        }
        public Construction(float height, float width, int entrances, int humanCapacity, string buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }

        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }

        private BuildMaterialEnum _buildMaterial { get; set; }
        public BuildMaterialEnum BuildMaterial {
            get
            {
                return _buildMaterial;
            }
            set {
                //if (value == null)
                //{
                //    throw new ArgumentNullException("value can't be empty");
                //}
                _buildMaterial = value;
            }
        
        
        
        
        
        
        }
        public float getSquareCost()
        {
            if(BuildMaterial == BuildMaterialEnum.Concrete)
            {

            }
        }
        
    }
}
