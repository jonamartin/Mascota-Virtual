using System;
using Mascota_Virtual;

class Mascota 
{
    public bool alimentado {get; set;}
    public bool durmiendo {get; set;}
    public Mascota()
    {
        alimentado = true;
        durmiendo = false;
    }

    public bool alimentar()
    {
        if(durmiendo == false)
        {
            if (alimentado == false){
                Console.WriteLine("Estoy comiendo");
                alimentado = true;
            }
            else {
                Console.WriteLine("No puedo comer, necesito ir al baño");
            }
        }
        else{
            Console.WriteLine("No puedo comer, estoy durmiendo");
        }
        return alimentado;
    }
    public bool jugar(){
        if(durmiendo == false){
            if(alimentado == true){
                Console.WriteLine("Estoy jugando");
                alimentado = false;
            }
            else{
                Console.WriteLine("No puedo jugar, tengo que comer");
            }
        }
        else{
            Console.WriteLine("No puedo jugar, estoy durmiendo.");
        }
        return alimentado;
    }

    public void irBanio(){
        if(durmiendo == false){
            Console.WriteLine("Estoy yendo al baño");
        }
        else{
            Console.WriteLine("Estoy durmiendo, no puedo ir al baño");
        }
    }

    public bool dormir(){
        if(durmiendo==false){
            Console.WriteLine("Voy a dormir");
            durmiendo = true;
        }
        else{
            Console.WriteLine("Ya estoy durmiendo. Intenta despertarme");
        }
        return durmiendo;
    }

    public bool despertarse(){
        if(durmiendo == true){
            Console.WriteLine("Me desperté");
            durmiendo = false;
        }
        else{
            Console.WriteLine("No estaba durmiendo");
        }
        return durmiendo;
    }

}


