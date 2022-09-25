using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldStat : MonoBehaviour
{
    public int playerShield = 3;
    [SerializeField] GameObject HUD;
    SFXnMusic playerHit;

    private void Start()
    {
        playerHit = FindObjectOfType<SFXnMusic>();
        updateShieldUI();

    }

    public void decreaseShield()
    {
        playerShield--;
        playerHit.playBaseHit();
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
