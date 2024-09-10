using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Xml.Linq;

namespace CRT
{
    class Program
    {
        static List<Student> stu = new List<Student>();
        static List<TPO> tpo = new List<TPO>();
        public static int apply = 0;
        static List<Company> company = new List<Company>();

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\tWELCOME TO CAMPUS RECRUITMENT PORTAL\n");
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("1. Login as Student");
                Console.WriteLine("2. Login as TPO");
                Console.WriteLine("3. Signup as Student");
                Console.WriteLine("4. Signup as TPO");
                Console.WriteLine("5. Login as Company");
                Console.WriteLine("6. Signup as Company");
                Console.WriteLine("7. Exit");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("\nEnter your choice: ");
                Console.ForegroundColor = ConsoleColor.White;
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        LoginAsStudent();
                        break;
                    case 2:
                        LoginAsTPO();
                        break;
                    case 3:
                        SignUpAsstu();
                        break;
                    case 4:
                        SignUpAsTPO();
                        break;
                    case 5:
                        LoginAsComp();
                        break;
                    case 6:
                        comp();
                        break;
                    case 7:
                        exit = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                }
            }
        }

        static void LoginAsStudent()
        {

            if (stu.Count > 0)
            {

                Thread.Sleep(1500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n\tSTUDENT SIGN IN PORTAL \n\n");
                Console.ForegroundColor = ConsoleColor.Yellow;

                Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter your Email\t: ");
                Console.ForegroundColor = ConsoleColor.White;
                string email = Console.ReadLine().ToUpper();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter your password\t: ");
                Console.ForegroundColor = ConsoleColor.White;
                string password = Console.ReadLine();


                Student stud = stu.Find(s => s.Email == email && s.Password == password);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\tLogin Successfull..");
                Thread.Sleep(1500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                if (stud != null)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\tWELCOME, {stud.Name}!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    // Implement Student functionalities here

                    bool exit = false;
                    while (exit != true)
                    {

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write(" 1. Profile\n 2. Job Alerts\n 3. Check Status\n 4. Logout");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\nCHOICE : ");
                        Console.ForegroundColor = ConsoleColor.White;
                        int ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                            Profile:
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"NAME            : {stud.Name}");
                                Console.WriteLine($"ROLL NO         : {stud.RollNo}");
                                Console.WriteLine($"Gender          : {stud.Gender}");
                                Console.WriteLine($"PHONE NUMBER    : {stud.Phno}");
                                Console.WriteLine($"EMAIL           : {stud.Email}");
                                Console.WriteLine($"DATE OF BIRTH   : {stud.DOB}");
                                Console.WriteLine($"BRANCH          : {stud.Branch}");
                                Console.WriteLine($"COLLEGE NAME    : {stud.Clg}");
                                Console.WriteLine($"COLLEGE CODE    : {stud.Clgcode}");
                                Console.WriteLine($"ADDRESS         : {stud.Add}");

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n1.Update Profile\t2.Delete Profile\t3.Home");
                                Console.Write("\nEnter Choice : ");
                                int c2 = Convert.ToInt32(Console.ReadLine());
                                if (c2 == 1)
                                {
                                UpdateStu:
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Clear();
                                    Console.WriteLine("\t\tProfile Updation");
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nChoose Field to update \n\t1. Name\n\t2. Phone Number\n\t3. Mail\n\t4. Address");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.Write("\nEnter Choice (1-4) : ");
                                    int c7 = Convert.ToInt32(Console.ReadLine());


                                    if (c7 < 1 && c7 > 4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("\nInvlid Choice...");
                                        Thread.Sleep(1500);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto UpdateStu;
                                    }

                                    else if (c7 == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("\nUpdate Name : ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        stud.Name = Console.ReadLine().ToUpper();

                                    }
                                    else if (c7 == 2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("\nUpdate Mobile Number : ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        stud.Phno = Convert.ToInt64(Console.ReadLine());
                                    }
                                    else if (c7 == 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("\nUpdate Email : ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        stud.Email = Console.ReadLine().ToUpper();
                                    }
                                    else if (c7 == 4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("\nUpdate Address : ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        stud.Add = Console.ReadLine().ToUpper();
                                    }

                                UpdCh:
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("Want to Update another \n    1.Yes\t2.No");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Enter Choice : ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    int b1 = Convert.ToInt32(Console.ReadLine());

                                    if (b1 == 1)
                                    {
                                        goto UpdateStu;
                                    }
                                    else if (b1 < 1 && b1 > 2)
                                    {
                                        Console.WriteLine("Enter Valid Choice..");
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        goto UpdCh;
                                    }

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Thread.Sleep(1500);
                                    Console.Clear();
                                    Console.WriteLine("\nProfile Updated Successfully...");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    goto Profile;
                                }
                                else if (c2 == 2)
                                {
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.Write("Are you sure to want to delete Profile\n\t1.Yes\t2.No\n\nEnter Choice : ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    int dp = Convert.ToInt32(Console.ReadLine());
                                    if (dp == 1)
                                    {


                                        //stu.Clear();
                                        //stu.RemoveAll(stud.Name,stud.RollNo,stud.DOB,stud.Gender,stud.Phno,stud.Email,stud.Add,stud.Branch,stud.Password);
                                        stud.Name = "";
                                        stud.RollNo = "";
                                        stud.DOB = "";
                                        stud.Gender = "";
                                        stud.Phno = 0;
                                        stud.Email = "";
                                        stud.Add = "";
                                        stud.Branch = "";
                                        stud.Clg = "";
                                        stud.Clgcode = "";

                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        Console.WriteLine("Profile Deleted Successfully...");
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.White;

                                    }
                                    else
                                    {
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        Console.WriteLine("\n\n");

                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine();
                                Thread.Sleep(1000);
                                Console.Clear();
                                if (company.Count > 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("\tJOB OFFERS AVAILABLE ");


                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine($"the compnys the accepted by your TPO ");
                                    foreach (Company compy in company)
                                    {
                                        if (compy.sal != 0 && compy.app == 1)
                                        {

                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.WriteLine($"Company Name    : {compy.CName}");
                                            Console.WriteLine($"Job Role        : {compy.job}");
                                            Console.WriteLine($"Skills Required : {compy.skill}");
                                            Console.WriteLine($"Salary          : {compy.sal}");
                                            Console.WriteLine($"Vacancies       : {compy.vacanci}");
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.WriteLine();
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine("Do You Wanna apply for the Job? \n1.Yes\t2.No");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            int ch2 = Convert.ToInt32(Console.ReadLine());
                                            if (ch2 == 1)
                                            {

                                                Thread.Sleep(2000);
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine($"Hey {stud.Name},You Successfully applied for this job");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                compy.stuapply.Add(stud.RollNo);
                                                apply++;
                                            }


                                        }

                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("No Companies are hiring currently.....!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }


                                break;

                            case 3:
                                int co = 0;
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Thread.Sleep(1500);
                                Console.WriteLine("\n\nJob Application Status\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                if (apply != 0)
                                {
                                    foreach (Company compy in company)
                                    {
                                        foreach (string se in compy.hire)
                                        {
                                            if (String.Compare(se, stud.RollNo) == 0)
                                            {
                                                co++;
                                            }
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            if (co != 0) Console.WriteLine($"Congratulation! You are hired in {compy.CName} as a {compy.job}");
                                            Console.ForegroundColor = ConsoleColor.White;

                                        }


                                    }
                                    Thread.Sleep(1500);
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    if (co == 0) Console.WriteLine("Status Pending..");
                                    Thread.Sleep(2000);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("You haven't applied for a job yet..");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Thread.Sleep(1500);
                                    Console.Clear();
                                }





                                break;
                            case 4:

                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Are you sure to want to Logout\n\t1.Yes\t2.No");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("\nEnter Choice : ");
                                Console.ForegroundColor = ConsoleColor.White;
                                int lc = Convert.ToInt32(Console.ReadLine());
                                if (lc == 1)
                                {
                                    Thread.Sleep(1000);
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\n\n\tSigning off..See you again...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Thread.Sleep(1800);
                                    Console.Clear();
                                    exit = true;
                                }
                                else
                                {
                                    Thread.Sleep(1500);
                                    Console.Clear();
                                }
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Input");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid username or password.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No Student Registered Yet...");
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("Wanna Register \n1.Yes \t2.No\n\nEnter Choice : ");
                Console.ForegroundColor = ConsoleColor.White;
                int sr = Convert.ToInt32(Console.ReadLine());

                if (sr == 1)
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    SignUpAsstu();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Going Back...");
                    Thread.Sleep(1000);
                    Console.Clear();
                }

            }

        }
        static void LoginAsTPO()
        {

            if (tpo.Count > 0)
            {


                Thread.Sleep(1500);
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\tTPO SIGN IN PORTAL\n\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("ENTER TPO MAIL ID\t: ");
                Console.ForegroundColor = ConsoleColor.White;
                string email = Console.ReadLine().ToUpper();                         //reading TPO - id from tpo                                
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("ENTER PASSWORD\t\t: ");
                Console.ForegroundColor = ConsoleColor.White;
                string password = Console.ReadLine();


                TPO tpoo = tpo.Find(b => b.Email == email && b.Password == password);
                if (tpoo != null)
                {
                    Thread.Sleep(1500);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n\t\t\tDASHBOARD");
                    Console.WriteLine("\n--------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Blue;

                    // Implement TPO functionalities here
                    Console.ForegroundColor = ConsoleColor.White;
                    bool exit = false;
                    while (exit != true)
                    {


                        Console.WriteLine($"\n\t\tWELCOME, {tpoo.Name}!");

                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.Write("1.Profile\n2.Notifications\n3.LogOut\n\nEnter Choice : ");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {
                            case 1://Profile
                            TpProf:
                                Thread.Sleep(1500);
                                Console.Clear();

                                Console.WriteLine("\tTPO PROFILE PAGE\n\n");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine($"NAME            : {tpoo.Name}");
                                Console.WriteLine($"GENDER          : {tpoo.Gender}");
                                Console.WriteLine($"PHONE           : {tpoo.Phno}");
                                Console.WriteLine($"EMAIL           : {tpoo.Email}");
                                Console.WriteLine($"QUALIFICATION   : {tpoo.Quali}");
                                Console.WriteLine($"EXPERIENCE      : {tpoo.Exper}");
                                Console.WriteLine($"COLLEGE NAME    : {tpoo.Clgname}");
                                Console.WriteLine($"COLLEGE CODE    : {tpoo.Clgcode}");
                                Console.WriteLine($"COLLEGE ADDRESS : {tpoo.CAdd}");
                                Console.ForegroundColor = ConsoleColor.White;


                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("\n\nWanna Update your Profile \n\t1. Yes\n\t2. No\nEnter Choice : ");
                                Console.ForegroundColor = ConsoleColor.White;
                                int c1 = Convert.ToInt32(Console.ReadLine());
                                if (c1 == 1)
                                {
                                UpdateTpo:
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Clear();
                                    Console.Write("\t\tProfile Updation");
                                    Console.WriteLine("-----------------------------------------------");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nChoose Field to update \n\t1.Name\n\t2. Phone Number\n\t3.Email\n\t4. Qualification\n\t5. Experience");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    Console.Write("Enter Choice (1-5) : ");
                                    int c7 = Convert.ToInt32(Console.ReadLine());


                                    if (c7 < 1 && c7 > 5)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("\nInvlid Choice...");
                                        Thread.Sleep(1000);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        goto UpdateTpo;
                                    }

                                    else if (c7 == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("\nUpdate Name : ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        tpoo.Name = Console.ReadLine().ToUpper();

                                    }
                                    else if (c7 == 2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("\nUpdate Mobile Number\t: ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        tpoo.Phno = Convert.ToInt64(Console.ReadLine());
                                    }
                                    else if (c7 == 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("\nUpdate Mail\t: ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        tpoo.Email = Console.ReadLine().ToUpper();
                                    }
                                    else if (c7 == 4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("\nUpdate Qualification\t: ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        tpoo.Quali = Console.ReadLine().ToUpper();
                                    }
                                    else if (c7 == 5)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("\nUpdate Experience\t: ");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        tpoo.Exper = Convert.ToInt32(Console.ReadLine());
                                    }

                                UpdCh:
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Want to Update another \n\t1.Yes\n\t2.No");
                                    Console.Write("Enter Choice : ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    int b1 = Convert.ToInt32(Console.ReadLine());

                                    if (b1 == 1)
                                    {
                                        goto UpdateTpo;
                                    }
                                    else if (b1 == 2)
                                    {
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("\nGoing Back...");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter Valid Choice..");
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        goto UpdCh;
                                    }

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Thread.Sleep(1500);
                                    Console.Clear();
                                    Console.WriteLine("\nProfile Updated Successfully...");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    goto TpProf;
                                }
                                Thread.Sleep(1500);
                                Console.WriteLine("\n\n");

                                break;
                            case 2:
                                Thread.Sleep(1000);
                                Console.Clear();

                                Console.WriteLine("\tNOTIFICATIONS");
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write("\n1.Companies\n2.Students");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n\nEnter Choice : ");
                                Console.ForegroundColor = ConsoleColor.White;
                                int ch3 = Convert.ToInt32(Console.ReadLine());
                                if (ch3 == 1)
                                {
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("\tCOMPANIES HIRING\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    foreach (Company compy in company)
                                    {
                                        foreach (string set in compy.hrsent)
                                        {


                                            if (set == tpoo.Name)
                                            {
                                                Console.WriteLine($"COMPANY NAME    : {compy.CName}");
                                                Console.WriteLine($"JOB ROLE        : {compy.job}");
                                                Console.WriteLine($"SKILL REQUIRED  : {compy.skill}");
                                                Console.WriteLine($"SALARY          : {compy.sal}");
                                                Console.WriteLine($"VACCANCIES      : {compy.vacanci}");
                                                Console.WriteLine();
                                                Console.WriteLine();

                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.Write("Do You Wanna Forward to Student? \n   1.Yes\t2.No\nEnter Choice :");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                int ch2 = Convert.ToInt32(Console.ReadLine());
                                                if (ch2 == 1)
                                                {
                                                    Thread.Sleep(1000);
                                                    Console.Clear();
                                                    compy.app = 1;
                                                }
                                                else
                                                    compy.app = 0;

                                            }
                                        }

                                    }
                                }
                                else
                                if (ch3 == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    Console.WriteLine("\n\ntSTUDENTS APPLIED TO COMPANIES \n");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    foreach (Company compy in company)
                                    {
                                        if (compy.app == 1)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"COMPANY NAME\t:\t{compy.CName}");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            foreach (string se in compy.stuapply)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Cyan;
                                                Console.WriteLine($"STUDENT ROLL\t:\t{se}");
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.Write("\nDo You Wanna Forward this student to Company? \n1.Yes\n2.No\n\nEnter Choice : ");
                                                Console.ForegroundColor = ConsoleColor.White;

                                                int ch4 = Convert.ToInt32(Console.ReadLine());
                                                if (ch4 == 1)
                                                {
                                                    Thread.Sleep(1000);
                                                    Console.ForegroundColor = ConsoleColor.Green;
                                                    Console.WriteLine("Student details Sent successfully to Company..");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Thread.Sleep(1500);
                                                    continue;
                                                }
                                                else
                                                    if (ch4 == 2)
                                                    compy.stuapply.Remove(se);
                                            }

                                        }

                                    }

                                }



                                break;
                            case 3:
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Are you sure to want to Logout\n\t1.Yes\t2.No");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Enter Choice : ");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.ForegroundColor = ConsoleColor.White;
                                int c2 = Convert.ToInt32(Console.ReadLine());
                                if (c2 == 1)
                                {
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("See you again...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    exit = true;
                                }
                                else
                                {
                                    Thread.Sleep(1500);
                                    Console.Clear();
                                }

                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Input");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid username or password.\n\n");
                    Thread.Sleep(1500);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {

            c:
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("TPO not yet registered..");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Thread.Sleep(1500);
                Console.Write("\nWanna Register\n1.Yes\t2.No\n\nEnter Choice : ");
                Console.ForegroundColor = ConsoleColor.White;
                int c = Convert.ToInt32(Console.ReadLine());

                if (c == 1)
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                    SignUpAsTPO();

                }
                else if (c == 2)
                {
                    Thread.Sleep(1000);
                    Console.Clear();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter Valid Choice...");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto c;
                }
            }
        }

        static void LoginAsComp()
        {

            if (company.Count > 0)
            {


                Thread.Sleep(1000);
                Console.Clear();


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n\n\tCONPANY SIGN IN PORTAL \n\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter your Email: ");
                Console.ForegroundColor = ConsoleColor.White;
                string email = Console.ReadLine().ToUpper();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter Password\t: ");
                Console.ForegroundColor = ConsoleColor.White;
                string password = Console.ReadLine();

                Company compy = company.Find(b => b.Email == email && b.Pass == password);
                if (compy != null)
                {
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\n\n\t{compy.CName} Welcomes you!!\n\n");
                    Console.ForegroundColor = ConsoleColor.White;

                    // Implement TPO functionalities here
                    bool exit = false;
                    while (exit != true)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("1. About\n2. Offer Jobs\n3. Notification\n4. LogOut");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\nEnter Choice : ");
                        Console.ForegroundColor = ConsoleColor.White;
                        int ch = Convert.ToInt32(Console.ReadLine());
                        switch (ch)
                        {

                            //public company(string cName, string type, string isin, string industry, string founder, string temp, string wbs, string email, string pass)
                            case 1://Profile
                                Thread.Sleep(1500);
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"\n\t\tAbout {compy.CName} \n");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($"COMPANY NAME        : {compy.CName}");
                                Console.WriteLine($"COMPANY TYPE        : {compy.Type}");
                                Console.WriteLine($"ISIN                : {compy.Isin}");
                                Console.WriteLine($"INDUSTRY            : {compy.Industry}");
                                Console.WriteLine($"FOUNDATION          : {compy.Founder}");
                                Console.WriteLine($"TOTAL EMPLOYEES     : {compy.Temp}");
                                Console.WriteLine($"WEBSITE             : {compy.Wbs}");
                                Console.ForegroundColor = ConsoleColor.White;

                                Thread.Sleep(2000);
                                Console.WriteLine();
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Wanna Hire\n1.Yes\t2.no\n\nEnter Choice : ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                int ch1 = Convert.ToInt32(Console.ReadLine());
                                if (ch1 == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Job Role\t: ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    compy.job = Console.ReadLine().ToUpper();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Skill Required\t: ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    compy.skill = Console.ReadLine().ToUpper();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Salary Offered\t: ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    compy.sal = Convert.ToInt64(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Vacancies\t: ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    compy.vacanci = Convert.ToInt32(Console.ReadLine());
                                    Thread.Sleep(1500);
                                    Console.Clear();
                                call:

                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("Wanna forward these to TPO  : \n     1. Yes\t 2. No\nEnter Choice : ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    int tc = Convert.ToInt32(Console.ReadLine());

                                    if (tc == 1)
                                    {
                                        foreach (TPO te in tpo)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                                            Console.WriteLine($"TPO NAME     : {te.Name}");
                                            Console.WriteLine($"COLLEGE NAME : {te.Clgname}\n\n");
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("Do You want to forward to this TPO\n1.Yes\n2.No\nEnter Choice : ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            int ch5 = Convert.ToInt32(Console.ReadLine());
                                            if (ch5 == 1)
                                            {
                                                //company.Add(new Company(cname, type, isin, iind, founder, year, wt, wbs, email, pass));
                                                Thread.Sleep(1500);
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                compy.hrsent.Add(te.Name);
                                                Console.WriteLine("\nNotification details sent Successfully..\n\n");
                                                Thread.Sleep(1500);


                                            }

                                        }


                                    }


                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }

                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\n\tSTUDENTS REGISTERED FOR THIS JOB\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                foreach (string se in compy.stuapply)
                                {
                                    foreach (Student st in stu)
                                    {
                                        if (se == st.RollNo)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.WriteLine($"NAME            : {st.Name}");
                                            Console.WriteLine($"ROLL NO         : {st.RollNo}");
                                            Console.WriteLine($"GENDER          : {st.Gender}");
                                            Console.WriteLine($"PHONE NUM       : {st.Phno}");
                                            Console.WriteLine($"DATE OF BIRTH   : {st.DOB}");
                                            Console.WriteLine($"BRANCH          : {st.Branch}");
                                            Console.WriteLine($"ADDRESS         : {st.Add}");
                                            Console.WriteLine();
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.Write("Do You Wanna Hire Him\n1.Yes\n2.No\n\nEnter Choice : ");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            int ch2 = Convert.ToInt32(Console.ReadLine());
                                            if (ch2 == 1)
                                            {
                                                Thread.Sleep(1000);
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                compy.hire.Add(st.RollNo);
                                                Console.Clear();
                                                Console.WriteLine($"\nYou hired Mr/Mrs.{st.Name} Successfylly as a {compy.job} \n\n");
                                                Thread.Sleep(1500);


                                            }

                                        }
                                    }
                                }


                                break;
                            case 4:
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Are you sure to want to Logout\n\t1.Yes\t2.No");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("Enter Choice : ");
                                Console.ForegroundColor = ConsoleColor.White;
                                int c2 = Convert.ToInt32(Console.ReadLine());
                                if (c2 == 1)
                                {
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("See you again...");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    exit = true;

                                }
                                else
                                {
                                    Thread.Sleep(1500);
                                    Console.Clear();
                                }
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid Input");
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                        }
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid username or password.");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            else
            {
                Thread.Sleep(1000);
                Console.Clear();
            cr:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No company regiestered yet...");
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nWanna register \n\t1.Yes\t2.No\n\nEnter Choice : ");
                Console.ForegroundColor = ConsoleColor.White;
                int cr = Convert.ToInt32(Console.ReadLine());
                if (cr == 1)
                {
                    Thread.Sleep(1000);
                    comp();
                }
                else if (cr == 2)
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\nEnter valid Choice..");
                    Thread.Sleep(1800);
                    Console.Clear();
                    goto cr;
                }
            }
        }

        static void SignUpAsstu()
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\tSTUDENT SIGN UP PORTAL \n\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter Name\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter RollNo\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string roll = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter DOB(dd/mm/yyyy)\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string dob = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter Gender\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string gen = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter Phone Number\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            long phno = Convert.ToInt64(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter Email\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string email = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter Address\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string add = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter Branch\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string branch = Console.ReadLine().ToUpper();


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NOTE : College Name can't be modified..");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter College Name\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string clg = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter College Code\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string clgcode = Console.ReadLine().ToUpper();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Profile Created Successfully...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.Clear();

        P:
            string password;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Set a Password (4-12) alphanumeric Characters\t: ");
                Console.ForegroundColor = ConsoleColor.White;
                password = Console.ReadLine();
                //Console.Clear();

            } while (password.Length <= 3 || password.Length > 12);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("CONFIRM PASSWORD\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string P1 = Console.ReadLine();

            if (password == P1)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Registered Successfully...");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                Console.Clear();

                stu.Add(new Student(name, roll, dob, gen, phno, email, add, branch, clg, clgcode, password));

            lc:
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\n\nDo you Wanna Sign in now..\n\t1.Yes\t2.No\n\nEnter Choice : ");
                Console.ForegroundColor = ConsoleColor.White;
                int lc = Convert.ToInt32(Console.ReadLine());
                if (lc == 1)
                {
                    LoginAsStudent();
                }
                else if (lc == 2)
                {
                    Thread.Sleep(1000);
                    Console.Clear();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter Valid Choice ");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    goto lc;
                }


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password Not Matched..");
                Console.ForegroundColor = ConsoleColor.White;
                goto P;
            }





        }



        static void SignUpAsTPO()
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\tTPO SIGN UP PORTAL\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter Name\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter Gender\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string gen = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter Phone Number\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            long phno = Convert.ToInt64(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter Email\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string email = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter Qualification\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string quali = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter Experience\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            int exp = Convert.ToInt32(Console.ReadLine());


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter College name\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string clgname = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter College Code\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string ccode = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter College Address\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string add = Console.ReadLine().ToUpper();



        P:
            string password;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Set a Password (4-12) alphanumeric Characters\t: ");
                Console.ForegroundColor = ConsoleColor.White;
                password = Console.ReadLine();
                //Console.Clear();

            } while (password.Length <= 3 || password.Length > 12);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("CONFIRM PASSWORD\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string P1 = Console.ReadLine();

            if (password == P1)
            {
                tpo.Add(new TPO(name, gen, phno, email, quali, exp, clgname, ccode, add, password));

                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("TPO Registered Successfully...");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1000);
                Console.Clear();



            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password Not Matched..");
                Console.ForegroundColor = ConsoleColor.White;
                goto P;
            }


            Console.ForegroundColor = ConsoleColor.Yellow;
        lc:
            Console.Write("\n\nWanna Sign in\n\t1.Yes\t2.No\n\nEnter Choice : ");
            Console.ForegroundColor = ConsoleColor.White;
            int lc = Convert.ToInt32(Console.ReadLine());
            if (lc == 1)
            {
                LoginAsTPO();
            }
            else if (lc == 2)
            {
                Thread.Sleep(1000);
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter Valid Choice ");
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                goto lc;
            }

        }


        //public company(string cName, string type, string isin, string industry, string founder, string temp, string wbs, string email, string pass)


        static void comp()
        {


            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n\t\tWELCOME TO COMPANY REGISTRATION PORTALl!!\n\n");


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Company name\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string cname = Console.ReadLine().ToUpper();


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Company Type\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string type = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Company isin\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string isin = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Industry\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string iind = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Company Founder\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string founder = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Established year\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            int year = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Total Employess\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string wt = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Company Website\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string wbs = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Email\t\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string email = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Set Password\t\t: ");
            Console.ForegroundColor = ConsoleColor.White;
            string pass = Console.ReadLine();


            company.Add(new Company(cname, type, isin, iind, founder, year, wt, wbs, email, pass));
            Thread.Sleep(1500);
            //Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n\nCompany Profile created successfully...");
            Console.ForegroundColor = ConsoleColor.Yellow;
        lc:
            Console.Write("\n\nWanna Sign in\n\t1.Yes\t2.No\n\nEnter Choice : ");
            Console.ForegroundColor = ConsoleColor.White;
            int lc = Convert.ToInt32(Console.ReadLine());
            if (lc == 1)
            {
                LoginAsComp();
            }
            else if (lc == 2)
            {
                Thread.Sleep(1000);
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter Valid Choice ");
                Thread.Sleep(1000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                goto lc;
            }
        }




        class Student
        {
            public string Name { get; set; }
            public string RollNo { get; set; }
            public string DOB { get; set; }
            public string Gender { get; set; }
            public long Phno { get; set; }
            public string Email { get; set; }
            public string Add { get; set; }
            public string Clg { get; set; }
            public string Clgcode { get; set; }
            public string Branch { get; set; }

            public string Password { get; }

            public Student(string name, string roll, string dob, string gender, long phno, string email, string add, string branch, string clg, string clgcode, string password)
            {
                Name = name;
                RollNo = roll;
                DOB = dob;
                Gender = gender;
                Phno = phno;
                Email = email;
                Add = add;
                Branch = branch;
                Clg = clg;
                Clgcode = clgcode;
                Password = password;
            }
        }

        class TPO
        {
            public string Name { get; set; }
            public string Gender { get; set; }
            public long Phno { get; set; }
            public string Email { get; set; }
            public string Quali { get; set; }
            public int Exper { get; set; }
            public string Clgname { get; set; }
            public string Clgcode { get; set; }

            public string CAdd { get; set; }

            public string Password { get; }


            public TPO(string name, string gender, long phno, string email, string quali, int exper, string clgname, string clgcode, string cadd, string password)
            {
                Name = name;
                Gender = gender;
                Phno = phno;
                Email = email;
                Quali = quali;
                Exper = exper;
                Clgname = clgname;
                Clgcode = clgcode;
                CAdd = cadd;
                Password = password;
            }
        }

        class Company
        {
            public string CName { get; set; }
            public string Type { get; set; }
            public string Isin { get; set; }
            public string Industry { get; set; }
            public string Founder { get; set; }
            public int Year { get; set; }
            public string Temp { get; set; }
            public string Wbs { get; set; }
            public string Email { get; set; }
            public string Pass { get; set; }
            public string job { get; set; }
            public string skill { get; set; }
            public long sal { get; set; }
            public int vacanci { get; set; }
            public int app { get; set; }
            public List<string> stuapply { get; set; }
            public List<string> hire { get; set; }
            public List<string> hrsent { get; set; }
            public Company(string cName, string type, string isin, string industry, string founder, int year, string temp, string wbs, string email, string pass)
            {
                CName = cName;
                Type = type;
                Isin = isin;
                Industry = industry;
                Founder = founder;
                Year = year;
                Temp = temp;
                Wbs = wbs;
                Email = email;
                Pass = pass;
                job = "";
                skill = "";
                sal = 0;
                vacanci = 0;
                app = 0;
                stuapply = new List<string>();
                hire = new List<string>();
                hrsent = new List<string>();
            }
        }


    }
}