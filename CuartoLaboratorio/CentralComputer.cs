using System;
namespace CuartoLaboratorio
{
    public abstract class CentralComputer 
    {
        abstract public string turnon();
        abstract public string turnoff();
        abstract public string restart();
        public void operationTurnon()
        {
            Console.WriteLine($"Encender maquina: {turnon()}");
        }
        public void operationRestart()
        {
            Console.WriteLine($"Reiniciar maquina: {restart()}");
        }
        public void operationTurnoff()
        {
            Console.WriteLine($"Apagar maquina: {turnoff()}");
        }
    }
}
