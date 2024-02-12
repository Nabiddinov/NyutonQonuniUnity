using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scen1ChangeA : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ScenAlmshuv());
    }


    IEnumerator ScenAlmshuv()
    {
        yield return new WaitForSeconds(86);
        SceneManager.LoadScene(1);
    }
}