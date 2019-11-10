using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheMission
{
    public partial class FormMission : Form
    {
        private Game _game;
        private Random _random = new Random();

        public FormMission()
        {
            InitializeComponent();
        }

        private void UpdateCharacters()
        {
            // Lê a localização do jogador, dos inimiogs e de qualquer arma
            // presente na masmorra no momento e certifica-se de que as caixas
            // de imagem estejam nos lugares certos.
            // Também checa o inventário do jogador e certifica-se de que os ícones
            // corretos sejam exibidos no pergaminho de inventário.

            // Quando todos os objetos tenham se movido e atuados uns sobre os outros,
            // o formulário atualiza tudo. Então as armas que foram pegas têm sua
            // propriedade Visible de suas caixas de imagem igualadas a false,
            // inimigos e jogadores são colocados em seus novos lugares (e os mortos
            // ficam invisíveis) e o inventário é atualizado.

            picPlayer.Location = _game.PlayerLocation;
            lblPlayerHitPoints.Text = _game.PlayerHitPoints.ToString();
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;
            Control weaponControl = null;

            lblBat.Text = string.Empty;
            lblGhost.Text = string.Empty;
            lblGhoul.Text = string.Empty;
            lblBatHitPoints.Text = string.Empty;
            lblGhostHitPoints.Text = string.Empty;
            lblGhoulHitPoints.Text = string.Empty;

            foreach (Enemy enemy in _game.Enemies)
            {
                if(enemy is Bat)
                {
                    picBat.Location = enemy.Location;
                    lblBatHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    picGhost.Location = enemy.Location;
                    lblGhostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    picGhoul.Location = enemy.Location;
                    lblGhoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

            // Depois que você iterou por todos os inimigos no nível, cheque
            // a variável showBat. Se o morcego foi morto, então será false,
            // logo deixe sua PictureBox invisível e apague seu rótulo de pontos
            // de vida. Depois faça o mesmo para showGhost e showGhoul.

            picSword.Visible = false;
            picBow.Visible = false;
            picRedPotion.Visible = false;
            picBluePotion.Visible = false;
            picMace.Visible = false;

            switch (_game.WeaponInRoom.Name)
            {
                case "Espada":
                    weaponControl = picSword;
                    break;
                case "Arco":
                    weaponControl = picBow;
                    break;
                case "Poção Azul":
                    weaponControl = picBluePotion;
                    break;
                case "Poção Vermelha":
                    weaponControl = picRedPotion;
                    break;
                case "Bastão":
                    weaponControl = picMace;
                    break;
            }

            weaponControl.Visible = true;

            // Use o método CheckPlayerInventory() do objeto Game para descobrir
            // se os diversos ícones no inventário devem ser exibidos.

            weaponControl.Location = _game.WeaponInRoom.Location;
            // Todo nível tem uma arma. Se ela foi recolhida, precisamos deixar
            // seu ícone invisível.
            weaponControl.Visible = _game.WeaponInRoom.PickedUp;
            if (_game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("Você morreu!", "Fim de jogo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("Você derrotou todos os inimigos neste nível!", "Parabéns",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _game.NewLevel(_random);
                UpdateCharacters();
            }
        }

        private void FormMission_Load(object sender, EventArgs e)
        {
            _game = new Game(new Rectangle(78, 57, 420, 155));
            _game.NewLevel(_random);
            UpdateCharacters();
        }

        // Quando o jogador clicar numa arma, primeiro verifica-se se ela está no
        // inventário usando o método CheckPlayerInventory() do objeto Game. Se
        // o jogador estiver de posse da arma, chama _game.Equip() para que o
        // jogador a segure. Então configura cada propriedade BorderStyle de
        // PicutreBox para desenhar uma caixa em volta da arma e certifica-se de
        // que nenhum dos outros itens têm uma caixa em volta deles.
        private void PicSwordWeapon_Click(object sender, EventArgs e)
        {
            if(_game.CheckPlayerInventory("Espada")){
                _game.Equip("Espada");
                picSwordWeapon.BorderStyle = BorderStyle.FixedSingle;
                picBowWeapon.BorderStyle = BorderStyle.None;
                picMaceWeapon.BorderStyle = BorderStyle.None;
                picRedPotionWeapon.BorderStyle = BorderStyle.None;
                picBluePotionWeapon.BorderStyle = BorderStyle.None;

                btnAttackDown.Visible = true;
                btnAttackLeft.Visible = true;
                btnAttackRight.Visible = true;
                btnAttackUp.Text = "Para cima";
            }
        }

        private void PicBowWeapon_Click(object sender, EventArgs e)
        {
            if (_game.CheckPlayerInventory("Arco"))
            {
                _game.Equip("Arco");
                picSwordWeapon.BorderStyle = BorderStyle.None;
                picBowWeapon.BorderStyle = BorderStyle.FixedSingle;
                picMaceWeapon.BorderStyle = BorderStyle.None;
                picRedPotionWeapon.BorderStyle = BorderStyle.None;
                picBluePotionWeapon.BorderStyle = BorderStyle.None;

                btnAttackDown.Visible = true;
                btnAttackLeft.Visible = true;
                btnAttackRight.Visible = true;
                btnAttackUp.Text = "Para cima";
            }
        }

        private void PicBluePotionWeapon_Click(object sender, EventArgs e)
        {
            if (_game.CheckPlayerInventory("Poção Azul"))
            {
                _game.Equip("Poção Azul");
                picSwordWeapon.BorderStyle = BorderStyle.None;
                picBowWeapon.BorderStyle = BorderStyle.None;
                picMaceWeapon.BorderStyle = BorderStyle.None;
                picRedPotionWeapon.BorderStyle = BorderStyle.None;
                picBluePotionWeapon.BorderStyle = BorderStyle.FixedSingle;

                btnAttackDown.Visible = false;
                btnAttackLeft.Visible = false;
                btnAttackRight.Visible = false;
                btnAttackUp.Text = "Beber";
            }
        }

        private void PicRedPotionWeapon_Click(object sender, EventArgs e)
        {
            if (_game.CheckPlayerInventory("Poção Vermelha"))
            {
                _game.Equip("Poção Vermelha");
                picSwordWeapon.BorderStyle = BorderStyle.None;
                picBowWeapon.BorderStyle = BorderStyle.None;
                picMaceWeapon.BorderStyle = BorderStyle.None;
                picRedPotionWeapon.BorderStyle = BorderStyle.FixedSingle;
                picBluePotionWeapon.BorderStyle = BorderStyle.None;

                btnAttackDown.Visible = false;
                btnAttackLeft.Visible = false;
                btnAttackRight.Visible = false;
                btnAttackUp.Text = "Beber";
            }
        }

        private void PicMaceWeapon_Click(object sender, EventArgs e)
        {
            if (_game.CheckPlayerInventory("Bastão"))
            {
                _game.Equip("Bastão");
                picSwordWeapon.BorderStyle = BorderStyle.None;
                picBowWeapon.BorderStyle = BorderStyle.None;
                picMaceWeapon.BorderStyle = BorderStyle.FixedSingle;
                picRedPotionWeapon.BorderStyle = BorderStyle.None;
                picBluePotionWeapon.BorderStyle = BorderStyle.None;

                btnAttackDown.Visible = true;
                btnAttackLeft.Visible = true;
                btnAttackRight.Visible = true;
                btnAttackUp.Text = "Para cima";
            }
        }

        // Primeiro o botão chama _game.Move() com o valor de Direction
        // apropriado, e então chama o método UpdateCharacters().
        private void BtnMoveUp_Click(object sender, EventArgs e)
        {
            _game.Move(Direction.Up, _random);
            UpdateCharacters();
        }

        private void BtnMoveRight_Click(object sender, EventArgs e)
        {
            _game.Move(Direction.Right, _random);
            UpdateCharacters();
        }

        private void BtnMoveDown_Click(object sender, EventArgs e)
        {
            _game.Move(Direction.Down, _random);
            UpdateCharacters();
        }

        private void BtnMoveLeft_Click(object sender, EventArgs e)
        {
            _game.Move(Direction.Left, _random);
            UpdateCharacters();
        }

        // Cada botão chama _game.Attack() e então o método UpdateCharacters().
        // Se o jogador prepara uma poção, ela ainda é usda da mesma forma -
        // chamando _game.Attack() - mas ela não tem direção. Então deixe os
        // botões Esquerda, Direita e Para Baixo invisíveis quando o jogador
        // preparar uma poção e altere o texto no botão Para Cima pra "Beber".
        private void BtnAttackUp_Click(object sender, EventArgs e)
        {
            _game.Attack(Direction.Up, _random); 
            UpdateCharacters();
        }

        private void BtnAttackRight_Click(object sender, EventArgs e)
        {
            _game.Attack(Direction.Right, _random);
            UpdateCharacters();
        }

        private void BtnAttackDown_Click(object sender, EventArgs e)
        {
            _game.Attack(Direction.Down, _random);
            UpdateCharacters();
        }

        private void BtnAttackLeft_Click(object sender, EventArgs e)
        {
            _game.Attack(Direction.Left, _random);
            UpdateCharacters();
        }
    }
}