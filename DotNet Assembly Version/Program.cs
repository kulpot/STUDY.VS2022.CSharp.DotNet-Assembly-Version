using System;
//using System.Reflection;

//ref link:https://www.youtube.com/watch?v=L0UavAtVnD4&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=15
//

//[assembly: AssemblyVersion("1.0.0.0")]          // requires knowledge in attributes/reflections

//----4 Assembly IDENTIFYER---
// 1- Name
// 2- Version
// 3- Public Key
// 4- Culture

// csc /out:Farm.dll    -- basic name

/*-------------------------CMD---------------------------------
 * 
C:\Users\sunny\source\repos\DotNet Assembly Version>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Version

26/09/2023  05:16 am    <DIR>          .
26/09/2023  05:16 am    <DIR>          ..
26/09/2023  05:16 am             2,581 .gitattributes
26/09/2023  05:16 am             6,585 .gitignore
26/09/2023  05:20 am    <DIR>          DotNet Assembly Version
26/09/2023  05:10 am             1,175 DotNet Assembly Version.sln
               3 File(s)         10,341 bytes
               3 Dir(s)  489,139,912,704 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Version>cd DotNet Assembly Version

C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version

26/09/2023  05:20 am    <DIR>          .
26/09/2023  05:20 am    <DIR>          ..
26/09/2023  05:09 am               189 App.config
26/09/2023  05:09 am    <DIR>          bin
26/09/2023  05:10 am             2,396 DotNet Assembly Version.csproj
26/09/2023  05:09 am    <DIR>          obj
26/09/2023  05:20 am               592 Program.cs
26/09/2023  05:19 am    <DIR>          Properties
               3 File(s)          3,177 bytes
               5 Dir(s)  489,139,908,608 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>csc /t:library /out:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version

26/09/2023  05:23 am    <DIR>          .
26/09/2023  05:23 am    <DIR>          ..
26/09/2023  05:09 am               189 App.config
26/09/2023  05:09 am    <DIR>          bin
26/09/2023  05:10 am             2,396 DotNet Assembly Version.csproj
26/09/2023  05:23 am             3,584 Farm.dll
26/09/2023  05:09 am    <DIR>          obj
26/09/2023  05:21 am             2,040 Program.cs
26/09/2023  05:19 am    <DIR>          Properties
               4 File(s)          8,209 bytes
               5 Dir(s)  489,139,191,808 bytes free
----------------------
turn all lines to comment then.....
---------------------------------created---

using System;

class MeMainClass
{
    static void Main()
    {
        Cow.Moo();
    }
}

----------------------------------
C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>csc /r:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version

26/09/2023  05:29 am    <DIR>          .
26/09/2023  05:29 am    <DIR>          ..
26/09/2023  05:09 am               189 App.config
26/09/2023  05:09 am    <DIR>          bin
26/09/2023  05:23 am             2,411 DotNet Assembly Version.csproj
26/09/2023  05:23 am             3,584 Farm.dll
26/09/2023  05:09 am    <DIR>          obj
26/09/2023  05:29 am             3,190 Program.cs
26/09/2023  05:29 am             4,096 Program.exe  <----- no "/out:" so Program.exe is generated
26/09/2023  05:19 am    <DIR>          Properties
               5 File(s)         13,470 bytes
               5 Dir(s)  489,139,777,536 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Version\DotNet Assembly Version>Program.exe
Moo Version 1





 * 
 */


//public class Cow
//{
//    public static void Moo()
//    {
//        Console.WriteLine("Moo Version 1");
//    }
//}

class MeMainClass
{
    static void Main()
    {
        Cow.Moo();
    }
}