using System;

    class CompanyInfo
    {
        static void Main()
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyPhone = Console.ReadLine();
            string companyFax = Console.ReadLine();
            string companySite = Console.ReadLine();

            string managerFName = Console.ReadLine();
            string managerLName = Console.ReadLine();
            byte managerAge = byte.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();
            string managerFullName = managerFName + " " + managerLName;

            if (companyFax=="")
            {
                companyFax = "(no fax)";
            }

            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\n", companyName, companyAddress, companyPhone, companyFax, companySite);
            Console.WriteLine("Manager: {0} (age: {1}, tel. {2})", managerFullName, managerAge, managerPhone);



        }
    }

