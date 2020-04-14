using System;
namespace CuartoLaboratorio
{
    public class Machine3 : CentralComputer, IAssembly
    {
        private int memorycapacity;
        private int piezas;
        public Machine3(int memorycapacity, int piezas)
        {
            this.memorycapacity = memorycapacity;
            this.piezas = piezas;
        }
        public override string turnon()
        {
            string message = $"de ensamblaje con una memoria de {memorycapacity}";
            return message;
        }
        public override string turnoff()
        {
            string message = "de ensamblaje";
            return message;
        }
        public override string restart()
        {
            string message = "de ensamblaje";
            return message;
        }
        public void Assembly()
        {
            Console.WriteLine($"Se ha ensamblado");
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
