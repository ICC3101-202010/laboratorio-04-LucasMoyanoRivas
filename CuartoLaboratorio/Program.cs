using System;

namespace CuartoLaboratorio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random number = new Random();
            int piezas;
            piezas = number.Next(5, 10);
            Machine1 machine1 = new Machine1(number.Next(5, 10), piezas);
            Machine2 machine2 = new Machine2(number.Next(5, 10), piezas);
            Machine3 machine3 = new Machine3(number.Next(5, 10), piezas);
            Machine4 machine4 = new Machine4(number.Next(5, 10), piezas);
            Machine5 machine5 = new Machine5(number.Next(5, 10), piezas);
            CentralComputer[] listmachine = {machine1, machine2, machine3, machine4, machine5};
            Console.WriteLine("Bienvenido a la fabrica");
            Console.WriteLine($"Hoy hay {piezas} piezas para trabajar");
            TurnOnlistmachine(listmachine);
            for (int i = 0; i < piezas; ++i)
            {
                Console.WriteLine($"Inicio de pieza numero {i+1}");
                if (listmachine[0].GetMemory() > 0)
                {
                    machine1.Reception();
                }
                if (listmachine[0].GetMemory() == 0)
                {
                    listmachine[0].operationRestart(piezas);
                }
                if (listmachine[1].GetMemory() > 0)
                {
                    machine2.Storage();
                }
                if (listmachine[1].GetMemory() == 0)
                {
                    listmachine[1].operationRestart(piezas);
                }
                if (listmachine[2].GetMemory() > 0)
                {
                    machine3.Assembly();
                }
                if (listmachine[2].GetMemory() == 0)
                {
                    listmachine[2].operationRestart(piezas);
                }
                if (listmachine[3].GetMemory() > 0)
                {
                    machine4.Check();
                }
                if (listmachine[3].GetMemory() == 0)
                {
                    listmachine[3].operationRestart(piezas);
                }
                if (listmachine[4].GetMemory() > 0)
                {
                    machine5.Packing();
                }
                if (listmachine[4].GetMemory() == 0)
                {
                    listmachine[4].operationRestart(piezas);
                }
                Console.WriteLine($"Lista pieza numero {i+1}");
            }
            Console.WriteLine("Trabajo terminado");
            Console.WriteLine("Momento de cerrar la fabrica");
            TurnOfflistmachine(listmachine);
        }
        private static void TurnOnlistmachine(CentralComputer[] listmachine)
        {
            for (int i = 0; i < listmachine.Length; ++i)
            {
                listmachine[i].operationTurnon();
            }
        }
            private static void TurnOfflistmachine(CentralComputer[] listmachine)
        {
            for (int i = 0; i < listmachine.Length; ++i)
            {
                listmachine[i].operationTurnoff();
            }
        }
    }
}
