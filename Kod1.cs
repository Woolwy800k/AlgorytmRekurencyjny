using System;
using System.IO;




namespace LOCHYrekurencyjnie
{
    class Program
    {
        static void Sprawdź(int[,] znacznik,int[,] loch,int r,int d,int poziomkryt)
        {

            if (znacznik[r, d] == 1)
            {
                if (((loch[r, d] - loch[r - 1, d - 1]) > -5 && (loch[r, d] - loch[r - 1, d - 1]) < 5) && loch[r - 1, d - 1] > poziomkryt)
                {
                    znacznik[r - 1, d - 1] = 1;
                   
                }
                if (((loch[r, d] - loch[r - 1, d]) > -5 && (loch[r, d] - loch[r - 1, d]) < 5) && loch[r - 1, d] > poziomkryt)
                {
                    znacznik[r - 1, d] = 1;
                }
                if (((loch[r, d] - loch[r - 1, d + 1]) > -5 && (loch[r, d] - loch[r - 1, d + 1]) < 5) && loch[r - 1, d + 1] > poziomkryt)
                {
                    znacznik[r - 1, d + 1] = 1;
                }
                if (((loch[r, d] - loch[r, d - 1]) > -5 && (loch[r, d] - loch[r, d - 1]) < 5) && loch[r, d - 1] > poziomkryt)
                {
                    znacznik[r, d - 1] = 1;
                }
                if (((loch[r, d] - loch[r, d + 1]) > -5 && (loch[r, d] - loch[r, d + 1]) < 5) && loch[r, d + 1] > poziomkryt)
                {
                    znacznik[r, d + 1] = 1;
                }
                if (((loch[r, d] - loch[r + 1, d - 1]) > -5 && (loch[r, d] - loch[r + 1, d - 1]) < 5) && loch[r + 1, d - 1] > poziomkryt)
                {
                    znacznik[r + 1, d - 1] = 1;
                }
                if (((loch[r, d] - loch[r + 1, d]) > -5 && (loch[r, d] - loch[r + 1, d]) < 5) && loch[r + 1, d] > poziomkryt)
                {
                    znacznik[r + 1, d] = 1;
                }
                if (((loch[r, d] - loch[r + 1, d + 1]) > -5 && (loch[r, d] - loch[r + 1, d + 1]) < 5) && loch[r + 1, d + 1] > poziomkryt)
                {
                    znacznik[r + 1, d + 1] = 1;
                }
                
            }
            if (znacznik[r - 1, d - 1] == 1)
            {
                SprawdźLD(znacznik, loch, r - 1, d - 1, poziomkryt);
            }
            if (znacznik[r - 1, d] == 1)
            {
                SprawdźD(znacznik, loch, r - 1, d, poziomkryt);
            }
            if (znacznik[r - 1, d + 1] == 1)
            {
                SprawdźPD(znacznik, loch, r - 1, d + 1, poziomkryt);
            }
            if (znacznik[r, d - 1] == 1)
            {
                SprawdźP(znacznik, loch, r - 1, d, poziomkryt);
            }
            if (znacznik[r, d + 1] == 1)
            {
                SprawdźL(znacznik, loch, r - 1, d, poziomkryt);
            }
            if (znacznik[r + 1, d - 1] == 1)
            {
                SprawdźLG(znacznik, loch, r + 1, d - 1, poziomkryt);
            }
            if (znacznik[r + 1, d] == 1)
            {
                SprawdźG(znacznik, loch, r + 1, d, poziomkryt);
            }
            if (znacznik[r + 1, d + 1] == 1)
            {
                SprawdźPG(znacznik, loch, r + 1, d + 1, poziomkryt);
            }
        }
        static void SprawdźL(int[,] znacznik, int[,] loch, int r, int d, int poziomkryt)
        {
            if (r > 0 && d > 0)
            {
                if (znacznik[r, d] == 1)
                {
                    if (((loch[r, d] - loch[r - 1, d - 1]) > -5 && (loch[r, d] - loch[r - 1, d - 1]) < 5) && loch[r - 1, d - 1] > poziomkryt)
                    {
                        znacznik[r - 1, d - 1] = 1;

                    }
                    if (((loch[r, d] - loch[r - 1, d]) > -5 && (loch[r, d] - loch[r - 1, d]) < 5) && loch[r - 1, d] > poziomkryt)
                    {
                        znacznik[r - 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r - 1, d + 1]) > -5 && (loch[r, d] - loch[r - 1, d + 1]) < 5) && loch[r - 1, d + 1] > poziomkryt)
                    {
                        znacznik[r - 1, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d - 1]) > -5 && (loch[r, d] - loch[r, d - 1]) < 5) && loch[r, d - 1] > poziomkryt)
                    {
                        znacznik[r, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d + 1]) > -5 && (loch[r, d] - loch[r, d + 1]) < 5) && loch[r, d + 1] > poziomkryt)
                    {
                        znacznik[r, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d - 1]) > -5 && (loch[r, d] - loch[r + 1, d - 1]) < 5) && loch[r + 1, d - 1] > poziomkryt)
                    {
                        znacznik[r + 1, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d]) > -5 && (loch[r, d] - loch[r + 1, d]) < 5) && loch[r + 1, d] > poziomkryt)
                    {
                        znacznik[r + 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d + 1]) > -5 && (loch[r, d] - loch[r + 1, d + 1]) < 5) && loch[r + 1, d + 1] > poziomkryt)
                    {
                        znacznik[r + 1, d + 1] = 1;
                    }
                }
                if (znacznik[r - 1, d - 1] == 1)
                {
                    SprawdźLD(znacznik, loch, r - 1, d - 1, poziomkryt);
                }
                if (znacznik[r, d + 1] == 1)
                {
                    SprawdźL(znacznik, loch, r - 1, d, poziomkryt);
                }
                if (znacznik[r + 1, d - 1] == 1)
                {
                    SprawdźLG(znacznik, loch, r + 1, d - 1, poziomkryt);
                }
            }
        }
        static void SprawdźLG(int[,] znacznik, int[,] loch, int r, int d, int poziomkryt)
        {
            if (r > 0 && d > 0)
            {
                if (znacznik[r, d] == 1)
                {
                    if (((loch[r, d] - loch[r - 1, d - 1]) > -5 && (loch[r, d] - loch[r - 1, d - 1]) < 5) && loch[r - 1, d - 1] > poziomkryt)
                    {
                        znacznik[r - 1, d - 1] = 1;

                    }
                    if (((loch[r, d] - loch[r - 1, d]) > -5 && (loch[r, d] - loch[r - 1, d]) < 5) && loch[r - 1, d] > poziomkryt)
                    {
                        znacznik[r - 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r - 1, d + 1]) > -5 && (loch[r, d] - loch[r - 1, d + 1]) < 5) && loch[r - 1, d + 1] > poziomkryt)
                    {
                        znacznik[r - 1, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d - 1]) > -5 && (loch[r, d] - loch[r, d - 1]) < 5) && loch[r, d - 1] > poziomkryt)
                    {
                        znacznik[r, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d + 1]) > -5 && (loch[r, d] - loch[r, d + 1]) < 5) && loch[r, d + 1] > poziomkryt)
                    {
                        znacznik[r, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d - 1]) > -5 && (loch[r, d] - loch[r + 1, d - 1]) < 5) && loch[r + 1, d - 1] > poziomkryt)
                    {
                        znacznik[r + 1, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d]) > -5 && (loch[r, d] - loch[r + 1, d]) < 5) && loch[r + 1, d] > poziomkryt)
                    {
                        znacznik[r + 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d + 1]) > -5 && (loch[r, d] - loch[r + 1, d + 1]) < 5) && loch[r + 1, d + 1] > poziomkryt)
                    {
                        znacznik[r + 1, d + 1] = 1;
                    }
                }

                if (znacznik[r + 1, d - 1] == 1)
                {
                    SprawdźLG(znacznik, loch, r + 1, d - 1, poziomkryt);
                }
                if (znacznik[r + 1, d] == 1)
                {
                    SprawdźG(znacznik, loch, r + 1, d, poziomkryt);
                }
                if (znacznik[r, d + 1] == 1)
                {
                    SprawdźL(znacznik, loch, r - 1, d, poziomkryt);
                }
            }
        }
        static void SprawdźG(int[,] znacznik, int[,] loch, int r, int d, int poziomkryt)
        {
            if (r > 0 && d > 0)
            {
                if (znacznik[r, d] == 1)
                {
                    if (((loch[r, d] - loch[r - 1, d - 1]) > -5 && (loch[r, d] - loch[r - 1, d - 1]) < 5) && loch[r - 1, d - 1] > poziomkryt)
                    {
                        znacznik[r - 1, d - 1] = 1;

                    }
                    if (((loch[r, d] - loch[r - 1, d]) > -5 && (loch[r, d] - loch[r - 1, d]) < 5) && loch[r - 1, d] > poziomkryt)
                    {
                        znacznik[r - 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r - 1, d + 1]) > -5 && (loch[r, d] - loch[r - 1, d + 1]) < 5) && loch[r - 1, d + 1] > poziomkryt)
                    {
                        znacznik[r - 1, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d - 1]) > -5 && (loch[r, d] - loch[r, d - 1]) < 5) && loch[r, d - 1] > poziomkryt)
                    {
                        znacznik[r, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d + 1]) > -5 && (loch[r, d] - loch[r, d + 1]) < 5) && loch[r, d + 1] > poziomkryt)
                    {
                        znacznik[r, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d - 1]) > -5 && (loch[r, d] - loch[r + 1, d - 1]) < 5) && loch[r + 1, d - 1] > poziomkryt)
                    {
                        znacznik[r + 1, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d]) > -5 && (loch[r, d] - loch[r + 1, d]) < 5) && loch[r + 1, d] > poziomkryt)
                    {
                        znacznik[r + 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d + 1]) > -5 && (loch[r, d] - loch[r + 1, d + 1]) < 5) && loch[r + 1, d + 1] > poziomkryt)
                    {
                        znacznik[r + 1, d + 1] = 1;
                    }
                }
                if (znacznik[r + 1, d - 1] == 1)
                {
                    SprawdźLG(znacznik, loch, r + 1, d - 1, poziomkryt);
                }
                if (znacznik[r + 1, d] == 1)
                {
                    SprawdźG(znacznik, loch, r + 1, d, poziomkryt);
                }
                if (znacznik[r + 1, d + 1] == 1)
                {
                    SprawdźPG(znacznik, loch, r + 1, d + 1, poziomkryt);
                }
            }
        }
        static void SprawdźPG(int[,] znacznik, int[,] loch, int r, int d, int poziomkryt)
        {
            if (r > 0 && d > 0)
            {
                if (znacznik[r, d] == 1)
                {
                    if (((loch[r, d] - loch[r - 1, d - 1]) > -5 && (loch[r, d] - loch[r - 1, d - 1]) < 5) && loch[r - 1, d - 1] > poziomkryt)
                    {
                        znacznik[r - 1, d - 1] = 1;

                    }
                    if (((loch[r, d] - loch[r - 1, d]) > -5 && (loch[r, d] - loch[r - 1, d]) < 5) && loch[r - 1, d] > poziomkryt)
                    {
                        znacznik[r - 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r - 1, d + 1]) > -5 && (loch[r, d] - loch[r - 1, d + 1]) < 5) && loch[r - 1, d + 1] > poziomkryt)
                    {
                        znacznik[r - 1, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d - 1]) > -5 && (loch[r, d] - loch[r, d - 1]) < 5) && loch[r, d - 1] > poziomkryt)
                    {
                        znacznik[r, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d + 1]) > -5 && (loch[r, d] - loch[r, d + 1]) < 5) && loch[r, d + 1] > poziomkryt)
                    {
                        znacznik[r, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d - 1]) > -5 && (loch[r, d] - loch[r + 1, d - 1]) < 5) && loch[r + 1, d - 1] > poziomkryt)
                    {
                        znacznik[r + 1, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d]) > -5 && (loch[r, d] - loch[r + 1, d]) < 5) && loch[r + 1, d] > poziomkryt)
                    {
                        znacznik[r + 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d + 1]) > -5 && (loch[r, d] - loch[r + 1, d + 1]) < 5) && loch[r + 1, d + 1] > poziomkryt)
                    {
                        znacznik[r + 1, d + 1] = 1;
                    }
                }
                if (znacznik[r + 1, d] == 1)
                {
                    SprawdźG(znacznik, loch, r + 1, d, poziomkryt);
                }
                if (znacznik[r + 1, d + 1] == 1)
                {
                    SprawdźPG(znacznik, loch, r + 1, d + 1, poziomkryt);
                }
                if (znacznik[r, d - 1] == 1)
                {
                    SprawdźP(znacznik, loch, r - 1, d, poziomkryt);
                }
            }
        }
        static void SprawdźP(int[,] znacznik, int[,] loch, int r, int d, int poziomkryt)
        {
            if (r > 0 && d > 0)
            {
                if (znacznik[r, d] == 1)
                {
                    if (((loch[r, d] - loch[r - 1, d - 1]) > -5 && (loch[r, d] - loch[r - 1, d - 1]) < 5) && loch[r - 1, d - 1] > poziomkryt)
                    {
                        znacznik[r - 1, d - 1] = 1;

                    }
                    if (((loch[r, d] - loch[r - 1, d]) > -5 && (loch[r, d] - loch[r - 1, d]) < 5) && loch[r - 1, d] > poziomkryt)
                    {
                        znacznik[r - 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r - 1, d + 1]) > -5 && (loch[r, d] - loch[r - 1, d + 1]) < 5) && loch[r - 1, d + 1] > poziomkryt)
                    {
                        znacznik[r - 1, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d - 1]) > -5 && (loch[r, d] - loch[r, d - 1]) < 5) && loch[r, d - 1] > poziomkryt)
                    {
                        znacznik[r, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d + 1]) > -5 && (loch[r, d] - loch[r, d + 1]) < 5) && loch[r, d + 1] > poziomkryt)
                    {
                        znacznik[r, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d - 1]) > -5 && (loch[r, d] - loch[r + 1, d - 1]) < 5) && loch[r + 1, d - 1] > poziomkryt)
                    {
                        znacznik[r + 1, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d]) > -5 && (loch[r, d] - loch[r + 1, d]) < 5) && loch[r + 1, d] > poziomkryt)
                    {
                        znacznik[r + 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d + 1]) > -5 && (loch[r, d] - loch[r + 1, d + 1]) < 5) && loch[r + 1, d + 1] > poziomkryt)
                    {
                        znacznik[r + 1, d + 1] = 1;
                    }
                }
                if (znacznik[r, d - 1] == 1)
                {
                    SprawdźP(znacznik, loch, r - 1, d, poziomkryt);
                }
                if (znacznik[r + 1, d + 1] == 1)
                {
                    SprawdźPG(znacznik, loch, r + 1, d + 1, poziomkryt);
                }
                if (znacznik[r - 1, d + 1] == 1)
                {
                    SprawdźPD(znacznik, loch, r - 1, d + 1, poziomkryt);
                }
            }
        }
        static void SprawdźPD(int[,] znacznik, int[,] loch, int r, int d, int poziomkryt)
        {
            if (r > 0 && d > 0)
            {
                if (znacznik[r, d] == 1)
                {
                    if (((loch[r, d] - loch[r - 1, d - 1]) > -5 && (loch[r, d] - loch[r - 1, d - 1]) < 5) && loch[r - 1, d - 1] > poziomkryt)
                    {
                        znacznik[r - 1, d - 1] = 1;

                    }
                    if (((loch[r, d] - loch[r - 1, d]) > -5 && (loch[r, d] - loch[r - 1, d]) < 5) && loch[r - 1, d] > poziomkryt)
                    {
                        znacznik[r - 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r - 1, d + 1]) > -5 && (loch[r, d] - loch[r - 1, d + 1]) < 5) && loch[r - 1, d + 1] > poziomkryt)
                    {
                        znacznik[r - 1, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d - 1]) > -5 && (loch[r, d] - loch[r, d - 1]) < 5) && loch[r, d - 1] > poziomkryt)
                    {
                        znacznik[r, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d + 1]) > -5 && (loch[r, d] - loch[r, d + 1]) < 5) && loch[r, d + 1] > poziomkryt)
                    {
                        znacznik[r, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d - 1]) > -5 && (loch[r, d] - loch[r + 1, d - 1]) < 5) && loch[r + 1, d - 1] > poziomkryt)
                    {
                        znacznik[r + 1, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d]) > -5 && (loch[r, d] - loch[r + 1, d]) < 5) && loch[r + 1, d] > poziomkryt)
                    {
                        znacznik[r + 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d + 1]) > -5 && (loch[r, d] - loch[r + 1, d + 1]) < 5) && loch[r + 1, d + 1] > poziomkryt)
                    {
                        znacznik[r + 1, d + 1] = 1;
                    }
                }
                if (znacznik[r - 1, d + 1] == 1)
                {
                    SprawdźPD(znacznik, loch, r - 1, d + 1, poziomkryt);
                }
                if (znacznik[r, d - 1] == 1)
                {
                    SprawdźP(znacznik, loch, r - 1, d, poziomkryt);
                }
                if (znacznik[r - 1, d] == 1)
                {
                    SprawdźD(znacznik, loch, r - 1, d, poziomkryt);
                }
            }
        }
        static void SprawdźD(int[,] znacznik, int[,] loch, int r, int d, int poziomkryt)
        {
            if (r > 0 && d > 0)
            {
                if (znacznik[r, d] == 1)
                {
                    if (((loch[r, d] - loch[r - 1, d - 1]) > -5 && (loch[r, d] - loch[r - 1, d - 1]) < 5) && loch[r - 1, d - 1] > poziomkryt)
                    {
                        znacznik[r - 1, d - 1] = 1;

                    }
                    if (((loch[r, d] - loch[r - 1, d]) > -5 && (loch[r, d] - loch[r - 1, d]) < 5) && loch[r - 1, d] > poziomkryt)
                    {
                        znacznik[r - 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r - 1, d + 1]) > -5 && (loch[r, d] - loch[r - 1, d + 1]) < 5) && loch[r - 1, d + 1] > poziomkryt)
                    {
                        znacznik[r - 1, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d - 1]) > -5 && (loch[r, d] - loch[r, d - 1]) < 5) && loch[r, d - 1] > poziomkryt)
                    {
                        znacznik[r, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d + 1]) > -5 && (loch[r, d] - loch[r, d + 1]) < 5) && loch[r, d + 1] > poziomkryt)
                    {
                        znacznik[r, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d - 1]) > -5 && (loch[r, d] - loch[r + 1, d - 1]) < 5) && loch[r + 1, d - 1] > poziomkryt)
                    {
                        znacznik[r + 1, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d]) > -5 && (loch[r, d] - loch[r + 1, d]) < 5) && loch[r + 1, d] > poziomkryt)
                    {
                        znacznik[r + 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d + 1]) > -5 && (loch[r, d] - loch[r + 1, d + 1]) < 5) && loch[r + 1, d + 1] > poziomkryt)
                    {
                        znacznik[r + 1, d + 1] = 1;
                    }
                }
                if (znacznik[r - 1, d] == 1)
                {
                    SprawdźD(znacznik, loch, r - 1, d, poziomkryt);
                }
                if (znacznik[r - 1, d - 1] == 1)
                {
                    SprawdźLD(znacznik, loch, r - 1, d - 1, poziomkryt);
                }
                if (znacznik[r - 1, d + 1] == 1)
                {
                    SprawdźPD(znacznik, loch, r - 1, d + 1, poziomkryt);
                }
            }
        }
        static void SprawdźLD(int[,] znacznik, int[,] loch, int r, int d, int poziomkryt)
        {
            if (r > 0 && d > 0)
            {
                if (znacznik[r, d] == 1)
                {
                    if (((loch[r, d] - loch[r - 1, d - 1]) > -5 && (loch[r, d] - loch[r - 1, d - 1]) < 5) && loch[r - 1, d - 1] > poziomkryt)
                    {
                        znacznik[r - 1, d - 1] = 1;

                    }
                    if (((loch[r, d] - loch[r - 1, d]) > -5 && (loch[r, d] - loch[r - 1, d]) < 5) && loch[r - 1, d] > poziomkryt)
                    {
                        znacznik[r - 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r - 1, d + 1]) > -5 && (loch[r, d] - loch[r - 1, d + 1]) < 5) && loch[r - 1, d + 1] > poziomkryt)
                    {
                        znacznik[r - 1, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d - 1]) > -5 && (loch[r, d] - loch[r, d - 1]) < 5) && loch[r, d - 1] > poziomkryt)
                    {
                        znacznik[r, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r, d + 1]) > -5 && (loch[r, d] - loch[r, d + 1]) < 5) && loch[r, d + 1] > poziomkryt)
                    {
                        znacznik[r, d + 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d - 1]) > -5 && (loch[r, d] - loch[r + 1, d - 1]) < 5) && loch[r + 1, d - 1] > poziomkryt)
                    {
                        znacznik[r + 1, d - 1] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d]) > -5 && (loch[r, d] - loch[r + 1, d]) < 5) && loch[r + 1, d] > poziomkryt)
                    {
                        znacznik[r + 1, d] = 1;
                    }
                    if (((loch[r, d] - loch[r + 1, d + 1]) > -5 && (loch[r, d] - loch[r + 1, d + 1]) < 5) && loch[r + 1, d + 1] > poziomkryt)
                    {
                        znacznik[r + 1, d + 1] = 1;
                    }
                }
                if (znacznik[r - 1, d - 1] == 1)
                {
                    SprawdźLD(znacznik, loch, r - 1, d - 1, poziomkryt);
                }
                if (znacznik[r, d + 1] == 1)
                {
                    SprawdźL(znacznik, loch, r - 1, d, poziomkryt);
                }
                if (znacznik[r - 1, d] == 1)
                {
                    SprawdźD(znacznik, loch, r - 1, d, poziomkryt);
                }
            }
        }

        static void Main(string[] args)
        {
            int n, m;
            int poziomkryt;
            int i, j;
            int woda=0;
            int r, d;

            string path2 = "wczytajsredni2.txt";
            StreamReader odczyt = File.OpenText(path2);
            string s = odczyt.ReadLine();
            string[] wymiary = s.Split(" ");
            n = Int32.Parse(wymiary[0]);
            m = Int32.Parse(wymiary[1]);
            int [ , ] loch= new int[n+1, m+1];
            int[,] znacznik = new int[n+1, m+1];
            for( r=1;r<n+1;r++)
            {
                s = odczyt.ReadLine();
                string[] sufity = s.Split(" ");
                for ( d = 1; d < m+1; d++)
                {
                    loch[r, d] = Int32.Parse(sufity[d-1]);
                }
                
            }
            s = odczyt.ReadLine();
            wymiary = s.Split(" ");
            i = Int32.Parse(wymiary[0]);
            j = Int32.Parse(wymiary[1]);
            r = i;
            d = j;
            int[] t = new int[2];
            poziomkryt = loch[i, j] - 1;
            znacznik[i, j] = 1;
            SprawdźL(znacznik, loch,r, d ,poziomkryt);

            for (r = 1; r < n + 1; r++)
            {

                for (d = 1; d < m + 1; d++)
                {
                    if (znacznik[r, d] == 1 && loch[r, d] >= poziomkryt)
                    {
                        if ((loch[r, d] - poziomkryt) >= 5)
                        {
                            woda += 5;
                        }
                        else
                        {
                            woda += (loch[r, d] - poziomkryt);
                        }
                    }
                }

            }

            Console.WriteLine(woda);

        }
        
    }
}
