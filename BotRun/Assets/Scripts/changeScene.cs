using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {
    [SerializeField]
    string SceneString;
    public void LoadScene()
    {
        SceneManager.LoadScene(SceneString);
    }

		
}
