using System;

namespace Mascota_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
           Mascota pet = new Mascota();
           pet.dormir();
           pet.despertarse();
           pet.jugar();
           pet.alimentar();
           pet.irBanio();
        }
    }
}
