Calculadora calc=new Calculadora();
int opc=10;
double x;
while(opc!=0){
    Console.WriteLine("Seleccione el tipo de operacion que desea realizar y encadenar");
    Console.WriteLine("1-> SUMAR");
    Console.WriteLine("2-> RESTAR");
    Console.WriteLine("3-> MULTIPLICAR"); 
    Console.WriteLine("4-> DIVIDIR");
    Console.WriteLine("5-> LIMPIAR");
    Console.Write("Seleccion -> ");
    opc = Convert.ToInt32(Console.ReadLine());
    if(opc!=5){
        Console.WriteLine("Ingrese un número"); 
        x = Convert.ToDouble(Console.ReadLine());
    }
    // Console.WriteLine("Ingrese un número"); 
    // x = Convert.ToDouble(Console.ReadLine());
    double resultado;
    
    switch (opc)
    {
        case 1: 
            resultado = calc.Sumar(x);
            Console.WriteLine("Resultado con Suma: "+ resultado);
            break;
        case 2: 
            resultado = calc.Restar(x);
            Console.WriteLine("Resultado con Resta: "+ resultado);
            break;
        case 3: 
            resultado = calc.Multiplicar(x);
            Console.WriteLine("Resultado con Multiplicación: "+ resultado);
            break;
        case 4:
            if(x!=0){
                resultado = calc.Dividir(x);
                Console.WriteLine("Resultado con División: "+ Math.Round(resultado,2));
            }else{
                Console.WriteLine("ERROR: Ingrese un valor distinto a 0");
            }            
            break;
        case 5: 
            calc.Limpiar();
            Console.WriteLine("Memoria borrada.");
            break;
    }
    Console.WriteLine("¿Desea realizar otro calculo?");
    Console.WriteLine("0-> NO");
    Console.WriteLine("1-> SI"); 
    opc = Convert.ToInt32(Console.ReadLine());
}