using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckInput : MonoBehaviour
{
    public GameObject label;
    public GameObject hero;
    public GameObject enemy;
    public InputField input;
    public string[] letra;
    public string[] letraEcra;
    public float[] timings;
    public int contador = 0;
    public int tamanho = 0;
    public string text;
    public Text timerText;
    public Text combo;
    public Text heroLife;
    private float startTime;
    private int combocounter;
    public int spawnContador = 0;
    private Dictionary<int, GameObject> spawnedObjects = new Dictionary<int, GameObject>();
    public int id;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        tamanho = letra.Length;
        for (int i = 0; i < 5; i++)
        {
            text += letraEcra[i];
        }
        label.GetComponent<Text>().text = text;
        combo.text = null;
        heroLife.text = "HP: 100";
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        if (combocounter != 0)
        {
            combo.text = "Combo: " + combocounter;
        }
        else
        {
            combo.text = null;
        }

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        float segundos = (t % 60);
        timerText.text = minutes + ":" + seconds;

        if (t > (timings[spawnContador] - 1))
        {
            spawnEnemys();
            spawnContador++;
        }
        if (contador == tamanho)
        {
            label.GetComponent<Text>().text = "<color=green> Parabéns, nível finalizado! </color>";
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (t > timings[contador] - 1)
            {
                if (input.text.ToString() == letra[contador])
                {
                    if (spawnedObjects.ContainsKey(contador))
                    {
                        id = contador;
                        DestroyObject(id);
                    }
                    if (t > timings[contador] - 1 && t < timings[contador] + 1)
                    {
                        combocounter++;
                    }
                    else
                    {
                        combocounter = 0;
                    }
                    letraEcra[contador] = "<color=green>" + letra[contador] + "</color>";
                    text = "";
                    for (int i = contador; i < (contador + 5); i++)
                    {
                        text += letraEcra[i];
                    }
                    label.GetComponent<Text>().text = text;
                    contador += 1;
                    input.text = null;
                }
            }
            else
            {
                letraEcra[contador] = "<color=red>" + letra[contador] + "</color>";
                text = "";
                combocounter = 0;

                for (int i = contador; i < (contador + 5); i++)
                {
                    text += letraEcra[i];
                }
                label.GetComponent<Text>().text = text;

                input.text = null;
            }
        }
    }

    void spawnEnemys()
    {
        GameObject newEnemy = Instantiate(
            enemy,
            new Vector3(1721, 569, 0),
            enemy.transform.rotation
        );
        spawnedObjects.Add(spawnContador, newEnemy); // Usar o spawnContador como chave e o novo inimigo como valor
        newEnemy.transform.SetParent(transform);
    }

    public void DestroyObject(int id)
    {
        if (spawnedObjects.ContainsKey(id))
        {
            GameObject objectToDestroy = spawnedObjects[id];
            spawnedObjects.Remove(id);
            Destroy(objectToDestroy);
        }
    }

    public void Vida()
    {
        label.GetComponent<Text>().text = "<color=green> Parabéns, nível finalizado! </color>";
    }
}
