
using System.Collections;
using UnityEngine;

public class CatPointsFunction : MonoBehaviour
{
    public LevelFunction script;
    public GameObject catToDisable;
    [SerializeField] private int beatenPoints;
    [ContextMenu("Die")]
    public void Die ()
    { 
        script.points = script.points+ beatenPoints;
        
        
        transform.Rotate(-180, 0, 0);
        StartCoroutine(N());
        
    }

    IEnumerator N()
    {
        yield return new WaitForSeconds(0.6f);
        catToDisable.SetActive(false);
    }
}