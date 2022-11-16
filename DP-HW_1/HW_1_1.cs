using static System.Console;

interface IChair
{
	void HasLegs();
	void SitOn();
}

class VictorianChair : IChair
{
	public void HasLegs()
		=> WriteLine($"Has Legs {nameof(VictorianChair)}...");

	public void SitOn()
		=> WriteLine($"Sit On {nameof(VictorianChair)}...");
}

class ModernChair : IChair
{
	public void HasLegs()
		=> WriteLine($"Has No Legs{nameof(ModernChair)}...");
	public void SitOn() 
		=> WriteLine($"Sit on {nameof(ModernChair)}...");
}

class ArtDecoChair : IChair
{
	public void HasLegs() 
		=> WriteLine($"Has Legs {nameof(ArtDecoChair)}...");
	public void SitOn() 
		=> WriteLine($"Sit On {nameof(ArtDecoChair)}...");
}

interface ISofa
{
	void HasLegs();
	void SitOn();
}

class VictorianSofa : ISofa
{
	public void HasLegs() 
		=> WriteLine($"Has Legs {nameof(VictorianSofa)}...");
	public void SitOn() 
		=> WriteLine($"Sit On {nameof(VictorianSofa)}...");
}

class ModernSofa : ISofa
{
	public void HasLegs() 
		=> WriteLine($"Has No Legs {nameof(ModernSofa)}...");
	public void SitOn() 
		=> WriteLine($"Sit On {nameof(ModernSofa)}...");
}

class ArtDecoSofa : ISofa
{
	public void HasLegs() 
		=> WriteLine($"Has Legs {nameof(ArtDecoSofa)}...");
	public void SitOn() 
		=> WriteLine($"Sit On {nameof(ArtDecoSofa)}...");
}

interface ICoffeeTable
{
	void IsRound();
	void PlaceOn();
}

class VictorianCoffeeTable : ICoffeeTable
{
	public void IsRound() 
		=> WriteLine($"Is Round {nameof(VictorianCoffeeTable)}...");
	public void PlaceOn() 
		=> WriteLine($"Placed On {nameof(VictorianCoffeeTable)}...");
}

class ModernCoffeeTable : ICoffeeTable
{
	public void IsRound() 
		=> WriteLine($"Is Round {nameof(ModernCoffeeTable)}...");
	public void PlaceOn() 
		=> WriteLine($"Placed On {nameof(ModernCoffeeTable)}...");
}

class ArtDecoCoffeeTable : ICoffeeTable
{
	public void IsRound() => 
		WriteLine($"Is Not Round {nameof(ArtDecoCoffeeTable)}...");
	public void PlaceOn() => 
		WriteLine($"Placed On {nameof(ArtDecoCoffeeTable)}...");
}

abstract class FurnitureFactory
{
	public abstract IChair CreateChair();
	public abstract ISofa CreateSofa();
	public abstract ICoffeeTable CreateCoffeeTable();
}

class VictorianFurnitureFactory : FurnitureFactory
{
	public override IChair CreateChair() 
		=> new VictorianChair();

	public override ICoffeeTable CreateCoffeeTable() 
		=> new VictorianCoffeeTable();

	public override ISofa CreateSofa() 
		=> new VictorianSofa();
}

class ModernFurnitureFactory : FurnitureFactory
{
	public override IChair CreateChair() 
		=> new ModernChair();

	public override ICoffeeTable CreateCoffeeTable() 
		=> new ModernCoffeeTable();

	public override ISofa CreateSofa() 
		=> new ModernSofa();
}

class ArtDecoFurnitureFactory : FurnitureFactory
{
	public override IChair CreateChair() 
		=> new ArtDecoChair();

	public override ICoffeeTable CreateCoffeeTable() 
		=> new ArtDecoCoffeeTable();

	public override ISofa CreateSofa() 
		=> new ArtDecoSofa();
}

class Client
{
	public void Run()
	{
		FurnitureFactory furnitureFactory = new ModernFurnitureFactory();
		furnitureFactory.CreateSofa().SitOn();

		furnitureFactory = new ArtDecoFurnitureFactory();
		furnitureFactory.CreateCoffeeTable().IsRound();

		furnitureFactory = new VictorianFurnitureFactory();
		furnitureFactory.CreateChair().HasLegs();
	}
}

class Program
{
	static void Main()
	{
		Client client = new Client();
		client.Run();
	}
}