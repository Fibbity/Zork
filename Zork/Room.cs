namespace Zork
{
    public class Room
    {
        public string roomName { get;  }

        public string roomDescription { get; set; }

        //--------------------------//
        public Room(string name, string description = "")
        //--------------------------//
        {
            roomName = name;
            roomDescription = description;

        }//END Room

        public override string ToString() => roomName;
        

    }//END Room
}