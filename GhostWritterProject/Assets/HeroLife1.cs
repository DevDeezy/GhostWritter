using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        vidas -= 0;
        vidaLabel.text = "HP: " + vidas;
        if (vidas <= 0)
            SceneManager.LoadScene(4);
    }
}
