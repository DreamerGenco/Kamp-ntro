﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Gun_5_Odev_2
{
    internal class ProjectManager
    {
      public void Add(IPersonManager personManager)
        {
            personManager.Add();
           

        }
    }
}
