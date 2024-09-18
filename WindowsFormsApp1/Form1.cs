using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Room room1 = new Room();
            Room room2 = new Room(10,5,2,"Гостинная");
            Room room3 = new Room(room2);
            string xd = $"Класс комнат, демонтрация метода ToString:\n" +
                $"Конструктор без параметров: {room1.ToString()}\n" +
                $"С параметрами: {room2.ToString()}\n" +
                $"Конструктор копирования: {room3.ToString()}";
            listBox1.Items.AddRange(xd.Split('\n'));
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Apartment apartment1 = new Apartment();
            Room[] rooms = new Room[3];
            Apartment apartment2 = new Apartment(rooms,3,2);
            Apartment apartment3 = new Apartment(apartment2);
            string xd = $"Класс квартир, демонтрация метода ToString:\n" +
                $"Конструктор без параметров: {apartment1.ToString()}\n" +
                $"С параметрами: {apartment2.ToString()}\n" +
                $"Конструктор копирования: {apartment3.ToString()}";
            listBox1.Items.AddRange(xd.Split('\n'));
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Building building1 = new Building();
            Apartment[] apartments = new Apartment[4];
            Building building2 = new Building(apartments,4,"Пушкина 52");
            Building building3 = new Building(building2);
            string xd = $"Класс зданий, демонтрация метода ToString:\n" +
                $"Конструктор без параметров: {building1.ToString()}\n" +
                $"С параметрами: {building2.ToString()}\n" +
                $"Конструктор копирования: {building3.ToString()}";
            listBox1.Items.AddRange(xd.Split('\n'));
        }
    }
}
/*
 Point p1 = new Point();
            listBox1.Items.Add("Точка 1. Конструктор без параметров");
            listBox1.Items.Add(p1.ToString());
            Point p2 = new Point(3,5);
            listBox1.Items.Add("Точка 2. Конструктор с параметрами");
            listBox1.Items.Add(p2.ToString());
            p2.x = 4;
            p2.y = 8;
            listBox1.Items.Add("Точка 2. Изменили параметры");
            listBox1.Items.Add(p2.ToString());
*/
