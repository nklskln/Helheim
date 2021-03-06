﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSwitch : MonoBehaviour
{
    public enum InventorySlots
    {
        Zero,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine
    }

    public Text inventorySlotText;

    public AudioClip changeWeapon;

    public AudioSource myAudioSource;

    public GameObject slot_0;
    public GameObject slot_1;
    public GameObject slot_2;
    public GameObject slot_3;
    public GameObject slot_4;
    public GameObject slot_5;
    public GameObject slot_6;
    public GameObject slot_7;
    public GameObject slot_8;
    public GameObject slot_9;

    public InventorySlots currentSlot = InventorySlots.Zero;

    public static WeaponSwitch Instance;

    public InventorySlots CurrentSlot
    {
        get
        {
            return currentSlot;
        }
    }

    public void Start()
    {
        currentSlot = InventorySlots.Zero;
        inventorySlotText.text = "0 - Hands";
        slot_0.gameObject.SetActive(true);
        slot_1.gameObject.SetActive(false);
        slot_2.gameObject.SetActive(false);
        slot_3.gameObject.SetActive(false);
        slot_4.gameObject.SetActive(false);
        slot_5.gameObject.SetActive(false);
        slot_6.gameObject.SetActive(false);
        slot_7.gameObject.SetActive(false);
        slot_8.gameObject.SetActive(false);
        slot_9.gameObject.SetActive(false);


        myAudioSource = gameObject.GetComponent<AudioSource>();

        myAudioSource.clip = changeWeapon;
        myAudioSource.Play();
        

    }

    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha0) && currentSlot != InventorySlots.Zero)
        {
            currentSlot = InventorySlots.Zero;
            inventorySlotText.text = "0 - Hands";
            slot_0.gameObject.SetActive(true);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);

            myAudioSource.Stop();
            myAudioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.Alpha1) && currentSlot != InventorySlots.One)
        {
            currentSlot = InventorySlots.One;
            inventorySlotText.text = "1 - Double Axes";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(true);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);

            myAudioSource.Stop();
            myAudioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2) && currentSlot != InventorySlots.Two)
        {
            currentSlot = InventorySlots.Two;
            inventorySlotText.text = "2 - 'Blaster'";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(true);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);

            myAudioSource.Stop();
            myAudioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3) && currentSlot != InventorySlots.Three)
        {
            currentSlot = InventorySlots.Three;
            inventorySlotText.text = "3 - Crossbow";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(true);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);

            myAudioSource.Stop();
            myAudioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4) && currentSlot != InventorySlots.Four)
        {
            currentSlot = InventorySlots.Four;
            inventorySlotText.text = "4 - 'SMG'";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(true);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);

            myAudioSource.Stop();
            myAudioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.Alpha5) && currentSlot != InventorySlots.Five)
        {
            currentSlot = InventorySlots.Five;
            inventorySlotText.text = "5 - 'Flamer'";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(true);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);

            myAudioSource.Stop();
            myAudioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.Alpha6) && currentSlot != InventorySlots.Six)
        {
            currentSlot = InventorySlots.Six;
            inventorySlotText.text = "6 - 'MG'";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(true);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);

            myAudioSource.Stop();
            myAudioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.Alpha7) && currentSlot != InventorySlots.Seven)
        {
            currentSlot = InventorySlots.Seven;
            inventorySlotText.text = "7 - 'Big Boom'";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(true);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(false);

            myAudioSource.Stop();
            myAudioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.Alpha8) && currentSlot != InventorySlots.Eight)
        {
            currentSlot = InventorySlots.Eight;
            inventorySlotText.text = "8";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(true);
            slot_9.gameObject.SetActive(false);

            myAudioSource.Stop();
            myAudioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.Alpha9) && currentSlot != InventorySlots.Nine)
        {
            currentSlot = InventorySlots.Nine;
            inventorySlotText.text = "9";
            slot_0.gameObject.SetActive(false);
            slot_1.gameObject.SetActive(false);
            slot_2.gameObject.SetActive(false);
            slot_3.gameObject.SetActive(false);
            slot_4.gameObject.SetActive(false);
            slot_5.gameObject.SetActive(false);
            slot_6.gameObject.SetActive(false);
            slot_7.gameObject.SetActive(false);
            slot_8.gameObject.SetActive(false);
            slot_9.gameObject.SetActive(true);

            myAudioSource.Stop();
            myAudioSource.Play();
        }
    }
}
