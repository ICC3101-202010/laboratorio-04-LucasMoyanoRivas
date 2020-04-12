using System;
namespace CuartoLaboratorio
{
    public class Machine3 : CentralComputer, IMemory, IAssembly
    {
        private int memorycapacity;
        public Machine3(int memorycapacity)
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
        public void Assembly(Machine2 machine2)
        {

        }
        public void memory(int memorycapacity)
        {

        }
    }
}
