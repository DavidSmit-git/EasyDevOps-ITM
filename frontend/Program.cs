var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();

app.MapGet("/", () => Results.Content(@"
    <!DOCTYPE html>
    <html>
        <head>
            <title>EasyDevOps</title>
            <style>
                body { font-family: sans-serif; text-align: center; background: #f4f4f9; padding-top: 100px; }
                .card { background: white; padding: 40px; border-radius: 10px; display: inline-block; box-shadow: 0 4px 8px rgba(0,0,0,0.1); }
                h1 { color: #0056b3; }
                img { width: 180px; }
            </style>
        </head>
        <body>
            <div class='card'>
                <img src='/itm.png' alt='ITM Logo'>
                <h1>EasyDevOps</h1>
                <p>Status: Online (Port 5000)</p>
            </div>
        </body>
    </html>", "text/html"));

app.Run();