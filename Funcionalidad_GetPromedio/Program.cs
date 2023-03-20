// See https://aka.ms/new-console-template for more information
using Funcionalidad_GetPromedio.Contratos;

List<string> listAgents = new List<string>() { "A", "B", "C" };
string agent;
List<int> numbers = null;
int size = 0;

Console.WriteLine("Seleccione A) Agente A. B) Agente B. C) Agente C: ");
agent = Console.ReadLine();

if(listAgents.Exists(a => a  == agent.ToUpper())) 
{
    Console.WriteLine("Ingrese el tamaño de lista de números (debe ser mayor a 0 y menor o igual a 100): ");
    int.TryParse(Console.ReadLine(), out size);
    if(size > 0 && size <= 100) 
    {
        numbers = new Media().numberRandom(size);
        Console.WriteLine("La lista autogenerada es: ");
        for(int i = 0; i < numbers.Count(); i++) 
        {
            if(i == numbers.Count() - 1)
                Console.WriteLine(numbers[i]+". ");
            else
                Console.Write(numbers[i]+", ");
        }
        Console.WriteLine("El agente seleccionado " + agent.ToUpper() + ", usó el metodo: " + new Media().ResultMethod(agent.ToUpper()) + ", y su resultado es: " + new Media().GetMedia(agent.ToUpper(), numbers));
    }
    else 
    {
        Console.WriteLine("No elegiste un tamaño válido.");
    }
}
else 
{
    Console.WriteLine("No elegiste un agente válido.");
}

Console.ReadKey();




