using System;

public class HR 
{
	//= new double[5];
	public int _theAge;
	public string _theGender;
	public int _maxHR;
	
	public static double[] theZones = new double[]{ .9,.8,.7,.6,.5 };
	internal static double[] theTargetHeartRates = new double[5];
	
	public HR()
	{
	}
	
	public HR(int anAge, string aGender)
	{	
		this._theAge = anAge;
		this._theGender = aGender;
		this._maxHR = aGender == "M" ? (220 - anAge): (200 - anAge);
		calcZones(_maxHR);
	}
	public static void calcZones(int theMaxHR)
	{
		int i;
		for (i=0; i < theZones.Length; i++){
			double theHR = theMaxHR * theZones[i];
			theTargetHeartRates[i] = theHR;
		}
		
		//double[] calculatedHRs = new double[5];
		//int i;
		//for (i=0; i < theZones.Length; i++){
		//	double theHR = maxHR * theZones[i];
		//	calculatedHRs[i] = theHR;
		//}
		//theTargetHeartRates
		
		//return calculatedHRs;
	}
	public double[] GetHRs()
	{
		return theTargetHeartRates;
	}
}

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Welcome to the Heart Rate calculator!");
		HR theAthelete = new HR(51, "M");
		
		//double[] theHRZones = theAthelete.GetHRs();
		foreach (double x in theAthelete.GetHRs())
		{
			Console.WriteLine("The heart rate for the zone is: {0}", x);				
		}
	}
}