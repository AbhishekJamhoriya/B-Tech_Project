using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class model_orientation : MonoBehaviour
{
    
    public Vector3 rot;
    void Update(){
       
            transform.Rotate(rot*Time.deltaTime);
        
    }
}
