using System;

namespace task_4
// Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека
// в интернете и схематично нарисуйте его в консоли, только за место динамических, по вашему мнению,
// данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные, которые были
// заранее заготовлены до вывода на консоль.

{
    class Program
    {
        static void Main(string[] args)
        {
            // Реквизиты чека

            const string CompanyName = "ООО Магазин";                // 1- Название торговой точки (постоянная величина)
            int ReceiptNumber;                                       // 2-Порядковый номер чека   (меняется от меньшего к большему +1)
            string CashierLastName = "Петрова А. И.";                // 3-фамилия кассира
            string Product = "Товар1";                                // 4а-наименование товара
            double ProductQuantity;                                  // 4б-количество товара
            double ProductPrice;                                     // 4в-стоимость товара за единицу
            const int VatTaxRate = 20;                               // 5-налоговая ставка НДС. Здесь константа, а вообще зависит от товара
            double summa;                                             // 6-итоговая сумма в чеке
            const long FactoryNumberFiscalDevice = 99990789403;      // 9-заводской номер фискального накопителя
            const uint InnCompany = 2462064186;                      // 11-ИНН организации продавца
            int ShiftNumber = 5;                                     // 15-Номер смены (правильно нужно изменять после сятия фиск. отчета
            int SerialNumberReceipt = 10;                            // 16а-порядковый номер чека. После каждой покупки должен увеличиваться на 1
            uint FiscalSignReceipt = 2309843641;                     /* 16б-фискальный признак чека. рассчитывается по встроенному алгоритму. У каждого чека свой.
                                                                            Здесь просто введен как переменная*/
            const uint CashRegisterNumber = 0493049100;              // 10-номер кассы выданный при регистрации в ФНС
            const long CashNumberRegNalog = 000000003601858;         // 10а-регистрационный номер кассы выданный при регистрации в ФНС
            const string FormOfTaxation = "УСН";                     // 12-Задается в параметрах при первой настройке ККМ
            const string PlaceOfSale = "660000, г. Иваново,\nул. Ивановская, дом 18, корп. 7.\nСайт ФНС: WWW.NALOG.RU"; //13- адрес место продаж
            double nal = 0;                                          // суммна внесенных наличных
            double Change = 0;                                       // сумма сдачи

            Console.Write("Введите порядковый номер чека ККМ: ");
            ReceiptNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество купленного товара: ");
            ProductQuantity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите цену купленного товара: ");
            ProductPrice = Convert.ToDouble(Console.ReadLine());
            summa = Math.Round(ProductQuantity * ProductPrice, 2);


            Console.Write("Какую оплату вы предпочитаете \n1-наличный расчет\n2-расчет по карте\n3-через систему быстрых платежей\nВыберите значение: ");
            int Sale = Convert.ToInt32(Console.ReadLine());


            if (Sale == 1)
            {
                Console.Write($"Ваша сумма покупок составила {summa}. Какую сумму наличных вы вносите? ");
                nal = Convert.ToDouble(Console.ReadLine());    // Сумма внесенных наличных денег
                Change = Math.Round(nal - summa, 2);                          // Сумма сдачи
            }

            Console.Clear();

            Console.WriteLine($"      {CompanyName} \nКассовый чек № {ReceiptNumber} (приход)\nКассир: {CashierLastName}");
            Console.WriteLine($"{Product}\n{ProductQuantity} * {ProductPrice} = {summa}");
            Console.WriteLine($"Ставка НДС: {VatTaxRate}% Сумма НДС ={Math.Round((summa * VatTaxRate / 120), 2)}");
            Console.WriteLine($"ИТОГО К  ОПЛАТЕ   ={summa}");

            if (Sale == 1)
            {
                Console.WriteLine($"НАЛИЧНЫМИ= {nal}  СДАЧА= {Change}");
            }
            else if (Sale == 2)
            {
                Console.WriteLine($"ОПЛАТА ПО КАРТЕ= {summa}");
            }
            else if (Sale == 3)
            {
                Console.WriteLine($"ОПЛАТА ЧЕРЕЗ СБП= {summa}");
            }

            Console.WriteLine($"ЗН ККТ:{CashRegisterNumber} ФН:{FactoryNumberFiscalDevice}\nРН ККТ: {CashNumberRegNalog}");
            Console.WriteLine($"СНО: {FormOfTaxation}    ИНН {InnCompany}\nСУММА ФН:={summa}\nМЕСТО РАСЧЕТОВ: {PlaceOfSale} ");
            Console.WriteLine($"{DateTime.Now} СМЕНА: {ShiftNumber}\nФД:{SerialNumberReceipt}  ФП:{FiscalSignReceipt}");
        }



    }
}

