using IRF_ZH2_GYAK.Abstraction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_ZH2_GYAK.Entities
{
    public class Drink : Product
    {
        protected override void Display()
        {
            BackColor = Color.LightBlue;
        }
    }
}
