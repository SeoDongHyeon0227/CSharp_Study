using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oracle_Test002
{
    class Program
    {
        static void Main(string[] args)
        {
            // 오라클 연결 문자열        
            //string strConn = "Data Source=orcl;User Id=scott;Password=TIGER;";

            // 네트워크 연결 정보 직접 대입
            string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=125.141.133.87)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=ad12;Password=ad12;";

            // 오라클 연결
            OracleConnection conn = new OracleConnection(strConn);

            conn.Open();

            // 명령 객체 생성
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // SQL문 지정 및 INSERT 실행
            cmd.CommandText = "select * from emp";

            //cmd.ExecuteNonQuery();

            // 결과 리더 객체를 리턴
            OracleDataReader rdr = cmd.ExecuteReader();

            // 레코드 계속 가져와서 루핑
            while (rdr.Read())
            {
                // 필드 데이타 읽기
                string ename = rdr["first_name"] as string;
                string job = rdr["job_id"] as string;
                //int sal = rdr.GetInt32(5);
                string sal = rdr["salary"].ToString();

                // 데이타를 리스트박스에 추가
                Console.WriteLine($"{ename}  :  {job}  :  {sal}");
            }
            // 사용후 닫음
            conn.Close();
        }
    }
}
