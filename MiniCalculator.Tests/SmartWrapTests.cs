using MiniCalculator.Views.Helpers;
using Xunit;

namespace MiniCalculator.Tests;

public class SmartWrapTests
{
    [Fact]
    public void EmptyString_InsertsOpenFunction()
    {
        var (newText, newPos) = ExpressionInputHelper.ComputeSmartWrap("", 0, "pow");
        Assert.Equal("pow(", newText);
        Assert.Equal(4, newPos);
    }

    [Fact]
    public void IntegerOperand_WrapsAsFirstArgument()
    {
        var (newText, newPos) = ExpressionInputHelper.ComputeSmartWrap("123", 3, "pow");
        Assert.Equal("pow(123, ", newText);
        Assert.Equal("pow(123, ".Length, newPos);
    }

    [Fact]
    public void DecimalOperand_WrapsAsFirstArgument()
    {
        var (newText, newPos) = ExpressionInputHelper.ComputeSmartWrap("12.5", 4, "root");
        Assert.Equal("root(12.5, ", newText);
        Assert.Equal("root(12.5, ".Length, newPos);
    }

    [Fact]
    public void ParenthesizedExpression_WrapsEntireParenGroup()
    {
        var (newText, newPos) = ExpressionInputHelper.ComputeSmartWrap("(2 + 3)", 7, "pow");
        Assert.Equal("pow((2 + 3), ", newText);
        Assert.Equal("pow((2 + 3), ".Length, newPos);
    }

    [Fact]
    public void NestedFunctionCall_WrapsEntireFunctionCall()
    {
        var (newText, newPos) = ExpressionInputHelper.ComputeSmartWrap("root(8, 3)", 10, "pow");
        Assert.Equal("pow(root(8, 3), ", newText);
        Assert.Equal("pow(root(8, 3), ".Length, newPos);
    }

    [Fact]
    public void AfterOperator_DoesNotWrapOperator_InsertsOpenFunction()
    {
        var (newText, newPos) = ExpressionInputHelper.ComputeSmartWrap("5 + ", 4, "root");
        Assert.Equal("5 + root(", newText);
        Assert.Equal(9, newPos);
    }

    [Fact]
    public void AfterComma_InsertsNestedOpenFunction()
    {
        var (newText, newPos) = ExpressionInputHelper.ComputeSmartWrap("pow(2, ", 7, "root");
        Assert.Equal("pow(2, root(", newText);
        Assert.Equal(12, newPos);
    }

    [Fact]
    public void AfterOpenParen_InsertsOpenFunction()
    {
        var (newText, newPos) = ExpressionInputHelper.ComputeSmartWrap("(2 * (", 6, "pow");
        Assert.Equal("(2 * (pow(", newText);
        Assert.Equal(10, newPos);
    }

    [Fact]
    public void CaretInMiddleOfExpression_WrapsOnlyPrecedingOperand()
    {
        var (newText, newPos) = ExpressionInputHelper.ComputeSmartWrap("2 + 5 * 3", 5, "pow");
        Assert.Equal("2 + pow(5,  * 3", newText);
        Assert.Equal("2 + pow(5, ".Length, newPos);
    }
}
