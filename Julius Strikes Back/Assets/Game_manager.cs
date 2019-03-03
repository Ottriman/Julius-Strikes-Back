using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_manager : MonoBehaviour {

    public GameObject save1;
    public GameObject save2;
    public GameObject save3;
    public GameObject save4;

    private void Awake()
    {
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
		
	}
}
