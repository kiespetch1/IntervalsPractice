namespace IntervalsPractice.BaseClasses; 

public class DiatonicIntervals {
    private static readonly List<Interval?> Table = new List<Interval?>(14);

    public DiatonicIntervals() {
        Table.Insert(0, new Interval("Perfect Prime", 1, 0)); //Чистая Прима	1 ступень	0 полутонов
        Table.Insert(1, new Interval("Minor Second", 2, 1)); //Малая Секунда	2 ступени	1 полутон
        Table.Insert(2, new Interval("Major Second", 2, 2)); //Большая Секунда	2 ступени	2 полутона
        Table.Insert(3, new Interval("Minor Third", 3, 3)); //Малая Терция	3 ступени	3 полутона
        Table.Insert(4, new Interval("Major Third", 3, 4)); //Большая Терция	3 ступени	4 полутона
        Table.Insert(5, new Interval("Perfect Fourth", 4, 5)); //Чистая Кварта	4 ступени	5 полутонов
        Table.Insert(6, new Interval("Augmented Fourth", 4, 6)); //Увеличенная Кварта	4 ступень	6 полутонов
        Table.Insert(7, new Interval("Diminished Fifth", 5, 6)); //Уменьшённая Квинта	5 ступени	6 полутонов
        Table.Insert(8, new Interval("Perfect Fifth", 5, 7)); //Чистая Квинта	5 ступеней	7 полутонов
        Table.Insert(9, new Interval("Minor Sixth", 6, 8)); //Малая Секста	6 ступеней	8 полутонов
        Table.Insert(10, new Interval("Major Sixth", 6, 9)); //Большая Секста	6 ступеней	9 полутонов
        Table.Insert(11, new Interval("Minor Seventh", 7, 10)); //Малая Септима	7 ступеней	10 полутонов
        Table.Insert(12, new Interval("Major Seventh", 7, 11)); //Большая Септима	7 ступеней	11 полутонов
        Table.Insert(13, new Interval("Perfect Octave", 8, 12)); //Чистая Октава	8 ступеней	12 полутонов
    }
    
    public static Interval? CreateInterval() {
        var rnd = new Random();
        return Table[rnd.Next(14)];
    }
}
