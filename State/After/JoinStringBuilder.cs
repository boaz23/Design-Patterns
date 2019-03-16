using System.Text;

namespace State.After {
    public class JoinStringBuilder {
        private interface IAppendState {
            void Append(string value);
        }

        private class FirstAppendState : IAppendState {
            public FirstAppendState(JoinStringBuilder joinStringBuilder) {
                this.JoinStringBuilder = joinStringBuilder;
            }

            public JoinStringBuilder JoinStringBuilder { get; }

            public void Append(string value) {
                this.JoinStringBuilder.StringBuilder.Append(value);
                this.JoinStringBuilder.AppendState = new NormalAppendState(this.JoinStringBuilder);
            }
        }

        private class NormalAppendState : IAppendState {
            public NormalAppendState(JoinStringBuilder joinStringBuilder) {
                this.JoinStringBuilder = joinStringBuilder;
            }

            public JoinStringBuilder JoinStringBuilder { get; }

            public void Append(string value) {
                this.JoinStringBuilder.StringBuilder.Append(this.JoinStringBuilder.Seperator);
                this.JoinStringBuilder.StringBuilder.Append(value);
            }
        }

        public JoinStringBuilder(char seperator) : this(new StringBuilder(), seperator) { }
        public JoinStringBuilder(StringBuilder sb, char seperator) {
            this.StringBuilder = sb;
            this.Seperator = seperator;

            this.AppendState = new FirstAppendState(this);
        }

        public StringBuilder StringBuilder { get; }
        public char Seperator { get; }

        private IAppendState AppendState { get; set; }

        public void Append(string value) {
            this.AppendState.Append(value);
        }
    }
}