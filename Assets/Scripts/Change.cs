using System.Collections;
using UnityEngine;


public class Change : MonoBehaviour
{
    public Animator CanvasAnim;

    void Start()
    {
        StartCoroutine(AnimationController());
    }

    IEnumerator AnimationController()
    {
        yield return new WaitForSeconds(49f);

        GetComponent<Animator>().SetInteger("Link", 1);

        StartCoroutine(CanvasAnimControler());

        yield return new WaitForSeconds(35.4f);

        CanvasAnim.SetInteger("Canva", 1);
    }

    IEnumerator CanvasAnimControler()
    {
        yield return new WaitForSeconds(1f);
        CanvasAnim.SetInteger("Canva", 1);
        yield return new WaitForSeconds(5f);
        CanvasAnim.SetInteger("Canva", 2);
    }
}