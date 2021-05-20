using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Test
{
    //Our laptop is the best example for the data abstration we don't need turn on bios, moniter, cpu, fan etc
    //Just we need to turn on the power
    //We don't have the rights to access the remainining process
    class AbstrationExample
    {
        private void processBIOS()
        {
            Console.WriteLine("BIOS is started....");
            Thread.Sleep(3000);
        }
        private void processCPU()
        {
            Console.WriteLine("CPU is started.....");
            Thread.Sleep(3000);
        }
        private void processFan()
        {
            Console.WriteLine("Cooling fan is Turning on....");
            Thread.Sleep(3000);
        }
        private void moniter()
        {
            Console.WriteLine("Turning on moniter");
            Thread.Sleep(3000);

        }
        private void processDisk()
        {
            Console.WriteLine("Disk is processing.....");
            Thread.Sleep(3000);
            Console.WriteLine("Processing is done");
            Thread.Sleep(3000);
        }
        public void powerOn()
        {
            processBIOS();
            processCPU();
            processFan();
            moniter();
            processDisk();
            Console.WriteLine("Booting is started");
        }
    }
}
