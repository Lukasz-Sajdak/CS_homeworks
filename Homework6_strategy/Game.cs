using System;
using System.Collections.Generic;

namespace Homework6_strategy
{
    class Game
    {
        public static void Run()
        {
            int rounds = 30;
            int score1 = 10;
            int score2 = 15;
            int score3 = -10;
            int score4 = 0;

            var strategies = new List<(string Name, IStrategy Strategy)>
            {
                ("AlwaysTrue", new StrategyAlwaysTrue()),
                ("AlwaysFalse", new StrategyAlwaysFalse()),
                ("Follower", new StrategyFollower()),
                ("Grudger", new StrategyGrudger()),
                ("Random", new StrategyRandom()),
                ("Detective", new StrategyDetective())
            };

            int n = strategies.Count;
            int[,] scores = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    var p1 = new Player(CloneStrategy(strategies[i].Strategy));
                    var p2 = new Player(CloneStrategy(strategies[j].Strategy));

                    for (int r = 0; r < rounds; r++)
                    {
                        bool move1 = p1.GetNextMove();
                        bool move2 = p2.GetNextMove();

                        if (move1 && move2)
                        {
                            p1.Score += score1;
                            p2.Score += score1;
                        }
                        else if (move1)
                        {
                            p1.Score += score3;
                            p2.Score += score2;
                        }
                        else if (move2)
                        {
                            p1.Score += score2;
                            p2.Score += score3;
                        }
                        else
                        {
                            p1.Score += score4;
                            p2.Score += score4;
                        }

                        p1.PartnerMoves.Add(move2);
                        p2.PartnerMoves.Add(move1);
                    }

                    scores[i, j] = p1.Score;
                }
            }

            int columnWidth = 12;

            Console.Write("".PadRight(columnWidth));
            for (int i = 0; i < n; i++)
                Console.Write(strategies[i].Name.PadRight(columnWidth));
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write(strategies[i].Name.PadRight(columnWidth));
                for (int j = 0; j < n; j++)
                {
                    string value = scores[i, j].ToString();
                    Console.Write(value.PadRight(columnWidth));
                }
                Console.WriteLine();
            }
        }

        private static IStrategy CloneStrategy(IStrategy strategy)
        {
            if (strategy is StrategyAlwaysTrue)
                return new StrategyAlwaysTrue();
            if (strategy is StrategyAlwaysFalse)
                return new StrategyAlwaysFalse();
            if (strategy is StrategyFollower)
                return new StrategyFollower();
            if (strategy is StrategyGrudger)
                return new StrategyGrudger();
            if (strategy is StrategyRandom)
                return new StrategyRandom();
            if (strategy is StrategyDetective)
                return new StrategyDetective();

            throw new NotImplementedException("Unknown strategy.");
        }
    }
}
