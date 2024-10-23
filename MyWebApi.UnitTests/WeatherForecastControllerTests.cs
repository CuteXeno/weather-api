namespace MyWebApi.UnitTests
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void Get_ReturnsExpectedForecasts()
        {
            // Arrange
            var service = new WeatherService();

            // Act
            var result = service.GetWeather();

            // Assert
            Assert.NotEmpty(result);
        }
    }
}