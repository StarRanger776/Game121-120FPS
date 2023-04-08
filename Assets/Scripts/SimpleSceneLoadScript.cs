using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleSceneLoadScript : MonoBehaviour
{
    public string sceneToLoad;

    private void OnTriggerEnter(Collider other)
    {
        PlayerController player = other.GetComponent<PlayerController>();

        if (player != null && sceneToLoad != null)
        {
            player.transform.position = new Vector3(0, 0, 0);
            player.gameObject.transform.rotation = new Quaternion(0, -90, 0, 0);
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
