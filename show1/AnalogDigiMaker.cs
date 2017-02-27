using System;
using System.Threading;
using RaspberryPiDotNet;

namespace show1
{
	public class AnalogDigiMaker
	{
		public void StartMe ()
		{
			Console.WriteLine ("Tempertur:");
			//# set up the SPI interface pins
			//# SPI port on the ADC to the Cobbler
			GPIOMem SPICLK = new GPIOMem(GPIOPins.GPIO_11, GPIODirection.Out);
			GPIOMem SPIMISO = new GPIOMem(GPIOPins.GPIO_09, GPIODirection.In);
			GPIOMem SPIMOSI = new GPIOMem(GPIOPins.GPIO_10, GPIODirection.Out);
			GPIOMem SPICS = new GPIOMem(GPIOPins.GPIO_08, GPIODirection.Out);

			int adcum = 1;
			double read_adc0 =1;

			while (true) {
				MCP3008 ADChip = new MCP3008 (adcum, SPICLK, SPIMOSI, SPIMISO, SPICS);
				read_adc0 = ADChip.AnalogToDigital;
				double millivolts=Convert.ToDouble(read_adc0)*(3300/1024);
				double temp_C = ((millivolts - 100) / 10) - 40;
				Console.WriteLine ("read_adc0:{0}", read_adc0);
				Thread.Sleep (3000);
			
			}
		}
	}
}

