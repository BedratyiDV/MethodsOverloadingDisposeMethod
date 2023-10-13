using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedParking
{
    public struct Color
    {
        private int _red;
        private int _green;
        private int _blue;
        private int _opacity;

        /// <summary>
        /// Contains  a red color component
        /// </summary>
        public int Red
        {
            get => _red;
            set => _red = value < 256 && value > 0 ? value : 0;
        }

        /// <summary>
        /// Contains  a green color component
        /// </summary>
        public int Green
        {
            get => _green;
            set => _green = value < 256 && value > 0 ? value : 0;
        }
        /// <summary>
        /// Contains  a blue color component
        /// </summary>
        public int Blue
        {
            get => _blue;
            set => _blue = value < 256 && value > 0 ? value : 0;
        }
        /// <summary>
        /// Contains color opacity
        /// </summary>
        public int Opacity
        {
            get => _opacity;
            set => _opacity = value < 101 && value > 0 ? value : 0;
        }
        /// <summary>
        /// Constructor for R-G-B color components and color opacity
        /// </summary>
        /// <param name="red">   </param>
        /// <param name="green"> </param>
        /// <param name="blue">  </param>
        /// <param name="opacity"> </param>

        public Color (int red, int green, int blue, int opacity)
        {
            _red = red < 256 && red > 0 ? red : 0;
            _green = green < 256 && green > 0 ? green : 0;
            _blue = blue < 256 && blue > 0 ? blue : 0;
            _opacity = opacity < 101 && opacity > 0 ? opacity : 0;
        }
        /// <summary>
        /// Constructor for R-G-B color components having default opacity equal 100
        /// </summary>
        public Color(int red, int green, int blue)
        {
            _red = red < 256 && red > 0 ? red : 0;
            _green = green < 256 && green > 0 ? green : 0;
            _blue = blue < 256 && blue > 0 ? blue : 0;
            _opacity = 100;
        }
        /// <summary>
        /// Constructor for R-G-B color components having default value equal 255 for each component
        /// </summary>
        public Color(int opacity)
        {
            _red = 255;
            _green = 255;
            _blue = 255;
            _opacity = opacity < 101 && opacity > 0 ? opacity : 0;
        }
    }

}
