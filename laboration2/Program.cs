using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboration2
{
    class Program
    {
        static Shape savedEllips;
        static Shape savedRectangle;
        
        static void Main(string[] args)
        {
            bool start = true;
            while (start)
            {
            Console.Clear();
            Console.WriteLine("Meny" + "\n" + "\n" + "Press E for Ellipse\n" + "Press R for Rectangle\nPress S for a resizable rectangle\nPress C to compare your ellips to your rectangle\nPress J to compare your Rectangle to your ellips\nPress Esc for Exit");
            ConsoleKey userChoice = Console.ReadKey(true).Key;

            double currentLength = 0;
            double currentWidth = 0;
            

            switch (userChoice)
            {

                case ConsoleKey.E:
                    Shape newEllipse = CreateShape(ShapeType.Ellipse);
                    Console.WriteLine("\nStep 1. Write the length of the ellipse:\nStep 2. Press enter \nStep 3. Write the width of the ellipse:  ");
                    try {
                            readLengthAndWidth(out currentLength, out currentWidth);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Error: " + e.Message + " Write numbers.\n");

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                    newEllipse.Length = currentLength;
                    newEllipse.Width = currentWidth;
                    ViewShapeInfo(newEllipse);
                    savedEllips = newEllipse;
                    Console.ReadKey();                                                          
                             
                    break;
                case ConsoleKey.R:
                    Shape newRectangle = CreateShape(ShapeType.Rectangle);
                    Console.WriteLine("\nStep 1. Write the length of the rectangle:\nStep 2. Press enter \nStep 3. Write the width of the rectangle: ");
                        try
                        {
                            readLengthAndWidth(out currentLength, out currentWidth);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Error: " + e.Message + " Write numbers.\n");

                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                    newRectangle.Length = currentLength;
                    newRectangle.Width = currentWidth;
                    ViewShapeInfo(newRectangle);
                    Console.WriteLine("Press enter");
                    savedRectangle = newRectangle;          
                    Console.ReadKey();
                    break;
                case ConsoleKey.S:
                        var resizeRectangle = CreateShape(ShapeType.ResizableRectangle);// as ResizableRectangle;
                        Console.WriteLine("\nStep 1. Write the length of the rectangle:\nStep 2. Press enter \nStep 3. Write the width of the rectangle:\nStep 4. Write how many percent you wish to resize with ");
                        try
                        {
                            readLengthAndWidth(out currentLength, out currentWidth);
                        }
                        catch (FormatException e)
                        {

                            Console.WriteLine("Error: " + e.Message);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        resizeRectangle.Length = currentLength;
                        resizeRectangle.Width = currentWidth;
                        ViewShapeInfo(resizeRectangle);
                        try
                        {
                            int percent = Int32.Parse(Console.ReadLine());
                            IResizable r = resizeRectangle as IResizable;
                            r.resize(percent);
                            ViewShapeInfo(resizeRectangle);
                            Console.ReadKey();
                        }
                        
                        catch (FormatException e)
                        {
                            Console.WriteLine("Error: " + e.Message);

                        }
                        break;

                case ConsoleKey.C:
                        Console.WriteLine("\nIf you got 1 your Ellips is bigger than your Rectangle\nIf you got -1 your rectangle is bigger than your Ellips\nIf you got a 0 they were the same");
                        try
                        {
                            Console.WriteLine(savedEllips.CompareTo(savedRectangle));
                            Console.ReadKey();

                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine("\nError: " + ex.Message + ", you need to create your Ellips and Rectangle before comparing them");
                            Console.ReadKey();
                        }
                        break;
                case ConsoleKey.J:
                        Console.WriteLine("\nIf you got 1 your Rectangle is bigger than your Ellips\nIf you got - 1 your Ellips is bigger than your Rectangle\nIf you got a 0 they were the same");
                        try
                        {                         
                            Console.WriteLine(savedRectangle.CompareTo(savedEllips));
                            Console.ReadKey();

                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine("\nError: " + ex.Message + "\nYou need to create your Ellips and Rectangle before comparing them");
                            Console.ReadKey();                        }
                        Console.ReadKey();
                        break;
                case ConsoleKey.Escape:
                    start = false;
                    break;


            }


        }
     }

        private static void compareEllips(Shape obj, Shape obje)
        {
            obj.CompareTo(obje);
        }



        public static Shape CreateShape(ShapeType shape)
        {
           
            switch (shape)
            {
                case ShapeType.Ellipse:
                    return new Ellipse(1.0, 1.0);

                   
                case ShapeType.Rectangle:
                    return new Rectangle(1.0, 1.0);

                case ShapeType.ResizableRectangle:
                    return new ResizableRectangle(1.0, 1.0);
                    
            }
            return null;
        }

        public static void readLengthAndWidth(out double currentLenght, out double currentWidth)
        {
            currentLenght = Double.Parse(Console.ReadLine());
            currentWidth = Double.Parse(Console.ReadLine());
        }

        public static void ViewShapeInfo(Shape shape)
        {
            var printShape = shape;
            Console.WriteLine(printShape.ToString());

        }
    }
}



