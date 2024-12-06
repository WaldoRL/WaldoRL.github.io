using System.Security.Cryptography.X509Certificates;

public class Moto : IVehiculo
{
public void Arrancar()
{
    Console.WriteLine("la moto ha arrancado");
}
public void Apagar()
{
    Console.WriteLine("la moto se ha apagado!");
}
}