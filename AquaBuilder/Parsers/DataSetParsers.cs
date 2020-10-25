using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AquaBuilder.DTO;

namespace AquaBuilder.Parsers
{
    public class DataSetParsers
    {
        public static ProductDTO DataSetToProduct(DataSet set, int rowindex)
        {
            return new ProductDTO()
            {
                productId = (int)set.Tables[0].Rows[rowindex][0],
                name = (string)set.Tables[0].Rows[rowindex][1],
                description = (string)set.Tables[0].Rows[rowindex][2],
                price = (decimal)set.Tables[0].Rows[rowindex][3],
                image = (byte[])set.Tables[0].Rows[rowindex][4],
                supply = (int)set.Tables[0].Rows[rowindex][5],
            };
        }
    }
}
