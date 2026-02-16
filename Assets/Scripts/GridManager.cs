using UnityEngine;
using System.Collections.Generic;

public class GridManager : MonoBehaviour
{
    private PathGenerator pathGenerator;
    public int gridWidth = 16;
    public int gridHeight = 8;

    public GameObject pathTile;

    void Start()
    {
        pathGenerator = new PathGenerator(gridWidth, gridHeight);
        List<Vector2Int> pathCells = pathGenerator.GeneratePath();

        foreach (Vector2Int pathCell in pathCells)
        {
            Instantiate(pathTile, new Vector3(pathCell.x, 0f, pathCell.y), Quaternion.identity);
        }
    }
}
