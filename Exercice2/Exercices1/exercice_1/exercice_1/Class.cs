using System;
namespace exercice_1
{
    //Exercices1
    public class Class
    {
        public int content;

        public void ConvertToChaine()
        {
            var convertion = Convert.ToString(content);
        }
        public void ConvertToDouble()
        {
            Console.WriteLine("conversion en double");
        }
        public void ConvertToFloat()
        {
            Console.WriteLine("conversion en float");
        }
        public void ConvertToCar()
        {
            Console.WriteLine("conversion en car");
        }


    }
    public class Class2
    {
        public string content;

        public void ConvertToInteger()
        {
            
        }
        public void Capitalize()
        {
            var Capitali =  content.Substring(0, 1).ToUpper();
        }
        public void Minimize()
        {
            var Min = content.ToLower();
        }
        public void Maximize()
        {
            var Max = content.ToUpper();

        }
        public void RevokeOnStart(int T )
        {
            var lettre = content.TrimStart();
            content.Remove(T,0);
        }

        public void RevokeOnEnd(int T)
        {
            var lettre = content.TrimEnd();
            content.Remove(T, -1);
        }

        public void Revoke(int T, int A)
        {
            var lettre = content.Trim();
            content.Remove(T, A);
        }
    }
    //Exercices2


    public class TextSstyle
    {
        public int content;
        public string color;
        public string font_family;
        public int font_weigth;
        public int font_size;
        public string text_decoration;

    }

    public class SetBackground
    {
        public string background_color;
        public string background_image;
        public int background_size;
        public string background_position;
        public string background_attachement;
        public string background;
    }

        public class Box_style
    {
        public int width;
        public int heigth;
        public string box_shadow;
        public string border;
        public string border_raduis;
        public string border_color;
        public string border_style;
    }

    public class Animation
    {
        public void Bounce()
        {
            Console.WriteLine("methode1");
        }

        public void BounceUp()
        {
            Console.WriteLine("methode2");
        }

        public void BouncedDown()
        {
            Console.WriteLine("methode3");
        }

        public void Shake()
        {
            Console.WriteLine("methode4");
        }

        public void fadeln()
        {
            Console.WriteLine("methode5");
        }

        public void fadeOut()
        {
            Console.WriteLine("methode6");
        }

        public void fadelnUp()
        {
            Console.WriteLine("methode7");
        }

        public void fadeInDown()
        {
            Console.WriteLine("methode8");
        }

        public void fadeOutUp()
        {
            Console.WriteLine("methode9");
        }

        public void fadeOutDown()
        {
            Console.WriteLine("methode10");
        }
    }
}
