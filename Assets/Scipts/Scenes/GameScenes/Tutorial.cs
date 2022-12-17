using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Tutorial:GameScene
{
    public IEnumerator deleay()
    {
        yield return new WaitForSeconds(5.1f);
        SceneLoader.LoadScene("TestScene");
    }

    public override void Start()
    {
        Name = "Tutorial";
     ;
    }

    public override void Update()
    {
        
    }
}
