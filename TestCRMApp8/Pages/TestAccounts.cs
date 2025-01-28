using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRMApp8.Pages;
using CRMApp8.Northwind;

namespace TestCRMApp8
{
  [Collection("CRMApp8")]
  public class TestAccounts
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbButtonModule),
        typeof(IgbRippleModule),
        typeof(IgbSelectModule),
        typeof(IgbInputModule),
        typeof(IgbDropdownModule),
        typeof(IgbDropdownItemModule),
        typeof(IgbGridModule),
        typeof(IgbTextareaModule));
      ctx.Services.AddScoped<INorthwindService>(sp => new MockNorthwindService());
      var componentUnderTest = ctx.RenderComponent<Accounts>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
