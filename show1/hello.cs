using System;
using System.IO;
using System.Threading;
using RaspberryPiDotNet;
using RaspberryPiDotNet.MicroLiquidCrystal;
using System.Collections.Generic;

namespace show1
{

public class HelloWorld
{
	

    public static void Main()
	{ 	
			BasicFileFunctions AusgabeListing = new BasicFileFunctions ();
			//AusgabeListing.ReadListing ();
			//AusgabeListing.ReadWebsite (@"http://www.google.de");
			Blinky led = new Blinky ();
			//led.OneLed (60);
			AnalogDigiMaker ADC = new AnalogDigiMaker ();
			ADC.StartMe ();

     }
	private static void test(){
		
	}
}
}