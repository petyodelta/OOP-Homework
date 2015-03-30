using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public Group StudentGroupNumber { get; set; }
        
        public Students(){}
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + this.FirstName + " " + this.LastName
                + " " + "Age: " + this.Age + " " + "FN: " + this.FN
                + " " + "Tel: " + this.Tel + " " + "Email: " + this.Email
                + " " +"Department: " + this.StudentGroupNumber.DepartmentName + " " + "Group Number: " + this.StudentGroupNumber.GroupNumber
                + " " + "Marks: ");
            foreach (var item in this.Marks)
            {
                sb.Append(item + " ");
            }
            sb.AppendLine("\n");
            return sb.ToString();
        }
    }
}
