using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cell : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private int dnaCapacity;
    [SerializeField] private float reproductionSpeed;
}
