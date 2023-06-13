using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Cevap : MonoBehaviour
{
   

    public GameObject image;
    public Button button;

    void Start()
    {

        button.onClick.AddListener(() => {
            if (image.active == true)
            {
              image.active = false;
            }
            else if(image.active == false)
            {
                image.active = true;
            }
            ;
            
        });
       
    }


}
