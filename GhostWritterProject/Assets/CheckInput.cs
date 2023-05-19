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
    public string[] letra = {"Tequila ","Tequila ", "Tequila "};
    public string[] letraEcra = {"Tequila ","Tequila ", "Tequila "};
    public float[] timings = {52, 223, 345};
    public int contador = 0;
    public int tamanho = 0; 
    public string text;
    public Text timerText;
    public Text combo;
    private float startTime;
    private int combocounter;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        tamanho = letra.Length;
        for (int i = 0; i < tamanho; i++) {        
            text += letraEcra[i];
        }
        label.GetComponent<Text>().text = text;
        combo.text = null;

    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;
        if(combocounter != 0){
            combo.text = "Combo: " + combocounter;
        }
        string minutes = ((int) t/60).ToString();
        string seconds = (t % 60).ToString("f2");
        float segundos = (t % 60);
        timerText.text = minutes + ":" + seconds;
        if(contador != tamanho){
            // if((contador + 1) >= tamanho){
            //     label.GetComponent<Text>().text = letraEcra[contador];
            // }else{
            //     label.GetComponent<Text>().text = letraEcra[contador] + letraEcra[contador + 1 ];
            // }
        }else{
            label.GetComponent<Text>().text = "<color=green> Parabéns, nível finalizado! </color>";
        }
        if (Input.GetKeyDown("space"))
        {
            if(input.text.ToString() == letra[contador]){
                if(segundos > timings[contador] - 2 && segundos < timings[contador] + 2 ){
                    combocounter++;
                }else{
                    combocounter = 0;
                }
                letraEcra[contador] = "<color=green>" + letra[contador] + "</color>";
                text = "";
                for (int i = 0; i < tamanho; i++) {        
                    text += letraEcra[i];
                }
                label.GetComponent<Text>().text = text;
                contador ++;
                input.text = null;
            }else{
                
                letraEcra[contador] = "<color=red>" + letra[contador] + "</color>";
                text = "";
                combocounter = 0;

                for (int i = 0; i < tamanho; i++) {        
                    text += letraEcra[i];
                }
                label.GetComponent<Text>().text = text;

                input.text = null;
            }
        }
    }
}
