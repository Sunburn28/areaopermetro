int apo;
int l;
int peri;
int peri2;
int a;
int op;

Console.WriteLine("¿Que deseas calcular del poligono? \n1.- Area \n2.- Perimetro");
op=int.Parse(Console.ReadLine());

switch (op)
{
    case 1:
        Console.WriteLine("Ingresa el perimetro del poligono");
        peri2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el apotema del poligono");
        apo = int.Parse(Console.ReadLine());
        a = (peri2 * apo) / 2;
        Console.WriteLine("El area del poligono es: " + a + "cm^2");
        break;
    
    case 2:
        Console.WriteLine("Ingresa el valor de un lado del poligono");
            l = int.Parse(Console.ReadLine());
        peri = 5 * l;
        Console.WriteLine("El perimetro del poligono es: " + peri);
        break;
}
