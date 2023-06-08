using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroLife : MonoBehaviour
{
    Vector3 tempPos;
    public GameObject enemy;
    public GameObject hero;
    public GameObject label;
    public Text heroLife;
    public int life;
    public int damagePerEnemie;

    // Start is called before the first frame update
    void Start()
    {
        life = 100;
        damagePerEnemie = 50;
        heroLife.text = "HP: " + life;
    }

    // Update is called once per frame
    void Update() { }

    public void PerderVida()
    {
        if (life >= damagePerEnemie)
        {
            life = life - 50;
        }
        if (life <= damagePerEnemie)
        {
            label.GetComponent<Text>().text = "<color=red> Derrota! Morreu </color>";
        }
        heroLife.text = "HP: " + life;
        enemy.SetActive(false);
    }
}
