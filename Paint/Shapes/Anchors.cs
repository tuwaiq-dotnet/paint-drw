using System;
using System.Drawing;

namespace Paint.Shapes
{
    public class Anchors
    {
        private Rectangle[] anchors;

        public Anchors(int anchorsCount)
        {
            if (anchorsCount == 2)
                anchors = new Rectangle[2];
            else if (anchorsCount == 8)
                anchors = new Rectangle[8];
            else throw new Exception($"Unaccepted number anchors: anchors can be either 2 or 8, not {anchorsCount}");
            for (int i = 0; i < anchors.Length; i++)
                anchors[i] = new Rectangle();
        }
        public AnchorDirection OnAnchor(Point p)
        {
            if (anchors.Length == 2)
                if (anchors[(int)AnchorDirection.Start].Contains(p)) return AnchorDirection.Start;
                else if (anchors[(int)AnchorDirection.End].Contains(p)) return AnchorDirection.End;
                else return AnchorDirection.None;

            if (anchors[(int)AnchorDirection.North].Contains(p)) return AnchorDirection.North;
            else if (anchors[(int)AnchorDirection.NorthEast].Contains(p)) return AnchorDirection.NorthEast;
            else if (anchors[(int)AnchorDirection.East].Contains(p)) return AnchorDirection.East;
            else if (anchors[(int)AnchorDirection.SouthEast].Contains(p)) return AnchorDirection.SouthEast;
            else if (anchors[(int)AnchorDirection.South].Contains(p)) return AnchorDirection.South;
            else if (anchors[(int)AnchorDirection.SouthWest].Contains(p)) return AnchorDirection.SouthWest;
            else if (anchors[(int)AnchorDirection.West].Contains(p)) return AnchorDirection.West;
            else if (anchors[(int)AnchorDirection.NorthWest].Contains(p)) return AnchorDirection.NorthWest;
            else return AnchorDirection.None;
        }
        public void Draw(Point Start, Point End, Graphics g)
        {
            UpdateAnchors(Start, End);
            foreach (var anchor in anchors)
            {
                g.FillRectangle(new SolidBrush(Settings.GetInstance().AnchorColor), anchor);
            }
        }
        private void UpdateAnchors(Point start, Point end)
        {
            if (anchors.Length == 2) Update2Anchors(start, end);
            else Update8Anchors(start, end);
        }
        private void Update2Anchors(Point start, Point end)
        {
            int AS = Settings.GetInstance().AnchorSize;
            int HAS = Settings.GetInstance().AnchorSize / 2;
            anchors[(int)AnchorDirection.Start] = new Rectangle(start.X - HAS, start.Y - HAS, AS, AS);
            anchors[(int)AnchorDirection.End] = new Rectangle(end.X - HAS, end.Y - HAS, AS, AS);
        }
        private void Update8Anchors(Point S, Point E)
        {
            int BO = Settings.GetInstance().BorderOffset;
            int AS = Settings.GetInstance().AnchorSize;
            int HAS = Settings.GetInstance().AnchorSize / 2; // Half-Anchor Size
            anchors[(int)AnchorDirection.North] = new Rectangle(S.X + (E.X - S.X) / 2 - HAS, S.Y - HAS - BO, AS, AS);
            anchors[(int)AnchorDirection.NorthEast] = new Rectangle(E.X - HAS + BO, S.Y - HAS - BO, AS, AS);
            anchors[(int)AnchorDirection.East] = new Rectangle(E.X - HAS + BO, S.Y + (E.Y - S.Y) / 2 - HAS, AS, AS);
            anchors[(int)AnchorDirection.SouthEast] = new Rectangle(E.X - HAS + BO, E.Y - HAS + BO, AS, AS);
            anchors[(int)AnchorDirection.South] = new Rectangle(S.X + (E.X - S.X) / 2 - HAS, E.Y - HAS + BO, AS, AS);
            anchors[(int)AnchorDirection.SouthWest] = new Rectangle(S.X - HAS - BO, E.Y - HAS + BO, AS, AS);
            anchors[(int)AnchorDirection.West] = new Rectangle(S.X - HAS - BO, S.Y + (E.Y - S.Y) / 2 - HAS, AS, AS);
            anchors[(int)AnchorDirection.NorthWest] = new Rectangle(S.X - HAS - BO, S.Y - HAS - BO, AS, AS);
        }
    }

    public enum AnchorDirection
    {
        None = -1,

        // In case there were eight anchors
        North,
        NorthEast,
        East,
        SouthEast,
        South,
        SouthWest,
        West,
        NorthWest,

        // In case there were two anchors only
        Start = 0,
        End,

    }
}