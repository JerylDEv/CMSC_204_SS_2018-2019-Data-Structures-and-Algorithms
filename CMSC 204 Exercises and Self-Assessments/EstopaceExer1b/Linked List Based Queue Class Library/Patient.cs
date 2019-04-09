using System;

namespace Linked_List_Based_Queue_Class_Library
{
    public class Patient
    {
        public string Index { get; set; }
        public string Name { get; set; }
        public string Concern { get; set; }

        // Class Constructor
        public Patient(string name, string concern)
        {
            this.Name = name;
            this.Concern = concern;
        }

        public Patient(string index, string name, string concern)
        {
            this.Index = index;
            this.Name = name;
            this.Concern = concern;
        }
    }
}
