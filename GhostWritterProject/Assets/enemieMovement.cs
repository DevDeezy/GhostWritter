using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemieMovement : MonoBehaviour
{
    Vector3 tempPos;
    public GameObject enemy;
    public Text heroLife;
    public int life = 100;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        heroLife.text = "HP: " + life;
        tempPos = transform.position;
        tempPos.x -= 0.25f;
        transform.position = tempPos;
        GameObject jogador = GameObject.FindGameObjectWithTag("Player");

        if (transform.position == jogador.transform.position)
        {
            life -= 50;
            heroLife.text = "HP: " + life;
            enemy.SetActive(false);
        }
    }
}
