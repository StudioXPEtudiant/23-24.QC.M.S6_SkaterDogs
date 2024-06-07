using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatPointsFunction : MonoBehaviour
{
    public LevelFunction script;
    public GameObject catToDisable;
    [SerializeField] private int beatenPoints;
    [ContextMenu("Die")]
    private void Die ()
    { 
        script.points = script.points+ beatenPoints;
        catToDisable.SetActive(false);
    }
}