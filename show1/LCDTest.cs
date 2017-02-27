using System;
using System.Threading;
using RaspberryPiDotNet;
using RaspberryPiDotNet.MicroLiquidCrystal;

namespace show1
{
	public class LCDTest
	{
		public LCDTest ()
		{
			// RS,RW,E,D4,D5,D6,D7
			RaspPiGPIOMemLcdTransferProvider lcdProvider = new RaspPiGPIOMemLcdTransferProvider(
				GPIOPins.Pin_P1_07,
				GPIOPins.Pin_P1_22,
				GPIOPins.Pin_P1_11,
				GPIOPins.Pin_P1_12,
				GPIOPins.Pin_P1_15,
				GPIOPins.Pin_P1_16,
				GPIOPins.Pin_P1_18);

			string meintext = "Hello World, how are you?";
			Lcd lcd = new Lcd(lcdProvider);

			lcd.Begin(16, 2);
			lcd.Clear();
			lcd.Backlight = false;
			lcd.SetCursorPosition(0, 0);
			lcd.Write(meintext);
			//System.Threading.Thread.Sleep (3);
			//lcd.Clear();
			//lcd.Write("Ahoj Bernie?!");
			System.Threading.Thread.Sleep (2000);
			int anzahl = meintext.Length;
			while (anzahl>0) {
				lcd.ScrollDisplayLeft ();
				System.Threading.Thread.Sleep (200);
				anzahl--;
			}
		}
	}
}

