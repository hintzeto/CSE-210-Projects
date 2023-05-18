Fraction one = new Fraction();

int top = one.GetTop();
int bottom = one.GetBottom();

Console.WriteLine($"{top}/{bottom}");

Fraction five = new Fraction(5);

int top2 = five.GetTop();
int bottom2 = five.GetBottom();

Console.WriteLine($"{top2}/{bottom2}");

Fraction fiveThirds = new Fraction(5, 3);

Console.WriteLine(fiveThirds.GetFractionString());
Console.WriteLine(fiveThirds.GetDecimalValue());