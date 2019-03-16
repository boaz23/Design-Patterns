namespace Design.Patterns.NullObject.Before {
    public class Node {
        public Node(Node left, Node right) {
            this.Left = left;
            this.Right = right;
        }

        public Node Left { get; }
        public Node Right { get; }

        public int Height {
            get {
                int height = 1;
                if (this.Left != null) {
                    height += this.Left.Height;
                }
                if (this.Right != null) {
                    height += this.Right.Height;
                }

                return height;
            }
        }
    }
}