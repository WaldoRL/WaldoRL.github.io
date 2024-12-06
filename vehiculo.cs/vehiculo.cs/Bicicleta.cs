public class Bicicleta : IVehiculo
{
    public void Arrancar()
    {
        Console.WriteLine("La bicicleta ha arrancado.");
    }

    public void Apagar()
    {
        Console.WriteLine("La bicicleta se ha detenido.");
    }
}
