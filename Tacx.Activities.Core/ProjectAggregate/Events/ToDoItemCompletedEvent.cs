using Tacx.Activities.Core.ProjectAggregate;
using Tacx.Activities.SharedKernel;

namespace Tacx.Activities.Core.ProjectAggregate.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}