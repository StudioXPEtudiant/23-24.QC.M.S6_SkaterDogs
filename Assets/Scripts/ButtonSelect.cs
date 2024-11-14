
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ButtonSelect : MonoBehaviour
{ 
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject image;
   [SerializeField] public GameObject startButton1;
   [SerializeField] private GameObject creditsButton1;
   [SerializeField] public GameObject startButton2;
   [SerializeField] private GameObject creditsButton2;
   [SerializeField] public string startOrCredits;

   private QuitterCreditsButton quitter;
    // Start is called before the first frame update
    void Start()
    {
        player.SetActive(false);
        startOrCredits = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (startOrCredits == "") 
        {
            
            startButton1.SetActive(true); 
            startButton2.SetActive(false); 
           
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (startOrCredits == "start") 
            {
                image.SetActive(false); 
                startButton1.SetActive(false); 
                startButton2.SetActive(false); 
                creditsButton1.SetActive(false); 
                creditsButton2.SetActive(false);
                player.SetActive(true);

            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (startOrCredits == "credits") 
            {
                SceneManager.LoadScene(1);
            }
        }

        if (image.activeSelf)
        {
            
       
        if (Input.GetKeyDown(KeyCode.W))
        {
            startOrCredits = "start";
          
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            startOrCredits = "credits";
         
        }
        
        if (startOrCredits == "start")
        {
           startButton1.SetActive(false);
           startButton2.SetActive(true);
           creditsButton1.SetActive(true);
           creditsButton2.SetActive(false);
           
        }
        if (startOrCredits == "credits")
        {
            startButton1.SetActive(true);
            startButton2.SetActive(false);
            creditsButton1.SetActive(false);
            creditsButton2.SetActive(true);
        }
        }
    }
    
}
