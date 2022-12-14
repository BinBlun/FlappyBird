using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Number : MonoBehaviour
{
    public static int number = 0;
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        number = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = number.ToString();
        if (Input.GetMouseButtonDown(0))
            number++;
    }
}
