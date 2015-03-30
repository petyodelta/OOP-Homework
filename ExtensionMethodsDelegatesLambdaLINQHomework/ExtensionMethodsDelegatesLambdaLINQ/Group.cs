
namespace ExtensionMethodsDelegatesLambdaLINQ
{
    public class Group
    {
        public byte GroupNumber { get; set; }
        public string DepartmentName { get; set; }

        public Group(byte groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }
    }
}
