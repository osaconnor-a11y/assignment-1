var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// BOOK ROUTES
app.MapGet("/books", () => "Getting all books");
app.MapPost("/books", () => "Book added");
app.MapPut("/books/{id}", (int id) => $"Book {id} updated");
app.MapDelete("/books/{id}", (int id) => $"Book {id} deleted");

// READER ROUTES
app.MapGet("/readers", () => "Getting all readers");
app.MapPost("/readers", () => "Reader added");
app.MapPut("/readers/{id}", (int id) => $"Reader {id} updated");
app.MapDelete("/readers/{id}", (int id) => $"Reader {id} deleted");

// BORROWING ROUTES
app.MapGet("/borrowings", () => "Getting all borrowings");
app.MapPost("/borrowings", () => "Borrowing created");
app.MapPut("/borrowings/{id}", (int id) => $"Borrowing {id} updated");
app.MapDelete("/borrowings/{id}", (int id) => $"Borrowing {id} deleted");

app.Run();
