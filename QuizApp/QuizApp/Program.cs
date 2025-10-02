using MudBlazor.Services;
using QuizApp.Components;
using QuizApp.Components.Hubs;
using QuizApp.Components.Logic;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddSignalR();
builder.Services.AddMudServices();
builder.Services.AddSingleton<QuestionManager>()
    .AddSingleton<RoomManager>()
    .AddSingleton<AnswerSubmissionService>()
    //.AddSingleton<LeaderBoardService>()
    .AddSingleton<ILeaderBoardStore, InMemoryLeaderBoardStore>()
    .AddSingleton<ILeaderBoardBroadcaster, LeaderBoardService>()
    ;

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapHub<MessageHub>("/messagehub");
app.MapHub<LeaderBoardHub>("/leaderboardhub");

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
