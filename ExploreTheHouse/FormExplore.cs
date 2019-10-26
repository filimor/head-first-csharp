using System.Windows.Forms;

namespace ExploreTheHouse
{
    public partial class FormExplore : Form
    {
        // btnGoThroughTheDoor só é visível quando existe uma porta externa
        private Location currentLocation;
        private RoomWithDoor livingRoom;
        private Room dinningRoom;
        private RoomWithDoor kitchen;
        private OutsideWithDoor backYard;
        private OutsideWithHidingPlace garden;
        private OutsideWithDoor frontYard;

        private Room stairs;
        private RoomWithHidingPlace upstairsHallway;
        private RoomWithHidingPlace masterBedroom;
        private RoomWithHidingPlace secondBedroom;
        private RoomWithHidingPlace bathroom;
        private OutsideWithHidingPlace driveway;

        public FormExplore()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Sala de Estar", "um carpete antigo" , "uma porta de carvalho com uma maçaneta de latão");
            dinningRoom = new Room("Sala de Jantar", "um candelabro de cristal");
            kitchen = new RoomWithDoor("Cozinha", "detalhes em aço inox", "uma porta com tela");
            backYard = new OutsideWithDoor("Quintal dos Fundos", true, "uma porta com tela");
            garden = new OutsideWithHidingPlace("Jardim", false,"no galpãozinho");
            frontYard = new OutsideWithDoor("Quintal da Frente", false, "uma porta de carvalho com uma maçaneta de latão");

            stairs = new Room("Escadas", "um corrimão de madeira");
            upstairsHallway = new RoomWithHidingPlace("Hall Superior", "um quadro de um cachorro", "no armário");
            masterBedroom = new RoomWithHidingPlace("Quarto Principal", "uma cama grande", "debaixo da cama");
            secondBedroom = new RoomWithHidingPlace("Segundo Quarto", "uma cama pequena", "debaixo da cama");
            bathroom = new RoomWithHidingPlace("Banheiro", "uma pia e um vaso sanitário", "no chuveiro");
            driveway = new OutsideWithHidingPlace("Calçada", false, "na garagem");


            livingRoom.Exits = new Location[] { dinningRoom, stairs };
            dinningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { dinningRoom };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { frontYard, backYard };
            frontYard.Exits = new Location[] { backYard, garden, driveway };

            stairs.Exits = new Location[] { livingRoom, upstairsHallway };
            upstairsHallway.Exits = new Location[] { stairs, masterBedroom, secondBedroom, bathroom };
            masterBedroom.Exits = new Location[] { upstairsHallway };
            secondBedroom.Exits = new Location[] { upstairsHallway };
            bathroom.Exits = new Location[] { upstairsHallway };
            driveway.Exits = new Location[] { frontYard, backYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
    }

        private void MoveToANewLocation(Location location)
        {
            currentLocation = location;
            cboExits.Items.Clear();
            foreach (Location exit in currentLocation.Exits)
            {
                cboExits.Items.Add(exit.Name);
            }
            cboExits.SelectedItem = 0;
            txtDescription.Text = currentLocation.Description;
            btnPassThroughTheDoor.Visible = currentLocation is IHasExteriorDoor;
        }

        private void BtnGoHere_Click(object sender, System.EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[cboExits.SelectedIndex]);
        }

        private void BtnPassThroughTheDoor_Click(object sender, System.EventArgs e)
        {
            var location = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(location.DoorLocation);
        }
    }
}