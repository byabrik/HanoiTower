using System.Collections.Generic;

namespace HanoiTower
{
    public sealed class Game
    {
        public readonly int NumOfPegs = 3;
        private readonly int _numberOfDisks;
        private Stack<Disk>[] _pegs;

        public Game(int n)
        {
            _numberOfDisks = n;
            InitGame(_numberOfDisks);
        }

        public void StartGame()
        {
            MoveDisks(_numberOfDisks, 0, 2, 1);
        }

        public void InitGame(int n)
        {
            _pegs = new Stack<Disk>[NumOfPegs];

            for (int i = 0; i < NumOfPegs; i++)
            {
                _pegs[i] = new Stack<Disk>();
            }

            for (int i = n; i >= 1; i--)
            {
                _pegs[0].Push(new Disk(i));
            }
        }

        public void MoveDisks(int n, int from, int to, int via)
        {
            if (n == 1)
            {
                if (_pegs[from].Count > 0)
                {
                    _pegs[to].Push(_pegs[from].Pop());
                }
            }
            else
            {
                MoveDisks(n - 1, from, via, to);
                MoveDisks(1, from, to, via);
                MoveDisks(n - 1, via, to, from);
            }
        }
    }
}