using System.Windows.Forms;

namespace ExploreTheHouse
{
    public partial class FormExplore : Form
    {
        public FormExplore()
        {
            InitializeComponent();
            CreateObjects();
        }

        private void CreateObjects()
        {
            var livingRoom = new RoomWithDoor("Sala de Estar", "um carpete antigo" , "uma porta de carvalho com uma maçaneta de latão");
            var dinningRoom = new Room("Sala de Jantar", "um candelabro de cristal");
            var kitchen = new RoomWithDoor("Cozinha", "detalhes em aço inox", "uma porta com tela");
            var backYard = new OutsideWithDoor("Quintal dos Fundos", true, "uma porta com tela");
            var garden = new Outside("Jardim", false);
            var frontYard = new OutsideWithDoor("Quintal da Frente", false, "uma porta de carvalho com uma maçaneta de latão");

            livingRoom.Exits = new Location[] { dinningRoom };
            dinningRoom.Exits = new Location[] { livingRoom, kitchen };
            kitchen.Exits = new Location[] { dinningRoom };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { frontYard, backYard };
            frontYard.Exits = new Location[] { backYard, garden };

        }
    }
}