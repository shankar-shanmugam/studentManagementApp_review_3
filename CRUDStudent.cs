using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementApp
{
    public class CRUDStudent
    {
       private List<Student> studentList;

        public CRUDStudent()
        { 
            studentList = new List<Student>();
        }

        public void AddStudent()
        {
            Student s = PromptDataFromUser();
            studentList.Add(s);
        }

        public void DisplayAllStudents()
        {
            if(studentList.Count == 0 || studentList == null)
            {
                Console.WriteLine("List is empty No records to show ");
            }

            studentList.ForEach(x => Console.WriteLine(x));

        }

        public void SearchByName(string name)
        {
          Student s =  studentList.Find(x => x.Name.Equals(name));
            if(s != null)
            {
                Console.WriteLine("student is found : "+ s );
            }
            else
            {
                throw new StudentNotFoundException(" student is not in the list ");
            }

        }
        public void SearchByGrade(string grade)
        {
            Student s = studentList.Find(x => x.Grade.Equals(grade));

            if (s != null)
            {
                Console.WriteLine("student is found : " + s);
            }
            else
            {
                throw new StudentNotFoundException(" student is not in the list ");
            }

        }
        public void UpdateStudent(int studentId)
        {
          Student s =  studentList.Find(x=>x.Id==studentId);
            if(s == null)
            {
                throw new StudentNotFoundException(" student is not in the list ");
            }
            else
            {
                Console.WriteLine(" Enter the user to choose which one he want to update : ");
                Console.WriteLine(" 1) update name \n 2) update age \n  3) update grade  \n 4) update email ");

                int choice = Convert.ToInt32(Console.ReadLine());
                StudentValidation valid=new StudentValidation();
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("enter updated Name : ");
                        string name=Console.ReadLine();
                        if (valid.ValidateName(name))
                            s.Name = name;
                        else
                            throw new ValidationException($"{name} you entered is not valid ");
                        break;

                    case 2:
                        Console.WriteLine(" Enter updated age :");
                        string age = Console.ReadLine();
                        if (valid.ValidateAge(age))
                            s.Age = age;
                        else
                            throw new ValidationException($"{age} you entered is not valid ");
                        break;

                    case 3:
                        Console.WriteLine(" Enter updated Grade :");
                        string grade = Console.ReadLine();
                        if (valid.ValidateGrade(grade))
                            s.Grade=grade;
                        else
                            throw new ValidationException($"{grade} you entered is not valid ");
                        break;

                    case 4:
                        Console.WriteLine(" Enter updated email :");
                        string email = Console.ReadLine();
                        if (valid.ValidateEmail(email))
                            s.Email = email;
                        else
                            throw new ValidationException($"{email} you entered is not valid ");
                        break;

                    default:
                        Console.WriteLine("Invalid choice try again----");
                        break;

                }

                Console.WriteLine($"updated student details are :{s}");
            }
        }

        public void RemoveStudent(int studentId)
        {
            Student s = studentList.Find(x => x.Id == studentId);
            if (s == null)
            {
                throw new StudentNotFoundException(" student is not in the list ");
            }

            if (studentList.Remove(s))
                Console.WriteLine($"{s} successfully removed");
            else
                Console.WriteLine("student not removed");
        }

        public Student PromptDataFromUser()
        {
            Console.Write("Enter the student ID :");
            int studentId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the student Name :");
            string studentName = Console.ReadLine();

            Console.Write("Enter the student Age :");
            string studentAge = Console.ReadLine();

            Console.Write("Enter the student grade :");
            string studentGrade = Console.ReadLine();

            Console.Write("Enter the student Email :");
            string studentEmail = Console.ReadLine();

            try
            {
                ValidatePromptData(studentName, studentEmail, studentGrade, studentAge);
            }
            catch (ValidationException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            return new Student { Age = studentAge,Email=studentEmail,Id=studentId,Name=studentName,Grade=studentGrade };
        }

        public void ValidatePromptData(string name,string email,string grade,string age)
        {

            StudentValidation valid= new StudentValidation();

            if (valid.ValidateName(name))
                Console.WriteLine("student name is valid ");
            else
                throw new ValidationException($"{name} is not valid ");

            if (valid.ValidateEmail(email))
                Console.WriteLine(" student email is valid ");
            else
                throw new ValidationException($"{email} is not valid ");

            if (valid.ValidateGrade(grade))
                Console.WriteLine("student grade is valid");
            else
                throw new ValidationException($"{grade} is not valid ");

            if (valid.ValidateAge(age))
                Console.WriteLine("student age is valid ");
            else
                throw new ValidationException($"{age} is not valid ");

        }

    }
}
