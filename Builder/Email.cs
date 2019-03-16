namespace Builder {
    public class Email {
        public string Subject { get; }
        public string Body { get; }
        public string From { get; }
        public string[] To { get; }

        public string Cc { get; }
        public string Bcc { get; }
        public string[] Attachments { get; }

        public Email(string subject, string body, string from, string[] to) {
            this.Subject = subject;
            this.Body = body;
            this.From = from;
            this.To = to;
        }

        public Email(string subject,
                     string body,
                     string from,
                     string[] to,
                     string cc,
                     string bcc,
                     string[] attachments) {
            this.Subject = subject;
            this.Body = body;
            this.From = from;
            this.To = to;

            this.Cc = cc;
            this.Bcc = bcc;
            this.Attachments = attachments;
        }
    }
}