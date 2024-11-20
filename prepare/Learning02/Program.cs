using System;

namespace AbstractionAssignment
{
    // Class representing a Blind
    public class Blind
    {
        public double _width;   // Width of the blind
        public double _height;  // Height of the blind
        public string _color;   // Color of the blind

        // Constructor to initialize a Blind object
        public Blind(double width, double height, string color)
        {
            _width = width;
            _height = height;
            _color = color;
        }

        // Method to calculate the area of the blind
        public double GetArea()
        {
            return _width * _height;
        }

        // Method to display blind details
        public void DisplayDetails()
        {
            Console.WriteLine($"Blind Details - Width: {_width}, Height: {_height}, Color: {_color}, Area: {GetArea()}");
        }
    }

    // Class representing a Room
    public class Room
    {
        public string _name;       // Name of the room
        public Blind _roomBlind;   // Blind used in the room

        // Constructor to initialize a Room object
        public Room(string name, Blind roomBlind)
        {
            _name = name;
            _roomBlind = roomBlind;
        }

        // Method to display room details
        public void DisplayRoomDetails()
        {
            Console.WriteLine($"Room Name: {_name}");
            _roomBlind.DisplayDetails();
        }
    }

    // Class representing a House
    public class House
    {
        public string _owner;  // Owner of the house
        public Room _kitchen;  // Kitchen details
        public Room _livingRoom; // Living room details

        // Constructor to initialize a House object
        public House(string owner, Room kitchen, Room livingRoom)
        {
            _owner = owner;
            _kitchen = kitchen;
            _livingRoom = livingRoom;
        }

        // Method to display house details
        public void DisplayHouseDetails()
        {
            Console.WriteLine($"House Owner: {_owner}");
            Console.WriteLine("Kitchen Details:");
            _kitchen.DisplayRoomDetails();
            Console.WriteLine("Living Room Details:");
            _livingRoom.DisplayRoomDetails();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create Blind objects
            Blind kitchenBlind = new Blind(60, 48, "White");
            Blind livingRoomBlind = new Blind(72, 50, "Beige");

            // Create Room objects
            Room kitchen = new Room("Kitchen", kitchenBlind);
            Room livingRoom = new Room("Living Room", livingRoomBlind);

            // Create a House object
            House house = new House("John Johnson", kitchen, livingRoom);

            // Display the complete house details
            house.DisplayHouseDetails();
        }
    }
}
