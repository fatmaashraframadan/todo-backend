using System.Reflection;
using Infrastructure;
using IUserRepositoryAlias = Infrastructure.Interfaces.IUserRepository;
using Infrastructure.Repositories;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson.Serialization;
using Infrastructure.Interfaces;
using API.Application.Factories;

var builder = WebApplication.CreateBuilder(args);

// Configure DatabaseSettings
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("DatabaseSettings"));
builder.Services.AddSingleton(sp => sp.GetRequiredService<IOptions<DatabaseSettings>>().Value);
BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.CSharpLegacy));

// Register MongoDB client and database
builder.Services.AddSingleton<IMongoClient>(sp =>
{
    var settings = sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
    return new MongoClient(settings.ConnectionString);
});

builder.Services.AddSingleton(sp =>
{
    var settings = sp.GetRequiredService<IOptions<DatabaseSettings>>().Value;
    var client = sp.GetRequiredService<IMongoClient>();
    return client.GetDatabase(settings.DatabaseName);
});



// Register repositories and context
builder.Services.AddScoped<IUserRepositoryAlias, UserRepository>();
builder.Services.AddScoped<ITodoItemRepository, TodoItemRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<TodoItemFactory>();

builder.Services.AddScoped(typeof(BaseContext<>));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

// Add controllers and other middleware
builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    });

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "API", Version = "v1" });
});

var app = builder.Build();

app.UseRouting();
app.UseCors();
app.UseSwagger();
app.MapControllers();
app.UseDeveloperExceptionPage();

Console.WriteLine("Hello World!");
app.Run();
