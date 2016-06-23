using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SAPR_Piping
{
    [Serializable]
    class Section
    //Линия состит из участков. Каждый участок - экземлпляр этого класса.
    {
        public int ID { get; set; }//Индекс
        public string NameOfSection { get; set; }//Название участка
        public string FromSection { get; set; }//Поле "От"
        public string ToSection { get; set; }// Поле "До"
        public string NameOfProduct { get; set; }// Наименование транспортируемого продукта
        public string GroupAndCategoryOfProduct { get; set; }// Группа и категория транспортируемого продукта
        public decimal PUsl { get; set; }//Pусл
        public decimal Prab { get; set; } //Рраб
        public decimal PRasch { get; set; }//Pрасч
        public decimal Pproch { get; set; }//Pпроч
        public decimal Pplot { get; set; }//Рплот
        public decimal PGerm { get; set; }//Pгерм
        public decimal dP { get; set; }//dP
        public decimal tCh { get; set; }//t(Ч) Время проверки
        public decimal TFrom { get; set; }// Температура ОТ
        public decimal TTo { get; set; }// Температура ДО
        public decimal TMax { get; set; }// Температура МАХ
        public int Group { get; set; }//Индекс комбоокса с группой продукта
        public int IndexOfCategory { get; set; }//Индекс комбобокса с категорией трубопровода
        public decimal VControlOfWeldSeam { get; set; }//Объём контроля сварных швов
        public decimal SpeedOfCorrosion { get; set; }//Скорость коррозии, мм в год
        public decimal LifeTime { get; set; }//Срок службы трубопровода, лет
        public bool HeatTreatment { get; set; }//Термообработка (да-нет)
        public int Insulation { get; set; }// Изоляция и её тип. 
        public int PProchMethod { get; set; }//Индекс комбобокса с методом проверки Рпрочее
        public int PPlotMethod { get; set; }//Индекс комбобокса с методом проверки Рплот
        public int PGermMethod { get; set; }//Индекс комбобокса с методом проверки Ргерм
        public int Construction { get; set; }//Раздел Конструкция, комбо-бокс с методами изоляции. Индекс.
        public List<VT> DGV1  { get; set; } // Содержимое DataGridView
        public object[,] DGVItems { get; set; }
        
    }
}
