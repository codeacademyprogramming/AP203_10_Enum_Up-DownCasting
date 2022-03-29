using System;

namespace _29032022
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int num1 = 600;

            byte num2 = (byte)num1;

            Console.WriteLine(num2);

            Sheep sheep1 = new Sheep("qoyun1");
            Sheep sheep2 = new Sheep("qoyun2");
            Sheep sheep3 = new Sheep("qoyun3");
            Sheep sheep4 = new Sheep("qoyun4");

            Animal animal1 = sheep1;

            int[] nums = { };
            try
            {
                Console.WriteLine("NAme daxil et");
                string name = Console.ReadLine();

                if (name != null && !char.IsUpper(name[0]))
                    throw new NameIsWrongException("Name boyuk herfle baslamalidir!");

                nums[1] = 45;
                Horse newSheep = animal1 as Horse;
                Console.WriteLine(newSheep.Name);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Cevirme xeta verir"+"\n message: "+ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null deyerdir" + "\n message: " + ex.Message);
            }
            catch (NameIsWrongException ex)
            {
                Console.WriteLine("Ad boyuk herfle baslamalidir!" + "\n message: " + ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Bilinmedik bir xata bas verdi!");
            }



            if (animal1 is Horse)
            {
                Console.WriteLine("Animal atdir");
            }
            else if(animal1 is Sheep)
            {
                Console.WriteLine("Animal qoyundur");
            }



            Horse horse1 = new Horse("at1");
            Horse horse2 = new Horse("at2");
            Horse horse3 = new Horse("at3");

            horse1.Sort = HorseType.Qarabag;
            horse2.Sort = HorseType.Ingilis;
            horse3.Sort = HorseType.Qarabag;


            Console.WriteLine(Horse.TotalCount);

            Farm hikmetinFermasi = new Farm();
            hikmetinFermasi.AddAnimal(horse1);
            hikmetinFermasi.AddAnimal(horse2);
            hikmetinFermasi.AddAnimal(sheep2);
            hikmetinFermasi.AddAnimal(sheep3);


            foreach (var item in hikmetinFermasi.Animals)
            {
                Console.WriteLine(item.Name);
            }

            Horse[] horses = { horse1, horse2, horse3 };

            Console.WriteLine("serached horses");

            HorseType searchedType;

            Console.WriteLine("Asagidaki  at novlerinden birini secin:");
            foreach (var item in Enum.GetValues(typeof(HorseType)))
            {
                Console.WriteLine(item+ " "+ (byte)item);
            }

            byte secim = Convert.ToByte(Console.ReadLine());
            searchedType = (HorseType)secim;

            while (!Enum.IsDefined(typeof(HorseType),searchedType))
            {
                secim = Convert.ToByte(Console.ReadLine());
                searchedType = (HorseType)secim;
            }


            foreach (var item in horses)
            {
                if(item.Sort == searchedType)
                    Console.WriteLine(item.Name+ " "+item.Sort);
            }


            Console.WriteLine("Sheeps");
            foreach (var item in hikmetinFermasi.GetSheeps())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
