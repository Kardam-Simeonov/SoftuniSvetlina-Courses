namespace ClassCard
{
    class Card
    {
        public string Face { get; set; }
        public string Suite { get; set; }

        public Card(string face, string suite)
        {
            Face = face;
            Suite = suite;
        }
        public void Print()
        {
            System.Console.WriteLine($"{Face} {Suite}");
        }
    }
}