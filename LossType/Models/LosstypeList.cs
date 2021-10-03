using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LossType.Models
{
    public class LosstypeList
    {
        public List<Losstype> lossTypeList = new List<Losstype>();
        public List<Losstype> GetLossType()
        {
            string connection = "Server=interview-testing-server.database.windows.net; Database=Interview; User Id=TestLogin; Password=5D9ej2G64s3sd^;";    //ConfigurationManager.AppSettings["LossTypeConnect"];
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    SqlCommand command = new SqlCommand(
                      "select * from LossTypes",
                      conn);
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Losstype lossType=new Losstype();
                        lossType.LossTypeId = int.Parse(reader[0].ToString());
                        lossType.LossTypeCode = reader[1].ToString();
                        lossType.LossTypeDescription = reader[2].ToString();
                        lossType.Active = bool.Parse(reader[3].ToString());
                        lossType.LastUpdatedDate = reader[4].ToString();
                        lossType.LastUpdatedId = int.Parse(reader[5].ToString());
                        lossType.CreatedDate = reader[6].ToString();
                        lossType.CreatedId = int.Parse(reader[7].ToString());
                        lossTypeList.Add(lossType);
                    }
                }
                finally { conn.Close(); }
                return lossTypeList;
            }
        }
    }
}