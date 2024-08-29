using scyllaela.Models;
using Cassandra.Data.Linq;
namespace scyllaela.Business;

public class StudBusiness: IStudBusiness
{
    private ScyllaDBService scylla_service;
    public StudBusiness()
    {
        scylla_service = new ScyllaDBService();
    }
    // make async task
    public async Task<List<StudentModel>> GetData()
    {
                                        // call async fetch
        IEnumerable<StudentModel> result = await scylla_service.mapper.FetchAsync<StudentModel>("SELECT * FROM users WHERE user_type=2");
        return result.ToList();  
    }
}
