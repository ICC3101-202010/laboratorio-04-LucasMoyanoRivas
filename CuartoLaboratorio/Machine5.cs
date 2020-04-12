using System;
namespace CuartoLaboratorio
{
    public class Machine5 : CentralComputer, IMemory, IPacking
    {
        private int memorycapacity;
        public Machine5(int memorycapacity)
        {
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
        public void Packing(Machine4 machine4)
        {

        }
        public void memory(int memorycapacity)
        {

        }
    }
}
