using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorIsLavaEasterEgg : MonoBehaviour
{
    [SerializeField]private GameObject lava;

    [SerializeField]private GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        lava.SetActive(false);
        UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        lava.SetActive(true);
        UI.SetActive(true);
    }
}
