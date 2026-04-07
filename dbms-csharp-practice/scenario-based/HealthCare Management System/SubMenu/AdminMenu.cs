using System;

public class AdminMenu
{
    private readonly IAdminService admin =
        new SystemAdminUtility();

    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n=== System Admin ===");
            Console.WriteLine("1. Add Specialty");
            Console.WriteLine("2. Delete Specialty");
            Console.WriteLine("3. View Audit Logs");
            Console.WriteLine("4. Backup Database");
            Console.WriteLine("5. Back");

            Console.Write("Choice: ");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    admin.AddSpecialty();
                    break;

                case 2:
                    admin.DeleteSpecialty();
                    break;

                case 3:
                    admin.ViewAuditLogs();
                    break;

                case 4:
                    admin.BackupDatabase();
                    break;

                case 5:
                    return;
            }
        }
    }
}
