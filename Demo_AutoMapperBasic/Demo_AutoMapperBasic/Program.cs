using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Demo_AutoMapperBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();


            program.Run();

           


        }

        private void Run()
        {
            Person_Info person = GetPersonInfo();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Person_Info, Person_Info_1>());

            var mapper = new Mapper(config);
            Person_Info_1 _person = mapper.Map<Person_Info_1>(person);

            ShowPersonInDataGrid(_person);
        }

        private void ShowPersonInDataGrid(Person_Info_1 Person_Info) { }

        private Person_Info GetPersonInfo()
        {
            return new Person_Info()
            {
                FristName = "Phạm",
                LastName = "Thông",
                Age = 1,
                Gender = Convert.ToBoolean(1),

            };
        }

    }

    public class Person_Info
    {
        public string FristName { get; set; }

        public string LastName { get; set; }

        //public string FullName { get; set; }

        public int Age { get; set; }

        public bool Gender { get; set; }

    } 

    public class Person_Info_1
    {
        public string FristName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        public bool Gender { get; set; }
    }

}
