using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneticAlgortihm
{
    public class Person
    {
        // Bireylerin Asıl Değerleri Karşılığı
        public int Value { get; set; }
        // Bireylerin Amaç Fonksiyonuna Göre Uygunluk Değerleri
        public double AccordanceValue { get; set; }
        // Bireylerin Bitsel Karşılığının değerlerinin tutan liste
        public int[] BitsValue { get; set; }
        // Bireylerin populasyondaki bireylere oranı
        public double RateByTotalAccordanceValues { get; set; }
    }
}
