using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Program
{
    public class RuleGame
    {
        public const int total_cell = 40;
        public static int now_player;
        public int id_player;
        public int step;

        public void Start_Game()
        {
            now_player = 1;
            step = 0;
            id_player = now_player;
        }
    }
}
