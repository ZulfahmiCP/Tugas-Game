using UnityEngine;

// Membuat daftar pilihan Elemen
public enum Elemen { Api, Angin, Tanah, Listrik, Air }

// Baris ini membuat menu baru di Unity agar kita bisa klik kanan -> Create Monster
[CreateAssetMenu(fileName = "MonsterBaru", menuName = "GameMonster/Buat Monster Baru")]
public class MonsterData : ScriptableObject
{
    [Header("Info Dasar")]
    public string namaMonster;
    public Elemen elemenMonster;
    
    // Karena asetmu ada yang hadap kiri/kanan, kita siapkan 2 slot gambar
    [Header("Visual (Gambar PNG)")]
    public Sprite spriteHadapKanan; // Untuk tim kita (di kiri layar, hadap kanan)
    public Sprite spriteHadapKiri;  // Untuk musuh (di kanan layar, hadap kiri)

    [Header("Status Dasar (Level 1)")]
    public int baseAtk;
    public int baseDef;
    public int baseHP;

    [Header("Daftar Skill")]
    public string namaSkill1; // Pukul biasa
    public string namaSkill2; // Skill Elemen 1
    public string namaSkill3; // Skill Elemen 2 (Ultimate)
}