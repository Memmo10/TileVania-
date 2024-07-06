using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Exit : MonoBehaviour
{
    [SerializeField] float sceneDelayTime = 1f;
    BoxCollider2D myBoxCollider;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(LoadNextLevel());
        }
    }
    IEnumerator LoadNextLevel() 
    { 
        yield return new WaitForSecondsRealtime(sceneDelayTime);
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0; 
        }

        SceneManager.LoadScene(nextSceneIndex);
    }

}
