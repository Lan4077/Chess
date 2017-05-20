using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class set_point
    {
        public Point[,,] setpnt(Point[,,] cletochki)
        {
            cletochki[0, 0, 0] = new Point(32, 32);   cletochki[0, 1, 0] = new Point(32, 104);
            cletochki[0, 0, 1] = new Point(102, 102); cletochki[0, 1, 1] = new Point(102, 174);
            cletochki[1, 0, 0] = new Point(104, 32);  cletochki[1, 1, 0] = new Point(104, 104);
            cletochki[1, 0, 1] = new Point(174, 102); cletochki[1, 1, 1] = new Point(174, 174);
            cletochki[2, 0, 0] = new Point(176, 32);  cletochki[2, 1, 0] = new Point(176, 104);
            cletochki[2, 0, 1] = new Point(246, 102); cletochki[2, 1, 1] = new Point(246, 174);
            cletochki[3, 0, 0] = new Point(248, 32);  cletochki[3, 1, 0] = new Point(248, 104);
            cletochki[3, 0, 1] = new Point(319, 102); cletochki[3, 1, 1] = new Point(319, 174);
            cletochki[4, 0, 0] = new Point(321, 32);  cletochki[4, 1, 0] = new Point(321, 104);
            cletochki[4, 0, 1] = new Point(391, 102); cletochki[4, 1, 1] = new Point(391, 174);
            cletochki[5, 0, 0] = new Point(393, 32);  cletochki[5, 1, 0] = new Point(393, 104);
            cletochki[5, 0, 1] = new Point(463, 102); cletochki[5, 1, 1] = new Point(463, 174);
            cletochki[6, 0, 0] = new Point(465, 32);  cletochki[6, 1, 0] = new Point(465, 104);
            cletochki[6, 0, 1] = new Point(535, 102); cletochki[6, 1, 1] = new Point(535, 174);
            cletochki[7, 0, 0] = new Point(537, 32);  cletochki[7, 1, 0] = new Point(537, 104);
            cletochki[7, 0, 1] = new Point(607, 102); cletochki[7, 1, 1] = new Point(607, 174);

            cletochki[0, 2, 0] = new Point(32, 176); cletochki[0, 3, 0] = new Point(32, 248);
            cletochki[0, 2, 1] = new Point(102, 246); cletochki[0, 3, 1] = new Point(102, 319);
            cletochki[1, 2, 0] = new Point(104, 176); cletochki[1, 3, 0] = new Point(104, 248);
            cletochki[1, 2, 1] = new Point(174, 246); cletochki[1, 3, 1] = new Point(174, 319);
            cletochki[2, 2, 0] = new Point(176, 176); cletochki[2, 3, 0] = new Point(176, 248);
            cletochki[2, 2, 1] = new Point(246, 246); cletochki[2, 3, 1] = new Point(246, 319);
            cletochki[3, 2, 0] = new Point(248, 176); cletochki[3, 3, 0] = new Point(248, 248);
            cletochki[3, 2, 1] = new Point(319, 246); cletochki[3, 3, 1] = new Point(319, 319);
            cletochki[4, 2, 0] = new Point(321, 176); cletochki[4, 3, 0] = new Point(321, 248);
            cletochki[4, 2, 1] = new Point(391, 246); cletochki[4, 3, 1] = new Point(391, 319);
            cletochki[5, 2, 0] = new Point(393, 176); cletochki[5, 3, 0] = new Point(393, 248);
            cletochki[5, 2, 1] = new Point(463, 246); cletochki[5, 3, 1] = new Point(463, 319);
            cletochki[6, 2, 0] = new Point(465, 176); cletochki[6, 3, 0] = new Point(465, 248);
            cletochki[6, 2, 1] = new Point(535, 246); cletochki[6, 3, 1] = new Point(535, 319);
            cletochki[7, 2, 0] = new Point(537, 176); cletochki[7, 3, 0] = new Point(537, 248);
            cletochki[7, 2, 1] = new Point(607, 246); cletochki[7, 3, 1] = new Point(607, 319);

            cletochki[0, 4, 0] = new Point(32, 321); cletochki[0, 5, 0] = new Point(32, 393);
            cletochki[0, 4, 1] = new Point(102, 391); cletochki[0, 5, 1] = new Point(102, 463);
            cletochki[1, 4, 0] = new Point(104, 321); cletochki[1, 5, 0] = new Point(104, 393);
            cletochki[1, 4, 1] = new Point(174, 391); cletochki[1, 5, 1] = new Point(174, 463);
            cletochki[2, 4, 0] = new Point(176, 321); cletochki[2, 5, 0] = new Point(176, 393);
            cletochki[2, 4, 1] = new Point(246, 391); cletochki[2, 5, 1] = new Point(246, 463);
            cletochki[3, 4, 0] = new Point(248, 321); cletochki[3, 5, 0] = new Point(248, 393);
            cletochki[3, 4, 1] = new Point(319, 391); cletochki[3, 5, 1] = new Point(319, 463);
            cletochki[4, 4, 0] = new Point(321, 321); cletochki[4, 5, 0] = new Point(321, 393);
            cletochki[4, 4, 1] = new Point(391, 391); cletochki[4, 5, 1] = new Point(391, 463);
            cletochki[5, 4, 0] = new Point(393, 321); cletochki[5, 5, 0] = new Point(393, 393);
            cletochki[5, 4, 1] = new Point(463, 391); cletochki[5, 5, 1] = new Point(463, 463);
            cletochki[6, 4, 0] = new Point(465, 321); cletochki[6, 5, 0] = new Point(465, 393);
            cletochki[6, 4, 1] = new Point(535, 391); cletochki[6, 5, 1] = new Point(535, 463);
            cletochki[7, 4, 0] = new Point(537, 321); cletochki[7, 5, 0] = new Point(537, 393);
            cletochki[7, 4, 1] = new Point(607, 391); cletochki[7, 5, 1] = new Point(607, 463);

            cletochki[0, 6, 0] = new Point(32, 465); cletochki[0, 7, 0] = new Point(32, 537);
            cletochki[0, 6, 1] = new Point(102, 535); cletochki[0, 7, 1] = new Point(102, 607);
            cletochki[1, 6, 0] = new Point(104, 465); cletochki[1, 7, 0] = new Point(104, 537);
            cletochki[1, 6, 1] = new Point(174, 535); cletochki[1, 7, 1] = new Point(174, 607);
            cletochki[2, 6, 0] = new Point(176, 465); cletochki[2, 7, 0] = new Point(176, 537);
            cletochki[2, 6, 1] = new Point(246, 535); cletochki[2, 7, 1] = new Point(246, 607);
            cletochki[3, 6, 0] = new Point(248, 465); cletochki[3, 7, 0] = new Point(248, 537);
            cletochki[3, 6, 1] = new Point(319, 535); cletochki[3, 7, 1] = new Point(319, 607);
            cletochki[4, 6, 0] = new Point(321, 465); cletochki[4, 7, 0] = new Point(321, 537);
            cletochki[4, 6, 1] = new Point(391, 535); cletochki[4, 7, 1] = new Point(391, 607);
            cletochki[5, 6, 0] = new Point(393, 465); cletochki[5, 7, 0] = new Point(393, 537);
            cletochki[5, 6, 1] = new Point(463, 535); cletochki[5, 7, 1] = new Point(463, 607);
            cletochki[6, 6, 0] = new Point(465, 465); cletochki[6, 7, 0] = new Point(465, 537);
            cletochki[6, 6, 1] = new Point(535, 535); cletochki[6, 7, 1] = new Point(535, 607);
            cletochki[7, 6, 0] = new Point(537, 465); cletochki[7, 7, 0] = new Point(537, 537);
            cletochki[7, 6, 1] = new Point(607, 535); cletochki[7, 7, 1] = new Point(607, 607);
            return cletochki;
        }
    }
}
