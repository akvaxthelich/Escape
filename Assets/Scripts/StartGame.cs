using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadMenu()
    {

        SceneManager.LoadScene(0);

    }
    public void LoadGame() {

        SceneManager.LoadScene(1);

    }

    public void LoadGameOver() {

        SceneManager.LoadScene(2);

    }

    public void LoadVictory()
    {

        SceneManager.LoadScene(3);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") { 
        
            LoadVictory();

        }
    }

}
