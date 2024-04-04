Console.WriteLine("Men fanlardan olgan balingizni toifalayman!\nFanlardan olgan balingizni 0-100 gacha kirting.");

Console.Write("Matimatika Balingiz => ");
int score = Convert.ToInt32(Console.ReadLine());

Console.Write("Tarix Balingiz => ");
int score1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Biologiya Balingiz => ");
int score2 = Convert.ToInt32(Console.ReadLine());

int add = score + score1 + score2;
int middleArchimetic = add / 3;

Console.WriteLine($"Sizning o'rtacha 3ta fandan ballingiz: {middleArchimetic}");

string work =
    middleArchimetic >= 80 && middleArchimetic <= 100
        ? "Siz A'lo darajada bal olgansiz"
        : middleArchimetic >= 60 && middleArchimetic <= 79
            ? "Siz Yaxshi darajada bal olgansiz"
            : middleArchimetic >= 40 && middleArchimetic <= 59
                ? "Siz Qoniqarli darajada bal olgansiz"
                : middleArchimetic <= 40
                    ? "Siz Qoniqarsiz darajada bal olgansiz"
                    : "not fount";
Console.WriteLine(work);
