using Library;

Book book = new Book("C# for Beginners", "BillGates", "12345678");
Book book1 = new Book("C# Methods and Classes", "Microsoft", "55667778");

Console.WriteLine("=======================\nCurrent books\n=======================");
book.DisplayBookInfo();
book1.DisplayBookInfo();

Member member = new Member(1, "John Smith", "1 High Street", "0790090090");
Member member1 = new Member(2, "Mary Jones", "102 Garden Road", "0790345666");

Console.WriteLine("=======================\nCurrent library members\n=======================");
member.DisplayInfo();
member1.DisplayInfo();