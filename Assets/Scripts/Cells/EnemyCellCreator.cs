using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCellCreator : CellCreator
{
    private List<EnemyCell> _creationCells = new List<EnemyCell>();

    private EnemyCell CreateEnemyCell() {

        var spawnPos = Vector3.one;

        var enemyCell = Instantiate(new GameObject("Enemy Cell"), spawnPos, Quaternion.identity).AddComponent<EnemyCell>();

        return enemyCell;
    }


    private EnemyCell CreateEnemyCellAt(Vector3 spawnPos)
    {
        var enemyCell = Instantiate(new GameObject("Enemy Cell"), spawnPos, Quaternion.identity).AddComponent<EnemyCell>();
       
        return enemyCell;
    }

    public override Cell CreateCell()
    {
        var cell = CreateEnemyCell();
        _creationCells.Add(cell);

        return cell;
    }

    public override Cell CreateCellAt(Vector3 spawnPos)
    {
        var cell = CreateEnemyCellAt(spawnPos);
        _creationCells.Add(cell);

        return cell;
    }
}
