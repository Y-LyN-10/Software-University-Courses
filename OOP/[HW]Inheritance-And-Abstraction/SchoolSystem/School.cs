    using System.Collections.Generic;

namespace SchoolSystem
{
    public class School
    {
        //School has a list of classes
        public IList<Class> Classes { get; set; }

        public School()
        {
            this.Classes = new List<Class>();
        }

        public void AddClass(Class classes)
        {
            this.Classes.Add(classes);
        }
    }
}
