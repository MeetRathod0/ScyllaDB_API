using scyllaela.Business;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// register business
builder.Services.AddSingleton<IStudBusiness,StudBusiness>();

builder.Services.AddControllers()
        .AddJsonOptions(options=> {
            // suressing the Camel-Casing
            options.JsonSerializerOptions.PropertyNamingPolicy = null;
        });

builder.Services.AddCors(options =>
{
    options.AddPolicy("CORS", policy =>
    {
        // All Web Clients are able to Access the API
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CORS");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

