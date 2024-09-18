using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Building
    {
        public Apartment[] apartments = new Apartment[2];
        public int floors;
        public string adress;
        public Building()
        {
            apartments = new Apartment[2];
            floors = 1;
            adress = "Отсутствует";
        }

        public Building(Apartment[] apartments, int floors, string adress)
        {
            this.apartments = apartments;
            this.floors = floors;
            this.adress = adress;
        }

        public Building(Building building)
        {
            this.apartments = building.apartments;
            this.floors = building.floors;
            this.adress = building.adress;
        }

        public override string ToString()
        {
            int xd = apartments.Length;
            string x = $"Здание на {floors} этажей, {xd} квартир. По адресу {adress}\n";
            return x;
        }
    }
}
