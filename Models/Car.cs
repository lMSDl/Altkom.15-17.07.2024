using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Car
    {
        public string Manufacturer { get; }
        public string Model { get; }
        public int ProductionYear { get; }
        public int Odo { get; private set; }
        public float FuelLevel { get; private set; }

        public Car(string manufacturer, string model, int productionYear)
        {
            Manufacturer = manufacturer;
            Model = model;
            ProductionYear = productionYear;
        }

        public string GetInformations()
        {
            return $"{Manufacturer} {Model} ({ProductionYear}): fuel level - {FuelLevel * 100}%, ODO - {Odo}km";
        }

        //parametr domyślny - jeśli użytkownik nie przekaże wartości, to zostanie użyta wpisana jako domyślna
        public void Fuel(float amount = 0.5f)
        {
            /*FuelLevel = FuelLevel + amount;
            if(FuelLevel > 1)
                FuelLevel = 1;*/

            if (FuelLevel + amount > 1)
                FuelLevel = 1;
            else
                FuelLevel += amount;
        }

        public void Drive(int distance)
        {
            if (distance < 0)
                return;

            int maxDistance = (int)(FuelLevel * 100f / 0.1f);

            if (maxDistance < distance)
                distance = maxDistance;

            Odo = Odo + distance;
            FuelLevel = FuelLevel - (0.1f * distance) / 100f;
        }
    }
}
