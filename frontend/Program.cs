var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Zorg dat de app bestanden uit de wwwroot map (zoals itm.png) kan tonen
app.UseStaticFiles();

app.MapGet("/", () => Results.Content(@"
    <!DOCTYPE html>
    <html>
        <head>
            <title>EasyDevOps</title>
            <style>
                body { 
                    font-family: 'Segoe UI', Arial, sans-serif; 
                    text-align: center; 
                    background-color: #f4f4f9; 
                    padding-top: 100px; 
                }
                .container { 
                    background: white; 
                    padding: 40px; 
                    border-radius: 10px; 
                    box-shadow: 0 4px 8px rgba(0,0,0,0.1); 
                    display: inline-block; 
                }
                h1 { color: #0056b3; margin: 20px 0; }
                img { width: 180px; height: auto; }
            </style>
        </head>
        <body>
            <div class='container'>
                <img src='/itm.png' alt='ITM Logo'>
                <h1>EasyDevOps</h1>
                <p>Status: Operationeel</p>
            </div>
        </body>
    </html>", "text/html"));

app.Run();