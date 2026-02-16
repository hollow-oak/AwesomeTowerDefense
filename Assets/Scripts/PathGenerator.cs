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

        int y = (int)(height / 2);

        for (int x = 0; x < width; x++)
        {
            pathCells.Add(new Vector2Int(x, y));
        }

        return pathCells;
    }
}
