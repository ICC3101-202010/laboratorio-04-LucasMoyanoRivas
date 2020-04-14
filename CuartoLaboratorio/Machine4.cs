using System;
namespace CuartoLaboratorio
{
    public class Machine4 : CentralComputer, ICheck
    {
        private int memorycapacity;
        private int piezas;
        public Machine4(int memorycapacity, int piezas)
        {
            this.memorycapacity = memorycapacity;
            this.piezas = piezas;
        }
        public override string turnon()
        {
            string message = $"de verificacion con una memoria de {memorycapacity}";
            return message;
        }
        public override string turnoff()
        {
            string message = "de verificacion";
            return message;
        }
        public override string restart()
        {
            string message = "de verificacion";
            return message;
        }
        public void Check()
        {
            Console.WriteLine($"Se ha verificado");
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
