using System;
using System.Drawing;
using System.Windows.Forms;

namespace BeehiveSimulator
{
    public partial class BeeControl : UserControl
    {
        private int _cell;
        private Bitmap[] _cells = new Bitmap[4];

        public BeeControl()
        {
            InitializeComponent();
            BackColor = Color.Transparent;
            //BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImageLayout = ImageLayout.None;
            ResizeCells();

        }
        
        private void ResizeCells()
        {
            _cells[0] = Renderer.ResizeImage(Properties.Resources.Bee_animation_1, Width, Height);
            _cells[1] = Renderer.ResizeImage(Properties.Resources.Bee_animation_2, Width, Height);
            _cells[2] = Renderer.ResizeImage(Properties.Resources.Bee_animation_3, Width, Height);
            _cells[3] = Renderer.ResizeImage(Properties.Resources.Bee_animation_4, Width, Height);
        }

        private void TmrTimer_Tick(object sender, EventArgs e)
        {
            _cell++;
            switch (_cell)
            {
                case 1:
                    BackgroundImage = _cells[0];
                    break;

                case 2:
                    BackgroundImage = _cells[1];
                    break;

                case 3:
                    BackgroundImage = _cells[2];
                    break;

                case 4:
                    BackgroundImage = _cells[3];
                    break;

                case 5:
                    BackgroundImage = _cells[2];
                    break;

                default:
                    BackgroundImage = _cells[1];
                    _cell = 0;
                    break;
            }
        }

        private void BeeControl_Resize(object sender, EventArgs e)
        {
            ResizeCells();
        }
    }
}