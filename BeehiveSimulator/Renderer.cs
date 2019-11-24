using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BeehiveSimulator
{
    public class Renderer
    {
        private World _world;
        private FormHive _hiveForm;
        private FormField _fieldForm;

        private Dictionary<Flower, PictureBox> _flowerLookup =
            new Dictionary<Flower, PictureBox>();

        private Dictionary<Bee, BeeControl> _beeLockup =
            new Dictionary<Bee, BeeControl>();

        private List<Flower> _deadFlowers = new List<Flower>();
        private List<Bee> _retiredBees = new List<Bee>();

        public Renderer(World world, FormHive hiveForm, FormField fieldForm)
        {
            _world = world;
            _hiveForm = hiveForm;
            _fieldForm = fieldForm;
        }

        public void Render()
        {
            DrawBees();
            DrawFlowers();
            RemoveRetiredBeesAndFlowers();
        }

        public void Reset()
        {
            foreach (PictureBox flower in _flowerLookup.Values)
            {
                _fieldForm.Controls.Remove(flower);
                flower.Dispose();
            }
            foreach (BeeControl bee in _beeLockup.Values)
            {
                _hiveForm.Controls.Remove(bee);
                _fieldForm.Controls.Remove(bee);
                bee.Dispose();
            }
            _flowerLookup.Clear();
            _beeLockup.Clear();
        }

        public static Bitmap ResizeImage(Bitmap picture, int width, int height)
        {
            var resizedPicture = new Bitmap(width, height);
            using(var graphics = Graphics.FromImage(resizedPicture))
            {
                graphics.DrawImage(picture, 0, 0, width, height);
            }
            return resizedPicture;
        }

        private void DrawFlowers()
        {
            foreach (Flower flower in _world.Flowers)
            {
                if (!_flowerLookup.ContainsKey(flower))
                {
                    var flowerControl = new PictureBox()
                    {
                        Width = 45,
                        Height = 55,
                        Image = Properties.Resources.Flower,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Location = flower.Location
                    };
                    _flowerLookup.Add(flower, flowerControl);
                    _fieldForm.Controls.Add(flowerControl);
                }
            }

            foreach (Flower flower in _flowerLookup.Keys)
            {
                if (!_world.Flowers.Contains(flower))
                {
                    PictureBox flowerControlToRemove = _flowerLookup[flower];
                    _fieldForm.Controls.Remove(flowerControlToRemove);
                    flowerControlToRemove.Dispose();
                    _deadFlowers.Add(flower);
                }
            }
        }

        private void DrawBees()
        {
            BeeControl beeControl;

            foreach (Bee bee in _world.Bees)
            {
                beeControl = GetBeeControl(bee);
                if (bee.InsideHive)
                {
                    if (_fieldForm.Controls.Contains(beeControl))
                    {
                        MoveBeeFromFieldToHive(beeControl);
                    }
                }
                else if (_hiveForm.Controls.Contains(beeControl))
                {
                    MoveBeeFromHiveToField(beeControl, bee);
                }
                beeControl.Location = bee.Location;
            }

            foreach (Bee bee in _beeLockup.Keys)
            {
                if (!_world.Bees.Contains(bee))
                {
                    beeControl = _beeLockup[bee];
                    if (_fieldForm.Controls.Contains(beeControl))
                    {
                        _fieldForm.Controls.Remove(beeControl);
                    }
                    if (_hiveForm.Controls.Contains(beeControl))
                    {
                        _hiveForm.Controls.Remove(beeControl);
                    }
                    beeControl.Dispose();
                    _retiredBees.Add(bee);
                }
            }
        }

        private BeeControl GetBeeControl(Bee bee)
        {
            BeeControl beeControl;
            if (!_beeLockup.ContainsKey(bee))
            {
                beeControl = new BeeControl() { Width = 40, Height = 40 };
                _beeLockup.Add(bee, beeControl);
                _hiveForm.Controls.Add(beeControl);
                beeControl.BringToFront();
            }
            else
            {
                beeControl = _beeLockup[bee];
            }
            return beeControl;
        }

        private void MoveBeeFromHiveToField(BeeControl beeControl, Bee bee)
        {
            _hiveForm.Controls.Remove(beeControl);
            beeControl.Size = new Size(40, 40);
            _fieldForm.Controls.Add(beeControl);
            beeControl.BringToFront();
        }

        private void MoveBeeFromFieldToHive(BeeControl beeControl)
        {
            _fieldForm.Controls.Remove(beeControl);
            beeControl.Size = new Size(40, 40);
            _hiveForm.Controls.Add(beeControl);
            beeControl.BringToFront();
        }

        private void RemoveRetiredBeesAndFlowers()
        {
            foreach (Bee bee in _retiredBees)
            {
                _beeLockup.Remove(bee);
            }
            _retiredBees.Clear();
            foreach (Flower flower in _deadFlowers)
            {
                _flowerLookup.Remove(flower);
            }
            _deadFlowers.Clear();
        }
    }
}