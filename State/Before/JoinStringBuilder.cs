using System.Text;

namespace State.Before {
    public class JoinStringBuilder {
        public JoinStringBuilder(char seperator) : this(new StringBuilder(), seperator) { }
        public JoinStringBuilder(StringBuilder sb, char seperator) {
            this.StringBuilder = sb;
            this.Seperator = seperator;

            this.IsFirstAppend = true;
        }

        public StringBuilder StringBuilder { get; }
        public char Seperator { get; }

        private bool IsFirstAppend { get; set; }

        public void Append(string value) {
            StringBuilder sb = this.StringBuilder;
            if (!this.IsFirstAppend) {
                sb.Append(this.Seperator);
            }
            else {
                this.IsFirstAppend = false;
            }
            sb.Append(value);
        }
    }
}