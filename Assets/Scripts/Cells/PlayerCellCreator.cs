using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCellCreator : CellCreator
{
    private List<PlayerCell> _creationCells = new List<PlayerCell>();

    private PlayerCell CreatePlayerCell()
    {
        var spawnPos = Vector3.one;
        var playerCell = Instantiate(new GameObject("Player Cell"), spawnPos, Quaternion.identity).AddComponent<PlayerCell>();

        return playerCell;
    }

    private PlayerCell CreatePlayerCellAt(Vector3 pos)
    {
        var playerCell = Instantiate(new GameObject("Player Cell"), pos, Quaternion.identity).AddComponent<PlayerCell>();
        
        return playerCell;
    }

    public override Cell CreateCell()
    {
        var cell = CreatePlayerCell();
        _creationCells.Add(cell);

        return cell;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override Cell CreateCellAt(Vector3 spawnPos)
    {
        var cell = CreatePlayerCellAt(spawnPos);
        _creationCells.Add(cell);

        return cell;
    }
}

