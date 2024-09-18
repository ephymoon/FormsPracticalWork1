using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Apartment
    {
        public Room[] rooms = new Room[2];
        public int aptNumber;
        public int floor;
        public Apartment()
        {
            rooms = new Room[2];
            aptNumber = 0;
            floor = 0;
        }
        public Apartment(Room[] rooms, int aptNumber, int floor)
        {
            this.rooms = rooms;
            this.aptNumber = aptNumber;
            this.floor = floor;
        }
        public Apartment(Apartment apartment)
        {
            this.rooms = apartment.rooms;
            this.aptNumber = apartment.aptNumber;
            this.floor = apartment.floor;
        }
        public override string ToString()
        {
            int xd = rooms.Length;
            string x = $"Квартира номер {aptNumber}, на {floor} этаже, {xd} комнат.\n";
            return x;
        }
    }
}
