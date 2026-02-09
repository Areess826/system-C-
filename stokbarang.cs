using UnityEngine;

public class CekStokBarang :
MonoBehaviour
{
    void Start()
    {
        int stok = 5;
        int jumlahBeli = 10;

        bool bisaBeli = stok >= jumlahBeli;

        Debug.Log("Jumlah stok: " + stok + ". Ingin beli: " + jumlahBeli + ". Hasil: " + bisaBeli);
    }
}