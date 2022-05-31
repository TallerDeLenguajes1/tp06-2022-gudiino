using System;
public class Emplea2
{
    public string Nombre;//declaracion: acceso tipo nomVar
    public string Apellido;
    public DateTime FecNac;
    public string EstadoCivil;
    public char Genero;
    public DateTime FecIngreso;
    public double SueldoBasico;
    
    public enum Cargos{Auxiliar,Administrativo,Ingeniero,Especialista,Investigador};
    public int cargo;
    public Emplea2(string nom, string ape, DateTime fec, string civ, char gne, DateTime fecing, double salario, int carg){
        Nombre=nom;
        Apellido=ape;
        FecNac=fec;
        EstadoCivil=civ;
        Genero=gne;
        FecIngreso=fecing;
        SueldoBasico=salario;
        cargo=carg;
    }
    public int Antiguedad()
    {
        DateTime actual = DateTime.Now;
        var antiguedad = actual - FecIngreso;
        int anios = (int)(antiguedad.TotalDays / 365.25);
        //int meses = (int)(((antiguedad.TotalDays / 365.25) - anios) * 12);
        //Console.WriteLine($"Antiguedad: {anios} años {(meses > 0 ? $"y {meses} meses" : "")}");
        return anios;
    }
    public void Edad()
    {
        DateTime actual = DateTime.Now;
        var edad = actual - FecNac;
        int anios = (int)(edad.TotalDays / 365.25);
        Console.WriteLine($"Edad: {anios} años");
    }
    public int TiempoJubilacion()
    {
        DateTime actual = DateTime.Now;
        var edad = actual - FecNac;
        int anios = (int)(edad.TotalDays / 365.25);
        int aniosJubilacion;
        if(Genero=='F'){
            aniosJubilacion=60-anios;
        }else{
            aniosJubilacion=65-anios;
        }
        // if(aniosJubilacion>0){
        //     Console.WriteLine($"Tiempo faltante para la edad jubilatoria: {anios} años");
        // }else{
        //     Console.WriteLine("Empleado con edad cumplida para jubilarse");
        // }
        return aniosJubilacion;       
    }
    public void Sueldo()
    {//sueldo = sueldo basico + adicional
        double PlusA, PlusC, PlusCo, total=0;
        int anios = Antiguedad();
        Console.WriteLine("Sueldo Basico:............. "+ SueldoBasico + " $");
        if(anios>20){
            PlusA=0.25*SueldoBasico;
            total+=PlusA;
            Console.WriteLine("Ajuste Antiguedad:......... "+PlusA+" $");
        }else{
            PlusA=0.01*anios*SueldoBasico;
            total+=PlusA;
            Console.WriteLine("Ajuste Antiguedad:......... "+PlusA+" $");
        }
        if(cargo==(int)Cargos.Especialista || cargo==(int)Cargos.Ingeniero){
            PlusC=0.5*PlusA;
            total+=PlusC;
            Console.WriteLine("Ajuste por Cargo:.......... "+PlusC+" $");
        }
        if(EstadoCivil=="C"){
            PlusCo=15000;
            total+=PlusCo;
            Console.WriteLine("Ajuste por Conyuge:........ "+PlusCo+" $");
        }
        Console.WriteLine("Total Sueldo:.............. "+Math.Round((total+SueldoBasico),2)+" $");
    }
    public void MostrarDatos()
    {
        Console.WriteLine($"Apellido: {Apellido}");
        Console.WriteLine($"Nombre: {Nombre}");
        Edad();
        Console.WriteLine($"Antiguedad: {Antiguedad().ToString()} años");
        Console.WriteLine($"Tiempo para la jubilacion: {TiempoJubilacion()} años");
    }


}
// public class Directivos : Emplea2
// {
//     // Los campos, las propiedades, los métodos y los eventos de los empleados se heredan
//     // Los nuevos campos, propiedades, métodos y eventos del administrador van aquí...
//     public enum Puesto{Gerente, Accionista};
//     public int cargo2;
// }