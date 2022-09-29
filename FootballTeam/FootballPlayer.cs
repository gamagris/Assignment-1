namespace FootballTeam
{
    public class FootballPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ShirtNumber { get; set; }

        public override string ToString()
        {
            return Id + " " + Name + " " + Age + " " + ShirtNumber;
        }
        public void ValidateName()
        {
            if (Name.Length < 2)
            {
                throw new ArgumentOutOfRangeException("Player name must be at least 2 characters");
            }
        }
        public void ValidateAge()
        {
            if (Age > 1)
            {
                throw new ArgumentOutOfRangeException("Player's age must be more then 1");
            }
        }
        public void ValidateShirtNumber()
        {
            if (ShirtNumber < 1 || ShirtNumber > 99)
            {
                throw new ArgumentOutOfRangeException("Shirt number can not be less than 1 or more than 99");
            }
            
        }


        public void Validate()
    {
        ValidateName();
        ValidateAge();
        ValidateShirtNumber();
    }
}
}