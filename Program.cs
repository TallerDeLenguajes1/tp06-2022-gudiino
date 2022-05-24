Calculadora calc=new Calculadora();
int opc=10;
double x;
Console.WriteLine("Seleccione el tipo de operacion que desea realizar y encadenar");
while(opc!=0){
    Console.WriteLine("..........................");
    Console.WriteLine("1-> SUMAR");
    Console.WriteLine("2-> RESTAR");
    Console.WriteLine("3-> MULTIPLICAR"); 
    Console.WriteLine("4-> DIVIDIR");
    Console.WriteLine("5-> LIMPIAR");
    Console.Write("Seleccion -> ");
    opc = Convert.ToInt32(Console.ReadLine());
    double resultado;
    switch (opc)
    {
        case 1: 
            Console.WriteLine("..........................");
            Console.WriteLine("SUMAR");
            Console.Write("Ingrese un número -> "); 
            x = Convert.ToDouble(Console.ReadLine());
            resultado = calc.Sumar(x);
            Console.WriteLine("Resultado con Suma: "+ resultado);
            break;
        case 2:
            Console.WriteLine(".........................."); 
            Console.WriteLine("RESTAR");
            Console.Write("Ingrese un número -> "); 
            x = Convert.ToDouble(Console.ReadLine());
            resultado = calc.Restar(x);
            Console.WriteLine("Resultado con Resta: "+ resultado);
            break;
        case 3:
            Console.WriteLine("..........................");
            Console.WriteLine("MULTIPLICAR");
            Console.Write("Ingrese un número -> "); 
            x = Convert.ToDouble(Console.ReadLine());
            resultado = calc.Multiplicar(x);
            Console.WriteLine("Resultado con Multiplicación: "+ resultado);
            break;
        case 4:
            Console.WriteLine("..........................");
            Console.WriteLine("DIVIDIR");
            Console.Write("Ingrese un número -> "); 
            x = Convert.ToDouble(Console.ReadLine());
            if(x!=0){
                resultado = calc.Dividir(x);
                Console.WriteLine("Resultado con División: "+ Math.Round(resultado,2));
            }else{
                Console.WriteLine("ERROR: Ingrese un valor distinto a 0");
            }            
            break;
        case 5:
            Console.WriteLine("..........................");
            Console.WriteLine("LIMPIAR");
            calc.Limpiar();
            Console.WriteLine("Memoria borrada.");
            break;
    }
    Console.WriteLine("................................");
    Console.WriteLine("¿Desea realizar otro operación?");
    Console.WriteLine("0-> NO");
    Console.WriteLine("1-> SI");
    Console.Write("Seleccion -> ");
    opc = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("FIN.");