using System;
using System.Collections;
using System.Text;
//using Wintellect.PowerCollections;

namespace Event
{
    public class Event : IComparable, IEnumerable
    {
        private DateTime _date;
        private String _title;
        private String _location;

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
                int byTitle = this.Title.CompareTo(other.Title);
                int byLocation = this.Location.CompareTo(other.Location);

                if (byDate == 0)
                {
                    return byTitle == 0 ? byLocation : byTitle;
                }
                else
                {
                    return byDate;
                }
            }

            return 0; // ?
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
    }

    public class Program
    {
        private static StringBuilder output = new StringBuilder();

        private static class Messages
        {
            public static void EventAdded()
            {
                output.Append("Event added\n");
            }

            public static void EventDeleted(int x)
            {
                if (x == 0)
                {
                    NoEventsFound();
                }
                else
                {
                    output.AppendFormat("{0} events deleted\n", x);
                }
            }

            public static void NoEventsFound()
            {
                output.Append("No events found\n");
            }

            public static void PrintEvent(Event eventToPrint)
            {
                if (eventToPrint != null)
                {
                    output.Append(eventToPrint + "\n");
                }
            }
        }

        public class EventHolder
        {
            private MultiDictionary<string, Event> byTitle = new MultiDictionary<string, Event>();

            private OrderedBag<Event> byDate = new OrderedBag<Event>();

            public void AddEvent(DateTime date, string title, string location)
            {
                var newEvent = new Event(date, title, location);
                byTitle.Add(title.ToLower(), newEvent);
                byDate.Add(newEvent);

                Messages.EventAdded();
            }

            public void DeleteEvents(string titleToDelete)
            {
                string title = titleToDelete.ToLower();
                int removed = 0;

                foreach (Event eventToRemove in byTitle[title])
                {
                    removed++;
                    byDate.Remove(eventToRemove);
                }

                byTitle.Remove(title);
                Messages.EventDeleted(removed);
            }

            public void ListEvents(DateTime date, int count)
            {
                OrderedBag<Event> eventsToShow = byDate.RangeFrom(new Event(date, "", ""),true);
                int showed = 0;
                foreach (var eventToShow in eventsToShow)
                {
                    if (showed == count) break;
                    Messages.PrintEvent(eventToShow);

                    showed++;
                }
                if (showed == 0) Messages.NoEventsFound();
            }
        }

        private static EventHolder events = new EventHolder();

        private static void Main(string[] args)
        {
            Console.WriteLine(output);
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
            events.AddEvent (date, title, location);
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
                eventTitle = commandForExecution.Substring(firstPipeIndex + 1,lastPipeIndex - firstPipeIndex - 1).Trim();
                eventLocation = commandForExecution.Substring(lastPipeIndex + 1).Trim();
            }
        }

        private static DateTime GetDate(string command, string commandType)
        {
            DateTime date = DateTime.Parse(command.Substring(commandType.Length + 1, 20));
            return date;
        }
    }
}