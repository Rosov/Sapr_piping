using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SAPR_Piping
{
    [Serializable]
    class Vedomost
    //Этот класс предназначен для установки значений P. Вводятся только Ррабочее и Русловное. Все остально зависит от этих данных
    {
        private const decimal PProchnostMultiply = 1.43m; //Множитель для Pпроч
        public decimal PRab { get; set; }//Свойство для Pрабочее
        public decimal PRasch { get; set; }//Свойство для Pрасчетное
        public int Group { get; set; }
        public decimal TMax { get; set; }
        public decimal VControlOfWeldSeam { get; set; }
        public decimal DP { get; set; }

        public Vedomost(decimal pRab, decimal pRasch, int group, decimal tMax)
        // Конструктор объекта
        {
            PRab = pRab;
            PRasch = pRasch;
            Group = group;
            TMax = TMax;
            DP = PRab * (decimal)0.01;
        }

        public decimal PProch
        {
            get
            {
                //округление неверно работает... Хотя все по MSDN сделано...
                decimal pProch = Math.Round(PRasch * PProchnostMultiply, 2, MidpointRounding.AwayFromZero);
                return pProch;
            }
        }

        public decimal PUsl
        {
            get
            {
                decimal pUsl=0;
                if (PRasch<=16)
                {
                    pUsl = 16;
                }

                if (PRasch > 16 & PRasch<=25)
                {
                    pUsl = 25;
                }

                if (PRasch > 25 & PRasch <= 40)
                {
                    pUsl = 40;
                }

                if (PRasch > 40 & PRasch <= 63)
                {
                     pUsl = 63;
                }

                if (PRasch > 63 & PRasch <= 100)
                {
                    pUsl = 100;
                }

                if (PRasch > 100)
                {
                    pUsl = 160;
                }

                return pUsl;
            }
        }


        public int IndexOfCategory
        {
            // Со временем переписать на switch:. Пока для понимания или дальнейшей правки делаю на if
            get
            {
                //Если выбрана группа веществ "Аа", то категория будет "I"
                if (Group==1)
                {
                    VControlOfWeldSeam = (decimal)20;
                    return 1;
                    


                }
                //Если выбрана группа веществ "Аб", то категория будет "II" или "I"
                if (Group==2)
                {
                    if (PRasch > (decimal)2.5 || PRasch<(decimal)0.08 || TMax>=300 || TMax<=-40)
                    {

                        VControlOfWeldSeam = (decimal)20; return 1;
                    }
                    else
                    {
                        VControlOfWeldSeam = (decimal)10;
                        return 2;
                    }
                    
                }
                //Если выбрана группа веществ "Ба", то категория будет "I", или "II"
                if (Group==3)
                {
                    DP = PRab * (decimal)0.02;
                    if (PRasch > (decimal)2.5 || PRasch < (decimal)0.08 || TMax >= 300 || TMax <= -40)
                    {
                        VControlOfWeldSeam = (decimal)20;
                        return 1;
                    }
                    else
                    {
                        VControlOfWeldSeam = (decimal)10;
                        return 2;
                    }
                }
                //Если выбрана группа веществ "Бб", то категория будет "I", "II" или "III"
                if (Group == 4)
                {
                    DP = PRab * (decimal)0.02;
                    if (PRasch >= (decimal)2.5 || PRasch <= (decimal)0.08  || TMax >= 300 || TMax <= -40)
                    {
                        VControlOfWeldSeam = (decimal)20;
                        return 1;
                    }
                    if (PRasch < (decimal)2.5 && PRasch >= (decimal)1.6 && TMax<300 )
                    {
                        VControlOfWeldSeam = (decimal)10;
                        return 2;
                    }
                    else
                    {
                        VControlOfWeldSeam = (decimal)2;
                        return 3;
                    }
                }
                //Если выбрана группа веществ "Бв", то категория будет "I", "II","III" или "IV"
                if (Group == 5)
                {
                    if (PRasch >= (decimal)6.3 || PRasch <= (decimal)0.03 || TMax >= 350 || TMax <= -40)
                    {
                        VControlOfWeldSeam = (decimal)20;
                        return 1;
                    }
                    if (PRasch < (decimal)6.3 && PRasch >= (decimal)2.5 && TMax<350)
                    {
                        VControlOfWeldSeam = (decimal)10;
                        return 2;
                    }
                    if (PRasch < (decimal)2.5 && PRasch >= (decimal)1.6 &&  TMax<250)
                    {
                        VControlOfWeldSeam = (decimal)2;
                        return 3;
                    }
                    else
                    {
                        VControlOfWeldSeam = (decimal)1;
                        return 4;
                    }
                }
                //Если выбрана группа веществ "В", то категория будет "I", "II","III", "IV" или "V"
                if (Group == 6)
                {
                    if (PRasch >= (decimal)6.3 || PRasch <= (decimal)0.03 || TMax >= 350 || TMax <= -40)
                    {
                        VControlOfWeldSeam = (decimal)20;
                        return 1;
                    }
                    if (PRasch < (decimal)6.3 && PRasch >= (decimal)2.5 && TMax < 350)
                    {
                        VControlOfWeldSeam = (decimal)10;
                        return 2;
                    }
                    if (PRasch < (decimal)2.5 && PRasch >= (decimal)1.6 && TMax < 250)
                    {
                        VControlOfWeldSeam = (decimal)2;
                        return 3;
                    }
                    else
                    {
                        VControlOfWeldSeam = (decimal)1;
                        return 4;
                    }
                }
                //В противном случае - вообще без категории
                else
	            {
                    return 0;
                }

            }
            set { }

        }

        
        //перед этой строкой можно дописывать методы


         

    }
}
