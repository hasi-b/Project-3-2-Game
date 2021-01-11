using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    int i=0;
   public GameObject tex;
    TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = tex.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        
        Debug.Log("score"+ i);
        text.SetText((i/100).ToString()); 

    }
}
