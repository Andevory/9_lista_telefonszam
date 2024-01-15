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
}