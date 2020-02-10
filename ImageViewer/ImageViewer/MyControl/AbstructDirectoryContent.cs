using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ImageViewer
{
    interface IDirectoryContent
    {
        void ContentSelect();
        void SetFont(Font font);
    }
}
