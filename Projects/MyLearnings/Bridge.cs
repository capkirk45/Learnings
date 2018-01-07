using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class BridgeClientConsumer
    {
        public void DesignRoom()
        {
            var simpleSwitchFarWall = new SimpleSwitch();
            IElectricalApplicanceService lightA = new LightFixture();
            IElectricalApplicanceService lightB = new LightFixture();
            IElectricalApplicanceService fanA = new CeilingFanFixture();

            simpleSwitchFarWall.ElectricalApplianceService = lightA;
            simpleSwitchFarWall.ElectricalApplianceService.TurnOn();
            simpleSwitchFarWall.On();
            simpleSwitchFarWall.ElectricalApplianceService.TurnOff();
            simpleSwitchFarWall.Off();

            var simpleSwitchNearWall = new SimpleSwitch();
            simpleSwitchNearWall.ElectricalApplianceService = lightB;
            simpleSwitchNearWall.ElectricalApplianceService.TurnOn();
            simpleSwitchNearWall.On();


            var fancySwitchNearWall = new FancySwitch();
            fancySwitchNearWall.ElectricalApplianceService = fanA;
            fancySwitchNearWall.ElectricalApplianceService.TurnOn();
            fancySwitchNearWall.On();

             
        }

    }

    public class Switch
    {
        public IElectricalApplicanceService ElectricalApplianceService
        {
            get;
            set;
        }

        public virtual void On()
        {
        }

        public virtual void Off()
        {

        }
    }

    public class SimpleSwitch: Switch
    {
        public override void On()
        {
            Console.WriteLine("Switch is turned on in simple mode");
        }

        public override void Off()
        {
            Console.WriteLine("Switch is turned off in simple mode");
        }
    }

    public class FancySwitch: Switch
    {
        public override void On()
        {
            Console.WriteLine("Switch is turned on in fancy mode");
        }

        public override void Off()
        {
            Console.WriteLine("Switch is turned off in fancy mode");
        }
    }


    public interface IElectricalApplicanceService
    {
        void TurnOn();
        void TurnOff();
    }


    public class LightFixture : IElectricalApplicanceService
    {
        public void TurnOff()
        {
            Console.WriteLine("Power is off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Power is on");
        }
    }

    public class CeilingFanFixture : IElectricalApplicanceService
    {
        public void TurnOn()
        {
            Console.WriteLine("Fan is turning on");
        }
        public void TurnOff()
        {
            Console.WriteLine("Fan is turning off");
        }

    }

}
