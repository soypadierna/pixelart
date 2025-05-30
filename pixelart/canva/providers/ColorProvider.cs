using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pixelart.canva.providers
{
    public class ColorProvider
    {
        private static readonly Lazy<ColorProvider> _instance = new Lazy<ColorProvider>(() => new ColorProvider());

        public static ColorProvider Instance => _instance.Value;

        public Color SelectedColor { get; private set; } = Color.Empty;

        public event Action<Color> OnColorChanged;

        private ColorProvider() { }

        public void SetColor(Color color)
        {
            SelectedColor = color;
            OnColorChanged?.Invoke(color);
        }
    }

}
