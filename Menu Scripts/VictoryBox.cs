using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryBox : MonoBehaviour
{
    public void OnTriggerEnter(Collider other){
        if(other.CompareTag("PSword")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
