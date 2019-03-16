using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyInitialization {
    public class DbConn {
        private static DbConn instance;

        private DbConnection _dbConnection;

        private DataSet _customers;

        private DbConn() { }

        public static DbConn Instance {
            get {
                if (instance == null) {
                    instance = new DbConn();
                }

                return instance;
            }
        }

        public DbConnection DbConnection {
            get {
                if (this._dbConnection == null) {
                    // initialize db connection here
                    //this._dbConnection = new SqlConnection("connection string");
                }

                return this._dbConnection;
            }
        }

        public DataSet Customers {
            get {
                if (this._customers == null) {
                    // make sure the database connection is initialized
                    DbConnection dbConnection = this.DbConnection;

                    // load customers from databasse here
                    try {
                        var command = new SqlCommand("SELECT * FROM Customers");
                        var dataAdapter = new SqlDataAdapter(command);

                        dbConnection.Open();
                        var dataset = new DataSet();
                        dataAdapter.Fill(dataset);

                        this._customers = dataset;
                    }
                    finally {
                        dbConnection.Close();
                    }
                }

                return this._customers;
            }
        }
    }
}