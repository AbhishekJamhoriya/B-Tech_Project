using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model_color_change : MonoBehaviour
{
    public Color[] colors;
    public Renderer mats;

    public void Acute(){
        mats.material.color=colors[0];
    }
    public void Chronic(){
        mats.material.color=colors[1];
    }
    public void Alcoholic(){
        mats.material.color=colors[2];
    }
    public void Cirrhosis(){
        mats.material.color=colors[3];
    }
    public void Bile_duct(){
        mats.material.color=colors[4];
    }
    public void Cancer(){
        mats.material.color=colors[5];
    }
    public void Autoimmune(){
        mats.material.color=colors[6];
    }

}
