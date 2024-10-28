using ConsoleApp.Service;

CourseService courseService = new CourseService();
string answer;

do
{
    Console.WriteLine($"1. Grup yarat\n2. Gruplarin siyahisini goster\n 3.qrup uzerinde duzelis etmek\n\n\n\n\n0.cixish");
    Console.WriteLine("2. Gruplarin siyahisini goster");
    Console.WriteLine("3. Qrup uzerinde duzelish etmek");


    Console.Write("Icra etmey istediyiniz funksiyani sechin: ");

    answer = Console.ReadLine().Trim();

    switch (answer)
    {
        case "1":
            courseService.CreateGroup();
            break;
        case "2":
            courseService.ShowAllGroups();
            break;
        case "3":
            courseService.EditGroup();
            break;

        case "0":
            Console.WriteLine("Proqramdan çıxılır...");
            break;
        default:
            Console.WriteLine("Deyer yanlishdir yeniden daxil edin.");
            break;
    }
} while (answer != "0");