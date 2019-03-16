using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Composite {
    public static class Program {
        private static void Main(string[] args) {
            Example();
        }

        private static void Example() {
            var composite1 = new CompositeGraphic();
            composite1.Add(new Rectangle(new Point(3, 4), new Size(6, 1)));
            composite1.Add(new Ellipse(new Point(7, 8), 1, 1)); // a circle

            var composite2 = new CompositeGraphic();
            composite2.AddRange(new IGraphic[] {
                new Ellipse(new Point(1, 0), 6, 9),
                new Ellipse(new Point(0, -4), 3, 7),
                new Rectangle(new Point(5, 2), new Size(7, 4))
            });

            var composite3 = new CompositeGraphic();
            composite3.AddRange(new IGraphic[] {
                composite1,
                composite2
            });

            composite3.Draw();
        }
    }
}