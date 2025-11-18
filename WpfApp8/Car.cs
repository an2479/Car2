using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8
{
    public class Car
    {
        private string carId;
        private int seats;
        private bool isSport;
        private double price;
        private string color;
        private DateTime manufactoredDate;
        private int hand;
        public Car(string carId, int seats, bool isSport, double price, string color, DateTime manufactoredDate, int hand)
        {
            this.carId = carId;
            this.seats = seats;
            this.isSport = isSport;
            this.price = price;
            this.color = color;
            this.manufactoredDate = manufactoredDate;
            this.hand = hand;
        }

        public string CarId { get => carId; set => carId = value; }
        public int Seats { get => seats; set => seats = value; }
        public bool IsSport { get => isSport; set => isSport = value; }
        public double Price { get => price; set => price = value; }
        public string Color { get => color; set => color = value; }
        public DateTime ManufactoredDate { get => manufactoredDate; set => manufactoredDate = value; }
        public int Hand { get => hand; set => hand = value; }
        public override string ToString()
        {
            return $"Car ID is: {carId},Seats number:{seats},Is a sport car:{IsSport},Price:{price}, Color: {color}, Manufactored date:{ManufactoredDate},Hand: {hand}.";
        }
    }
}
