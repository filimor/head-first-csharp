using System.Threading;
using System.Windows.Forms;

namespace ExploreTheHouse
{
    public partial class FormExplore : Form
    {
        // btnGoThroughTheDoor só é visível quando existe uma porta externa
        // btnGoHere e btnPassThroughTheDoor só são visíveis quando o jogo estiver rodando

        private Location currentLocation;
        private RoomWithDoor livingRoom;
        private RoomWithHidingPlace dinningRoom;
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

        private Opponent opponent;
        private int moves;

        public FormExplore()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Sala de Estar", "um carpete antigo", "dentro do closet", "uma porta de carvalho com uma maçaneta de latão");
            dinningRoom = new RoomWithHidingPlace("Sala de Jantar", "um candelabro de cristal", "no armário do hall");
            kitchen = new RoomWithDoor("Cozinha", "detalhes em aço inox", "dentro do armário", "uma porta com tela");
            backYard = new OutsideWithDoor("Quintal dos Fundos", true, "uma porta com tela");
            garden = new OutsideWithHidingPlace("Jardim", false, "no galpãozinho");
            frontYard = new OutsideWithDoor("Quintal da Frente", false, "uma porta de carvalho com uma maçaneta de latão");

            stairs = new Room("Escadas", "um corrimão de madeira");
            upstairsHallway = new RoomWithHidingPlace("Hall Superior", "um quadro de um cachorro", "no armário");
            masterBedroom = new RoomWithHidingPlace("Quarto Principal", "uma cama grande", "debaixo da cama");
            secondBedroom = new RoomWithHidingPlace("Segundo Quarto", "uma cama pequena", "debaixo da cama");
            bathroom = new RoomWithHidingPlace("Banheiro", "uma pia e um vaso sanitário", "no chuveiro");
            driveway = new OutsideWithHidingPlace("Calçada", true, "na garagem");

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

            opponent = new Opponent(frontYard);
        }

        private void MoveToANewLocation(Location newLocation)
        {
            moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        private void RedrawForm()
        {
            // Coloca o texto correto na caixa
            // Torna os botões visíveis ou invisíveis
            // Coloca o texto correto no botão do meio

            cboExits.Items.Clear();
            foreach (Location exit in currentLocation.Exits)
            {
                cboExits.Items.Add(exit.Name);
            }
            cboExits.SelectedItem = 0;
            txtDescription.Text = $"{currentLocation.Description}\n(Movimento {moves})";

            if (currentLocation is IHidingPlace)
            {
                var hidingPlace = currentLocation as IHidingPlace;
                btnCheck.Visible = true;
                btnCheck.Text = $"Verificar {hidingPlace.HidingPlaceName}";
            }
            else
            {
                btnCheck.Visible = false;
            }
            btnCheck.Visible = false;

            btnPassThroughTheDoor.Visible = currentLocation is IHasExteriorDoor;
        }

        private void ResetGame(bool displayMessage)
        {
            // Deve ser executado quando o oponente for encontrado
            // Mostrar na caixa de texto quando o oponente for encontrado e quantos
            // movimentos foram feitos para achá-lo

            if (displayMessage)
            {
                MessageBox.Show($"Você me achou em {moves} movimentos!",
                    "Oponente encontrdo", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                var foundLocation = currentLocation as IHidingPlace;
                txtDescription.Text = $"Você achou seu oponente em {moves} movimentos! Ele estava escondido em {foundLocation.HidingPlaceName}.";
            }

            moves = 0;
            btnGoHere.Visible = false;
            cboExits.Visible = false;
            btnHide.Visible = true;
            btnCheck.Visible = false;
            btnPassThroughTheDoor.Visible = false;
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

        private void BtnCheck_Click(object sender, System.EventArgs e)
        {
            // Checa um esconderijo na sala
            // Deve ser visível apenas numa sala qu tenha um
            // Quando for mostrado, Text = "Olhar" + nome do lugar
            // Usar o método Check() do inimigo
            // Se o inimigo for achado o jogo acaba

            moves++;
            if (opponent.Check(currentLocation))
            {
                ResetGame(true);
            }
            else
            {
                RedrawForm();
            }
        }

        private void BtnHide_Click(object sender, System.EventArgs e)
        {
            btnHide.Visible = false;

            for (int i = 1; i <= 10; i++)
            {
                txtDescription.Text = $"{i}...";
                opponent.Move();
                Application.DoEvents();
                Thread.Sleep(200);
            }
            txtDescription.Text = "Pronto ou não, aí vou eu!";
            Application.DoEvents();
            Thread.Sleep(500);
            MoveToANewLocation(livingRoom);
            btnGoHere.Visible = true;
            cboExits.Visible = true;
        }
    }
}