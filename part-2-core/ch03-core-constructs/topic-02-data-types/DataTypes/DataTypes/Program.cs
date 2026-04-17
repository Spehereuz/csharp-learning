Console.WriteLine($"{"Type",-10} {"Min",-45} {"Max",-45} {"Size"}");
Console.WriteLine($"{"int",-10} {int.MinValue,-45} {int.MaxValue,-45} {sizeof(int)} bytes");
Console.WriteLine($"{"long",-10} {long.MinValue,-45} {long.MaxValue,-45} {sizeof(long)} bytes");
Console.WriteLine($"{"float",-10} {float.MinValue,-45} {float.MaxValue,-45} {sizeof(float)} bytes");
Console.WriteLine($"{"double",-10} {double.MinValue,-45} {double.MaxValue,-45} {sizeof(double)} bytes");
Console.WriteLine($"{"decimal",-10} {decimal.MinValue,-45} {decimal.MaxValue,-45} {sizeof(decimal)} bytes");
Console.WriteLine();

double doubleWithSeparator = 1_234_567.891;
Console.WriteLine($"doubleWithSeparator = {doubleWithSeparator}");
Console.WriteLine();

int intByBinaryLiteral = 0b_0000_0000_0001_1010;
Console.WriteLine($"intByBinaryLiteral as decimal = {intByBinaryLiteral:D}");
Console.WriteLine($"intByBinaryLiteral as binary = {intByBinaryLiteral:b}");
Console.WriteLine($"intByBinaryLiteral as hex = {intByBinaryLiteral:X}");
Console.WriteLine();

int intMax = int.MaxValue;
Int32 systemInt32Max = Int32.MaxValue;
Console.WriteLine($"max value of int = {intMax}");
Console.WriteLine($"max value of Int32 = {systemInt32Max}");
Console.WriteLine($"Is int equal to Int32: {intMax == systemInt32Max}");