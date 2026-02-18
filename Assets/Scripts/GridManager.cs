using UnityEngine;
using System.Collections.Generic;
using System.Collections;

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

        StartCoroutine(LayPathCells(pathCells));
    }

    private IEnumerator LayPathCells(List<Vector2Int> pathCells)
    {
        foreach (Vector2Int pathCell in pathCells)
        {
            Instantiate(pathTile, new Vector3(pathCell.x, 0f, pathCell.y), Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
        }

        yield return null;
    }
}
