using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallAction : MonoBehaviour
{   
    public Material[] materials;
    public Renderer Rend;

    private int index = 1;

    public void leftButtonPressed(){
        if(materials.Length == 0)
            return;

        index -= 1;
        if(index == 0)
            index = materials.Length;

        print(index);

        Rend.sharedMaterial = materials[index - 1];
    }

    public void rightButtonPressed(){
        if(materials.Length == 0)
            return;

        index += 1;
        if(index == materials.Length + 1)
            index = 1;

        print(index);

        Rend.sharedMaterial = materials[index - 1];
    }
}
