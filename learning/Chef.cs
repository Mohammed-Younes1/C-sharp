using System;
namespace learning
{
	class Chef
	{
		public void MakeChicken()
		{
			Console.WriteLine("The Chef is making Chicken");
		}
		public void MakeSalad()
		{
            Console.WriteLine("The Chef is making Salad");

        }
		public virtual void MakeSpcialDish()
		{
			Console.WriteLine("The Chef Make bbq ribs");
		}

    }
}

