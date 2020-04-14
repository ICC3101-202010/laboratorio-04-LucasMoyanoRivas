using System;
namespace CuartoLaboratorio
{
    public class Machine5 : CentralComputer, IPacking
    {
        private int memorycapacity;
        private int piezas;
        public Machine5(int memorycapacity, int piezas)
        {
            this.memorycapacity = memorycapacity;
            this.piezas = piezas;
        }
        public override string turnon()
        {
            string message = $"de empaque con una memoria de {memorycapacity}";
            return message;
        }
        public override string turnoff()
        {
            string message = "de empaque";
            return message;
        }
        public override string restart()
        {
            string message = "de empaque";
            return message;
        }
        public void Packing()
        {
            Console.WriteLine($"Se ha empacado");
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
