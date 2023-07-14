namespace ChatGPT4TestTest
{
    public class StudentConverterTests
    {
        private readonly StudentConverter _converter;

        public StudentConverterTests()
        {
            _converter = new StudentConverter();
        }

        [Fact]
        public void HighAchieverTest()
        {
            var students = new List<Student> { new Student { Age = 21, Grade = 91 } };
            var result = _converter.ConvertStudents(students);
            Assert.True(result[0].HonorRoll);
        }

        [Fact]
        public void ExceptionalYoungHighAchieverTest()
        {
            var students = new List<Student> { new Student { Age = 20, Grade = 91 } };
            var result = _converter.ConvertStudents(students);
            Assert.True(result[0].Exceptional);
        }

        [Fact]
        public void PassedStudentTest()
        {
            var students = new List<Student> { new Student { Age = 22, Grade = 80 } };
            var result = _converter.ConvertStudents(students);
            Assert.True(result[0].Passed);
        }

        [Fact]
        public void FailedStudentTest()
        {
            var students = new List<Student> { new Student { Age = 22, Grade = 70 } };
            var result = _converter.ConvertStudents(students);
            Assert.False(result[0].Passed);
        }

        [Fact]
        public void EmptyArrayTest()
        {
            var students = new List<Student>();
            var result = _converter.ConvertStudents(students);
            Assert.Empty(result);
        }

        [Fact]
        public void NotArrayTest()
        {
            Assert.Throws<ArgumentNullException>(() => _converter.ConvertStudents(null));
        }
    }
}