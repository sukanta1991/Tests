using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Objects;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Objects.DataClasses;



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
            using (var context = new  DatabaseFirst_PublishingCompany.PublishingCompanyEntities())
            {
                var product = context.Articles.SingleOrDefault(p => p.ArticleID == 2);

                var newArt = new DatabaseFirst_PublishingCompany.Article
                {
                    ArticleID = 2,
                    Title = "EF Testing",
                    Body = "Entity Framework Testing",
                    AuthorID = 2
                };
                context.Articles.AddObject(newArt);
                context.SaveChanges();

            }

        }

        public static void DBCallGetArticleSP()
        {
            using (var context = new DatabaseFirst_PublishingCompany.PublishingCompanyEntities())
            {
                var ArtDet = context.GetArticle(9).ToList<DatabaseFirst_PublishingCompany.GetArticle_Result>();

                foreach (DatabaseFirst_PublishingCompany.GetArticle_Result cs in ArtDet)
                    Console.WriteLine("ArticleID :{0}, Title : {1} , Body : {2}, AuthorID : {3}", cs.ArticleID, cs.Title, cs.Body, cs.AuthorID );
                
            }
           
        }


        public static void DBCallGetNextAuthorSP()
        {
            using (var context = new DatabaseFirst_PublishingCompany.PublishingCompanyEntities())
            {
                ObjectResult<DatabaseFirst_PublishingCompany.GetNextAuthor_Result> orderDetailEnumerable = context.GetNextAuthor(2);
                List<DatabaseFirst_PublishingCompany.GetNextAuthor_Result> details = orderDetailEnumerable.ToList();

                foreach (DatabaseFirst_PublishingCompany.GetNextAuthor_Result dt in details)
                    Console.WriteLine("{0},{1},{2}", dt.AuthorID , dt.FirstName, dt.LastName );
                
            }
        }

        }

  }

