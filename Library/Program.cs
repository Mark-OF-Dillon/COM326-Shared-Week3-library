using Library;

List<Book> books = new List<Book>();
List<Member> members = new List<Member>();

books.Add(new Book("C# for beginners", "BillGates", "12345678"));
books.Add(new Book("C# Methods and classes", "Microsoft", "55667778"));

members.Add(new Member(1, "John Smith", "1 High Street", 0790090090));
members.Add(new Member(2, "Mary Jones", "102 Garden Road", 0790345666));

//Display all items in the book list
foreach (Book book in books)
{
    Console.WriteLine($"Book Title: {book.Title}");
    Console.WriteLine($"Book Author: {book.Author}");
    Console.WriteLine($"Book ISBN: {book.ISBN}");
}

//Display all items in the member list
foreach (Member member in members)
{
    Console.WriteLine($"Member ID: {member.MemberId}");
    Console.WriteLine($"Member Name: {member.Name}");
    Console.WriteLine($"Member Address: {member.Address}");
    Console.WriteLine($"Member Phone: {member.Phone}");
}