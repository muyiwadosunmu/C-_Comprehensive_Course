using System.Collections;
using System.Collections.Generic;
using InterfaceDemo;

namespace InterfaceDemo;

public interface IRun
{
    string? FirstName { get; set; }
    string? LastName { get; set; }
    string? Age { get; set; }
    void Run();
}


public class Common
{
    List<IRun> list = new List<IRun>();
    Animal animal = new Animal();
    Person person = new Person();




}