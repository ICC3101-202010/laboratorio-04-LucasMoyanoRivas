using System;
namespace CuartoLaboratorio
{
    public class Machine2 : CentralComputer, IMemory, IStorage
    {
        private int memorycapacity;
        public Machine2(int memorycapacity)
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
        public void Storage(Machine1 machine1)
        {

        }
        public void memory(int memorycapacity)
        {

        }
    }
}
