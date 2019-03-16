using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder {
    public static class Program {
        private static void Main(string[] args) {
            Example();
        }

        private static void Example() {
            var email1 = new Email(to: new string[] { "Genji" },
                                               body: "Simple geometry",
                                               from: "Hanzo",
                                               subject: "Shimada",
                                               cc: "Tracer",
                                               attachments: null,
                                               bcc: null);

            Email email2 = new EmailBuilder() {
                From = "Hanzo",
                To = {
                    "Genji"
                },
                Subject = "Shimada",
                Body = "Simple geometry",
                Cc = "Tracer"
            }.Build();
        }
    }
}