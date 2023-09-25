using System;
using System.Reflection;

//ref link:https://www.youtube.com/watch?v=L0UavAtVnD4&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=15
//

[assembly: AssemblyVersion("1.0.0.0")]          // requires knowledge in attributes/reflections

//----4 Assembly IDENTIFYER---
// 1- Name
// 2- Version
// 3- Public Key
// 4- Culture

// csc /out:Farm.dll    -- basic name

public class Cow
{
    public static void Moo()
    {
        Console.WriteLine("Moo Version 1");
    }
}