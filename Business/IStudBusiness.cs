using scyllaela.Models;
namespace scyllaela.Business;

public interface IStudBusiness
{
   // task list
   public Task<List<StudentModel>> GetData();
}
