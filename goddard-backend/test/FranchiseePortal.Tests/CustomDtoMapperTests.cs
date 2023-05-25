using AutoMapper;
using Xunit;

namespace FranchiseePortal.Tests
{
    public class CustomDtoMapperTests
    {
        [Fact()]
        public void CreateToursMappings()
        {
            // Arrange

            // Act
            var configuration = new MapperConfiguration(cfg => {
                CustomDtoMapper.CreateToursMappings(cfg);
            });

            // Assert
            configuration.AssertConfigurationIsValid();
        }
    }
}