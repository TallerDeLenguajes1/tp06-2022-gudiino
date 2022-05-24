using System;
public class Calculadora
{
    double resultado;
    public double Sumar(double termino)
    {
        return resultado+=termino;
    }
    public double Restar(double termino)
    {
        return resultado-=termino;
    }
    public double Multiplicar(double termino)
    {
        return resultado*=termino;
    }
    public double Dividir(double termino)
    {
        
        return resultado/termino;
    }
    public void Limpiar()
    {
        resultado=0;
    }
}