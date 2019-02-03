using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class opening_navigation : MonoBehaviour {

    static int size = 7;
    private GameObject[] slides;
    private int slide_id;

    public GameObject slide1;
    public GameObject slide2;
    public GameObject slide3;
    public GameObject slide4;
    public GameObject slide5;
    public GameObject slide6;
    public GameObject slide7;

    // Use this for initialization
    void Start () {
        slide_id = 0;
        slides = new GameObject[size];

        slides[0] = slide1;
        slides[1] = slide2;
        slides[2] = slide3;
        slides[3] = slide4;
        slides[4] = slide5;
        slides[5] = slide6;
        slides[6] = slide7;
    }

    public void next_scene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	
	// Update is called once per frame
	void Update () {
        
        if(Input.anyKeyDown && slide_id < size-1)
        {
            slides[slide_id].SetActive(false);
            slides[slide_id+1].SetActive(true);
            slide_id++;
        }
        else if(Input.anyKeyDown && slide_id >= size-1)
        {
            next_scene();
        }
    }
}
