using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp
{
    /**
     * This class work with source file, does serialization and deserialization
     */
    class WorkWithFile
    {
        //Path and name source file
        private String pathData;

        public List<Person> loadData()
        {

            //Check, if the specified file exists
            //If exists, load path to file with source data
            if (File.Exists("setting.txt")) pathData = File.ReadAllText("setting.txt");
            //if not exists, then we will find the target file ourselves
            else pathData = findSource();

            if(pathData != null)
            {
                //File found
                //deserialize it into a collection
                List<Person> person = loadSource(pathData);
                //Collection return
                return person;
            }
            else
                return null;
        }

        //Search through the OpenFileDialog file with data
        private String findSource()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Source file (*.txt)|*.txt;";
            //If no file is selected, null is returned
            if (open.ShowDialog() != DialogResult.OK) return null;
            //If the file is selected
            String file = open.FileName;
            //Write the full path and filename to the file setting.txt
            File.WriteAllText("setting.txt", file);
            //Return full path and name
            return file;
        }

        //Deserializing the file data in the person collection
        private List<Person> loadSource(String file)
        {
            List<Person> personData = new List<Person>();
            //Reading their file data into an array of strings
            String[] inData = File.ReadAllLines(file);
            //Deserialization
            for (int i = 0; i < inData.Length; i++)
            {
                int separator = inData[i].IndexOf(",");
                String id = inData[i].Substring(0, separator);
                inData[i] = inData[i].Substring(separator + 1);

                separator = inData[i].IndexOf(",");
                String firstName = inData[i].Substring(0, separator);
                inData[i] = inData[i].Substring(separator + 1);

                String SecondName = inData[i];

                personData.Add(new Person(int.Parse(id), firstName, SecondName));
            }

            return personData;
        }

        //Serializing and saving data to a file
        public void saveSource(List<Person> person)
        {
            //Create an array with the number of cells equal to the collection
            String[] outData = new String[person.Count];

            //Form an array of serialized strings
            for (int i = 0; i < outData.Length; i++)
            {
                outData[i] = person[i].getId().ToString() + "," + person[i].getFirst_name() + "," + person[i].getSecond_name();
            }
            //Refresh the file with new data
            File.WriteAllLines(pathData, outData);
        }
    }
}
