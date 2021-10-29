using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;

namespace Tabomtrak
{
    interface IDatabase
    {
        void P1_Write();
        void P2_Write();
        string L1 { get; }
        string L2 { get; }
        string L3 { get; }
        string L4 { get; }
        string L5 { get; }
        string L6 { get; }
        string L7 { get; }
    }
    class SqlConnect
    {
        public SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = Taboomboom; Integrated Security = True");
        public DataSet ds;
        public SqlDataAdapter da;
    }
    class SqlData : SqlConnect,IDatabase
    {
        Number number = new Number();
        Form1 form = new Form1();
        
        string[] label = new string[7];
        int numbers;       
        void IDatabase.P1_Write()
        {
            numbers = number.Dizi;
            con.Open();          
                da = new SqlDataAdapter("select * from Table_1 where pl1_id='" + numbers + "'", con);
                ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    label[0] = ds.Tables[0].Rows[0]["pl1_id"].ToString();
                    label[1] = ds.Tables[0].Rows[0]["answer"].ToString();
                    label[2] = ds.Tables[0].Rows[0]["first_hint"].ToString();
                    label[3] = ds.Tables[0].Rows[0]["second_hint"].ToString();
                    label[4] = ds.Tables[0].Rows[0]["third_hint"].ToString();
                    label[5] = ds.Tables[0].Rows[0]["fourth_hint"].ToString();
                    label[6] = ds.Tables[0].Rows[0]["fifth_hint"].ToString();
                }           
            con.Close();
        }
        
        string IDatabase.L1 { get{ return label[0]; } }
        string IDatabase.L2 { get { return label[1]; } }
        string IDatabase.L3 { get { return label[2]; } }
        string IDatabase.L4 { get { return label[3]; } }
        string IDatabase.L5 { get { return label[4]; } }
        string IDatabase.L6 { get { return label[5]; } }
        string IDatabase.L7 { get { return label[6]; } }
        
        void IDatabase.P2_Write()
        {
            numbers = number.Dizi;
            con.Open();
            da = new SqlDataAdapter("select * from Table_2 where pl2_id='"+ numbers +"'", con);
            ds = new DataSet();
            da.Fill(ds);
            if(ds.Tables[0].Rows.Count>0)
            {
                label[0] = ds.Tables[0].Rows[0]["pl2_id"].ToString();
                label[1] = ds.Tables[0].Rows[0]["answer"].ToString();
                label[2] = ds.Tables[0].Rows[0]["first_hint"].ToString();
                label[3] = ds.Tables[0].Rows[0]["second_hint"].ToString();
                label[4] = ds.Tables[0].Rows[0]["third_hint"].ToString();
                label[5] = ds.Tables[0].Rows[0]["fourth_hint"].ToString();
                label[6] = ds.Tables[0].Rows[0]["fifth_hint"].ToString();
            }
            con.Close();
        }
    }   
}