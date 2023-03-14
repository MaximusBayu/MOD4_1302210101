// See https://aka.ms/new-console-template for more information
using MOD4_13022101011;

KodeBuah buah = new KodeBuah();
KodeBuah.Buah1 apl = KodeBuah.Buah1.Apel;
Console.WriteLine(apl + " " + buah.getKodeBuah(apl));

PosisiKarakterGame pos = new PosisiKarakterGame();
pos.current = PosisiKarakterGame.State.Berdiri;
string[] screen = { "Tengkurap", "Jongkok", "Berdiri", "Terbang" };
while(pos.current != PosisiKarakterGame.State.Tengkurap)
{
    Console.WriteLine(screen[(int)pos.current]);
    Console.WriteLine("Enter command :");

    string command = Console.ReadLine();
    switch (pos.current)
    {
        case PosisiKarakterGame.State.Berdiri:
            if (command == "TombolW")
                pos.current = PosisiKarakterGame.State.Terbang;
            else if (command == "TombolS")
                pos.current = PosisiKarakterGame.State.Jongkok;
            break;
        case PosisiKarakterGame.State.Jongkok:
            if (command == "TombolS")
                pos.current = PosisiKarakterGame.State.Tengkurap;
            else if (command == "TombolW")
                pos.current = PosisiKarakterGame.State.Berdiri;
            break;
        case PosisiKarakterGame.State.Terbang:
            if (command == "TombolW")
                pos.current = PosisiKarakterGame.State.Terbang;
            else if (command == "TombolS")
                pos.current = PosisiKarakterGame.State.Berdiri;
            break;
        case PosisiKarakterGame.State.Tengkurap:
            if (command == "TombolW")
                pos.current = PosisiKarakterGame.State.Berdiri;
            else if (command == "TombolS")
                pos.current = PosisiKarakterGame.State.Tengkurap;
            break;
    }
    
}