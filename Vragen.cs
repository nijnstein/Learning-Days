using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datums01
{
    public class Vraag
    {
        public Vraag(string text, string answer1, string answer2, string answer3, string answer4)
        {
            Text = text;
            Answer1 = answer1;
            Answer2 = answer2;
            Answer3 = answer3;
            Answer4 = answer4;
        }

        public string Text { get; set; }
        public string Answer1 { get; set; }
        public string Answer2 { get; set; }
        public string Answer3 { get; set; }
        public string Answer4 { get; set; }

        public string this[int i]
        {
            get
            {
                switch (i)
                {
                    case 1: return Answer1;
                    case 2: return Answer2;
                    case 3: return Answer3;
                    case 4: return Answer4;
                    default: return Answer1;
                }
            }
        }
    }

    public class VraagGenerator
    {
        static string[] DagenNL = new string[] {
            "Maandag",
            "Dinsdag",
            "Woensdag",
            "Donderdag",
            "Vrijdag",
            "Zaterdag",
            "Zondag"
        };

        static string[] DagenEN = new string[]
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };



        static Random random = new Random();

        static Vraag generator1()
        {
            int i = random.Next(0, 7);
            int c = random.Next(0, 4);

            switch (c)
            {
                case 0:
                    {
                        int[] a = Randomize(new int[]
                        {
                                (i + 1) % 7,
                                (i + 2) % 7,
                                (i + 3) % 7,
                                (i + 4) % 7,
                                (i + 5) % 7,
                        });

                        return new Vraag(
                            $"Welke dag komt voor {DagenNL[i]}\n\nWhich day comes before {DagenEN[i]}",
                            $"{DagenNL[(i + 6) % 7]}\n{DagenEN[(i + 1) % 7]}",
                            $"{DagenNL[a[0]]}\n{DagenEN[a[0]]}",
                            $"{DagenNL[a[1]]}\n{DagenEN[a[1]]}",
                            $"{DagenNL[a[2]]}\n{DagenEN[a[2]]}"
                        );
                    }

                case 1:
                    {
                        int[] a = Randomize(new int[]
                        {
                                (i + 2) % 7,
                                (i + 3) % 7,
                                (i + 4) % 7,
                                (i + 5) % 7,
                                (i + 6) % 7,
                        });

                        return new Vraag(
                            $"Welke dag komt na {DagenNL[i]}\n\nWhich day comes after {DagenEN[i]}",
                            $"{DagenNL[(i + 1) % 7]}\n{DagenEN[(i + 1) % 7]}",
                            $"{DagenNL[a[0]]}\n{DagenEN[a[0]]}",
                            $"{DagenNL[a[1]]}\n{DagenEN[a[1]]}",
                            $"{DagenNL[a[2]]}\n{DagenEN[a[2]]}"
                        );
                    }

                default:
                    {
                        List<int> a = Randomize(new int[]
                        {
                                (i + 1) % 7,
                                (i + 2) % 7,
                                (i + 3) % 7,
                                (i + 4) % 7,
                                (i + 5) % 7,
                                (i + 6) % 7,
                        }).ToList();

                        if (random.Next(0, 2) == 1)
                        {
                            // voor
                            int i1 = (i - c + 7) % 7;
                            a.Remove(i1);

                            return new Vraag(
                                $"Welke dag komt {c} dagen voor {DagenNL[i]}\n\nWhich day comes {c} days before {DagenEN[i]}",
                                $"{DagenNL[i1]}\n{DagenEN[i1]}",
                                $"{DagenNL[a[0]]}\n{DagenEN[a[0]]}",
                                $"{DagenNL[a[1]]}\n{DagenEN[a[1]]}",
                                $"{DagenNL[a[2]]}\n{DagenEN[a[2]]}");
                        }
                        else
                        {
                            // na
                            int i1 = (i + c) % 7;
                            a.Remove(i1);

                            return new Vraag(
                                $"Welke dag komt {c} dagen na {DagenNL[i]}\n\nWhich day comes {c} days after {DagenEN[i]}",
                                $"{DagenNL[i1]}\n{DagenEN[i1]}",
                                $"{DagenNL[a[0]]}\n{DagenEN[a[0]]}",
                                $"{DagenNL[a[1]]}\n{DagenEN[a[1]]}",
                                $"{DagenNL[a[2]]}\n{DagenEN[a[2]]}");
                        }
                    }
            }
        }

        public static int[] Randomize(int[] a)
        {
            for (int j = 0; j < a.Length * 3; j++)
            {
                int i1 = random.Next(0, a.Length);
                int i2 = i1;
                while (i2 == i1) i2 = random.Next(0, a.Length);

                int t = a[i1]; 
                a[i1] = a[i2];
                a[i2] = t;
            }
            
            return a; 
        }

        public static Vraag Volgende()
        {
            return generator1();
        }
    }
}
