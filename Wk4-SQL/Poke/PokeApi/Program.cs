using PokeBL;
using PokeDL;
using PokeModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepository<Pokemon>, SQLPokemonRepository>(repo => new SQLPokemonRepository(builder.Configuration.GetConnectionString("Stephen_Pagdilao_DbDemo")));
builder.Services.AddScoped<IPokemonBL, PokemonBL>();
builder.Services.AddScoped<IRepository<PokemonAbilityJoin>, SQLPokeAbilityJoinRepo>(repo => new SQLPokeAbilityJoinRepo(builder.Configuration.GetConnectionString("Stephen_Pagdilao_DbDemo")));
builder.Services.AddScoped<IPokeAbiJoinBL, PokeAbiJoinBL>();

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
