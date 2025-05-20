namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Karakter> karakterek = new List<Karakter>();

            karakterek.Add(new Jatekos("Yadolf Yitler", 20, 2, 5));
            karakterek.Add(new Zombi("Zombi", 10, 1));
            karakterek.Add(new Farkas("Farkas", 8, 1, true));
            karakterek.Add(new Farkas("Vad Farkas", 8, 1, false));
            karakterek.Add(new Csontvaz("Csontváz", 10, 2));

            foreach (var karakter in karakterek)
            {
                Console.WriteLine($"Név: {karakter.Nev}, élet: {karakter.Elet}");
                karakter.Tamad();
            }
            karakterek[1].Harcol(karakterek[2]);
        }
    }
}
