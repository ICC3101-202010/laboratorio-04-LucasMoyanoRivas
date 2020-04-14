using System;
namespace CuartoLaboratorio
{
    public class Machine1 : CentralComputer, IReception
    {
        private int memorycapacity;
        private int piezas;
        private int memorycapacityinitial;
        public Machine1(int memorycapacity, int piezas)
        {
            this.memorycapacity = memorycapacity;
            this.piezas = piezas;
        }
        public override string turnon()
        {
            string message = $"de recepcion con una memoria de {memorycapacity}";
            memorycapacityinitial = memorycapacity;
            return message;
        }
        public override string turnoff()
        {
            string message = $"de recepcion";
            return message;
        }
        public override string restart()
        {
            string message = "de recepcion ";
            memorycapacity = memorycapacityinitial;
            return message;
        }
        public void Reception()
        {
            Console.WriteLine($"Se ha recepcionado");
            memorycapacity = memorycapacity - 1;
        }
        public override int GetMemory()
        {
            return memorycapacity;
        }
        public override int GetPiezas()
        {
            return piezas;
        }
    }
}
