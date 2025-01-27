using PracticaOopPolimorfsmo;
class Program
{
    static void Main(string[] args)
    {
      EmpleadoPorHora empleado2 = new EmpleadoPorHora("Yeliana", "Bencosme", "212-321-4444", 45);
      EmpleadoAdministrativo empleado1 = new EmpleadoAdministrativo("Wilfredo", "Ramirez", "213-33,2342", 6000m, false);
      EmpleadoPorContrato empleado3 = new EmpleadoPorContrato("Estimado", "Gonzales", "123-1223-21", 4000m, true);
        
        //Empleado por hora
        Console.WriteLine(empleado2);
        Console.WriteLine($"Salario calculado: {empleado2.CalcularSalario()}");
        Console.WriteLine("-------------------------------------------------");

        //Empleado Administrativo
        Console.WriteLine(empleado1);
        Console.WriteLine($"Salario acumulado: {empleado1.CalcularSalario()}");
        Console.WriteLine("-------------------------------------------------");

        //Empleado por contractos
        Console.WriteLine(empleado3);
        Console.WriteLine($"Salario acumulado: {empleado3.CalcularSalario()}");
        Console.WriteLine("-------------------------------------------------");
    }
}