namespace operadorMaestro
{
using System;
using System.Globalization;
    class calculadora{
        static void Main(string[] args)
        {
            while (true) 
            {    
            float numero_1, numero_2;
            ObtenerNumeros(out numero_1, out numero_2);   
            while(true) 
                {
                    Console.WriteLine("Elija la operacion que desea realizar: Sumar '+', restar '-', multiplicar 'x', o dividir '/' ");
                    string operacion = Console.ReadLine();
                    switch (operacion)
                        {
                            case "+": 
                                MetodoSumar(numero_1, numero_2);
                            break;

                            case "-":
                                MetodoRestar(numero_1, numero_2);
                            break;

                            case  "x":
                            case  "X":
                            case  "*":
                                MetodoMultiplicar(numero_1, numero_2);
                            break;

                            case  "/":  
                                if(numero_2 == 0)
                                {
                                    Console.WriteLine("No se puede dividir un numero por 0");
                                }   
                                else
                                {
                                MetodoDividir(numero_1, numero_2);
                                }
                                
                            break;
                        
                            default: 
                            Console.WriteLine("No ha ingresado un valor correcto. Vuelva a intentarlo");                       
                            break;
                        }
                            string continuar;
                            while (true) 
                            {                   
                                Console.WriteLine("¿Desea realizar otra operación? (sí/no): ");
                                continuar = Console.ReadLine().ToLower();
                                if (continuar == "no" || continuar == "No" || continuar == "NO")
                                {
                                    Console.WriteLine("Gracias por usar nuestra calculadora");
                                    return; 
                                }
                                else if (continuar == "si" || continuar == "Si" || continuar == "sí" || continuar == "Sí" || continuar == "SÍ" )
                                {
                                    break;
                                }   
                                else
                                {
                                    Console.WriteLine("Entrada {0} no  es válida. Por favor, escriba 'sí' o 'no'.",continuar);
                                }
                            }

                            break;
                        
                }   
            }    
                
        }  
        
        
        public static void ObtenerNumeros(out float numero_1, out float numero_2)
        {
             
           while (true) 
           { 
                Console.WriteLine("INGRESE EL PRIMER NUMERO (MAYOR O IGUAL A 0): "); 
                numero_1 =  float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (numero_1 >=0) 
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("El número ingresado es menor que 0, vuelva a ingresar los numeros");
                    Console.WriteLine("");
                }
            }
            while (true) 
           { 
                        
                Console.WriteLine("INGRESE EL SEGUNDO NUMERO (MAYOR O IGUAL A 0): ");
                numero_2 =  float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                

                if (numero_2 >= 0) 
                {
                    break; // aqui le he puesto break ya que si ambos valores dan true se corta el bucle.
                }
                else
                {
                    Console.WriteLine("El número ingresado es menor que 0, vuelva a ingresar los numeros");
                    Console.WriteLine("");
                }
            }
        }

         public static void MetodoSumar(float n1, float n2){
            float suma = n1 + n2;
            Console.WriteLine($"El resultado de sumar {n1} mas {n2} es: {suma:F0}");
        } 

         public static void MetodoRestar(float n1, float n2){
            float resta = n1 - n2;
            Console.WriteLine("El resultado de restar {0} menos {1} es: {2:F0}",n1,n2,resta);
        }

        public static void MetodoMultiplicar(float n1, float n2){
            float multix = n1 * n2;
            Console.WriteLine("El resultado de multiplicar {0} por {1} es: {2:F0}",n1,n2,multix);
        }


        public static void MetodoDividir(float n1, float n2){
            float dividir = n1 / n2;
            Console.WriteLine("El resultado de dividir {0} por {1} es: {2:F2}",n1,n2,dividir);
        }

        }//LLAVE CALCULADORA 
}//LLAVE OPERADORMAESTRO

