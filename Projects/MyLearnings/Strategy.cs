using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Scenario:

    Design a structure that provides an engine to a car.  Car models are BMW, Ford, Subaru, and can grow
*/


namespace DesignPatterns_Strategy
{
    public class EngineAssemblyCodeSmellConsumer
    {
        public void AssembleEngine(EngineType type)
        {
            if (type == EngineType.BMW)
            {
                var bmw = new BMW();
            }
            else if (type == EngineType.Ford)
            {
                var ford = new Ford();
            }
            else if (type == EngineType.Subaru)
            {
                var sub = new Subaru();
            }
            else
             throw new Exception("Engine type is not known");
        }
    }


    public class EngineAssemblyUsingStrategyPatternConsumer
    {
        private IEngine _engine;

        public EngineAssemblyUsingStrategyPatternConsumer(IEngine engine)
        {
            _engine = engine;
        }

        public void AssembleEngine()
        {
            Console.WriteLine("Build out started");
            _engine.BuildEngine();
        }

    }

    public abstract class Car
    {
        public abstract void ViewModelType();
    }

    public class BMW: Car, IEngine
    {
        public int Cylanders
        {
            get
            {
                return 6;
            }
        }

        public FuelType FuelTypeUsed
        {
            get
            {
                return FuelType.Gas;
            }
        }

        public void BuildEngine()
        {
            Console.WriteLine("Build out started for BMW");
        }

        public override void ViewModelType()
        {
            Console.WriteLine("Model Type:  BMW");
        }
    }

    public class Ford:  Car, IEngine
    {
        public int Cylanders
        {
            get
            {
                return 8;
            }
        }

        public FuelType FuelTypeUsed
        {
            get
            {
                return FuelType.Diesel;
            }
        }

        public void BuildEngine()
        {
            Console.WriteLine("Build out started for Ford");
        }

        public override void ViewModelType()
        {
            Console.WriteLine("Model Type:  Ford");
        }
    }

    public class Subaru:  Car, IEngine
    {
        public int Cylanders
        {
            get
            {
                return 4;
            }
        }

        public FuelType FuelTypeUsed
        {
            get
            {
                return FuelType.Hybrid;
            }
        }

        public void BuildEngine()
        {
            Console.WriteLine("Build out started for Subaru");
        }

        public override void ViewModelType()
        {
            Console.WriteLine("Model Type:  Subaru");
        }
    }

    public enum FuelType
    {
        Gas,
        Diesel,
        Hybrid
    }

    public enum EngineType
    {
        BMW,
        Ford,
        Subaru,
    }

    public interface IEngine
    {
        int Cylanders { get; }
        FuelType FuelTypeUsed { get; }

        void BuildEngine();
    }

}
