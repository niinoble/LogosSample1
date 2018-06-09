using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Dapper;   


namespace ZombieData
{
    

    public class StatusRepository : Repository
    {
        public List<Status> GetAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                string sql="SELECT p.FirstName, p.LastName, s.StatusDescription "
                    +"FROM personstatus s "
                    +"left join person p "
                    +"on s.personstatusid = p.personstatusid;";
            return dbConnection.Query<Status>(sql,commandType:CommandType.Text).ToList();
            }
        }
    }
}