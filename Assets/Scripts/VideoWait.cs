using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class VideoWait : MonoBehaviour
{
    // Start is called before the first frame update
   void Start()
{
    StartCoroutine(WaitForFunction());
}
IEnumerator WaitForFunction()
{
    yield return new WaitForSeconds(29);
    SceneManager.LoadScene(2);
}


void MyFunction()
{
    SceneManager.LoadScene(2);
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
