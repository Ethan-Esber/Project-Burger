
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NewGameButtonScript : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){
    }
    // Update is called once per frame
    void OnMouseDown(){

            SceneManager.LoadScene("Level1");
    }
}
