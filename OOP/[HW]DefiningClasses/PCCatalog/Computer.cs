using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace PCCatalog
{
    public class Computer : IComparable
    {
        /// <summary>
        /// Private Fields
        /// </summary>
        
        private string _name;
        private List<Component> _components;
        
        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="name"></param>
        /// <param name="components"></param>

        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
        }

        public Computer(string name)
            : this(name, null)
        {
        }

        /// <summary>
        /// Properties & Validations
        /// </summary>

        public string Name
        {
            get { return this._name; }
            private set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException();
                    }
                    if (value.Length < 2 || value.Length > 20)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    this._name = value;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Name can't be null or empty", ex);
                    throw;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Name should have at least 2 letters and can't be more than 20 letters", ex);
                    throw;
                }
            }
        }

        public List<Component> Components
        {
            get
            {
                return this._components;
            }
            private set {
                this._components = value ?? new List<Component>();
            }
        }

        public decimal Price
        {
            get
            {
                return this.Components.Count == 0 ? 0M : this.Components.Sum(x => x.Price);
            }
        }

        /// <summary>
        /// Methods
        /// </summary>
        /// <param name="component"></param>
        /// <returns></returns>
        /// 
        public bool AddComponent(Component component)
        {
            if (this.Components.Exists(x => x.Name == component.Name))
            {
                return false;
            }
            this.Components.Add(component);

            return true;
        }

        public string GetDescription()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Format("Computer: {0} ", this.Name));
            sb.AppendLine("Components:");

            foreach (var component in this.Components)
            {
                sb.AppendLine(string.Format("{0}", component));
            }

            sb.AppendLine();
            sb.AppendLine(string.Format("Total: {0}", this.Price.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG"))));

            return sb.ToString();
        }

        int IComparable.CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            var otherComputer = obj as Computer;
            if (otherComputer != null)
            {
                return this.Price.CompareTo(otherComputer.Price);
            }

            throw new ArgumentException("Object is not a Computer!");
        }
        public override string ToString()
        {
            return string.Format("Computer {0} with price: {1}", this.Name, this.Price.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG")));
        }
    }
}
