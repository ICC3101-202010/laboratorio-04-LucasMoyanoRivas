using System;
namespace CuartoLaboratorio
{
    public class Machine2 : CentralComputer, IStorage
    {
        private int memorycapacity;
        public Machine2(int memorycapacity)
        {
            this.memorycapacity = memorycapacity;
        }
        public override string turnon()
        {
            string message = "Se ha encendido la maquina de almacenamiento";
            return message;
        }
        public override string turnoff()
        {
            string message = "Se ha apagado la maquina de almacenamiento";
            return message;
        }
        public override string restart()
        {
            string message = "Se ha reiniciado la maquina de almacenamiento";
            return message;
        }
        public void Storage(Machine1 machine)
        {

        }
    }
}
