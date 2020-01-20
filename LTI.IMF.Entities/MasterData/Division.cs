namespace Ipm.Entities.MasterData
{
    public class Division
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string ActiveFlag { get; set; }
        public bool isActive
        {
            get
            {
                if (ActiveFlag == "Y")
                {
                    return true;
                }
                return false;
            }
        }
    }
}
