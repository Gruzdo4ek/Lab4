using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class Pet
    {
        public int weight = 2+rnd.Next() % 70;
        public static Random rnd = new Random();
        public virtual String GetInfo()
        {
            var str = String.Format("\nВес (кг): {0}", this.weight);
            return str;
        }
    }
    public enum DogType {Labrador,Chix,Mops,Buldog,Shpiz}
    public class Dog : Pet
    {
        public DogType Breed;
        public double IgnoringDistance = 0;
        public double TailLength = 0;
        public override String GetInfo()
        {
            var str = "Я собака";
            str += base.GetInfo();
            var breedInRus = this.Breed switch
            {
                DogType.Labrador => "Лабрадор",
                DogType.Chix => "Чихуахуа",
                DogType.Mops => "Мопс",
                DogType.Buldog => "Бульдог",
                DogType.Shpiz => "Шпиц",
                _ => ""
            };

            str += String.Format("\nПорода: {0}", breedInRus);
            str += String.Format("\nРасстояние игнора (м): {0}", this.IgnoringDistance);
            str += String.Format("\nДлина хвоста (см): {0}", this.TailLength);
            return str;
        }
    public static Dog Generate()
        {
            return new Dog
            {
                Breed = (DogType)rnd.Next(5),
                IgnoringDistance = 5 + rnd.Next() % 20,
                TailLength = 5 + rnd.Next() % 20
            };
        }
    }
    public class Cat : Pet
    {
        public bool HasFur = false;
        public int MiceCaughtPerDay = 0;
        public override string GetInfo()
        {
            var str = "Я кошка";
            str += base.GetInfo();
            var hasFurText = this.HasFur switch
            {
                true => "шерсть есть",
                false => "шерсти нет",
            };
            str += String.Format("\nНаличие шерсти: {0}", hasFurText);
            str += String.Format("\nКол-во мышей в день: {0}", this.MiceCaughtPerDay);
            return str;
        }
        public static Cat Generate()
        {
            return new Cat
            {
                MiceCaughtPerDay = rnd.Next() % 100,
                HasFur = rnd.Next() % 2 == 0
            };
        }
    }
    public class Cow : Pet
    {
        public int HornsLength = 0;
        public int MilkPerDay = 0;
        public override String GetInfo()
        {
            var str = "Я корова";
            str += base.GetInfo();
            str += String.Format("\nДлина рогов (см): {0}", this.HornsLength);
            str += String.Format("\nКол-во молока в день: {0}", this.MilkPerDay);
            return str;
        }
        public static Cow Generate()
        {
            return new Cow
            {
                HornsLength = 5 + rnd.Next() % 100,
                MilkPerDay = rnd.Next() % 100
            };
        }
    }


}