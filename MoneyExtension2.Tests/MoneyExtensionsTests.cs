namespace MoneyExtension2.Tests;

[TestClass]
public class MoneyExtensionsTests

{
    [TestMethod]
    public void ShoulConvertDecimalToInt()
    {
        decimal valor = 279.98M;
        var cents = valor.ToCents();

        Assert.AreEqual(27998,cents);
    }
}