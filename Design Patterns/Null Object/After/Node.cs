namespace Design.Patterns.NullObject.After {
    public class Node {
        public Node(Node left, Node right) {
            this.Left = left;
            this.Right = right;
        }

        private class NullNode : Node {
            private NullNode() { }

            public static NullNode Instance { get; } = new NullNode();

            public override Node Left => this;
            public override Node Right => this;
            public override int Height => 0;
        }

        static Node() {
            Empty = NullNode.Instance;
        }

        // Exists so that our NullNode node class can be instantiated.
        // Also note that trying to define the following constructor NullNode() : base(this, this)
        // is not possible because it doesn't compile.
        protected Node() { }

        public static readonly Node Empty;

        public virtual Node Left { get; }
        public virtual Node Right { get; }

        public virtual int Height {
            get {
                return 1 + this.Left.Height + this.Right.Height;
            }
        }
    }
}