using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public static event System.Action<Ray, RaycastHit2D> LeftClicked;
    public static event System.Action<Ray, RaycastHit2D> RightClicked;
}
