using System;

namespace Figuras
{
    class figurasap
    {
        private string figura;
        private double bas;
        private double altura;
        private double area;
        private double perimetro;

        public string Figura
        {
            get { return figura; }
            set { figura = value; }
        }

        public double Bas
        {
            get { return bas; }
            set { bas = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public double Perimetro
        {
            get { return perimetro; }
            set { perimetro = value; }
        }

        public bool calculadora()
        {
                Console.WriteLine("Por favor indique la figura que va a calcular: (1) Circulo. (2) Cuadrado. (3) Rectangulo. (4) Triangulo. (5) Elipse. : ");
                figura = Console.ReadLine();

                if (figura == "Circulo" || figura == "circulo")
                {
                    Console.WriteLine("Ingrese el radio: ");
                    bas = int.Parse(Console.ReadLine());

                    area = Math.PI * bas;
                    perimetro = 2 * Math.PI * bas;
                                    Console.WriteLine("El area del circulo es de: "+ area );
                                    Console.WriteLine("El perimetro del circulo es de: "+ perimetro );
                                    return true;
                }
                else
                {
                    if  (figura == "Cuadrado" || figura == "cuadrado")
                    {
                        Console.WriteLine("Ingrese cuanto mide un lado: ");
                        bas = int.Parse(Console.ReadLine());

                        area = bas * bas;
                        perimetro = bas * 4;
                                    Console.WriteLine("El area del cuadrado es de: "+ area );
                                    Console.WriteLine("El perimetro del cuadrado es de: "+ perimetro );
                                    return true;
                    }
                    else
                    {
                        if (figura == "Rectangulo" || figura == "rectangulo")
                        {
                            Console.WriteLine("Ingrese la base: ");
                            bas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la altura: ");
                            altura = int.Parse(Console.ReadLine());

                            area = bas * altura;
                            perimetro = bas + altura + altura + bas;
                                    Console.WriteLine("El area del Rectangulo es de: "+ area );
                                    Console.WriteLine("El perimetro del Rectangulo es de: "+ perimetro );
                                    return true;
                        }
                        else
                        {
                            if (figura == "Triangulo" || figura == "triangulo")
                            {
                                Console.WriteLine("Ingrese la base: ");
                                bas = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese la altura: ");
                                altura = int.Parse(Console.ReadLine());

                                area = bas * altura / 2;
                                perimetro = bas + altura + altura;
                                    Console.WriteLine("El area del triangulo es de: "+ area );
                                    Console.WriteLine("El perimetro del triangulo es de: "+ perimetro );
                                    return true;
                            }
                            else
                            {
                                if (figura == "Elipse" || figura == "elipse")
                                {
                                    Console.WriteLine("Ingrese el semieje mayor: ");
                                    bas = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese el semieje menor: ");
                                    altura = int.Parse(Console.ReadLine());

                                    area = Math.PI * bas * altura;
                                    perimetro = 2 * Math.PI * Math.Sqrt((Math.Pow(bas,2) + Math.Pow(altura,2)) / 2);
                                                 Console.WriteLine("El area del elipse es de: "+ area );
                                                 Console.WriteLine("El perimetro del elipse es de: "+ perimetro );
                                                 return true;
                                }
                                else { Console.WriteLine("Debe elegir una opción válida :) "); return false; }
                            }
                        }
                    }
                }
        }
    }
}