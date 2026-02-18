using UnityEngine;
using System.Collections.Generic;

public class PathGenerator : MonoBehaviour
{
    private int height, width;
    private List<Vector2Int> pathCells;

    public PathGenerator(int height, int width)
    {
        this.height = height;
        this.width = width;
    }

    public List<Vector2Int> GeneratePath()
    {
        pathCells = new List<Vector2Int>();
        int x = 0;
        int y = (int)(height / 2);

        /*
        for (int x = 0; x < width; x++)
        {
            pathCells.Add(new Vector2Int(x, y));
        }
        */

        while (x < width)
        {
            pathCells.Add(new Vector2Int(x, y));

            bool validMove = false;

            while (!validMove)
            {
                int move = Random.Range(0, pathCells.Count);

                if (move == 0 || x % 2 == 0)
                {
                    x++;
                    validMove = true;
                }
                else if (move == 1 && CellIsFree(x, y + 1) && y < (height - 3))
                {
                    y++;
                    validMove = true;
                }
                else if (move == 2 && CellIsFree(x, y -1) && y > 2)
                {
                    y--;
                    validMove = true;
                }
            }
        }

        return pathCells;
    }

    private bool CellIsFree(int x, int y)
    {
        return !pathCells.Contains(new Vector2Int(x, y));
    }
}
