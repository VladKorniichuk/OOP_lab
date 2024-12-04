// See https://aka.ms/new-console-template for more information

using OOP.BuildingWrapper;
using OOP.Constructions;
using OOP.Constructions.DTO;
using OOP.Constructions.Models;
using OOP.IndustrialHalls;
using OOP.ResidentalBuildings;

Console.WriteLine("Hello, World!");
var construction1 = new Construction();
var construction2 = new Construction(23.0f, 45.0f, 4, 4, BuildMaterialEnum.Wood);
var construction3 = new Construction(
    new CreateConstructionDTO() {
        BuildMaterial = BuildMaterialEnum.Brik,
        Width = 100,
        Height = 100,
        Entrances = 2
    }
);
Console.WriteLine(construction2.BuildMaterial);
Console.WriteLine(construction2.Width);
Console.WriteLine(construction2.HumanCapacity);
Console.WriteLine(construction2.Height);
Console.WriteLine(construction2.Entrances);

Console.WriteLine(construction1.BuildMaterial);
Console.WriteLine(construction1.Width);
Console.WriteLine(construction1.HumanCapacity);
Console.WriteLine(construction1.Height);
Console.WriteLine(construction1.Entrances);

Console.WriteLine(construction1.GetSquareCost());
var residental = new ResidentalBuilding(3);
var hall = new IndustrialHall();
Console.WriteLine(residental.Height);
Console.WriteLine(hall.Entrances);

var wrapper1 = new BuildingWrapper(residental);
var wrapper2 = new BuildingWrapper(hall);

Console.WriteLine(wrapper1.GetWrappedSquareCost());
Console.WriteLine(wrapper2.GetWrappedSquareCost());