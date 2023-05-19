using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckInput : MonoBehaviour
{
    public GameObject label;
    public InputField input;
    public string[] letra = {"ola ", "tudo ", "bem ", "tambem "};
    public string[] letraEcra = {"ola ", "tudo ", "bem ", "tambem "};
    public int contador = 0;
    public int tamanho = 0; 
    public string text;
    // Start is called before the first frame update
    void Start()
    {
        tamanho = letra.Length;
        for (int i = 0; i < tamanho; i++) {        
            text += letraEcra[i];
        }
        label.GetComponent<Text>().text = text;

    }

    // Update is called once per frame
    void Update()
    {
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
                letraEcra[contador] = "<color=green>" + letra[contador] + "</color>";
                text = "";
                for (int i = 0; i < tamanho; i++) {        
                    text += letraEcra[i];
                }
                label.GetComponent<Text>().text = text;
                contador++;
                input.text = null;
            }else{
                
                letraEcra[contador] = "<color=red>" + letra[contador] + "</color>";
                text = "";
                for (int i = 0; i < tamanho; i++) {        
                    text += letraEcra[i];
                }
                label.GetComponent<Text>().text = text;

                input.text = null;
            }
        }
    }
}
