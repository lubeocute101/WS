using System;

namespace CS25_Exception
{
    public class NameEmptyException : Exception
    {
        public NameEmptyException() :
            base("Ten phai khac rong")
        {
        }
    }

    public class AgeException : Exception
    {
        public int age { get; set; }

        public AgeException(int _age) :
            base("Tuoi khong hop le!")
        {
            age = _age;
        }

        public void Detail()
        {
            System
                .Console
                .WriteLine($"Tuoi = {age} khong nam trong khoang [18, 100]");
        }
    }
}
