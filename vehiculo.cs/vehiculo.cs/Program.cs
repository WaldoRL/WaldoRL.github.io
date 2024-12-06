using System;

class Program
{
    static void Main(string[] args)
    {
        IVehiculo miCoche = new Coche();
        miCoche.Arrancar();
        miCoche.Apagar();

        IVehiculo miBicicleta = new Bicicleta();
        miBicicleta.Arrancar();
        miBicicleta.Apagar();

        IVehiculo miMoto = new Moto();
        miMoto.Arrancar();
        miMoto.Apagar();
    }
}
