using System;
namespace CuartoLaboratorio
{
    public class Machine1 : CentralComputer, IMemory, IReception
    {
        private int piezas;
        private int memorycapacity;
        public Machine1(int piezas, int memorycapacity)
        {
            this.piezas = piezas;
            this.memorycapacity = memorycapacity;
        }
        public override string turnon()
        {
            throw new NotImplementedException();
        }
        public override string turnoff()
        {
            throw new NotImplementedException();
        }
        public override string restart()
        {
            throw new NotImplementedException();
        }
        public void Reception(int piezas)
        {

        }
        public void memory(int memorycapacity)
        {

        }
    }
}
