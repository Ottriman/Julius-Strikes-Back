using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class opening_navigation : MonoBehaviour {

    private int slide_id;

    // Use this for initialization
	void Start () {
        slide_id = 0;
	}

    public void next_scene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("x"))
        {
            next_scene();
        }
        /*else if (Input.GetKey("c"))
        {
            
            //Things
        }*/
    }
}
