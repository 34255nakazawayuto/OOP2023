using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System. Windows.Media;


namespace VisibilityConverter {
    public class ColorViewModel {
        private static IList<ColorViewModel> colors = new List<ColorViewModel> {

            new ColorViewModel { Name = "赤", Color = Colors.Red },
            new ColorViewModel { Name = "黄", Color = Colors.Yellow },
            new ColorViewModel { Name = "青", Color = Colors.Blue }
        };
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
