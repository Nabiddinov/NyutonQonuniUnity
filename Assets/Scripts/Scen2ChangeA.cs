using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scen2ChangeA : MonoBehaviour
{
    public Animator CanvasAnim;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            OnClick();
        }
    }

    public void OnClick()
    {
        CanvasAnim.Play("Canvas1");
        StartCoroutine(Kutish(2.2f));
    }
    IEnumerator Kutish(float a)
    {
        yield return new WaitForSeconds(a);
        SceneManager.LoadScene(2);
    }
}