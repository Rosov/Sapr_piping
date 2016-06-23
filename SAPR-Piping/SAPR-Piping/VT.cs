using System;

namespace SAPR_Piping
{
    [Serializable]
    public class VT
    {
        public int VtElementID { get; set; }//порядковый номер элемента линии
        public int VtElementType { get; set; }//Тип элемента для подгрузки формы редактирования
        public string VtNaim { get; set; }//Наименование
        public string VtMater { get; set; }//Материал
        public string VtEdIzm { get; set; }//Единица измерения
        public decimal VtKolvo { get; set; }//Количество
        public string VtOtbr { get; set; }//Отбраковочная толщина
        public string VtPrim { get; set; }//Примечание
        //public int VtMetka { get; set; }//Метка
        public string VtEP { get; set; }//Электропривод
        public string VtIspO { get; set; }//Исполнение органа
        public string VtIspM { get; set; }//Исполнение материальное
        public string VtIspP { get; set; }//Исполнение по присоединению к трубопроводу
        public decimal VtMassa { get; set; }//Масса с КОФ


        public VT() { }
       public VT(string vtNaim, string vtMater, string vtEdIzm, decimal vtKolvo, string vtOtbr, string vtPrim, string vtEP, string vtIspO, string vtIspM, string vtIspP,decimal vtMassa)
                // Конструктор объекта
        {
            VtNaim=vtNaim;
            VtMater=vtMater;
            VtEdIzm = vtEdIzm;
            VtKolvo = vtKolvo;
            VtOtbr = vtOtbr;
            VtPrim = vtPrim;
            VtEP = vtEP;
            VtIspO = vtIspO;
            VtIspM = vtIspM;
            VtIspP = vtIspP;
            VtMassa = vtMassa;
        }
}
}
