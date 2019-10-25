using System.Windows.Forms;

namespace ExploreTheHouse
{
    public partial class FormExplore : Form
    {
        // btnGoThroughTheDoor só é visível quando existe uma porta externa
        private Location currentLocation;
        private Location livingRoom;
        private Location dinningRoom;
        private Location kitchen;
        private Location backYard;
        private Location garden;
        private Location frontYard;

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
            garden = new Outside("Jardim", false);
            frontYard = new OutsideWithDoor("Quintal da Frente", false, "uma porta de carvalho com uma maçaneta de latão");

            livingRoom.Exits = new Location[] { dinningRoom };
            dinningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { dinningRoom };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { frontYard, backYard };
            frontYard.Exits = new Location[] { backYard, garden };
        }

        private void MoveToANewLocation(Location location)
        {
            currentLocation = location;
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