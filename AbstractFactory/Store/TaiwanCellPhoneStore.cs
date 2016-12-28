using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactory.Store
{
    public class TaiwanCellPhoneStore : AbstractCellPhoneStore
    {



        protected override AbstractCellPhone CreateCellPhone(string cellPhoneType)
        {
            AbstractCellPhone cellphone = null;
            ICellPhoneAssemblyFactory AssemblyFactory = new TaiwanCellPhoneAssemblyFactory();
           

            if (cellPhoneType.Equals("Business"))
            {
                cellphone = new twBusiness2CellPhone(AssemblyFactory); //把工廠傳給每一個手機，以便手機可從工廠取得組件
                cellphone.Name = "第一代音樂手機";
            }
            else if (cellPhoneType.Equals("Music"))
            {
                //音樂手機類別記得要實踐(如caBusinessPhone)
                //Code here 
            }
            else if (cellPhoneType.Equals("Sport"))
            {
                //運動手機類別記得要實踐
                //Code here
            }
            else
            {
                return null;
            }

            return cellphone;
        }
    }
}
