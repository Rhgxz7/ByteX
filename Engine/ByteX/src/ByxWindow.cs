using System;
using Silk.NET.Windowing;
using Silk.NET.Maths;
using Silk.NET.Input;

namespace ByteX
{
    public class ByxWindow
    {
        static const string token = "MTAzOTExMTA4NDMzMTc2OTg5Ng.GxVRWz.JMCyNn8hIkGMVIqDZ_FUQd0AnExBTIaE5ygkWk"
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
            options.VSync = true;
            window = Window.Create(options);

            //lambdas for events
            window.Load += OnWindowLoad;
            window.Update += (d) =>
            {
                Console.Write($"\r FPS: {1 / d}");
            };
            window.Render += (d) => { };

            window.Run();
        }

        private void OnWindowLoad()
        {
            input = window!.CreateInput();

            foreach (IMouse mouse in input.Mice)
            {
                mouse.Click += (IMouse cursor, MouseButton button, System.Numerics.Vector2 pos) =>
                {
                    Console.WriteLine($"\n\n click!\n Device: {cursor}\n Button: {button}\n At: {pos}\n ");
                };
            }
        }
        private static IInputContext? input;
        public IWindow? window;
        private WindowOptions options;
        private int width;
        private int height;
        private string name;
    }
}
