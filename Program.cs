char shape;
double length;
double width;
double tribase;
double height;
double radius;
double area;

do {
    Console.WriteLine("What type of shape (R)ectangle, (T)riangle, or (C)ircle?");
    shape = Console.ReadLine()[0];
    length = 0;
    width = 0;
    tribase = 0;
    height = 0;
    radius = 0;
    area = 0;

    switch (shape){
        case 'R':
            Console.Write("Enter the length: ");
            double.TryParse(Console.ReadLine(), out length);
            Console.Write("Enter with width: ");
            double.TryParse(Console.ReadLine(), out width);
            area = (length * width);
            Console.WriteLine(area);
            break;
        case 'T':
            Console.Write("Enter the base: ");
            double.TryParse(Console.ReadLine(), out tribase);
            Console.Write("Enter with height: ");
            double.TryParse(Console.ReadLine(), out height);
            break;
        case 'C':
            Console.Write("Enter the radius: ");
            double.TryParse(Console.ReadLine(), out radius);
            break;
        case 'E':
            Console.Write("Exiting Calculator");
            break;
        default: 
            Console.WriteLine("Invalid shape type!");
            break;
    }
} while (shape != 'E');