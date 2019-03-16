using System.Collections.Generic;

namespace Composite {
    // Composite
    public class CompositeGraphic : IGraphic {
        private List<IGraphic> Graphics { get; }

        public CompositeGraphic() {
            this.Graphics = new List<IGraphic>();
        }

        public void Add(IGraphic graphic) {
            this.Graphics.Add(graphic);
        }

        public void AddRange(params IGraphic[] graphic) {
            this.Graphics.AddRange(graphic);
        }

        public void Remove(IGraphic graphic) {
            this.Graphics.Remove(graphic);
        }

        public void RemoveAt(int index) {
            this.Graphics.RemoveAt(index);
        }

        public void Draw() {
            foreach (IGraphic childGraphic in this.Graphics) {
                childGraphic.Draw();
            }
        }
    }
}