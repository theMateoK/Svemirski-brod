using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Semafor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text myText = GetComponent<Text>();
        myText.text = PrikazRezultata.rezultat.ToString();
        PrikazRezultata.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
