using System;

namespace InterfaceDemo
{
    public class Animal : IRun
    {

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Age { get; set; }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}