using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JigsawPuzzle
{
    public class Piece
    {
        public Puzzle ParentPuzzle;
        List<Edge> Edges;
        public double Rotation;
        public Rectangle Size;
    }
}
