namespace RobotInAGrid
{
    public class Solution
    {
        public List<Point> GetPath(int[,] grid)
        {
            List<Point> offLimitPoints = new List<Point>();
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == 1)
                    {
                        offLimitPoints.Add(new Point(i, j));
                    }
                }
            }

            List<Point> pathWayPoints = new List<Point>();
            if (ValidPath(grid, grid.GetLength(0) - 1, grid.GetLength(1) - 1, pathWayPoints, offLimitPoints))
            {
                return pathWayPoints;
            }

            throw new Exception("No solution for this grid!");
        }

        protected Boolean ValidPath(int[,] grid, int row, int col, List<Point> pathWayPoints, List<Point> offLimitPoints)
        {
            if (row == 0 && col == 0)
            {
                pathWayPoints.Add(new Point(row, col));
                return true;
            }

            if (row < grid.GetLength(0) && col < grid.GetLength(1) && row >= 0 && col >= 0)
            {
                if (!IsContain(offLimitPoints, row, col))
                {
                    if (ValidPath(grid, row - 1, col, pathWayPoints, offLimitPoints))
                    {
                        pathWayPoints.Add(new Point(row, col));
                        return true;
                    }
                    else if (ValidPath(grid, row, col - 1, pathWayPoints, offLimitPoints))
                    {
                        pathWayPoints.Add(new Point(row, col));
                        return true;
                    }
                }
                offLimitPoints.Add(new Point(row, col));

            }

            return false;
        }

        protected Boolean IsContain(List<Point> checkList, int row, int col)
        {
            foreach (var item in checkList)
            {
                if (item.Row == row && item.Col == col)
                {
                    return true;
                }
            }

            return false;
        }
    }

    public class Point
    {
        public Point(int row, int col)
        {
            Row = row;
            Col = col;
        }
        public int Row { get; set; }
        public int Col { get; set; }

        public override string ToString()
        {
            return $"({Row},{Col})";
        }
    }
}