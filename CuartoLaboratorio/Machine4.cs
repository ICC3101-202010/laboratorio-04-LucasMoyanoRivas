using System;
namespace CuartoLaboratorio
{
    public class Machine4 : CentralComputer, ICheck
    {
        private int memorycapacity;
        public Machine4(int memorycapacity)
        {
            this.memorycapacity = memorycapacity;
        }
        public override string turnon()
        {
            string message = "Se ha encendido la maquina de verificacion";
            return message;
        }
        public override string turnoff()
        {
            string message = "Se ha apagado la maquina de verificacion";
            return message;
        }
        public override string restart()
        {
            string message = "Se ha reiniciado la maquina de verificacion";
            return message;
        }
        public void Check(Machine3 machine3)
        {

        }
    }
}
