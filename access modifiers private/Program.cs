using System;
namespace accessModifierPrivate
{
    class parent
    {
        private int value;
        public void setvalue(int v)
        {
            value = v;
        }
        public int getValue()
        {
            return value;
        }
    }
    
    class child: parent
    {
        public void showValue()
        {
            ;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            parent obj = new parent();
            obj.setvalue (25);
            Console.WriteLine("value =" + obj.getValue());
        }
    }
}