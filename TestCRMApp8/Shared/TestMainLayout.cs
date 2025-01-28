using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp8.Shared;

namespace TestCRMApp8
{
  [Collection("CRMApp8")]
  public class TestMainLayout
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbNavbarModule),
        typeof(IgbIconButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbNavDrawerModule),
        typeof(IgbListModule),
        typeof(IgbAvatarModule));
      var componentUnderTest = ctx.RenderComponent<MainLayout>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
