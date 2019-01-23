using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class opening_navigation : MonoBehaviour {

    static int size = 5;
    public GameObject[] slides;
    public int slide_id;

    // Use this for initialization
    void Start () {
        slide_id = 0;
        slides = new GameObject[size];
        for (int i = 0; i < size; i++)
        {
            slides[i] = GameObject.FindWithTag("cutscene_slide");
        }
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
        if(Input.GetMouseButtonDown(0) && slide_id < size)
        {
            slides[slide_id].SetActive(false);
            slides[slide_id+1].SetActive(true);
            slide_id++;
        }
        else if(Input.GetMouseButtonDown(0) && slide_id >= size)
        {
            next_scene();
        }
    }
}
