using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Room
    {
        public float lenght;
        public float width;
        public float height;
        public string purpose;
        public Room()
        {
            lenght = 2;
            width = 2;
            height = 2;
            purpose = "Не определено";
        }
        public Room(float lenght, float width, float height, string purpose)
        {
            this.lenght = lenght;
            this.width = width;
            this.height = height;
            this.purpose = purpose;
        }
        public Room(Room room)
        {
            this.lenght = room.lenght;
            this.width = room.width;
            this.height = room.height;
            purpose = room.purpose;
        }
        public override string ToString()
        {
            string x = $"Комната {lenght} на {width}, {height} в высоту. Предназначение: {purpose}\n";
            return x;
        }
    }
}
