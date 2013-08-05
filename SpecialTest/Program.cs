using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecialCore;

namespace SpecialTest
{
    internal class Program
    {
        private static Character Ted;
        private static Character Bill;
        private static Character You;

        private enum GameState
        {
            Start,
            Running,
            End
        }

        private static GameState _currentState;

        static void Main(string[] args)
        {
            _currentState = GameState.Start;
            Initialize();

            while (_currentState == GameState.Running)
            {

            }

            Cleanup();
        }

        private static void Cleanup()
        {
            Console.WriteLine("Cleanup");
        }

        private static void Initialize()
        {
            Console.WriteLine("Init");

            Ted = new Character
                {
                    Name = "Ted",
                    Hp = 10,

                    Strength = 
                }


            _currentState = GameState.Running;
        }
    }
}
