
using UnityEngine;
using TMPro;

public class LevelFunction: MonoBehaviour
{
    [SerializeField]   private int pointsNeededToLevelUp;
   [SerializeField] public int points = 0;
   [SerializeField] public int level = 0; 
    public TMP_Text textNiveau;
    public TMP_Text textPoints;
    void Update()
    {
        textNiveau.SetText("Niveau: " + level);
        textPoints.SetText( points +"/" + pointsNeededToLevelUp + " points");
        
        if (points > pointsNeededToLevelUp - 1) 
        { 
            level = level + 1; 
            points = points - pointsNeededToLevelUp;
            pointsNeededToLevelUp = pointsNeededToLevelUp + 5; 
        }
    }
    
}