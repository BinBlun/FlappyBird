using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMoon : MonoBehaviour
{
    public Sprite image1;
    public Sprite image2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Number.number % 2 == 0)
        {
            GetComponent<UnityEngine.UI.Image>().sprite = image1;
        }
        else
        {
            GetComponent<UnityEngine.UI.Image>().sprite = image2;
        }
    }
}
