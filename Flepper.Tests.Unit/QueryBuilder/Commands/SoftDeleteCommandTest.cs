using Flepper.QueryBuilder;
using FluentAssertions;
using Xunit;

namespace Flepper.Tests.Unit.QueryBuilder.Commands
{
    [Collection("CommandTests")]
    public class SoftDeleteCommandTest
    {
        [Fact]
        public void ShouldCreateSoftDeleteStatement()
        {
            FlepperQueryBuilder.SoftDelete()
                               .From("User")
                               .Build()
                               .Should()
                               .Be("UPDATE [Test] SET IsDeleted = 1");
        }
    }
}