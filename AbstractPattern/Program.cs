using System;


/// <summary>
/// 추상팩토리 패턴
/// 
/// </summary>
namespace AbstractPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBikeFactory factory = new SamFactory();
            Body body = factory.CreateBody();
            Wheel wheel = factory.CreateWheel();


            Console.WriteLine(body.GetType());
            Console.WriteLine(wheel.GetType());

        }
    }

    public interface Wheel
    {
    }

    public interface Body
    {
    }

    interface IBikeFactory
    {
        public Body CreateBody();
        public Wheel CreateWheel();
    }

    public class SamFactory : IBikeFactory
    {
        public Body CreateBody()
        {
            return new SamBody();
        }

        public Wheel CreateWheel()
        {
            return new SamWheel();
        }
    }

    public class SamBody : Body
    {

    }

    public class SamWheel : Wheel
    {

    }






}
