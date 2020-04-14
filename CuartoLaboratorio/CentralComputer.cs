using System;
namespace CuartoLaboratorio
{
    public abstract class CentralComputer
    {
        abstract public string turnon();
        abstract public string turnoff();
        abstract public string restart();
        abstract public int GetMemory();
        abstract public int GetPiezas();
        public void operationTurnon()
        {
            Console.WriteLine($"Se ha encendido la maquina {turnon()}");
        }
        public void operationRestart(int piezas)
        {
            if (GetMemory() == 0)
            {
                Console.WriteLine($"Se ha reiniciado la maquina {restart()}");
            }
        }
        public void operationTurnoff()
        {
            Console.WriteLine($"Se apagado la maquina {turnoff()}");
        }
    }
}
