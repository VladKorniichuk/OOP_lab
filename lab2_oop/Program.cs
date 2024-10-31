// See https://aka.ms/new-console-template for more information
using lab2_oop.Constructions;
using OOP.Constructions.DTO;

Console.WriteLine("Hello World!");
var construction1 = new Construction();
var construction2 = new Construction(23.0f, 45.0f, 4, 4, "Material");
var construction3 = new Construction(
    new CreateConstructionDTO(){
    BuildMaterial = "Material",
        Height = 100,
        Width = 100,
        Entrances = 2,
    }
);

Console.WriteLine("HI");

Console.WriteLine(construction1.BuildMaterial);
Console.WriteLine(construction1.Width);
Console.WriteLine(construction1.Height);
Console.WriteLine(construction1.HumanCapacity);
Console.WriteLine(construction1.Entrances);

Console.WriteLine(construction2.BuildMaterial);
Console.WriteLine(construction2.Width);
Console.WriteLine(construction2.Height);
Console.WriteLine(construction2.HumanCapacity);
Console.WriteLine(construction2.Entrances);