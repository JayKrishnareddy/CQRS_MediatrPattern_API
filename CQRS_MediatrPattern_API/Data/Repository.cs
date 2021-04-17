using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_MediatrPattern_API.Data
{
    public class Repository
    {
        public List<ToDo> ToDos = new List<ToDo>
        {
            new ToDo{Id = 1, Task = "Cardio for 1 hour", IsCompleted = true},
            new ToDo{Id = 2, Task = "Make Breakfast", IsCompleted = true},
            new ToDo{Id = 3, Task = "Practivce Programming", IsCompleted = true},
            new ToDo{Id = 4, Task = "Power Nap for 30 Min", IsCompleted = false},
            new ToDo{Id = 5, Task = "Sending Emails", IsCompleted = false},
            new ToDo{Id = 6, Task = "Cook Dinner", IsCompleted = false},
        };
    }
}
