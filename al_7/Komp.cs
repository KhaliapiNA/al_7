using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace al_7
{
    class Komp
    {
        ZPU zpu = new ZPU();
        Pamyt pamyt = new Pamyt();
        Disk gos_disk = new Disk();
        Monitor monitor= new Monitor();

        public void LoadZPU()
        {
            zpu.OperationA();
            pamyt.OperationB();
            gos_disk.OperationC();
           
        }

        public void Print(char p)
        {
            monitor.Print(p);
        }
    }
    }

