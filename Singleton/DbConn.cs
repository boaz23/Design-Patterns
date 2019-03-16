using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton {
    public class DbConn {
        private DbConn() { }

        public DbConn Instance { get; } = new DbConn();
    }
}