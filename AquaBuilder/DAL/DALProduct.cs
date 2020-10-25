using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AquaBuilder.DAL;
using AquaBuilder.DTO;
using AquaBuilder.Parsers;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace AquaBuilder.DAL
{
    public class DALProduct : BaseMSSQLContext
    {
        public List<ProductDTO> GetAll()
        {
            List<ProductDTO> productList = new List<ProductDTO>();
            try
            {
                string sql = "SELECT Product_ID, Name, Price, Image, Branch_ID FROM product";
                List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>
                {

                };
                DataSet results = ExecuteSql(sql, parameters);

                for (int x = 0; x < results.Tables[0].Rows.Count; x++)
                {
                    ProductDTO p = DataSetParsers.DataSetToProduct(results, x);
                    productList.Add(p);
                }
                return productList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
