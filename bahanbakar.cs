using UnityEngine;

public class SisaBahanBakar : 
MonoBehaviour
{
    void Start()
    {
        float bahanBakar = 100.0f;
        float terpakai = 85.5f;

        float sisa = bahanBakar - terpakai;
        bool isLow = sisa < 20.0f;

        Debug.Log("Sisa bensin: " + sisa + ". Status bensin lemah: " + isLow);
    }
}