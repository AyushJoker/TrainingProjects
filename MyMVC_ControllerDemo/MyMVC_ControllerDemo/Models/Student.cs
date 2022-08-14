namespace MyMVC_ControllerDemo.Models
{
    public class Student
    {
        public Student()
        {
        }

        public Student(object value1, object value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public int ID { get; set; }
        public  string fName { get; set; }
        public string lName { get; set; }
        public object Value1 { get; }
        public object Value2 { get; }
    }
}
