using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tutorial:GameScene
{
    [SerializeField] CellCreator _enemyCellCreator;
    [SerializeField] CellCreator _playerCellCreator;

    public IEnumerator deleay()
    {
        yield return new WaitForSeconds(5.1f);
        SceneLoader.LoadScene("TestScene");
    }

    public override void Start()
    {
        Name = "Tutorial";

        _enemyCellCreator.CreateCellAt(Vector3.zero);
        
        _enemyCellCreator.CreateCellAt(Vector3.one);

        _playerCellCreator.CreateCellAt(Vector3.down);

    }

    public override void Update()
    {
        
    }
}
