using System;
namespace learning
{
	class ItalianChef : Chef
	{
        public void MakePasta()
        {
            Console.WriteLine("The Chef is making Pasta");
        }
        public override void MakeSpcialDish()
        {
            Console.WriteLine("The Chef Make Bolognese");
        }

    }
}

