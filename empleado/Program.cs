﻿// See https://aka.ms/new-console-template for more information
using System;
Console.WriteLine("Hello, World!");
Emplea2 empleado1 = new Emplea2();
Emplea2 empleado2 = new Emplea2();
Emplea2 empleado3 = new Emplea2();
var nom = new List<string> {"Jorge", "Juan", "Luciana"};
var ape = new List<string> {"Gudiño", "Juarez", "Santos"};
var empleadoL = new List<Emplea2> {empleado1, empleado2, empleado3};
var nacimiento = new List<DateTime>();
nacimiento.Add(new DateTime(1987,5,13));
nacimiento.Add(new DateTime(1958,05,28));
nacimiento.Add(new DateTime(2001,03,15));
var civil = new List<string> {"S", "C", "C"};
var gnero = new List<char> {'M', 'M', 'F'};
var ingre = new List<DateTime>();
ingre.Add(new DateTime(2012,1,16));
ingre.Add(new DateTime(1987,05,28));
ingre.Add(new DateTime(2022,03,15));
var suel2 = new List<double> {45000, 50000, 60000};
var cargo = new List<int> {0,2,4};
int i=0;
foreach (var emp in empleadoL)
{
    emp.Nombre=nom[i];
    emp.Apellido=ape[i];
    emp.FecNac=nacimiento[i];
    emp.EstadoCivil=civil[i];
    emp.Genero=gnero[i];
    emp.FecIngreso=ingre[i];
    emp.SueldoBasico=suel2[i];
    emp.cargo=cargo[i];
    i++;    
}
// for (int i = 0; i < 1; i++)
// {
//     empleado1.Nombre=nom[i];
//     empleado1.Apellido=ape[i];
//     empleado1.FecNac=nacimiento[i];
//     empleado1.EstadoCivil=civil[i];
//     empleado1.Genero=gnero[i];
//     empleado1.FecIngreso=ingre[i];
//     empleado1.SueldoBasico=suel2[i];
//     empleado1.cargo=cargo[i];
// }
foreach (var emp in empleadoL)
{
    if(emp.TiempoJubilacion()<10){
        Console.WriteLine($"Apellido: {emp.Apellido}");
        Console.WriteLine($"Nombre: {emp.Nombre}");
        emp.Edad();
        Console.WriteLine($"Antiguedad: {emp.Antiguedad().ToString()} años");
        Console.WriteLine($"Tiempo para la jubilacion: {emp.TiempoJubilacion()} años");
        emp.Sueldo();
    }
}

Console.WriteLine("FIN.");