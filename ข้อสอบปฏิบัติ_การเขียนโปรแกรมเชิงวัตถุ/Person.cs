using System;
using System.Collections.Generic;
using System.Linq;


abstract class Person
{
    protected string name;
    protected string id;

    public Person(string name, string id)
    {
        this.name = name;
        this.id = id;
    }

    public abstract void ShowInfo();
}
