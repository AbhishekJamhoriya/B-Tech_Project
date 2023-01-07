using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    bool isOn=false;
   [SerializeField] GameObject LFTPanel;
   public void togglePanel()
   {
    if(isOn){
        LFTPanel.SetActive(false);
        isOn=false;
    }
    else{
        LFTPanel.SetActive(true);
        isOn=true; 
    }

   }
}
