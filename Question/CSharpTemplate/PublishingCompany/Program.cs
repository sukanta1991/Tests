using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace DataFirstModel_PublishingCompany
{
    class DataFirstmodel
    {
        public static void Main(string[] args)
        {
            DBOperations.DBAddEntity();
            DBOperations.DBCallGetArticleSP();
            DBOperations.DBCallGetNextAuthorSP();
        }

    }


    public class DBOperations
    {

        public static void DBAddEntity()
        {
            

        }

        public static void DBCallGetArticleSP()
        {
           
        }


        public static void DBCallGetNextAuthorSP()
        {
            
        }

    }
}
