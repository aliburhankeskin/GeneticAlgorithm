using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgortihm
{
    public class Genetic
    {
        // Başlangıç Değerler

        // Populasyon Sayısı => Başlangıç Topluluğunun Sayısı
        public int PopulationCount { get; set; }

        // Çaprazlama Oranı => Burada Tek noktalı çaprazlama vardır. Uygunluk Değeri yüksek olan değerler arasında çaprazlama yapılır.
        // Kormozonların nasıl çaprazlananacağını belirleyen oran
        public double CrossProbability { get; set; }

        // Mutasyon Oranı => bu orana göre kromozomun mutasyona uğrayıp uğramayacağını belirliyoruz.(0-1) arası verilir,
        // Örn: oran 0.001 olsun, 0-1 arasında random değer üretilir bundan küçük ise mutasyona uğrar
        public double MutationProbability { get; set; }

        // Seçkinlik => Her bir iterasyonda bir sonraki jenerasyone direkt eklenecek olan birey sayısı.
        // Bu bireyler uygunluk değeri en iyi olan bireylerdir
        public int ExclusivenessCount { get; set; }

        // Jenarasyon Sayısı => Algoritmanın kaç kez çalışacağını belirtir
        public int? GenarationCount { get; set; }

        // Sonlanma Ölçütünün Tipi => Eğer true ise Jenarasyon Sayısı olmak zorunda,false ise null olmaz zorunda
        public bool TerminationType { get; set; }

        // Bireyler ile iglili Listeler

        // Bireyleri tutan Liste    
        public List<Person> PersonList { get; set; }

        // Bir Sonraki İterasyona Aktarılcak Olan Bireyleri Tutan Liste (Seçkin Liste)
        public List<Person> ExclusivenessPersonList { get; set; }

        //Amaç Fonksiyonu İçin Sınır Değerleri

        // En büyük Değer
        public int MaxValueForPerson { get; set; }
        // En Küçük Değer
        public int MinValueForPerson { get; set; }

        // Random  => Birçok yerde random sayı üretileceği için genel tanımlandı
        private Random rn { get; set; }

        // Bit Sayısı => Her Bireydeki bit sayısı aynı olması için en yüksek sayıya göre max bit sayısı belirlenir 
        // Ctor da MaxValueForPerson ve MinValueForPerson ' a göre 
        // hangisinin mutlak değer büyük ise ona göre max bit sayısı belirlenir
        private int BitCount { get; set; }

        // Mutasyon için Random değer üretirken ihtiyacımız olucak
        private double mutationRandom = 0;

        //Ctor
        public Genetic(int _PopulationCount,
                         int _ExclusivenessCount,
                            double _CrossProbability,
                                double _MutationProbability,
                                    bool _TerminationType, 
                                            int _MaxValueForPerson,
                                                int _MinValueForPerson,
                                                    int _GenarationCount = default)
        {
            this.PopulationCount = _PopulationCount;
            this.CrossProbability = _CrossProbability;
            this.MutationProbability = _MutationProbability;
            this.ExclusivenessCount = _ExclusivenessCount;
            this.MaxValueForPerson = _MaxValueForPerson;
            this.MinValueForPerson = _MinValueForPerson;
            this.TerminationType = _TerminationType;
            this.GenarationCount = _TerminationType == true ? _GenarationCount : default; // Type Kontrolü
            this.rn = new Random();
            this.MaxBitCountCalculate();

            PersonList = new List<Person>();
            ExclusivenessPersonList = new List<Person>();
        }

        //Ana fonksiyon = SolveProblem

        // Algoritma ile Problemi Çözme
        // İterasyon(Jenarasyon)  Sayısı Kadar İşlemleri Yapar
        public void SolveProblem()
        {
            if (TerminationType)
            {
                for (int i = 0; i < GenarationCount; i++)
                {
                    this.CreatePopulation();
                    this.PurposeFunction();
                    this.RouletteWheelMethod();
                    this.CrossOver();
                    this.Mutation();

                    // Populasyonun Hep Maximum seviyede olması için , belirlene seçkin adedi(ExclusivenessCount) kadar "ExclusivenessPersonList" listesine eklenir
                    // Bir sonraki jenerasyona aktarmak için
                    ExclusivenessPersonList.Clear(); // Eski Bireyleri Temizliyoruz
                    PersonList = PersonList.OrderByDescending(s => s.AccordanceValue).ToList();
                    ExclusivenessPersonList.AddRange(PersonList.Take(ExclusivenessCount));
                }
            }
            else
            {
                this.CreatePopulation();
                this.PurposeFunction();
                this.RouletteWheelMethod();
                this.CrossOver();
                this.Mutation();

                // Populasyonun Hep Maximum seviyede olması için , belirlene seçkin adedi(ExclusivenessCount) kadar "ExclusivenessPersonList" listesine eklenir
                // Bir sonraki jenerasyona aktarmak için
                ExclusivenessPersonList.Clear(); // Eski Bireyleri Temizliyoruz
                PersonList = PersonList.OrderByDescending(s => s.AccordanceValue).ToList();
                ExclusivenessPersonList.AddRange(PersonList.Take(ExclusivenessCount));

            }
        }

        // Populasyon oluşturma => En büyük ve En küçük değerlere göre random bireyleri oluşturup "PersonList" Listesine ekler
        // İlk Jenarasyon ise "PopulationCount" kadar birey oluşturulur, ilk jenarasyon değil ise "PopulationCount" - "ExclusivenessCount" kadar birey oluşturulur ve 
        // Populasyona seçkin bireyleri yani  "ExclusivenessPersonList" listesine ekleyerek "Elitizm" uygulanır
        private void CreatePopulation()
        {
            int Lenght = PopulationCount;
            PersonList.Clear(); // Yeni Populasyon oluşturacağımız için eskiyi temizliyoruz

            if (ExclusivenessPersonList.Any()) // Eğer ilk jenerasyon değil ise seçkin bireyleri , yeni populasyona ekliyoruz 
            {
                Lenght = PopulationCount - ExclusivenessCount; // Seçkinleri eklediğimiz için , sayıyı azaltıyoruz
                PersonList.AddRange(ExclusivenessPersonList);

            }
            // Populasyonu Oluşturma
            for (int i = 0; i < Lenght; i++)
            {
                Person newPerson = new Person();
                newPerson.Value = rn.Next(MinValueForPerson, MaxValueForPerson);// Min-Max ' a göre random bir birey oluşturuldu

                PersonList.Add(newPerson);  // Bireyi populasyona Ekledik
            }
        }

        // Amaç Fonksiyonu => "PersonList" Listesindeki Değerlere göre Uygunluk değerini hesaplar
        private void PurposeFunction()
        {
            // Her bir birey için uygunluk değeri hesaplanır
            PersonList.ForEach(person => person.AccordanceValue = PurposeFunctionCalculate(person.Value));

            // Uygunluk değerine Göre Sıralama
            PersonList = PersonList.OrderByDescending(s => s.AccordanceValue).ToList();
        }

        // Fonksiyonumuz  => Bireyin değerine göre uygunluk değerini hesaplar, geriye döndürür 
        private double PurposeFunctionCalculate(int value)
        {
            // Formül değişkenleri
            int minValueForEquation = 1;
            int maxValueForEquation = 29;
            double xi = 0; // Formüldeki değişken
            double xi2 = 0; // Xi nin Karesi

            // Sonuçlar için
            double total = 0;
            double result = 0;

            // Formül'ün uygulanması
            for (int i = minValueForEquation - 1; i < maxValueForEquation; i++)
            {
                xi = value + i;
                xi2 = Math.Pow(xi, 2);

                result = (100 * Math.Pow((xi + 1) - xi2, 2)) + Math.Pow((xi - 1), 2);
                total += result;
            }

            return total;
        }

        // Rulet Tekerleği => Uygunluk Değerlerine Göre işlem Yapılır. İlk olarak bütün bireylerin uygunluk değerler toplanır.
        // Bireyin Uygunluk değerli / Toplam uygunluk değerleri toplamı oranlanır, her bir birey için oran belirlenir
        // Bu oranlar en küçükten başlayarak sırasıyla yüzdelik dilime pay edilir.
        // Örn: x1 = 6/359 = 3.67 ,x2 =  25/359 = 62.67 ... bu şekilde ortaya çıkan oranlara göre doldurulur.
        // Rulet Tekerleği Hazırlandıktan sonra populasyon yeniden oluşturulur.
        // Populasyon Sayısı kadar random değer üretiriz bu değerler 0-100 arasında olur.
        // Random değerin isabe ettiği dairenin kısmına karışık gelen birey , yeni populasyona eklenir.
        // Örn: RandomSay = 75 olsun bu değer yüzdelik kısmında x2 bireyine dekkeliyor çünkü yüzde 60'lık kısmı karışılıyor(küçüklerden başlayarak daireye eklendiği için)
        // Bu şekilde yeni populasyon oluşturulur

        private void RouletteWheelMethod()
        {
            // Yüzdelik oranın kurulması için bireylerin uygunluk değerlerini topladık
            double total = PersonList.Sum(s => s.AccordanceValue);

            // Her birey için yüzdelik kısım hesaplancak
            // Oranlar RateByTotalAccordanceValues propuna yazılır
            PersonList.ForEach(person => person.RateByTotalAccordanceValues = (person.AccordanceValue / total));// Uygunluk Değeri / Toplam 

            // Yeniden Populasyon Oluşturulacak , o yüzden ilk önce populasyon temizlenir 
            // Oranları Belirledikten sonra Populasyondaki birey sayısı kadar random değer üretilip 1-100 arasında
            // Rulet Tekerleğindeki , Üretilen random değere karşılık gelen birey populasyona eklenir
            List<Person> temp = new List<Person>();
            temp.AddRange(PersonList);
            temp = temp.OrderByDescending(s => s.RateByTotalAccordanceValues).ToList(); // Orana Göre Sıraladık Çünkü Rulet Tekerleğine Bu Şekilde yerleştireceğiz

            PersonList.Clear();

            for (int i = 0; i < PopulationCount; i++)
            {
                Person newPerson = new Person();
                double randomValue = rn.NextDouble();// 0-1 arasında random değer oluşturuldu, rulet tekerleğide 0-1 arasında

                // Random değerin işaret ettiği birey bulunarak yeni populasyona eklenir 
                newPerson.Value = PersonForRouletteWheelPoint(randomValue, temp);

                PersonList.Add(newPerson);  // Bireyi populasyona Ekledik
            }

            this.PurposeFunction(); // Uygunluk değerleri yeni bireylere göre güncellendi
        }

        // Random oluşturulan değerin ,Rulet Tekerleğindeki Yerine Göre Birey Döndürülür
        // Her bireyin oranı toplanarak sırayla random değer kontrol edilir , eğer aralığa dekkeldiği zaman sayı bulunmuş olunur
        // örn => x1 = 10, x2 = 20, x3 = 30,x4 = 40 olsun random value ise 42 olsun 
        // Bu senaryoda x1 + x2 + x3 = 60 old zaman, toplam değer random value değerini kapsadığı zaman o aralığa girmiş olur
        private int PersonForRouletteWheelPoint(double randomValue, List<Person> RateByTotalAccordanceValueList)
        {
            double total = 0;
            foreach (var person in RateByTotalAccordanceValueList)
            {
                total += person.RateByTotalAccordanceValues;
                // Rulet Tekerleğindeki Aralğıa giren değeri bulmuş oluyoruz ve return ederiz
                if (randomValue <= total) return person.Value;
            }
            return 0;// Default Herhangi bir hata çıkarsa 0 dönsün 
        }

        // Çaprazlama => Tek noktalı çaprazlama yapılıyor.
        // Çaprazlama yaparken Sayılar Bit'e dönüştürülür. Ve bu orana göre bir çaprazlama yapılır
        // Örn: x1 = [1,1,1,1,1] ile x2 = [0,0,0,0,0] iki bireyimiz olsun. Bu oran da 0.6 olsun bu durumda ;
        // Yeni Birey(x1)=> x1'in 0.6sına kadar olan kısmı ve x2'in 0.6'sından sonra olan kısmı yani => [1,1,1,0,0]
        // Yeni Birey(x2))=> [0,0,0,1,1] olur
        // Her 2 Birey İçin Yapılır, bundan Önce hepsi büyükten küçüğe sıralanır
        private void CrossOver()
        {
            // İlk önce bireylerin kromozom yapısı çıkartılır
            // Her bir birey bite dönüştürülür ve değeri tanımlanır
            // Önemli => Bireyleri çaprazlarken uygunluk değerine göre çaprazlancağı için ilk önce uygunluk değerlerine göre sıralandı
            PersonList = PersonList.OrderByDescending(s => s.AccordanceValue).ToList();
            PersonList.ForEach(person => person.BitsValue = ConverToBinary(Math.Abs(person.Value)));

            List<Person> temp = new List<Person>();
            // Çaprazlamayı 2 birey arasında yapacağımız için populasyon sayısı tek ise sondaki elemanı almıyacağız, o yüzden tek olur ise 1 eksilttik
            int length = PopulationCount % 2 == 0 ? PopulationCount : PopulationCount - 1;

            // Girilen Çaprazlama oranına göre kromozomdaki bölüm noktası
            // => Örn: 5 bitlik ise crossRate = 0.6 ise 3.bit hedef noktaso olur
            // Anlamı ilk bireyin  => ilk 3 bitini al , 2.bireyin => 3.bitten sonrakini al
            int targetPoint = Convert.ToInt32(Math.Round((CrossProbability * BitCount), 0));

            // 2 Birey Çaprazlamaya tutulacağı için döngüyü 2 şer arttırdık
            for (int i = 0; i < length; i = i + 2) 
            {
                // Çaprazlama İşlemine tabi tutlacak Bireyler
                Person p1 = PersonList.ElementAt(i); // İlk birey
                Person p2 = PersonList.ElementAt(i + 1); // Bir sonraki birey

                // Yeni Bireyler
                // Tek noktalı çaprazlama ile yeni bireyler oluşturulup, yeni değerleri hesaplanır
                // populasyona eklenir 
                // Yeni bireyler eski bireyden kalıtım aldıkları için ilk bireyin işaretini taşırlar => "Negatif" yada "Pozitif"
                Person firstPerson = new Person();
                firstPerson.BitsValue = SinglePointCrossover(p1, p2, targetPoint, true);

                //Negatiflik Kontrolü
                if(Math.Abs(p1.Value) == p1.Value)
                firstPerson.Value = BinaryToInt(firstPerson.BitsValue);
                else // Negaitf Yapma
                firstPerson.Value = BinaryToInt(firstPerson.BitsValue) * -1;

                temp.Add(firstPerson);

                Person secondPerson = new Person();
                secondPerson.BitsValue = SinglePointCrossover(p1, p2, targetPoint, false); // 2. Birey oldugu için False                

                //Negatiflik Kontrolü
                if (Math.Abs(p2.Value) == p2.Value)
                    secondPerson.Value = BinaryToInt(secondPerson.BitsValue);
                else // Negaitf Yapma
                    secondPerson.Value = BinaryToInt(secondPerson.BitsValue) * -1;

                temp.Add(secondPerson);
            }

            PersonList.Clear();
            PersonList.AddRange(temp);

            // Yeni Bireyler Oluşturuldukta sonra Uygunluk Değerleri Yeniden Hesaplanır
            this.PurposeFunction();
        }

        // Tek Noktalı Çaprazlama => Belirlenen noktoya kadar x1 den alınır, geri kalan x2 den alınır
        // Fonksiyonun 2 birey için de çalışması "isFirstCrossOver" parametresi alındı
        // isFirstCrossOver = true ise 1. Birey için Çaprazlama yapılıyordur
        // isFirstCrossOver = false ise 2. Birey için Çaprazlama yapılıyordur
        public int[] SinglePointCrossover(Person x1, Person x2, int targetPoint, bool isFirstCrossOver)
        {
            int[] bits = new int[BitCount];

            // ***Çaprazlama Birinci Yeni Birey için ise***
            // Başlangıç noktası  0 dan ve hedef noktaya kadar  1. bireyden bit alınır
            // Geri kalan kısım ise hedef noktadan son noktaya kadar olan kısım ise 2. bireyden bit alınır

            // => 2. birey için ise tam tersi işlem olur

            int firstLoopStart = isFirstCrossOver == true ? 0 : targetPoint;
            int firstLoopLenght = isFirstCrossOver == true ? targetPoint : BitCount;


            int SecondLoopStart = isFirstCrossOver == true ? targetPoint : 0;
            int SecondLoopLenght = isFirstCrossOver == true ? BitCount : targetPoint;

            // First Loop

            for (int i = firstLoopStart; i < firstLoopLenght; i++)
            {
                bits[i] = x1.BitsValue[i];
            }

            // Second Loop
            for (int i = SecondLoopStart; i < SecondLoopLenght; i++)
            {
                bits[i] = x2.BitsValue[i];
            }

            return bits;
        }

        // Bireyleri 2lik tabana Dönüştürme => BitCount' a göre bit sayısı en başta belirlenir yani dizinin sınırı
        private int[] ConverToBinary(int personValue)
        {
            string s = Convert.ToString(personValue, 2); // Binary'e çevrilir

            // Her Bireydeki bit sayısı aynı olması için en yüksek sayıya göre max bit sayısı belirlenir 
            // ve her bireyin bitcount kadar bit sayısı olur
            //bitcount ise 
            int[] bits = s.PadLeft(BitCount, '0')
                         .Select(c => int.Parse(c.ToString()))
                         .ToArray();
            return bits;
        }

        // 2 lik tabandan 10 luk tabana dönüştürme
        private int BinaryToInt(int[] bits)
        {
            double total = 0;
            double pow = 0;
            for (int i = 0; i < BitCount; i++)
            {
                pow = Math.Pow(2, BitCount - i - 1);
                total += bits[i] * pow;
            }

            return Convert.ToInt32(total);
        }

        // Mutasyon => Rastgele bir random değer üretilir. Bu Random Değer eğer mutasyon oranından
        // küçük yada eşit olursa kromozom terslenir ( 1 ler 0 , 0'lar 1) olur
        // Eğer random değer büyük ise , her bit için rastgele değer üretilerek terslenir
        private void Mutation()
        {      
            foreach (var person in PersonList)
            {
                mutationRandom = rn.NextDouble();

                // Bütün Elemanlar Terslenir
                if(mutationRandom < MutationProbability)
                {
                    person.BitsValue = PersonAllElementInverse(person.BitsValue);
                }
                // Bütün elemanlar için Random değerler üretilip küçük ise o eleman terslenir
                else
                {
                    person.BitsValue = PersonElementInverseByRandomValue(person.BitsValue);
                }

                //Negatiflik Kontrolü
                if (Math.Abs(person.Value) == person.Value)
                    person.Value = BinaryToInt(person.BitsValue);
                else // Negaitf Yapma
                    person.Value = BinaryToInt(person.BitsValue) * -1;
            }
            // Yeni Değerler Oluştukdan Sonra Uygunluk Değerleri Yeniden Hesaplanır
            this.PurposeFunction();

        }

        // Bütün Elemanları Tersleme  1 => 0 ; 0 => 1 yap
        public int[] PersonAllElementInverse(int[] personBits)
        {
            int[] bits = personBits;

            for (int i = 0; i < BitCount; i++)
            {
                bits[i] = personBits[i] == 1 ? 0 : 1;              
            }
            return bits;
        }

        // Random Değere Göre Tersleme; random değer üret,mutasyon oranından küçük ise tersle
        public int[] PersonElementInverseByRandomValue(int[] personBits)
        {
            int[] bits = personBits;
            for (int i = 0; i < BitCount; i++)
            {
                mutationRandom = rn.NextDouble();
                // Random Değer Mutasyon Oranından küçük ise tersle
                if (mutationRandom < MutationProbability)
                {
                    bits[i] = personBits[i] == 1 ? 0 : 1;
                }
            }
            return bits;
        }

        // Max Bit Sayısı Hesaplama => Denklemin hangi sınırın bit sayısı büyük ise ona göre hesaplancak
        private void MaxBitCountCalculate()
        {
            this.BitCount = ConverToBinary
                (
                Math.Abs(MaxValueForPerson) > Math.Abs(MinValueForPerson)
                ? Math.Abs(MaxValueForPerson)
                : Math.Abs(MinValueForPerson)
                ).Length;
        }
    }
}
