namespace Threeuple
{
    public class MyTuple<T1, T2, T3>
    {
        public T1 ItemOne { get; set; }
        public T2 ItemTwo { get; set; }
        public T3 ItemThree { get; set; }

        public MyTuple(T1 itemOne, T2 itemTwo, T3 itemThree)
        {
            this.ItemOne = itemOne;
            this.ItemTwo = itemTwo;
            this.ItemThree = itemThree;
        }
    }
}