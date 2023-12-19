using UnitTest;
namespace XUnitTestProject;

public class ValidatorTests
{
    [Theory]
    [InlineData("james@example.com", true)]
    [InlineData("james.bond@example.com", true)]
    [InlineData("james_bond@example.com", true)]
    [InlineData("james@example.co.uk", true)]
    [InlineData("james.bond007@example.com", true)]
    [InlineData("j.bond@example.com", true)]
    [InlineData("jb@example.com", true)]
    [InlineData("bond.james@example.com", true)]
    [InlineData("bond_james@example.com", true)]
    [InlineData("bond.james@example.co.uk", true)]
    [InlineData("bond_james007@example.com", true)]
    [InlineData("b.james@example.com", true)]
    [InlineData("bj@example.com", true)]
    [InlineData("007.james.bond@example.com", true)]
    [InlineData("007_james_bond@example.com", true)]
    [InlineData("007.james.bond@example.co.uk", true)]
    [InlineData("007.bond.james@example.com", true)]
    [InlineData("007_bj@example.com", true)]
    [InlineData("james@bond.com", true)]
    [InlineData("james.bond@mi6.co.uk", true)]
    [InlineData("james_bond@secret-service.us", true)]
    [InlineData("james.bond@agent.uk", true)]
    [InlineData("james.bond007@bond.com", true)]
    [InlineData("j.bond@bond.com", true)]
    [InlineData("jb@bond.com", true)]
    [InlineData("bond.james@mi6.co.uk", true)]
    [InlineData("bond_james@secret-service.us", true)]
    [InlineData("bond.james@agent.uk", true)]
    [InlineData("bond_james007@bond.com", true)]
    [InlineData("j.bond@mi6.co.uk", true)]
    [InlineData("007.james.bond@secret-service.us", true)]
    [InlineData("007_james_bond@agent.uk", true)]
    [InlineData("007.james.bond@bond.com", true)]
    [InlineData("007_james_bond@mi6.co.uk", true)]
    [InlineData("007.bond.james@secret-service.us", true)]
    [InlineData("007_bond.james@agent.uk", true)]
    [InlineData("exp1@example.com", true)]
    [InlineData("exp2.example@example.com", true)]
    [InlineData("exp3_example@example.com", true)]
    [InlineData("exp4@example.co.uk", true)]
    [InlineData("exp5_example@example.com", true)]
    [InlineData("exp6@example.com", true)]
    [InlineData("exp7@example.com", true)]
    [InlineData("exp8.example@example.com", true)]
    [InlineData("exp9_example@example.com", true)]
    [InlineData("exp10@example.com", true)]
    public void ShouldBeValidForEmailTest(string email, bool expected)
    {
        //arrange
        var validator = new Validator();
        
        //act
        var response = validator.IsValidEmail(email);
        
        //assert
        Assert.Equal(expected, response);
    }
}