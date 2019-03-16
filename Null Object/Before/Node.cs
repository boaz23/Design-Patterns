namespace Design.Patterns.NullObject.Before {
    public class Node {
        public Node(Node left, Node right) {
            this.Left = left;
            this.Right = right;
        }

        public Node Left { get; }
        public Node Right { get; }

        public int Size {
            get {
                int size = 1;
                if (this.Left != null) {
                    size += this.Left.Size;
                }
                if (this.Right != null) {
                    size += this.Right.Size;
                }

                return size;
            }
        }
    }
}