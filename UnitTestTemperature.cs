using CelsiusToFahrenheit.Models;

namespace TextTemperaturaCF
{
    [TestClass]
    public class UnitTestTemperature
    {
        [TestMethod]
        
        public void TestFarenheitConversion()
        {
            double temperatureCelcius = 22;
            double temperatureFahrenheitActual;
            double temperatureFahrenheitExpected = 71.6;

            temperatureFahrenheitActual = Temperature.CelsiusToFahrenheit(temperatureCelcius);

            Assert.AreEqual(temperatureFahrenheitExpected, temperatureFahrenheitActual, 0.001, "Conversion de temperatura incorrecta");
        }
    }
}