using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_classes
{
    public class Honda : Car
    {
        private string makeModel = "Honda";

        private void AccessSpeed()
        {
            this.speed = 100;
        }

        private int getSpeed()
        {
            return this.speed*10;
        }
    }
}
