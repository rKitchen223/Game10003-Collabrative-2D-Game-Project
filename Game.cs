// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        Vector2 CircleLoacation = new Vector2(200, 400);
        Vector2 LineSize = new Vector2(50, 120);
        Vector2 CircleLastPosition;
        public float x = 120;
        public float y = 100;
        public float radius = 170;
        public float CircleCenterX = 120;
        public float CircleCenterY = 100;
        public float Circleradius = 170;



        public void Setup()
        {
            Window.SetTitle("Multiple Clouds");
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Blue);
            Circle();

            x = 640;
            y = 485;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 510;
            y = 485;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 380;
            y = 485;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 250;
            y = 485;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 125;
            y = 485;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 640;
            y = 360;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 510;
            y = 360;
            radius = 50;
            Draw.Circle(x, y, radius);
            
            x = 380;
            y = 360;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 250;
            y = 360;
            radius = 50;
            Draw.Circle(x, y, radius);


            x = 125;
            y = 360;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 640;
            y = 230;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 510;
            y = 230;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 380;
            y = 230;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 250;
            y = 230;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 122;
            y = 230;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 640;
            y = 100;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 510;
            y = 100;
            radius = 50;
            Draw.Circle(x, y, radius);

            x = 380;
            y = 100;
            radius = 50;
            Draw.Circle(x, y, radius);



            x = 120;
            y = 100;
            radius = 50;
            Draw.Circle(x, y, radius);




            x = 250;
            y = 100;
            radius = 50;


            Draw.Circle(x, y, radius);



        }
        public void Circle()
        {


            Draw.FillColor = Color.OffWhite;
            Draw.LineColor = Color.Black;
            Draw.LineSize = 4;





        }
        
    }
}
