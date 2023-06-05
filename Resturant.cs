using System;
namespace API
{
	public class Resturant
	{
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int avgprice { get; set; }
        public Resturant()
		{
		}

        public Resturant(int id, string name, string address, int avgprice)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.avgprice = avgprice;
        }
    }
}

