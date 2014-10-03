namespace Event
{
    using System;
    using System.Collections;
    using System.Text;

    public class Event : IComparable, IEnumerable
    {
        private DateTime date;
        private String title;
        private String location;

        public Event(DateTime date, string title, string location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public DateTime Date { get; private set; }
        public string Title { get; private set; }
        public string Location { get; private set; }

        public int CompareTo(object obj)
        {
            var other = obj as Event;

            if (other != null)
            {
                int byDate = this.Date.CompareTo(other.Date);
                int byTitle = System.String.Compare(this.Title, other.Title, System.StringComparison.Ordinal);
                int byLocation = System.String.Compare(this.Location, other.Location, System.StringComparison.Ordinal);

                if (byDate == 0)
                {
                    return byTitle == 0 ? byLocation : byTitle;
                }
                else
                {
                    return byDate;
                }
            }

            return 0; // false
        }

        public override string ToString()
        {
            var strBuilder = new StringBuilder();
            strBuilder.Append(Date.ToString("yyyy-MM-ddTHH:mm:ss"));
            strBuilder.Append(" | " + this.Title);

            if (!string.IsNullOrEmpty(this.Location))
            {
                strBuilder.Append(" | " + this.Location);
            }

            return strBuilder.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private static bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();

            if (command != null)
            {
                if (command[0] == 'A')
                {
                    AddEvent(command);
                    return true;
                }
                if (command[0] == 'D')
                {
                    DeleteEvents(command);
                    return true;
                }

                if (command[0] == 'L')
                {
                    ListEvents(command);
                    return true;
                }
                if (command[0] == 'E')
                {
                    return false;
                }
            }
            return false;
        }

        private static EventHolder events = new EventHolder();

        private static void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf('|');
            DateTime date = GetDate(command, "ListEvents");

            string countString = command.Substring(pipeIndex + 1);
            int count = int.Parse(countString);
            events.ListEvents(date, count);
        }

        private static void DeleteEvents(string command)
        {
            string title = command.Substring("DeleteEvents".Length + 1);
            events.DeleteEvents(title);
        }

        private static void AddEvent(string command)
        {
            DateTime date;
            string title;
            string location;

            GetParameters(command, "AddEvent", out date, out title, out location);
            events.AddEvent(date, title, location);
        }

        private static void GetParameters(string commandForExecution, string commandType,
            out DateTime dateAndTime, out string eventTitle, out string eventLocation)
        {
            dateAndTime = GetDate(commandForExecution, commandType);
            var firstPipeIndex = commandForExecution.IndexOf('|');

            var lastPipeIndex = commandForExecution.LastIndexOf('|');
            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1).Trim();
                eventLocation = "";
            }
            else
            {
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        private static DateTime GetDate(string command, string commandType)
        {
            var date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));

            return date;
        }
    }
}