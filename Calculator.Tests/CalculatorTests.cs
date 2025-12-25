using Xunit;

public class CalculatorTests

{ private readonly Calculator
_calculator = new() ;

[Fact]
public void
Add_TwoNumbers_ReturnsSum( )
{

// Arrange
int a = 5, b = 3;

// Act
int result = _calculator.Add(a,

b);

// Assert
Assert.Equal(8, result);

}

[Fact]
public void
Subtract_TwoNumbers_ReturnsDifference()
{
// Arrange
int a = 10, b = 4;

// Act
int result =
_calculator.Subtract(a, b);

// Assert
Assert.Equal(6, result);
}
[Fact]
public void
Multiply_TwoNumbers_ReturnsProduct()
{
// Arrange
int a = 3, b = 4;

// Act
int result =
_calculator.Multiply(a, b);

// Assert
Assert.Equal(12, result);
}
[Fact]
public void
Divide_TwoNumbers_ReturnsQuotient()
{

// Arrange
int a = 10, b = 2;

// Act
double result =
_calculator.Divide(a, b);

// Assert
Assert.Equal(5.0, result);
}
[Fact]
public void
Divide_ByZero_ThrowsException()
{
// Arrange
int a = 10, b = 0;

// Act & Assert

Assert.Throws<DivideByZeroException>(()
=> _calculator.Divide(a, b));
}
}