using System;
namespace CuartoLaboratorio
{
    public class Machine2 : CentralComputer, IStorage
    {
        private int memorycapacity;
        private int piezas;
        public Machine2(int memorycapacity, int piezas)
        {
            this.memorycapacity = memorycapacity;
            this.piezas = piezas;
        }
        public override string turnon()
        {
            string message = $"de almacenamiento con una memoria de {memorycapacity}";
            return message;
        }
        public override string turnoff()
        {
            string message = "de almacenamiento";
            return message;
        }
        public override string restart()
        {
            string message = "de almacenamiento";
            return message;
        }
        public void Storage()
        {
            Console.WriteLine($"Se ha almacenado");
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
