using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroLife1 : MonoBehaviour
{
    public Text vidaLabel;
    public int vidas;

    // Start is called before the first frame update
    void Start()
    {
        vidas = 100;
    }

    // Update is called once per frame
    void Update() { }

    public void Vida()
    {
        vidas -= 50;
        vidaLabel.text = "HP: " + vidas;
    }
}
