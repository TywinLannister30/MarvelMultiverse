using MarvelMultiverse.Managers;
using MarvelMultiverse.Selectors;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ICharacterSelector, CharacterSelector>();
builder.Services.AddTransient<IOccupationSelector, OccupationSelector>();
builder.Services.AddTransient<IOriginSelector, OriginSelector>();
builder.Services.AddTransient<IPowerSelector, PowerSelector>();
builder.Services.AddTransient<ITagSelector, TagSelector>();
builder.Services.AddTransient<ITraitSelector, TraitSelector>();

builder.Services.AddTransient<ICharacterManager, CharacterManager>();
builder.Services.AddTransient<IOccupationManager, OccupationManager>();
builder.Services.AddTransient<IOriginManager, OriginManager>();


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
