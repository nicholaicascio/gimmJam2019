using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reload : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadscene());
    }

    // Update is called once per frame
    private IEnumerator loadscene()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("SampleScene");
    }
}
