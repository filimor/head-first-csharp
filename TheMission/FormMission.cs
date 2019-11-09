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

        }

        private void PicBowWeapon_Click(object sender, EventArgs e)
        {

        }

        private void PicBluePotion_Click(object sender, EventArgs e)
        {

        }

        private void PicRedPotion_Click(object sender, EventArgs e)
        {

        }

        private void PicMaceWeapon_Click(object sender, EventArgs e)
        {

        }

        // Primeiro o botão chama _game.Move() com o valor de Direction
        // apropriado, e então chama o método UpdateCharacters().
        private void BtnMoveUp_Click(object sender, EventArgs e)
        {

        }

        private void BtnMoveRight_Click(object sender, EventArgs e)
        {

        }

        private void BtnMoveDown_Click(object sender, EventArgs e)
        {

        }

        private void BtnMoveLeft_Click(object sender, EventArgs e)
        {

        }

        // Cada botão chama _game.Attack() e então o método UpdateCharacters().
        // Se o jogador prepara uma poção, ela ainda é usda da mesma forma -
        // chamando _game.Attack() - mas ela não tem direção. Então deixe os
        // botões Esquerda, Direita e Para Baixo invisíveis quando o jogador
        // preparar uma poção e altere o texto no botão Para Cima pra "Beber".
        private void BtnAttackUp_Click(object sender, EventArgs e)
        {

        }

        private void BtnAttackRight_Click(object sender, EventArgs e)
        {

        }

        private void BtnAttackDown_Click(object sender, EventArgs e)
        {

        }

        private void BtnAttackLeft_Click(object sender, EventArgs e)
        {

        }
    }
}