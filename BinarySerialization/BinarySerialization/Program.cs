using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


// http://metanit.com/sharp/tutorial/6.2.php - разобранный пример 
// http://metanit.com/sharp/tutorial/6.4.php - аналогичный пример только XML


namespace BinarySerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //// объект для сериализации
            //Person person = new Person("Tom", 29);
            //Console.WriteLine("Create Object");

            //// создаем объект BinaryFormatter
            //BinaryFormatter formatter = new BinaryFormatter();
            //// получаем поток, куда будем записывать сериализованный объект
            //using (FileStream fs = new FileStream("persons.dat", FileMode.OpenOrCreate))
            //{
            //    formatter.Serialize(fs, person);

            //    Console.WriteLine("Serialaze object");
            //}

            //// десериализация из файла persons.dat
            //using (FileStream fs = new FileStream("persons.dat", FileMode.OpenOrCreate))
            //{
            //    Person newPerson = (Person)formatter.Deserialize(fs);

            //    Console.WriteLine("Deserialaze object");
            //    Console.WriteLine("Name: {0} Age: {1}", newPerson.Name, newPerson.Age);
            //}

            //Console.ReadLine();


            Job job1 = new Job("Test1", 1);
            Job job2 = new Job("Test2", 2);
            Person person1 = new Person("Tom", 21, job1);
            Person person2 = new Person("Bill", 25, job2);

            // массив для сериализации
            Person[] persons = new Person[] { person1, person2 };

            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream("persons.dat", FileMode.OpenOrCreate))
            {
                // сериализуем весь массив persons
                formatter.Serialize(fs, persons);

                Console.WriteLine("Serialaze object");
            }

            // десериализация
            using (FileStream fs = new FileStream("persons.dat", FileMode.OpenOrCreate))
            {
                Person[] deserilizePersons = (Person[])formatter.Deserialize(fs);

                foreach (Person p in deserilizePersons)
                {
                    Console.WriteLine("Name: {0} --- Age: {1} --- Job: {2}", p.Name, p.Age, p.Job.Name);
                }
            }

        }
    }
}
