using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilRoosterScript : MonoBehaviour
{
    public GameObject Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Target != true)
        {
            GetComponent<BoxCollider>().enabled = true;
            Debug.Log("Game Over! The Rooster got you!");
        }
        else
        {
            GetComponent<BoxCollider>().enabled = false;
        }
    }

}
// Failed, tried to make it so that it would only detect collision with the player and log game over and ignore everything else, but wah wah