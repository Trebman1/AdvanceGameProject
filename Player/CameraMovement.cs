using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform camTarget;
    public float pLerp;
    public float rLerp;
    public float timeWait;

    void Start(){
        pLerp = .02f;
        rLerp = .01f;
        Invoke("ChangeLerps", timeWait);
    }
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, camTarget.position, pLerp);
        transform.rotation = Quaternion.Lerp(transform.rotation, camTarget.rotation, rLerp);
    }

    public void ChangeLerps(){
        pLerp = .4f;
        rLerp = .25f;
    }
}
