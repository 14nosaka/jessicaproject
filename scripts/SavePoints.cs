using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavePoints : MonoBehaviour
{
    public int totalPontos;
    public Text contador;

    //Cria um método estático para dar acesso à esta classe
    public static SavePoints acesso;
    // Start is called before the first frame update
    void Start()
    {
        acesso = this;
    }


    public void atualizaPontosText() => contador.text = totalPontos.ToString(); 

    


}
