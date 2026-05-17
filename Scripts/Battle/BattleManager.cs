using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    public int hpMusuh = 100;
    public int hpPlayer = 100; // Variabel baru untuk darah monstermu

    public Slider hpSliderMusuh;
    public Slider hpSliderPlayer; // Variabel baru untuk Slider monstermu

    public void PakaiSkill1()
    {
        hpMusuh = hpMusuh - 10;
        UpdateUIDarah();
        GiliranMusuh(); // Memanggil giliran musuh setelah kamu menyerang
    }

    public void PakaiSkill2()
    {
        hpMusuh = hpMusuh - 20;
        UpdateUIDarah();
        GiliranMusuh();
    }

    public void PakaiSkill3()
    {
        hpMusuh = hpMusuh - 50;
        UpdateUIDarah();
        GiliranMusuh();
    }

    // Fungsi untuk memicu serangan balasan musuh dengan jeda waktu
    private void GiliranMusuh()
    {
        Debug.Log("Giliran musuh menyerang...");
        // Invoke akan menjalankan fungsi "MusuhMenyerang" setelah jeda 1.5 detik
        Invoke("MusuhMenyerang", 1.5f); 
    }

    // Fungsi aksi musuh
    private void MusuhMenyerang()
    {
        Debug.Log("Musuh menggunakan skill biasa!");
        hpPlayer = hpPlayer - 15; // Musuh memberikan damage 15 ke monstermu
        UpdateUIDarah();
    }

    private void UpdateUIDarah()
    {
        // Mencegah darah minus
        if (hpMusuh < 0) { hpMusuh = 0; }
        if (hpPlayer < 0) { hpPlayer = 0; }

        // Memperbarui visual kedua Slider
        hpSliderMusuh.value = hpMusuh;
        hpSliderPlayer.value = hpPlayer;
    }
}