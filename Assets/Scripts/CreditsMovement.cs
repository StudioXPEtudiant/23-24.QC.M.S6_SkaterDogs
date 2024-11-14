using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsMovement : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        image.transform.position += Vector3.up * speed * Time.deltaTime;
    }
}
