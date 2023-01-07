using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Model_input : MonoBehaviour

 {   
    // Taking the input for LPT
    public TMP_InputField ALT;
    public TMP_InputField Albumin;   
    public TMP_InputField Bilirubin; 
    public TMP_InputField ALP; 
    public TMP_InputField AST; 
    public TMP_InputField GGT; 

    // Color vector
    public Color[] Liver_stage_color;

    // Model To change color
    public Renderer mat;
    
    // To change the text input
    public TextMeshProUGUI info_textfield;

    public void Go(){

    float input_AST;
    float.TryParse(AST.text, out input_AST);
    float input_ALT;
    float.TryParse(ALT.text, out input_ALT);
    float input_Bilirubin;
    float.TryParse(Bilirubin.text, out input_Bilirubin);
    float input_ALP;
    float.TryParse(ALP.text, out input_ALP);
    float input_Albumin;
    float.TryParse(Albumin.text, out input_Albumin);
    float input_GGT;
    float.TryParse(GGT.text, out input_GGT);

    float ratio_AST_ALT=input_AST/input_ALT;
    float ratio_ALT_AST=input_ALT/input_AST;

    // Stage: Healthy Liver

    if((input_AST>=10 && input_AST<=40) && (input_ALT>=5 && input_ALT<=35) &&(input_Bilirubin>=0.3 && input_Bilirubin<=1.2) && (input_ALP>=10 && input_ALP<=35) && (input_Albumin>=3.5 &&input_Albumin<=5.7)&& (input_GGT>=5 && input_GGT<=42)){
        mat.material.color=Liver_stage_color[0];
        info_textfield.text="For the Provided input the patient's liver is in stage 0. And the liver of the patient is in a healthy state.";
        Debug.Log("Normal");
        
    }

     else if((input_AST>=10 && input_AST<=40) && (input_ALT>=5 &&input_ALT<=35) &&(input_Bilirubin>=0.5 && input_Bilirubin<=1.6) && (input_ALP>=40 && input_ALP<=120) && (input_Albumin>=3.5 && input_Albumin<=5.7) && (input_GGT>=5 && input_GGT<=42)){
        mat.material.color=Liver_stage_color[0];
        info_textfield.text="For the Provided input the patient's may be suffering  from Bile duct obstruction.\n \nBile duct obstruction is a condition in which the flow of bile from the liver to the small intestine is blocked. This can occur due to a variety of factors such as inflammation, scarring, or the presence of a tumor or gallstone.";
        Debug.Log("Bile duct obstruction");

    }

    // Stage: Fatty liver

    else if(ratio_AST_ALT>=2 &&(input_AST>=40) && (input_ALT>=35) &&(input_Bilirubin>=0.5 && input_Bilirubin<=1.6) && (input_ALP>=10 && input_ALP<=35) && (input_Albumin>=3.5 &&input_Albumin<=5.7)&& (input_GGT>=5 && input_GGT<=42)){
        mat.material.color=Liver_stage_color[1];
        info_textfield.text="For the Provided input the patient's may be suffering  from Alcoholic Hapatitis.\n\nAlcoholic hepatitis is a serious and potentially life-threatening liver disease caused by excessive alcohol consumption. It is characterized by inflammation and damage to the liver cells, which can lead to scarring and fibrosis of the liver tissue.";
            Debug.Log("Alcoholic Hapatitis");
        }

    // Stage: Fibrosis Liver
        else if(ratio_AST_ALT<=1 &&(input_AST>=40) && (input_ALT>=35) &&(input_Bilirubin>=0.5 && input_Bilirubin<=1.6) && (input_ALP>=10 && input_ALP<=35) && (input_Albumin>=3.5 &&input_Albumin<=5.7)&& (input_GGT>=5 && input_GGT<=42)){
        mat.material.color=Liver_stage_color[2];
        info_textfield.text="For the Provided input the patient's may be suffering  from Achronic Form of liver damage.\n\nChronic liver damage is a long-term condition in which the liver is damaged over a period of time, often due to long-term exposure to toxins or viral infections such as hepatitis. Symptoms of chronic liver damage may include fatigue, weight loss, nausea, abdominal pain, and jaundice.";
                Debug.Log("Achronic Form of liver damage");
            }

    else if(ratio_ALT_AST>=1 &&(input_AST>=40) && (input_ALT>=35) &&(input_Bilirubin>=0.5 && input_Bilirubin<=1.7) && (input_ALP>=10 && input_ALP<=35) && (input_Albumin>=3.5 &&input_Albumin<=5.7)&& (input_GGT>=5 && input_GGT<=42)){
        mat.material.color=Liver_stage_color[2];
        info_textfield.text="or the Provided input the patient's may be suffering  from Acute Liver Damage.\n\n Acute liver damage, also known as acute liver failure, is a rapid deterioration of liver function that occurs over a period of days or weeks. It can be caused by a variety of factors, including viral infections, medications, toxins, and autoimmune diseases.";
        Debug.Log("Acute Liver Damage");
    }
    
    // Stage: Cirrhosis Liver

   else if(input_GGT>65){
        mat.material.color=Liver_stage_color[3];
        info_textfield.text="For the Provided input the patient's may be suffering  from Cirrhosis.\n\nCirrhosis is a chronic liver disease characterized by scarring and damage to the organ.It is often caused by long-term alcohol abuse or viral hepatitis infections.Cirrhosis can lead to serious complications such as liver failure and increased risk of liver cancer.";
        Debug.Log("Cirrhosis");
    }
     else if((ratio_AST_ALT<=2 && ratio_AST_ALT>=1)&&(input_AST>=40) && (input_ALT>=35) &&(input_Bilirubin>=0.5 && input_Bilirubin<=1.6) && (input_ALP>=10 && input_ALP<=35) && (input_Albumin>=3.5 &&input_Albumin<=5.7)&& (input_GGT>=5 && input_GGT<=42)){
        mat.material.color=Liver_stage_color[3];
         info_textfield.text="For the Provided input the patient's may be suffering  from Cirrhosis.\n\nCirrhosis is a chronic liver disease characterized by scarring and damage to the organ.It is often caused by long-term alcohol abuse or viral hepatitis infections.Cirrhosis can lead to serious complications such as liver failure and increased risk of liver cancer.";
        Debug.Log("Cirrhosis");
    }
    
    // Stage: Cancer Liver 

      else if((input_AST>=10 && input_AST<=50) && (input_ALT>=5 &&input_ALT<=45) &&(input_Bilirubin>=0.5 && input_Bilirubin<=1.6) && (input_ALP>=150) && (input_Albumin>=3.5 && input_Albumin<=5.7) && (input_GGT>=5 && input_GGT<=42)){
        mat.material.color=Liver_stage_color[3];
        info_textfield.text="For the Provided input the patient's may be suffering  from Liver Cancer.\n\nLiver cancer, also known as hepatocellular carcinoma, is a type of cancer that begins in the cells of the liver. The liver is a vital organ located in the upper right side of the abdomen that is responsible for many important functions, including filtering toxins and waste products from the blood, producing bile to help with digestion, and storing energy.";
        Debug.Log("Cancer");
    }
     else if(ratio_ALT_AST>=1 && (input_AST>=40 && input_AST<=60) && (input_ALT>=35 &&input_ALT<=55) &&(input_Bilirubin>=0.5 && input_Bilirubin<=1.6) && (input_ALP>=10 && input_ALP<=35) && (input_Albumin<=3.5) && (input_GGT>=5 && input_GGT<=42)){
        mat.material.color=Liver_stage_color[3];
        info_textfield.text="For the Provided input the patient's may be suffering  from Autoimmune.\n\nAutoimmune are conditions in which the immune system attacks healthy cells and tissues in the body, mistaking them for foreign invaders. Some common autoimmune diseases include rheumatoid arthritis, lupus, multiple sclerosis, type 1 diabetes, and inflammatory bowel disease";
        Debug.Log("Autoimmune");
    }
    
    else{
        mat.material.color=Liver_stage_color[0];
        info_textfield.text="For the Provided input the patient's liver is in stage 0. And the liver of the patient is in a healthy state.";
        Debug.Log("Error");
    }


   

}
   
    


}