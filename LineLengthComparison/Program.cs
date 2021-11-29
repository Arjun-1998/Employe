using Employe;
LineLengthComparison lineLengthComparison = new LineLengthComparison();
double length = lineLengthComparison.CalculateLength(5, 4, 6, 8);
Console.WriteLine(length);
int a1 = 4, b1 = 4,
                    c1 = 3, a2 = -6,
                    b2 = 2, c2 = 9;

lineLengthComparison.Compare(a1, b1, c1, a2, b2, c2);