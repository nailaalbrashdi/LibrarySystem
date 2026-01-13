using static System.Runtime.InteropServices.JavaScript.JSType;

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
            string[] bookCategories = new string[100]; // NEW - Fiction, Science, History, etc.
            string[] borrowCount = new string[100]; // NEW - track how many times each book was borrowed
            int LastBookIndex = -1;
            

            //seed data

            titles[0] = "Algebra";
            ISBNs[0] = "ISBN 0";
            authors[0] = "Ali";
            BorrowerNames[0] = "qais";
            availability[0]=false;
            bookCategories[0]= "mathematics";
            borrowCount[0] = "2";
            LastBookIndex++;

            titles[1] = "Physics";
            ISBNs[1] = "ISBN 1";
            authors[1] = "Omar";
            BorrowerNames[1] = "";
            availability[1] = true;
            bookCategories[1] = "science";
            borrowCount[1] = "0";
            LastBookIndex++;

            titles[2] = "Oman Culture";
            ISBNs[2] = "ISBN 2";
            authors[2] = "Naila";
            BorrowerNames[2] = "";
            availability[2] = true;
            bookCategories[2] = "History";
            borrowCount[2] = "4";
            LastBookIndex++;

            titles[3] = "Islamic Culture";
            ISBNs[3] = "ISBN 3";
            authors[3] = "rudaina";
            BorrowerNames[3] = "arwa";
            availability[3] = false;
            bookCategories[3] = "History";
            borrowCount[3] = "10";
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
                Console.WriteLine("7. Search Books by Category");
                Console.WriteLine("8. View Most Borrowed Books");
                Console.WriteLine("9. Exit");
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
                        Console.Write("Enter the book category: ");
                        bookCategories[LastBookIndex + 1] = Console.ReadLine();
                        availability[LastBookIndex + 1] = true;
                        Console.WriteLine("Book added successfully!");
                        LastBookIndex++;

                        break;


                    case 2:

                        Console.Write("Enter ISBN or Title: ");
                        string Input = Console.ReadLine();
                        bool Found = false;

                        for (int i = 0; i <100 ; i++)
                        {
                            if (titles[i] == Input || ISBNs[i] == Input)
                            {
                                //book is found in system
                                Found = true;

                                if (availability[i] == true)
                                {
                                    Console.Write("Borrower name: ");
                                    BorrowerNames[i] = Console.ReadLine();
                                    availability[i] = false;
                                    Console.WriteLine("Book borrowed successfully");
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Book already borrowed");
                                }

                                break;


                            }

                        }

                        if (Found == false)
                        {
                            Console.WriteLine("Book not found");
                        }



                        break;



                    case 3:

                        Console.Write("Enter ISBN or Title: ");
                        string input = Console.ReadLine();

                        bool found = false;

                        for (int i = 0; i <100; i++)
                        {
                            if (titles[i] == input || ISBNs[i] == input)
                            {
                                //book is found in system
                                found = true;



                                BorrowerNames[i] = "";
                                availability[i] = true;
                                Console.WriteLine("Book returned successfully");



                                break;


                            }

                        }

                        if (found == false)
                        {
                            Console.WriteLine("Book not found");
                        }




                        break;



                    case 4:

                        Console.Write("Enter ISBN or book title: ");
                        string INPUT = Console.ReadLine();
                        bool FOUND = false;
                        for (int i = 0; i < 100; i++)
                        {
                            if (INPUT == ISBNs[i] || INPUT == titles[i])
                            {
                                FOUND = true;
                                Console.WriteLine("Book title:" + titles[i]);
                                Console.WriteLine("Book author:" + authors[i]);
                                Console.WriteLine("Book ISBN:" + ISBNs[i]);
                                Console.WriteLine("Book availability:" + availability[i]);

                            }

                        }

                        if (FOUND == false)
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

                        Console.Write("Enter a category to search:");
                        string categoryInput = Console.ReadLine();
                        bool categoryFound = false;
                        for (int i = 0; i < 100; i++)
                        {
                            if (categoryInput == bookCategories[i])
                            {
                                categoryFound = true;
                                Console.WriteLine("Book title:" + titles[i]);
                                Console.WriteLine("Book author:" + authors[i]);
                                Console.WriteLine("Book ISBN:" + ISBNs[i]);
                                Console.WriteLine("Book availability:" + availability[i]);

                            }
                        }

                             if(categoryFound == false)
                        {
                            Console.WriteLine("no books found in this category");
                        }
                           

                        
                        


                        break;

                        
                    case 8:
                        break;




                    case 9:

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
