namespace AbstractFactory
{
    public abstract class AbstractCellPhoneStore
    {
        public AbstractCellPhone OrderCenllPhone(string CellPhoneType)
        {
            AbstractCellPhone cellPhone = CreateCellPhone(CellPhoneType);
            cellPhone.design();
            cellPhone.modeling();
            cellPhone.prepareAssembly();
            cellPhone.combine();
            return cellPhone;
        }

        protected abstract AbstractCellPhone CreateCellPhone(string cellPhoneType);
    }
}