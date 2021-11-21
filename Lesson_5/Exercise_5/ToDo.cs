using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_5
{
    public class ToDo
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public ToDo()
        {
            Title = null;
        }
        public ToDo (string title)
        {
            Title = title;
        }
    }
}
