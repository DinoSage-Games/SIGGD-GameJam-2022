using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldStat : MonoBehaviour
{
    public int playerShield = 2;
    [SerializeField] GameObject HUD;


    // Start is called before the first frame update
    void Awake()
    {

    }

    private void Start()
    {
        updateShieldUI();
    }

    public void decreaseShield()
    {
        playerShield--;
    }

    public int getPlayerShield()
    {
        return playerShield;
    }

    public void updateShieldUI()
    {
        HUD.GetComponent<ShieldManager>().updateShield(playerShield);
    }
}
