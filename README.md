# OrchardSkills.RaspberryPi.LedOnOff

## ASP.NET Core Raspberry Pi LED On Off

![rpi-led_bb](https://user-images.githubusercontent.com/59172485/103394042-43c5cc00-4ae3-11eb-92e0-76ecb4e67470.png)

![GPIO-Pinout-Diagram-2](https://user-images.githubusercontent.com/59172485/103394408-7a9ce180-4ae5-11eb-91f7-d244beb984d9.png)

## The LED

A Red LED When you pick up the LED, you will notice that one leg is longer than the other. The longer leg (known as the ‘anode’), is always connected to the positive supply of the circuit. The shorter leg (known as the ‘cathode’) is connected to the negative side of the power supply, known as ‘ground’.LED stands for Light Emitting Diode, and glows when electricity is passed through it.

LEDs will only work if power is supplied the correct way round (i.e. if the ‘polarity’ is correct). You will not break the LEDs if you connect them the wrong way round – they will just not light. If you find that they do not light in your circuit, it may be because they have been connected the wrong way round.

## The Resistor

330 Ohm ResistorYou must ALWAYS use resistors to connect LEDs up to the GPIO pins of the Raspberry Pi. The Raspberry Pi can only supply a small current (about 60mA). The LEDs will want to draw more, and if allowed to they will burn out the Raspberry Pi. Therefore putting the resistors in the circuit will ensure that only this small current will flow and the Raspberry Pi will not be damaged.
Resistors are a way of limiting the amount of electricity going through a circuit; specifically, they limit the amount of ‘current’ that is allowed to flow. The measure of resistance is called the Ohm (Ω), and the larger the resistance, the more it limits the current. The value of a resistor is marked with coloured bands along the length of the resistor body.

You will be using a 330Ω resistor. You can identify the 330Ω resistors by the colour bands along the body. The colour coding will depend on how many bands are on the resistors supplied:

If there are four colour bands, they will be Orange, Orange, Brown, and then Gold.
If there are five bands, then the colours will be Orange, Orange, Black, Black, Brown.
It does not matter which way round you connect the resistors. Current flows in both ways through them.