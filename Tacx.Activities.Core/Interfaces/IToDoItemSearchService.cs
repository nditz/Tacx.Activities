using Ardalis.Result;
using Tacx.Activities.Core.ProjectAggregate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tacx.Activities.Core.Interfaces
{
    public interface IToDoItemSearchService
    {
        Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
        Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
    }
}
