using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Silk.NET.Input;
using Silk.NET.Windowing;

namespace ByteX.src
{
    public class ByxInputManager
    {
        private static IInputContext? input;
        public ByxInputManager(IWindow window)
        {
            Init(window);
        }

        void Init(IWindow window)
        {
            window.Load += () =>
            {
                input = window.CreateInput();

            };
            
        }
    }
}
