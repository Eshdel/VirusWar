using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour
{
    public static UnityEvent<EnemyCell> OnClickEnemyCell;
    public static UnityEvent<PlayerCell> OnClickPlayerCell;

    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit raycastHit;

            if(Physics.Raycast(ray,out raycastHit))
            {
                var target = raycastHit.collider.transform.gameObject;
                var cell = target.GetComponent<Cell>();

                switch (cell) {
                    case EnemyCell: {
                        Debug.Log(" Enemy Hit");
                        OnClickEnemyCell.Invoke(cell as EnemyCell);
                        break;
                    }

                    case PlayerCell: { 
                        Debug.Log("Player Hit"); 
                        OnClickPlayerCell.Invoke(cell as PlayerCell);
                        break;
                    }

                    default: { 
                        break;
                    }
                }    
            }
        }
    }
}
