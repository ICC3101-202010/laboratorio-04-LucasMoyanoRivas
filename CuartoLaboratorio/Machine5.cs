using System;
namespace CuartoLaboratorio
{
    public class Machine5 : CentralComputer, IPacking
    {
        private int memorycapacity;
        public Machine5(int memorycapacity)
        {
            this.memorycapacity = memorycapacity;
        }
        public override string turnon()
        {
            string message = "Se ha encendido la maquina de empaque";
            return message;
        }
        public override string turnoff()
        {
            string message = "Se ha apagado la maquina de empaque";
            return message;
        }
        public override string restart()
        {
            string message = "Se ha reiniciado la maquina de empaque";
            return message;
        }
        public void Packing(Machine4 machine4)
        {

        }
    }
}
