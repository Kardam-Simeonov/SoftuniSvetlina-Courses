namespace Tuple
{
    public class MyTuple<T1, T2>
    {
        public T1 ItemOne { get; set; }
        public T2 ItemTwo { get; set; }
        
        public MyTuple(T1 itemOne, T2 itemTwo)
        {
            this.ItemOne = itemOne;
            this.ItemTwo = itemTwo;
        }
    }
}