using System;
using System.Windows.Forms;

namespace BeeControl
{
    public class BeeControl : PictureBox
    {
        private readonly Timer _animationTimer = new Timer();
        private int _cell;

        public BeeControl()
        {
            _animationTimer.Tick += AnimationTimer_Tick;
            _animationTimer.Interval = 150;
            _animationTimer.Start();
            BackColor = System.Drawing.Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            _cell++;
            switch (_cell)
            {
                case 1:
                    BackgroundImage = Properties.Resources.Bee_animation_1;
                    break;

                case 2:
                    BackgroundImage = Properties.Resources.Bee_animation_2;
                    break;

                case 3:
                    BackgroundImage = Properties.Resources.Bee_animation_3;
                    break;

                case 4:
                    BackgroundImage = Properties.Resources.Bee_animation_4;
                    break;

                case 5:
                    BackgroundImage = Properties.Resources.Bee_animation_3;
                    break;

                default:
                    BackgroundImage = Properties.Resources.Bee_animation_2;
                    _cell = 0;
                    break;
            }
        }

        protected override void Dispose(bool disposing)
        {
            _animationTimer.Dispose();
            base.Dispose(disposing);
        }
    }
}