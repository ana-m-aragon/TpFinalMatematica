



int opcion = 0, i=0, numero=0, diferencia=0, razon=0, tope=0, resultado=0;


Console.WriteLine("Elija una opcion presionando el numero por teclado \n 1.Aritmetica \n 2.Geometrica \n 3.Conjuntos");
opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    //artimetica 
    case 1:

        Console.WriteLine("Ingrese el primer termino");
        numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la diferencia");
        diferencia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Cuantos numeros desea");
        tope = Convert.ToInt32(Console.ReadLine());

        for (i=0; i < tope; i++)
        {
           //Crear vector, este for calcula los elementos de la sucesion y el usurio elige el tope
           numero += diferencia;
            Console.WriteLine(resultado);
        }

        break;
    // geometrica 
    case 2:
        break;
    //conjuntos    
    case 3:
        break;
}
    

