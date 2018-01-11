using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManegement;
// a quanto pare da errore con lo scene manager; forse perche è una libreria aggiuntia da scaricare


public class mainmenu : MonoBehaviour {
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildindex + 1); //è di riempitevo; dovremo aggoiungere il resto per far avviare i gioco;
        //al momento non funzionera; quando lo implementeremo dovremo fare una lista di ogeeti e questo avviera l ogetto piu 1 che sarebbe il nostro gioco
    }
    public void Quitgame()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
	
	
}

//questo è lo script con cui dovrebbe funionare il pulsante avvio è quit ma visto che ci sn degli errori e che dovremo tornarci dopo per inserci il game sopra

// fonti;https://www.youtube.com/watch?v=zc8ac_qUXQY