string[] input = File.ReadAllLines("hivasok.txt");
//Tömb esetén a méret fix és nem módosítható!
//Hivasok[] data = new Hivasok[input.Length];
//Lista létrehozása: Ez a lista egy úgynevezett
//láncolt lista lesz a háttérben. Ennek elmélete: 13.-ban
List<Hivasok> data = new List<Hivasok>();
//i = i + 2 --> Kettesével lépked végig a fájlon
for (int i = 0; i < input.Length; i = i + 2)
{
    //Add --> A lista végére szúr be egy új elemet!
    data.Add(new Hivasok(input[i], input[i + 1]));
    //Insert --> Adott indexű helyre szúr be új elemet!
    //data.Insert(0, new Hivasok(input[i], input[i + 1]));
    //Remove --> Kitöröl adott elemet a listából
    //data.Remove(data[i]);
    //RemoveAt --> Adott sorszámú elemet töröl
    //data.RemoveAt(i);
    //Clear --> Töröl minden elemet a listából
    //data.Clear();
}
Console.WriteLine($"A hívások száma: {data.Count}");
//Console.WriteLine(data[0].Idotartam());
double sum = 0;
for (int i = 0; i < data.Count; i++)
{
    sum += data[i].Idotartam();
}
Console.WriteLine($"Az hívás összege: {sum} másodperc");
struct Hivasok
{
    public int kora;
    public int kperc;
    public int kmperc;
    public int zora;
    public int zperc;
    public int zmperc;
    public string telszam;

    public Hivasok(string line, string line2)
    {
        string[] splitted = line.Split(' ');
        kora = int.Parse(splitted[0]);
        kperc = int.Parse(splitted[1]);
        kmperc = int.Parse(splitted[2]);
        zora = int.Parse(splitted[3]);
        zperc = int.Parse(splitted[4]);
        zmperc = int.Parse(splitted[5]);
        telszam = line2;
    }

    public double Idotartam()
    {
        TimeSpan t1 = new TimeSpan(kora, kperc, kmperc);
        TimeSpan t2 = new TimeSpan(zora, zperc, zmperc);
        TimeSpan t = t2.Subtract(t1);
        return t.TotalSeconds;
      }
}