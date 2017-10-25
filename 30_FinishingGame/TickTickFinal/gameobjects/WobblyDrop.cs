using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

class WobblyDrop : WaterDrop
{
    override public void MoveDrop()
    {
        int counter = 0, difference = 1;
        if (counter > 0 && counter < 10)
        {
            counter += difference;
            position.X += 2 * difference;
        }else
        {
            difference *= -1;
        }
    }
}

