using UnityEngine;

public class KonversiMataUang :
MonoBehaviour
{
    void Start()
    {
        int tembaga = 250;

        int emas = tembaga / 100;
        int sisaTembaga = tembaga % 100;

        Debug.Log("Anda punya " + emas + "koin emas dan " + sisaTembaga + " koin tembaga." );
    }
}