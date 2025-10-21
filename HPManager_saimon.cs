using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPManager_saimon : MonoBehaviour
{
    [SerializeField]int maxHP = 100;
    int currntHP;

    public Slider PlayerSlider;
    public Slider EnemySlider;

    private AudioSource audioSource;
    [SerializeField] private AudioClip damageAudioClip;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currntHP = maxHP;
        EnemySlider.value = maxHP;
        PlayerSlider.value = maxHP;
    }
    public void PlayerHP(float Damage)
    {
        currntHP -= (int)Damage;
        audioSource.PlayOneShot(damageAudioClip);
        Debug.Log("現在のプレイヤーHP："　+  currntHP);
        PlayerSlider.value = (float)currntHP / maxHP;
    }

    public void EnemyHP(float Damage)
    {
        currntHP -= (int)Damage;
        audioSource.PlayOneShot(damageAudioClip);
        Debug.Log("現在の敵HP：" + currntHP);
        EnemySlider.value = (float)currntHP / maxHP;
    }
}
