using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStop : MonoBehaviour
{
    bool pause = false;

    void Update()
    {
        if( Input.GetKeyDown(KeyCode.P)){
            if( pause == false ){
                Time.timeScale = 0;
                pause = true;
            } else if( pause == true ){
                Time.timeScale = 1;
                pause = false;
            }
        }
    }
}
