using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;   

public class CanvasTransisi : MonoBehaviour
{
    public static string NamaScene;

    public void Btn_pindah(string nama)
    {
        this.gameObject.SetActive(true);
        NamaScene = nama;
        GetComponent<Animator>().Play("start");
    }

    public void Object_InActive()
    {
        this.gameObject.SetActive(false);
    }

    public void Pindah_Scene()
    {
        SceneManager.LoadScene(NamaScene);
    }

    public void Btn_keluar()
    {
        Application.Quit();
    }


}
