using TaskAPI.Services.Authors;
using TaskAPI.Services.Todos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// builder.Services.AddControllers(); // Return type is JSON format only.

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;
}).AddXmlDataContractSerializerFormatters(); // Using this, values can only return json and xml format only

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inject the AutoMapper
// GetAssemblies = TaskAPI.Services.Profiles
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Dependencies Injection
builder.Services.AddScoped<ITodoRepository, TodoRepository>();
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
