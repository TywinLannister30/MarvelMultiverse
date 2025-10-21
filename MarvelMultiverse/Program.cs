using MarvelMultiverse.Managers;
using MarvelMultiverse.Selectors;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<ICharacterSelector, CharacterSelector>();
builder.Services.AddTransient<IIconicItemPowerSelector, IconicItemPowerSelector>();
builder.Services.AddTransient<IOccupationSelector, OccupationSelector>();
builder.Services.AddTransient<IOriginSelector, OriginSelector>();
builder.Services.AddTransient<IPowerSelector, PowerSelector>();
builder.Services.AddTransient<IPowerSetSelector, PowerSetSelector>();
builder.Services.AddTransient<ITagSelector, TagSelector>();
builder.Services.AddTransient<ITraitSelector, TraitSelector>();

builder.Services.AddTransient<ICharacterManager, CharacterManager>();
builder.Services.AddTransient<INarrativePowerSelector, NarrativePowerSelector>();
builder.Services.AddTransient<IOccupationManager, OccupationManager>();
builder.Services.AddTransient<IOriginManager, OriginManager>();
builder.Services.AddTransient<IPowerManager, PowerManager>();
builder.Services.AddTransient<IPowerSetManager, PowerSetManager>();
builder.Services.AddTransient<ITagManager, TagManager>();
builder.Services.AddTransient<ITraitManager, TraitManager>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowLocalBlazor", policy =>
        policy.WithOrigins("https://localhost:5001", "https://localhost:7186", "http://localhost:5042/") // your frontend ports
              .AllowAnyHeader()
              .AllowAnyMethod());
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowLocalBlazor");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
