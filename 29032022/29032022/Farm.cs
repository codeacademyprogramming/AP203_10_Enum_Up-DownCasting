using System;
using System.Collections.Generic;
using System.Text;

namespace _29032022
{
    internal class Farm
    {
        private Animal[] _animals;
        public Farm()
        {
            this._animals = new Animal[0];
        }
        public Animal[] Animals { get => _animals; }

        public void AddAnimal(Animal animal)
        {
            if(animal is Sheep || animal is Horse)
            {
                Array.Resize(ref this._animals, this._animals.Length + 1);
                this._animals[this._animals.Length - 1] = animal;
            }
        }

        public Sheep[] GetSheeps()
        {
            Sheep[] sheeps = new Sheep[0];

            foreach (var item in _animals)
            {
                if(item is Sheep)
                {
                    Array.Resize(ref sheeps, sheeps.Length + 1);
                    sheeps[sheeps.Length - 1] = item as Sheep;
                }    
            }

            return sheeps;
        }

    }
}
