using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hbs : MonoBehaviour
{
    public UnityEngine.UI.Image P1image;
    public UnityEngine.UI.Image P2image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        P1image.fillAmount = SaveScript.p1h;
        P2image.fillAmount = SaveScript.p2h;

    }
}
