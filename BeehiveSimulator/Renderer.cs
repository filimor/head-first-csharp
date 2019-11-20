using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
