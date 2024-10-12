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

    switch (shape){
        case 'R':
        
            break;
        case 'T':
            break;
        case 'C':
            break;
        case 'E':
            break;
        default: 
            Console.WriteLine("Invalid shape type!");
            break;
    }
} while (shape != 'E');