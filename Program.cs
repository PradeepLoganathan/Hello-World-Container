var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context =>
{
    var target = Environment.GetEnvironmentVariable("TARGET") ?? "World";
    await context.Response.WriteAsync($"Hello {target}!\n");
});

string port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
string url = String.Concat("http://0.0.0.0:", port);

app.Run(url);
