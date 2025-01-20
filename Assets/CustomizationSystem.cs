using UnityEngine;

public class CustomizationSystem : MonoBehaviour
{
    [SerializeField] GameObject[] Gender;
    
    [Header("Male Customization")]
    [SerializeField] GameObject[] BoyHair;
    [SerializeField] GameObject[] BoyShirt;
    [SerializeField] GameObject[] BoyPants;

    [Header("Female Customization")]
    [SerializeField] GameObject[] GirlHair;
    [SerializeField] GameObject[] GirlShirt;
    [SerializeField] GameObject[] GirlPants;

    private int hairindex;
    private int shirtindex;
    private int pantsindex;
    bool changeGen = false;

    public void changeGender()
    {
        changeGen = !changeGen;

        if (changeGen)
        {
            Gender[0].SetActive(true);
            Gender[1].SetActive(false);
        }
        else
        {
            Gender[0].SetActive(false);
            Gender[1].SetActive(true);
        }
    }

    public void hair()
    {
        hairindex++;  
        
        if (hairindex == BoyHair.Length)
        {
            hairindex = 0;
        }

        foreach (GameObject hair in BoyHair)
        {
            hair.SetActive(false);
        }
        BoyHair[hairindex].SetActive(true);
        
        
        if (hairindex == GirlHair.Length)
        {
            hairindex = 0;
        }

        foreach (GameObject hair in GirlHair)
        {
            hair.SetActive(false);
        }
        GirlHair[hairindex].SetActive(true);
        
    }

    public void shirt()
    {
        shirtindex++;

        if (shirtindex == BoyShirt.Length)
        {
            shirtindex = 0;
        }

        foreach (GameObject shirt in BoyShirt)
        {
            shirt.SetActive(false);
        }
        BoyShirt[shirtindex].SetActive(true);


        if (shirtindex == GirlShirt.Length)
        {
            shirtindex = 0;
        }

        foreach (GameObject shirt in GirlShirt)
        {
            shirt.SetActive(false);
        }
        GirlShirt[shirtindex].SetActive(true);

    }

    public void pants()
    {
        pantsindex++;

        if (pantsindex == BoyPants.Length)
        {
            pantsindex = 0;
        }

        foreach (GameObject pants in BoyPants)
        {
            pants.SetActive(false);
        }
        BoyPants[pantsindex].SetActive(true);


        if (pantsindex == GirlPants.Length)
        {
            pantsindex = 0;
        }

        foreach (GameObject Pants in GirlPants)
        {
            Pants.SetActive(false);
        }
        GirlPants[pantsindex].SetActive(true);
    }
}


