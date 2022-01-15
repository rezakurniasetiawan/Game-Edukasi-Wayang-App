using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject Pengaturan;
    public void Mulai()
    {
        SceneManager.LoadScene("MenuUtama");
    }
    public void About()
    {
        SceneManager.LoadScene("About");
    }
    public void Karakter()
    {
        SceneManager.LoadScene("MenuKarakter");
    }
    public void Cerita()
    {
        SceneManager.LoadScene("MenuCerita");
    }
    public void Selesai()
    {
        SceneManager.LoadScene("MenuUtama");
    }
    public void Game()
    {
        SceneManager.LoadScene("Game");
    }
    public void Referensi()
    {
        SceneManager.LoadScene("Referensi");
    }
    public void Referensi2()
    {
        SceneManager.LoadScene("Referensi2");
    }
    public void Referensi3()
    {
        SceneManager.LoadScene("Referensi3");
    }
    public void BackReferensi()
    {
        SceneManager.LoadScene("About");
    }


    // Back ke MainMenu
    public void AboutToMainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void MenuUtamaToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    //Back ke MenuUtama
    public void KarakterToMenuUtama()
    {
        SceneManager.LoadScene("MenuUtama");
    }
    public void CeritaToMenuUtama()
    {
        SceneManager.LoadScene("MenuUtama");
    }

    //Back ke MenuKarakter (ALL)

    public void backkarakter()
    {
        SceneManager.LoadScene("MenuKarakter");
    }

    //Back ke MenuCerita (ALL)
    public void BackAllCerita()
    {
        SceneManager.LoadScene("MenuCerita");
    }

    //Exit Aplikasi 
    public void Quit()
    {
        Application.Quit();
    }
    public void PengaturanActive()
    {
        Pengaturan.SetActive(true);
    }
    public void PengaturanClose()
    {
        Pengaturan.SetActive(false);
    }
}
