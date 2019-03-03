using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_manager : MonoBehaviour {
 
    public GameObject InGameMenu;
    public GameObject save1;
    public GameObject save2;
    public GameObject save3;
    public GameObject save4;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        DontDestroyOnLoad(this.InGameMenu);
        DontDestroyOnLoad(this.save1);
        DontDestroyOnLoad(this.save2);
        DontDestroyOnLoad(this.save3);
        DontDestroyOnLoad(this.save4);
    }

    // Use this for initialization
    void Start () {
		
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyUp("escape") && InGameMenu.activeSelf == false)
        {
            InGameMenu.SetActive(true);
        }
        else if (Input.GetKeyUp("escape") && InGameMenu.activeSelf == true)
        {
            InGameMenu.SetActive(false);
        }
		
	}
}
