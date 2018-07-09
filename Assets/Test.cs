using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    // Use this for initialization
    void Start() {

        int[] points = new int[5];

        points[0] = 5;
        points[1] = 10;
        points[2] = 15;
        points[3] = 20;
        points[4] = 25;


        for (int T = 0; T <= 4; T++) {
            Debug.Log(points[T]);
        }

        for (int i = 4; i >= 0; i--) {                     
            Debug.Log(points[i]);

        }
        

       
    }


    // Update is called once per frame
    void Update() {

    }
}