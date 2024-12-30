using System;

namespace StudentManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUDStudent crudStudent = new CRUDStudent();
            bool exit = false;
            Console.WriteLine("Welcome to the Student Management Application!");

            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display All Students");
                Console.WriteLine("3. Search Student by Name");
                Console.WriteLine("4. Search Student by Grade");
                Console.WriteLine("5. Update Student");
                Console.WriteLine("6. Remove Student");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            crudStudent.AddStudent();
                            Console.WriteLine("Student added successfully!");
                            break;

                        case 2:

                            Console.WriteLine("\nAll Students:");
                            crudStudent.DisplayAllStudents();
                            break;

                        case 3:

                            Console.Write("Enter student name to search: ");
                            string nameToSearch = Console.ReadLine();
                            crudStudent.SearchByName(nameToSearch);
                            break;

                        case 4:

                            Console.Write("Enter student grade to search: ");
                            string gradeToSearch = Console.ReadLine();
                            crudStudent.SearchByGrade(gradeToSearch);
                            break;

                        case 5:

                            Console.Write("Enter student ID to update: ");
                            int idToUpdate = Convert.ToInt32(Console.ReadLine());
                            crudStudent.UpdateStudent(idToUpdate);
                            break;

                        case 6:

                            Console.Write("Enter student ID to remove: ");
                            int idToRemove = Convert.ToInt32(Console.ReadLine());
                            crudStudent.RemoveStudent(idToRemove);
                            break;

                        case 7:

                            Console.WriteLine("Exiting the application. Goodbye!");
                            exit = true;

                            break;
                        default:

                            Console.WriteLine("Invalid choice! Please try again.");
                            break;
                    }
                }
                catch (StudentNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
