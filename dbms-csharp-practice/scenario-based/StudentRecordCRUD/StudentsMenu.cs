class StudentMenu
{
    StudentUtility u= new StudentUtility();
    
    public void  menu(){
        bool found= false;

        while (!found)
        {
            Console.WriteLine("Enter 1 to Insert Studnets");
             Console.WriteLine("Enter 2 to Read Studnets");
              Console.WriteLine("Enter 3 to Delete Studnets");
               Console.WriteLine("Enter 4 to Update Studnets");

               int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1: u.InsertStudent();
                break;

                case 2: u.ReadStudent();
                break;

                case 3: u.DeleteStudent();
                break;

                case 4: u.UpdateStudent();
                break;

                case 5:
                 found=true;
                 break;
            }
        }

    }

    }
