# Delegates
This package provides helper functions that convert the Delegate class to the Task class.

# Example
```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClouDeveloper.Delegates;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Action(() => Console.WriteLine("Hello, World!")).ToTask().Wait();
        }
    }
}
```
