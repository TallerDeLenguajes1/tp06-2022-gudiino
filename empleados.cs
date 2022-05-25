using System;
public class Empleado
{
    public string Nombre;
    public string Apellido;
    DateTime FecNac;
    public char EstadoCivil;
    public char Genero;
    public DateTime FecIngreso;
    public double SueldoBruto;
    enum Cargo
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    public void Antiguedad()
    {
        DateTime actual = DateTime.Now;
        var antiguedad = actual - FecIngreso;
        int anios = (int)(antiguedad.TotalDays / 365.25);
        int meses = (int)(((antiguedad.TotalDays / 365.25) - anios) * 12);
        Console.WriteLine($"Antiguedad: {anios} años {(meses > 0 ? $"y {meses} meses" : "")}");
    }
    public void Edad()
    {
        DateTime actual = DateTime.Now;
        var edad = actual - FecIngreso;
        int anios = (int)(edad.TotalDays / 365.25);
        Console.WriteLine($"Edad: {anios} años");
    }
    public void TiempoJubilacion()
    {
        DateTime actual = DateTime.Now;
        var edad = actual - FecIngreso;
        int anios = (int)(edad.TotalDays / 365.25);
        int aniosJubilacion;
        if(Genero=='F'){
            aniosJubilacion=60-anios;
        }else{
            aniosJubilacion=65-anios;
        }
        if(aniosJubilacion>0){
            Console.WriteLine($"Tiempo faltante para la edad jubilatoria: {anios} años");
        }else{
            Console.WriteLine("Empleado con edad cumplida para jubilarse");
        }
        
    }


}