
var builder = WebApplication.CreateBuilder();
builder.Services.AddFastEndpoints()
 .SwaggerDocument();

var app = builder.Build();
app.UseFastEndpoints(c => c.Serializer.Options.PropertyNamingPolicy = null)
   .UseSwaggerGen();


app.Run();