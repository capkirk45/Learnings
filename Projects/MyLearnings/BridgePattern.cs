using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Scenario:  Usage of the Bridge design pattern to facilitate proper construction of a room remodel:
    Light switches
    Light fixture
    Fan fixture
*/
namespace BridgePattern
{
    public class Client
    {
        public Client()
        {
            IElectricalEquipment fan = new Fan();
            IElectricalEquipment light = new Light();

            var fancySwitch = new FancySwitch();
            fancySwitch.Equipment = fan;
            fancySwitch.On();
            fancySwitch.Off();  //turn off fan

            fancySwitch.Equipment = light;
            fancySwitch.On();
            fancySwitch.Off(); //turn off light

            var simpleSwitch = new SimpleSwitch();
            simpleSwitch.Equipment = light;
            simpleSwitch.On(); // turn light on


        }
    }

    public class SwitchBase
    {
        public virtual void On() {
            //switch has an on button 
        }
        public virtual void Off() {
            //switch has an off button
        }

        public IElectricalEquipment Equipment
        {
            get;
            set;
        }
       
    }

    public class FancySwitch: SwitchBase
    {
        public override void On()
        {
            Console.WriteLine("Fancy switch turning on the equipment");
            this.Equipment.PowerOn();
        }

        public override void Off()
        {
            Console.WriteLine("Fancy Switch turning off now");
            this.Equipment.PowerOff();
        }
    }

    public class SimpleSwitch: SwitchBase
    {
        public override void On()
        {
            Console.WriteLine("Simple switch turning on the equipment");
            this.Equipment.PowerOn();

        }
        public override void Off()
        {
            Console.WriteLine("Simple switch turning off the equipment");
            this.Equipment.PowerOff();

        }
    }

    public interface IElectricalEquipment
    {
        void PowerOn();
        void PowerOff();
    }

    public class Fan: IElectricalEquipment
    {
        public void PowerOn()
        {
            Console.WriteLine("The fan is on");
        }

        public void PowerOff()
        {
            Console.WriteLine("The fan is off");
        }
    }

    public class Light : IElectricalEquipment
    {
        public void PowerOn()
        {
            Console.WriteLine("The light is on");
        }
        public void PowerOff()
        {
            Console.WriteLine("The light is off");
        }
    }

}
