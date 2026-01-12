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
            ISBNs[0] = "ISBN 0";
            authors[0] = "Ali";
            BorrowerNames[0] = "qais";
            availability[0]=false;
            LastBookIndex++;

            titles[1] = "Science";
            ISBNs[1] = "ISBN 1";
            authors[1] = "Omar";
            BorrowerNames[1] = "";
            availability[1] = true;
            LastBookIndex++;

            titles[2] = "Arabic";
            ISBNs[2] = "ISBN 2";
            authors[2] = "Naila";
            BorrowerNames[2] = "";
            availability[2] = true;
            LastBookIndex++;

            titles[3] = "history";
            ISBNs[3] = "ISBN 3";
            authors[3] = "rudaina";
            BorrowerNames[3] = "arwa";
            availability[3] = false;
            LastBookIndex++;


            bool exit = false;

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
                        Console.WriteLine(ISBNs[LastBookIndex + 1]);
                        availability[LastBookIndex + 1] = true;
                        Console.WriteLine("Book added successfully!");
                        LastBookIndex++;

                        break;


                    case 2:

                        Console.Write("Enter ISBN or book title: ");
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
                            if (returnISBN != ISBNs[i])
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

                        Console.Write("Enter ISBN or book title: ");
                        string Input = Console.ReadLine();
                        bool found = false;
                        for (int i = 0; i < 100; i++)
                        {
                            if (Input == ISBNs[i] || Input == titles[i])
                            {
                                found = true;
                                Console.WriteLine("Book title:" + titles[i]);
                                Console.WriteLine("Book author:" + authors[i]);
                                Console.WriteLine("Book ISBN:" + ISBNs[i]);
                                Console.WriteLine("Book availability:" + availability[i]);

                            }

                        }

                        if (found == false)
                        {
                            Console.WriteLine("Book not found");
                        }

                        break;


                    case 5:

                        Console.WriteLine("Available Books:");

                        for (int i = 0; i < 100; i++)
                        {
                            if (availability[i] == true)
                            {

                                Console.WriteLine("Book title:" + titles[i]);
                                Console.WriteLine("Book author:" + authors[i]);
                                Console.WriteLine("Book ISBN:" + ISBNs[i]);

                                break;

                            }

                        }

                        break;



                    case 6:

                        Console.Write("Enter current borrower name:");
                        string currentBorrower = Console.ReadLine();
                        Console.Write("Enter new borrower name:");
                        string newBorrower = Console.ReadLine();
                        Console.Write("Enter ISBN:");
                        string transferISBN = Console.ReadLine();
                        bool currentBorrowerFound = false;
                        int currentBorrowerIndex = 0;

                        for (int i = 0; i < 100; i++)
                        {
                            if (currentBorrower == BorrowerNames[i])
                            {
                                currentBorrowerIndex = i;
                                currentBorrowerFound = true;
                                break;

                            }
                        }
                        if (currentBorrowerFound == false)
                        {
                            Console.WriteLine("current borrower name not found");
                        }
                        else
                        {
                            bool newBorrowerFound = false;
                            int newBorrowerIndex = 0;
                            for (int i = 0; i < 100; i++)
                            {
                                if (newBorrower == BorrowerNames[i])
                                {
                                    newBorrowerIndex = i;
                                    newBorrowerFound = true;
                                    break;

                                }
                            }
                            if (newBorrowerFound == false)
                            {
                                Console.WriteLine("New borrower name not found");
                            }
                            else
                            {
                                string temp = BorrowerNames[currentBorrowerIndex];
                                BorrowerNames[currentBorrowerIndex] = BorrowerNames[newBorrowerIndex];
                                BorrowerNames[newBorrowerIndex] = temp;



                            }
                        }               
            
                        break;


                    case 7:

                        exit = true;

                        break;


                    default:

                        Console.WriteLine("Invalid option, please try again.");

                        break;

                }

                if (exit == true)
                {
                    break;
                }


                Console.WriteLine("Thank you for using the Library System, press any key....");
                Console.ReadLine();
                Console.Clear();

















            }
        }
    }
}
