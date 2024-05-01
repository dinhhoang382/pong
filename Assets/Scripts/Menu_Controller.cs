using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu_Controller : MonoBehaviour
{
    public Button Play;
    public Button Quit;
    public void Play_game(){
        SceneManager.LoadScene("PONG");
    }
    public void Quit_game(){
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
