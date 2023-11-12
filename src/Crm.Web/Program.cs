using Crm.BusinessLogic;
using Crm.Web;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection(Constants.ConnectionStringsSectionName));

builder.Services.AddHttpContextAccessor();
builder.Services.ConfigureCrmServices(builder.Configuration);

builder.Services.AddAuthentication
    (ApiKeyAuthenticationOptions.ApiKeyScheme)
        .AddScheme<ApiKeyAuthenticationOptions, ApiKeyAuthenticationHandler>(ApiKeyAuthenticationOptions.ApiKeyScheme,
            options => { });

builder.Services.AddControllers();

WebApplication app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();