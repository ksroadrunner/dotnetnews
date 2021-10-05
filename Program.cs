using System;
using DotNetNews;

// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version
Console.WriteLine("Merhaba !");
Hello();
Hallo();

void Hello()
{
    Console.WriteLine("Hi!");
}

static void Hallo()
{
    Console.WriteLine("Hallo, ich bin Caner!");
}

#region Examples
var exArray = new Example_Array();
exArray.Test1();

var exOperators = new Example_Operators();
exOperators.Test1();

var exOthers = new Example_Others();
exOthers.Test1();
exOthers.Test2();
exOthers.Test2A();
exOthers.Test3();
exOthers.Test4();
exOthers.Test5();

var exRecord = new Example_Record();
exRecord.Test1();
exRecord.Test2();
exRecord.Test3();
exRecord.Test4();

var exSwitchCase = new Example_SwitchCase();
exSwitchCase.Test1();
exSwitchCase.Test2();

var exInterface = new Example_Interface();
// Test 1
// Test 2
// Test 3
#endregion