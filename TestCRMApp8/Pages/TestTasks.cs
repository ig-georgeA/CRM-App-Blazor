using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp8.Pages;

namespace TestCRMApp8
{
	[Collection("CRMApp8")]
	public class TestTasks
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Tasks>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
