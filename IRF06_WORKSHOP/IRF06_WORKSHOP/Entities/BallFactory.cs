using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF06_WORKSHOP.Entities
{
    internal class BallFactory
    {
        public Ball CreateBall()
        {
            return new Ball();
        }
    }
}
