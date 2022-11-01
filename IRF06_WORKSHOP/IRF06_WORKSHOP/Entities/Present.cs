using IRF06_WORKSHOP.Abstraction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF06_WORKSHOP.Entities
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }

        public Present(Color box, Color ribbon)
        {
            BoxColor = new SolidBrush(box);
            RibbonColor = new SolidBrush(ribbon);
        }

        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor,0,0,Width,Height);
            g.FillRectangle(RibbonColor, 0, Height*1/4, Width, Height*3/4);
            g.FillRectangle(RibbonColor, Width*1/4, 0, Width*3/4, Height);
        }
    }
}
