// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Book fablehaven = new Book("Fablehaven","Brandon Mull");
fablehaven.Display();

Book bom = new Book("Book of Mormon","Mormon");
bom.CheckOut();
bom.Display();
bom.CheckIn();
bom.Display();

Console.WriteLine(bom.HasAuthor("Mormon"));

Console.WriteLine(bom.HasAuthor("Smith"));