using TMPro;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public GameObject pistol;
    public GameObject rifle;
    public TextMeshProUGUI weaponType;

    [Header("Audio")]
    public AudioSource weaponSwitchAudio;

    private void Start()
    {
        pistol.SetActive(true);
        rifle.SetActive(false);
        weaponType.text = "Pistol:";
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            pistol.SetActive(true);
            rifle .SetActive(false);
            weaponType.text = "Pistol:";
            weaponSwitchAudio.Play();
        }

        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            pistol.SetActive(false);
            rifle.SetActive(true);
            weaponType.text = "Shotgun:";
            weaponSwitchAudio.Play();
        }
    }
}
