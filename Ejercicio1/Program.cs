using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] empleados = new string[5,6]
            {

                {"100","Empleado","Silvio","10/08/2001","0","0"},
                {"101","Empleado","Gaston","10/08/2001","0","0"},
                {"102","Supervisor","Daniel","10/08/2001","2","0"},
                {"103","Empleado","Laura","10/08/2001","0","0"},
                {"104","Encargado Regional","Daniela","10/08/2001","4","0"}
            };

            bool seguir = true;

            while (seguir == true)
            {
                Console.WriteLine("Bienvenidos al programa");
                Console.WriteLine("\nOpcion 1: Listar Personal -- Opcion 2: Ascender persona -- Opcion 3: Salir del programa");
                Console.WriteLine("Ingrese el numero de la opcion que desee asceder");
                string ingreso = Console.ReadLine();
                Console.WriteLine("-------------------------");

                switch (ingreso)
                {
                    case "1":
                        for (int i = 0; i < 5; i++)
                        {
                            if (empleados[i,1].Equals("Empleado"))
                            {
                                Console.WriteLine($"Id: {empleados[i, 0]} \nCargo: {empleados[i, 1]} \nNombre: {empleados[i, 2]} \nFecha: {empleados[i, 3]}");
                                Console.WriteLine("-------------------------");
                            }else if (empleados[i, 1].Equals("Supervisor"))
                            {
                                Console.WriteLine($"Id: {empleados[i, 0]} \nCargo: {empleados[i, 1]} \nNombre: {empleados[i, 2]} \nFecha: {empleados[i, 3]} \nEmpleados a cargo: {empleados[i, 4]}");
                                Console.WriteLine("-------------------------");
                            }
                            else if (empleados[i, 1].Equals("Encargado Regional"))
                            {
                                Console.WriteLine($"Id: {empleados[i, 0]} \nCargo: {empleados[i, 1]} \nNombre: {empleados[i, 2]} \nFecha: {empleados[i, 3]} \nSucursales a cargo: {empleados[i, 5]}");
                                Console.WriteLine("-------------------------");
                            }
                            
                        }
                        break;
                    case "2":
                        Console.WriteLine("A que empleado desea ascender, Esriba su id");
                        string ascendido = Console.ReadLine();

                        for (int i = 0; i < 5; i++)
                        {
                            if (empleados[i, 0].Equals(ascendido))
                            {
                                if (empleados[i, 1] == "Empleado")
                                {
                                    Console.WriteLine("Cuantos empleados tiene a su cargo");
                                    string pesonas = Console.ReadLine();
                                    empleados[i, 4] = pesonas;
                                    empleados[i, 1] = "Supervisor";
                                    Console.WriteLine("-------------------------");
                                    break;
                                }
                                else if (empleados[i, 1] == "Supervisor")
                                {
                                    Console.WriteLine("Cuantas sucursales tiene a su cargo");
                                    string sucursales = Console.ReadLine();
                                    empleados[i, 5] = sucursales;
                                    empleados[i, 1] = "Encargado Regional";
                                    Console.WriteLine("-------------------------");
                                    break;
                                }
                                else if (empleados[i, 1].Equals("Encargado Regional"))
                                {
                                    Console.WriteLine("No se puede ascender a mas cargos");
                                    Console.WriteLine("-------------------------");
                                    break;
                                }
                            }
                        }
                        break;
                    case "3":
                        seguir = false;
                        break;
                }
            }
            


        }
    }
}
