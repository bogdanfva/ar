using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuControls : MonoBehaviour
{
    public void MENUS()
    {
        SceneManager.LoadScene("MEN");
    }

    public void ARKRAS()
    {
        SceneManager.LoadScene("ARKA");
    }

    public void PSUR()
    {
        SceneManager.LoadScene("SURIKOV");
    }

    public void PPOZD()
    {
        SceneManager.LoadScene("POZD");
    }

    public void PPG()
    {
        SceneManager.LoadScene("PUSHKIN");
    }

    public void PFOTAP()
    {
        SceneManager.LoadScene("FOTOAPA");
    }

}

