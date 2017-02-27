using System;
using RaspberryPiDotNet;

namespace show1
{
	public class Blinky
	{
		public void BlinkyMain ()
		{
			//display.Write ("Hallo");
			//GPIOPins.GPIO_17 = GPIO17 auf PIN11

			GPIOMem  pin11= new GPIOMem (GPIOPins.GPIO_17);
			GPIOMem button = new GPIOMem (GPIOPins.GPIO_18,GPIODirection.In);
			button.Write (PinState.High);
			pin11.Write (PinState.Low);
			int power= 1;
			int pause = 1;
			bool toggle = true;
			while (true) {

				if (button.Read () == PinState.Low) {
					//test ();
					if(toggle){
						power++;
					}else{
						power--;
					};
					Console.WriteLine("Power;{0} Pause:{1}",power.ToString (),pause.ToString());
					pause = power / 2;
					if(power==20 || power==0){toggle = !toggle;
					Console.Write(toggle.ToString ());
					}
					System.Threading.Thread.Sleep (5);
				}
				pin11.Write (PinState.High);
				System.Threading.Thread.Sleep (pause);
				pin11.Write (PinState.Low);
				System.Threading.Thread.Sleep (power);
			}
		}

		public void OneLed(int dauer){
			GPIOMem led = new GPIOMem (GPIOPins.GPIO_18,GPIODirection.Out);
				while(true)
			{
				led.Write(PinState.High);
				System.Threading.Thread.Sleep(dauer);
				led.Write(PinState.Low);
				System.Threading.Thread.Sleep(dauer);
			}

		}
	}
}

