// See https://aka.ms/new-console-template for more information
float tempF, tempC;
bool flag;

float conversion(float tempC)
{
    return (9 * tempC + 160) / 5;
}

do{
    Console.WriteLine("Digite a temperatura em graus Celsius: ");
    flag = float.TryParse(Console.ReadLine().Replace(".", ","), out tempC);
    if (!flag){
        Console.WriteLine("Formato inválido, digite apenas números"); 
    }
} while (!flag);

tempF = conversion(tempC);

Console.WriteLine("A temperatura em Fahrenheit é: " + tempF);