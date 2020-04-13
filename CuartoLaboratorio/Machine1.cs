using System;
namespace CuartoLaboratorio
{
    public class Machine1 : CentralComputer, IReception
    {
        private int memorycapacity;
        public Machine1(int memorycapacity)
        {
            this.memorycapacity = memorycapacity;
        }
        public override string turnon()
        {
            string message = "Se ha encendido la maquina de recepcion";
            return message;
        }
        public override string turnoff()
        {
            string message = "Se ha apagado la maquina de recepcion";
            return message;
        }
        public override string restart()
        {
            string message = "Se ha reiniciado la maquina de recepcion";
            return message;
        }
        public void Reception()
        {

        }
    }
}
