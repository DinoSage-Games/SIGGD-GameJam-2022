using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldManager : MonoBehaviour
{
    public GameObject Image0;
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;

    private bool hasShield = true;
    public void updateShield(int shields)
    {
        if (hasShield)
        {
            Image0.gameObject.SetActive(false);
        }
        else
            Image0.gameObject.SetActive(true);
        Image1.gameObject.SetActive(false);
        Image2.gameObject.SetActive(false);
        Image3.gameObject.SetActive(false);

        switch (shields)
        {
            case 3:
                Debug.Log("Shield 3");
                Image3.gameObject.SetActive(true);
                break;
            case 2:
                Debug.Log("Shield 2");
                Image2.gameObject.SetActive(true);
                break;
            case 1:
                Debug.Log("Shield 1");
                Image1.gameObject.SetActive(true);
                break;
            case 0:
                hasShield = false;
                break;
            default:
                break;
        }
        if (!hasShield)
        {
            Image0.gameObject.SetActive(true);
        }
    }
}
