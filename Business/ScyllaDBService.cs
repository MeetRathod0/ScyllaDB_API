using Cassandra;
using Cassandra.Mapping;
using scyllaela.Models;

namespace scyllaela.Business
{
    // service
    public class ScyllaDBService
    {
        private Cluster cluster;
        public Cassandra.ISession session;
        public IMapper mapper;

        public ScyllaDBService() {
            cluster = Cluster.Builder()
                .AddContactPoint("192.168.10.129")
                .WithCredentials("cassandra", "cassandra")
                .Build();
            // keyspace
            session = cluster.Connect("stud");
            mapper = new Mapper(session);
        }   
        
    }
}
