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
        case 'R':{
            Console.WriteLine("Enter the length: ");
            double.TryParse(Console.ReadLine(), out length);
            Console.WriteLine("Enter with width: ");
            double.TryParse(Console.ReadLine(), out width);
            area = Math.Round((length * width), 2);
            Console.WriteLine(area);
            break;}
        case 'T':{
            Console.WriteLine("Enter the base: ");
            double.TryParse(Console.ReadLine(), out tribase);
            Console.WriteLine("Enter with height: ");
            double.TryParse(Console.ReadLine(), out height);
            area = Math.Round((tribase * height) / 2, 2);
            Console.WriteLine(area);
            break;}
        case 'C':{
            Console.WriteLine("Enter the radius: ");
            double.TryParse(Console.ReadLine(), out radius);
            area = Math.Round((radius * radius * Math.PI), 2);
            Console.WriteLine(area);
            break;}
        case 'E':
            Console.WriteLine("Exiting Calculator");
            break;
        default: 
            Console.WriteLine("Invalid shape type!");
            break;
    }
} while (shape != 'E');