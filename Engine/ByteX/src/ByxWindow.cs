using System;
using Silk.NET.Windowing;
using Silk.NET.Maths;

namespace ByteX.src
{
    public class ByxWindow
    {
        public ByxWindow(int _width, int _height, string _name)
        {
            width = _width;
            height = _height;
            name = _name;
            InitWindow();
        }

        private void InitWindow()
        {
            options = WindowOptions.Default;
            options.Title = name;
            options.Size = new Vector2D<int>(width, height);
            options.VSync = false;
            window = Window.Create(options);

            //lambdas
            window.Load += () =>
            {
                Console.WriteLine($"window {window} loaded");
            };
            window.Update += (d) =>
            {
                Console.Write($"\r FPS: {1 / d}");
            };
            window.Render += (d) => { };

            window.Run();
        }


        public IWindow? window;
        private WindowOptions options;
        private int width;
        private int height;
        private string name;
    }
}
