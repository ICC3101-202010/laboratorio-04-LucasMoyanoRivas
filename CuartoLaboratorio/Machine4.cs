using System;
namespace CuartoLaboratorio
{
    public class Machine4 : CentralComputer, IMemory, ICheck
    {
        private int memorycapacity;
        public Machine4(int memorycapacity)
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
        public void Check(Machine3 machine3)
        {

        }
        public void memory(int memorycapacity)
        {

        }
    }
}
