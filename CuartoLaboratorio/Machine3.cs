using System;
namespace CuartoLaboratorio
{
    public class Machine3 : CentralComputer, IAssembly
    {
        private int memorycapacity;
        public Machine3(int memorycapacity)
        {
            this.memorycapacity = memorycapacity;
        }
        public override string turnon()
        {
            string message = "Se ha encendido la maquina de ensamblaje";
            return message;
        }
        public override string turnoff()
        {
            string message = "Se ha apagado la maquina de ensamblaje";
            return message;
        }
        public override string restart()
        {
            string message = "Se ha reiniciado la maquina de ensamblaje";
            return message;
        }
        public void Assembly(Machine2 machine2)
        {

        }
    }
}
