using System.Collections.Generic;

namespace Builder {
    public class EmailBuilder {
        public EmailBuilder() : this(new List<string>(), new List<string>()) { }
        public EmailBuilder(List<string> to, List<string> attachments) {
            this.To = to;
            this.Attachments = attachments;
        }

        public string Subject { get; set; }
        public string Body { get; set; }
        public string From { get; set; }
        public List<string> To { get; }

        public string Cc { get; set; }
        public string Bcc { get; set; }
        public List<string> Attachments { get; }

        public void AddTo(string to) {
            this.To.Add(to);
        }
        public void AddRangeTo(IEnumerable<string> collection) {
            this.To.AddRange(collection);
        }

        public void AddAttachment(string attachment) {
            this.Attachments.Add(attachment);
        }
        public void AddAttachments(IEnumerable<string> attachments) {
            this.Attachments.AddRange(attachments);
        }

        public Email Build() {
            return new Email(this.Subject,
                             this.Body,
                             this.From,
                             this.To.ToArray(),
                             this.Cc,
                             this.Bcc,
                             this.Attachments.ToArray());
        }
    }
}