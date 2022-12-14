using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hbs3Player : MonoBehaviour
{
    public UnityEngine.UI.Image P1image;
    public UnityEngine.UI.Image P2image;
    public UnityEngine.UI.Image P3image;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        P1image.fillAmount = SaveScript3.p1h;
        P2image.fillAmount = SaveScript3.p2h;
        P3image.fillAmount = SaveScript3.p3h;

    }
}
