namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Phase1: system storage
            string[] titles = new string[100];
            string[] ISBNs = new string[100];
            string[] BorrowerNames = new string[100];
            string[] authors = new string[100];
            bool[] availability = new bool[100];
            int LastBookIndex = -1;

            //seed data

            titles[0] = "Math";
            ISBNs[0] = "ISBN 123";
            authors[0] = "Ali";
            BorrowerNames[0] = "qais";
            availability[0]=false;
            LastBookIndex++;

            titles[1] = "Science";
            ISBNs[1] = "ISBN 456";
            authors[1] = "Omar";
            BorrowerNames[1] = "mohammed";
            availability[1] = false;
            LastBookIndex++;


            bool exit = false;
            bool isAvaliable = true;

            while (true)
            {
                Console.WriteLine("Welcome to the library System");
                Console.WriteLine("1. Add New Book");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("4. Search Book");
                Console.WriteLine("5. List All Available Books ");
                Console.WriteLine("6. Transfer Book");
                Console.WriteLine("7. Exit");
                Console.Write("Please select an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:

                        Console.Write("Enter the book title: ");
                        titles[LastBookIndex + 1] = Console.ReadLine();
                        Console.Write("Enter the book author: ");
                        authors[LastBookIndex + 1] = Console.ReadLine();
                        Console.Write("Enter the book ISBN: ");
                        ISBNs[LastBookIndex + 1] = "ISBN" + (LastBookIndex + 1);
                        Console.WriteLine( ISBNs[LastBookIndex + 1]);
                        availability[LastBookIndex + 1] = true;
                        Console.WriteLine("Book added successfully!");
                        LastBookIndex++;

                        break;


                    case 2:

                        Console.Write("Enter ISBN: ");
                        string input = Console.ReadLine();
                        Console.Write("Enter a borrower name: ");
                        string borrowerName = Console.ReadLine();

                        bool isAvailable = false;
                        for (int i = 0; i < 100; i++)
                        {
                            if (input == ISBNs[i] || input == titles[i])
                            {
                                isAvailable = true;


                            }
                        }
                            if (isAvailable)
                            {
                                 Console.WriteLine("Book is available"); 
                            }
                            else
                            {
                                isAvailable = false;
                                Console.WriteLine("sorry Book is not available");
                            }


                        break;


                    case 3:
                        Console.Write("Enter ISBN:");
                        string returnISBN = Console.ReadLine();

                        bool isaAvailable = false;
                        for (int i = 0; i < 100; i++)
                        {
                            if(returnISBN != ISBNs[i])
                            {
                                isaAvailable = false;

                            }
                        }

                        if (isaAvailable == true)
                        {
                            Console.Write("book is returned");
                        }
                        else
                        {
                            Console.Write("book is not returned");
                        }

                            break;


                    case 4:
                        break;


                    case 5:
                        break;


                    case 6:
                        break;



                    case 7:
                        break;


                    default:
                        break;

                }


















            }
        }
    }
}
