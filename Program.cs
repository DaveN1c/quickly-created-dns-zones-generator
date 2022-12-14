Console.WriteLine("1 - DNS Forward Lookup Zone (Host) IP Generator");
Console.WriteLine("2 - DNS Reverse Lookup Zone (PTR) IP Generator");
int varianta = int.Parse(Console.ReadLine());

if(varianta == 1)
{
    Console.WriteLine("Name of PCs:");
    string pcnames = Console.ReadLine();
    Console.WriteLine("Default IP Adress:");
    string defaultip = Console.ReadLine();
    Console.WriteLine("A or AAAA:");
    string aoraaaa = Console.ReadLine();
    Console.WriteLine("Number of PCs:");
    int pcnum = int.Parse(Console.ReadLine());

    Console.Clear();

    if(aoraaaa == "a")
    {
        aoraaaa = "A";
    }
    if (aoraaaa == "aaaa")
    {
        aoraaaa = "AAAA";
    }
    for (int i = 1; i <= pcnum; i++)
    {
        if(i < 10)
        {
            Console.WriteLine(pcnames + i + " " + aoraaaa + " " + defaultip + "0" + i);
        }
        else
        {
            Console.WriteLine(pcnames + i + " " + aoraaaa + " " + defaultip + i);
        }
    }
    Console.WriteLine("Press any key to exit...");
    Console.ReadLine();
}

if(varianta == 2)
{
    Console.WriteLine("Name of PCs:");
    string pcnames = Console.ReadLine();
    Console.WriteLine("Default IP Address That Is Needed For This:");
    string defaultip = Console.ReadLine();
    Console.WriteLine("Zone Name:");
    string zonename = Console.ReadLine();
    Console.WriteLine("Number of PCs:");
    int pcnum = int.Parse(Console.ReadLine());

    Console.Clear();

    if(defaultip == "")
    {
        for (int i = 1; i <= pcnum; i++)
        {
                Console.WriteLine(i + " " + "PTR" + " " + pcnames + i + "." + zonename);
        }
    }
    else
    {
        for (int i = 1; i <= pcnum; i++)
        {
            if (i < 10)
            {
                Console.WriteLine(defaultip + "0" + i + " " + "PTR" + " " + pcnames + i + "." + zonename);
            }
            else
            {
                Console.WriteLine(defaultip + i + " " + "PTR" + " " + pcnames + i + "." + zonename);
            }
        }
    }
    Console.WriteLine("Press any key to exit...");
    Console.ReadLine();
}